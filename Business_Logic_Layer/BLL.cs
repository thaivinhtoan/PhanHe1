using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Object;
using Data_Access_Layer;
namespace Business_Logic_Layer
{
    public class BLL
    {
        public System.Data.DataSet get_Log()
        {
            DAL respon = new DAL();
            return respon.get_log();
        }
        public List<DanhSachUser> get_DsUser()
        {
            List<DanhSachUser> ds = new List<DanhSachUser>();
            DAL respon = new DAL();
            var ds_user = respon.Get_DsUser_From_Database();
            foreach(var us in ds_user)
            {
                ds.Add(us);
            }
            return ds;
        }
        public List<DanhSachUser> get_DsRole()
        {
            List<DanhSachUser> ds = new List<DanhSachUser>();
            DAL respon = new DAL();
            var ds_role = respon.Get_DsRole_From_Database();
            foreach (var us in ds_role)
            {
                ds.Add(us);
            }
            return ds;
        }
        public List<Quyen> Lay_DsQuyen(string gt)
        {
            List<Quyen> qu = new List<Quyen>();
            DAL respon = new DAL();
            var ds_quyen = respon.Lay_DSQuyen_From_Database(gt);
            foreach(var quyen in ds_quyen)
            {
                qu.Add(quyen);
            }
            return qu;
        }
        //Lấy ds quyền ứng với role đó
        public List<string> Lay_DsQuyen_UngVoiRole(string gt)
        {
            List<string> qu = new List<string>();
            DAL respon = new DAL();
            var ds_quyen = respon.Lay_DSQuyen_UngVoiRole_From_Database(gt);
            foreach (var quyen in ds_quyen)
            {
                qu.Add(quyen);
            }
            return qu;
        }
        //Lấy các quyền ứng với user đó
        public bool KT_QuyenCua_User(string username, string quyen)
        { 
            List<string> qu = new List<string>();
            DAL respon = new DAL();
            var ds_quyen = respon.LayQuyen_User_DB(username);
            foreach (var quyens in ds_quyen)
            {
                if(quyens == quyen.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public bool KT_QuyenCua_Role(string grantee, string quyen)
        {
            List<string> qu = new List<string>();
            DAL respon = new DAL();
            var ds_quyen = respon.LayQuyen_User_DB(grantee);
            foreach (var quyens in ds_quyen)
            {
                if (quyens == quyen.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public bool KT_user_Role(string grantee, string quyen)
        {
            List<string> qu = new List<string>();
            DAL respon = new DAL();
            var ds_quyen = respon.Lay_Role_UngVoi_Granteee_From_Database(grantee);
            foreach (var quyens in ds_quyen)
            {
                if (quyens == quyen)
                {
                    return true;
                }
            }
            return false;
        }
        //Lấy quyền ứng với role
        public List<string> Lay_Quyen_UngVoiRole(string grantee)
        {
            List<string> qu = new List<string>();
            DAL respon = new DAL();
            var ds_quyen = respon.LayQuyen_User_DB(grantee);
            foreach (var quyen in ds_quyen)
            {
                qu.Add(quyen);
            }
            return qu;
        }

        public DanhSachUser Drop_user(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Drop_user_In_Database(danhsach);
        }

        public User Create_user(User nguoidung)
        {
            var respon = new DAL();
            return respon.Create_user_In_Database(nguoidung);
        }
        public DanhSachUser Create_role(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Create_role_In_Database(danhsach);
        }
        public DanhSachUser Drop_role(DanhSachUser danhsach)
        {
            var respon = new DAL();
            return respon.Drop_role_In_Database(danhsach);
        }
        //Grant quyen cho user
        public CapQuyen Grant_privs(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Grant_Priv_In_Database(capquyen);
        }
        //Revoke quyen cho user
        public CapQuyen Revoke_privs(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Revoke_Priv_In_Database(capquyen);
        }
        //Grant quyen cho role
        public CapQuyen Grant_privs_Role(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Grant_Priv_Role_In_Database(capquyen);
        }
        //Revoke quyen cho role
        public CapQuyen Revoke_privs_Role(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Revoke_Priv_Role_In_Database(capquyen);
        }
        //Grant role cho user
        public CapQuyen Grant_Role_To_User(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Grant_Role_To_User_In_Database(capquyen);
        }
        //Revoke role cua user
        public CapQuyen Revoke_Role_To_User(CapQuyen capquyen)
        {
            var respon = new DAL();
            return respon.Revoke_Role_To_User_In_Database(capquyen);
        }
        public CapQuyenOption Grant_privs_option(CapQuyenOption capquyenoption)
        {
            var respon = new DAL();
            return respon.Grant_Priv_With_Admin_Option_In_Database(capquyenoption);
        }
        public List<USER_OBJECT> GetAllUserObject()
        {
            var respon = new DAL();
            return respon.GetAllUserObject();
        }
        //Vy
        public bool Audit(string username, List<string> actions, bool successful, bool notsuccessful)
        {
            var respon = new DAL();
            return respon.Audit(username, actions, successful, notsuccessful);
        }
        //Phương
        public List<Entity_Object.Object> get_DsObject()
        {
            DAL respon = new DAL();
            var objs = respon.Get_Objects_From_Database();

            return objs;
        }

        public bool TonTaiUser(String name)
        {
            var dsuser = new DAL().Get_DsUser_From_Database();
            foreach (var user in dsuser)
            {
                if (user.username == name.ToUpper())
                    return true;
            }
            return false;
        }
        public bool TonTaiRole(String name)
        {
            var dsrole = new DAL().Get_DsRole_From_Database();
            foreach (var role in dsrole)
            {
                if (role.username == name.ToUpper())
                    return true;
            }
            return false;
        }
    }
}
