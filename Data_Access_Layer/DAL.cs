﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity_Object;
using System.Data;

namespace Data_Access_Layer
{
    public class DAL
    {

        public OracleConnection Connect()
        {
            //Create a connection String to Oracle
            string connectionString = "User Id=dbadmin; password=dbadmin;" +

            //Connect Format is [hostname]:[port]/[service_name]
            "Data Source=localhost:1521/xe; Pooling=false;";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectionString;
            con.Open();
            return con;
        }
        // Vy
        public DataSet get_log()
        {
            OracleConnection conn = Connect();
            string command = "select username, owner, obj_name, action_name, sql_text, EXTENDED_TIMESTAMP from DBA_AUDIT_TRAIL";
            OracleDataAdapter adapter = new OracleDataAdapter(command, conn);
            var ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }
        //Long
        public List<DanhSachUser> Get_DsUser_From_Database()
        {
            var dsuser = new List<DanhSachUser>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "select username from all_users";
            var er = orc.ExecuteReader();
            while(er.Read())
            {
                dsuser.Add(new DanhSachUser(er.GetString(0)));
            }
            conn.Close();
            return dsuser;
        }
        public List<DanhSachUser> Get_DsRole_From_Database()
        {
            var dsrole = new List<DanhSachUser>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "SELECT * FROM DBA_ROLES;";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                dsrole.Add(new DanhSachUser(er.GetString(0)));
            }
            conn.Close();
            return dsrole;
        }
        public List<Quyen> Lay_DSQuyen_From_Database(string grantee)
        {
            var dsquyen = new List<Quyen>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select * from dba_sys_privs where grantee = '{grantee}'";
            var er = orc.ExecuteReader();
            while(er.Read())
            {
                var quyen = new Quyen();
                quyen.grantee = er.GetString(0);
                quyen.privilege = er.GetString(1);
                quyen.admin_option = er.GetString(2);
                quyen.common = er.GetString(3);
                quyen.inheritied = er.GetString(4);
                dsquyen.Add(quyen);
            }
            conn.Close();
            return dsquyen;
        }
        //Lấy ds quyền ứng với role đó

        public List<string> Lay_DSQuyen_UngVoiRole_From_Database(string grantee)
        {
            var dsquyen = new List<string>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select  grantee from dba_role_privs where granted_role = '{grantee}'";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                dsquyen.Add(er.GetString(0));
            }
            conn.Close();
            return dsquyen;
        }
        //Lấy các quyền ứng với user đó
        public List<string> LayQuyen_User_DB(string grantee)
        {
            var dsquyen = new List<string>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select privilege from dba_sys_privs where grantee = '{grantee}'";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                dsquyen.Add(er.GetString(0));
            }
            conn.Close();
            return dsquyen;
        }
        //Lay Role ung voi username(grantee)
        public List<string> Lay_Role_UngVoi_Granteee_From_Database(string grantee)
        {
            var dsquyen = new List<string>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select  granted_role from dba_role_privs where grantee = '{grantee}'";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                dsquyen.Add(er.GetString(0));
            }
            conn.Close();
            return dsquyen;
        }
        public DanhSachUser Drop_user_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            //            string s = @"''_ORACLE_SCRIPT''";
            orc.CommandText = "sp_drop_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            //$"begin execute sp_drop_user('{ds.username}'); end;";
            orc.ExecuteNonQuery();            
            conn.Close();
            return ds;
        }
        public User Create_user_In_Database(User ng)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_create_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ng.username}";
            orc.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = $"{ng.password}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ng;
        }
        public DanhSachUser Create_role_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_create_role";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        public DanhSachUser Drop_role_In_Database(DanhSachUser ds)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_drop_role";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{ds.username}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return ds;
        }
        //Grant quyen cho user
        public CapQuyen Grant_Priv_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "sp_grant_user";
            orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        //Grant quyen voi admin option
        public CapQuyenOption Grant_Priv_With_Admin_Option_In_Database(CapQuyenOption cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            if (cq.option == "")
            {
                orc.CommandText = "begin sp_grant_user('" + cq.username + "','" + cq.name_privs + "'); END;";
            }
            else
            {
                orc.CommandText = "begin sp_grant('" + cq.username + "','" + cq.name_privs + "','" + cq.option + "'); END;";

            }
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.Parameters.Add(new OracleParameter("option", OracleDbType.Varchar2)).Value = $"{cq.option}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            //string hi = orc.ToString();
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }

        //Revoke quyen cho user
        public CapQuyen Revoke_Priv_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "begin sp_revoke_user('" + cq.username + "','" + cq.name_privs + "'); END;";
            //orc.CommandText = "sp_revoke_user";
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        //Grant quyen cho role
        public CapQuyen Grant_Priv_Role_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "begin sp_grant_role('" + cq.username + "','" + cq.name_privs + "'); end;";
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        //Revoke quyen cho role
        public CapQuyen Revoke_Priv_Role_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "begin sp_revoke_role('" + cq.username + "','" + cq.name_privs + "'); end;";
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        //Grant role cho user
        public CapQuyen Grant_Role_To_User_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "begin sp_grant_role_user('" + cq.username + "','" + cq.name_privs + "'); end;";
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        //Revoke role cho user
        public CapQuyen Revoke_Role_To_User_In_Database(CapQuyen cq)
        {
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "begin sp_revoke_role_user('" + cq.username + "','" + cq.name_privs + "'); end;";
            //orc.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = $"{cq.username}";
            //orc.Parameters.Add(new OracleParameter("name_privs", OracleDbType.Varchar2)).Value = $"{cq.name_privs}";
            //orc.CommandType = System.Data.CommandType.StoredProcedure;
            orc.ExecuteNonQuery();
            conn.Close();
            return cq;
        }
        public List<USER_OBJECT> GetAllUserObject()
        {
            var userTables = new List<USER_OBJECT>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = "SELECT OBJECT_NAME FROM USER_OBJECTS WHERE OBJECT_TYPE IN ('TABLE', 'FUNCTION', 'PROCEDURE', 'VIEW')";
            var er = orc.ExecuteReader();
            while (er.Read())
            {
                userTables.Add(new USER_OBJECT(er.GetString(0)));
            }
            conn.Close();
            return userTables;
        }
        //Vy
        public bool Audit(string username, List<string> actions, bool successful, bool notsuccessful)
        {
            OracleConnection conn = Connect();
            try
            {
                OracleCommand orc = new OracleCommand();
                orc.Connection = conn;
                string action = "";
                foreach (var item in actions)
                {
                    action += item + ",";
                }
                action = action.Remove(action.Length - 1);

                orc.CommandText = $"AUDIT {action} BY {username}";
                orc.ExecuteNonQuery();

                if (successful)
                {
                    orc.CommandText = $"AUDIT {action} BY {username} WHENEVER SUCCESSFUL";
                    orc.ExecuteNonQuery();
                }

                if (notsuccessful)
                {
                    orc.CommandText = $"AUDIT {action} BY {username} WHENEVER NOT SUCCESSFUL";
                    orc.ExecuteNonQuery();
                }
                orc.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        //Phương
        public List<Entity_Object.Object> Get_Objects_From_Database()
        {
            var objects = new List<Entity_Object.Object>();
            OracleConnection conn = Connect();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select object_name, subobject_name, object_type from user_objects";
            var er = orc.ExecuteReader();
            while (er.Read())
            {

                String objname;
                if (er.IsDBNull(0))
                    objname = "";
                else objname = er.GetString(0);
                String subobjname;
                if (er.IsDBNull(1))
                    subobjname = "";
                else subobjname = er.GetString(1);
                String objtype;
                if (er.IsDBNull(2))
                    objtype = "";
                else objtype = er.GetString(2);
                var obj = new Entity_Object.Object(objname, subobjname, objtype);

                objects.Add(obj);
            }
            conn.Close();
            return objects;
        }
    }
}
