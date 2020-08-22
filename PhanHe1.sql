/*Tao user dbadmin*/
--->Login vao sys
alter session set "_ORACLE_SCRIPT"=true;

DROP user dbadmin CASCADE;
create user dbadmin identified by dbadmin
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
--Grant quyen cho dbadmin
grant create session, create user, drop user, create role, 
drop any role, create procedure, execute any procedure, 
alter any procedure, drop any procedure, select any table,
create table, insert any table, update any table, drop any table to dbadmin with admin option;
grant select on sys.dba_sys_privs to dbadmin;
grant select on sys.dba_role_privs to dbadmin;


/*Xem ds user, quyen trong he thong*/
-- Xem ds nguoi dung trong he thong
select username from all_users;
-- Thong tin ve  quyen (Quyen he thong) cua moi user
select * from dba_sys_privs where grantee = 'SYS';
/*Xem ds role, thong tin ve quyen cua role trong he thong*/
--Xem ds role
select role from dba_roles;
-- Thong tin quyen ve role
select  granted_role from dba_role_privs where grantee = 'dbadmin';

-->>>Login with dbadmin

/*Create /drop user*/
--Procedure thuc thi create user
create or replace procedure sp_create_user(username in varchar2, pw in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    EXECUTE IMMEDIATE('create user ' || username || ' identified by ' || pw || ' default tablespace users TEMPORARY TABLESPACE temp Quota 10M on users');
    EXECUTE IMMEDIATE('grant create session to ' || username);
end;
/

begin
sp_create_user('toan123456','123');
end;
--Procedure thuc thi drop user
create or replace procedure sp_Drop_user(username in varchar2)
is
begin
  EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
  execute IMMEDIATE('drop user ' || username);
end;
/

begin
sp_Drop_user('toan12345');
end;

/*Create/drop role*/
--Procedure tao role
create or replace procedure sp_create_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('create role ' || rolename);
end;
/
--Procedure drop role
create or replace procedure sp_drop_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('drop role ' || rolename);
end;
/
/*Cap/Thu hoi quyen cua user*/
--Procedure grant quyen cho user
create or replace procedure sp_grant_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username);
end;
/

begin
sp_grant_user('TOAN12345','DROP USER');
END;

---Procedure grant quyen cho user voi with admin option
create or replace procedure sp_grant(username in varchar2, name_privs in varchar2, with_option in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username || ' ' || with_option);
end;
--Procedure revoke quyen user
create or replace procedure sp_revoke_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || name_privs || ' from ' || username);
end;
/

/*Cap va thu hoi role cua user*/
--Procedure grant role cho user
create or replace procedure sp_grant_role_user(namerole in varchar2, username in varchar2)
is
begin
    execute IMMEDIATE('grant ' || namerole || ' to ' || username);
end;
/
--Procedure revoke role cho user
create or replace procedure sp_revoke_role_user(namerole in varchar2, username in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || namerole || ' from ' || username);
end;
/

/*Cap / thu hoi quyen cua role*/
--Procedure grant quyen cho role
create or replace procedure sp_grant_role(namerole in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || namerole);
end;
/
--Procedure revoke quyen cho role
create or replace procedure sp_revoke_role(namerole in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || name_privs || ' from ' || namerole);
end;
/*Thong tin cua cac doi tuong trong user hien tai */
select object_name, subobject_name, object_type from user_objects;

select * from dba_sys_privs where grantee = 'DA2';
select role from dba_roles;
---Coi  danh sach thong tin quyen cua role
select grantee, granted_role from dba_role_privs where granted_role ='GVIEN';

/*Lay danh sach quyen cua user*/
select privilege from dba_sys_privs where grantee = 'SV3';

--->>>Login sys
/*Gran quyen DBA_AUDIT_TRAIL cho user dbadmin */
grant select on sys.DBA_AUDIT_TRAIL to dbadmin;
/*Gran quyen DBA_FGA_AUDIT_TRAIL cho user dbadmin */
grant select on sys.DBA_FGA_AUDIT_TRAIL to dbadmin;


execute sp_revoke_role('DA1', 'create session');

/*Grant , revoke role cho user*/

execute sp_grant_role_user('da2', 'sv1');
/*Test
execute sp_create_role('da2');
execute sp_drop_role('da1');
execute sp_create_user('da2', 'da2');
execute sp_drop_user('da2');
execute sp_grant_user('da2', 'insert any table');
grant create table to da2;
select  granted_role from dba_role_privs where grantee = '';


select  grantee from dba_role_privs where granted_role = 'GVIEN';


select privilege from dba_sys_privs where grantee = 'DA';
*/
-- Kiem tra voi username la SV1 thi co ton tai role ko
select  granted_role from dba_role_privs where grantee = 'SV1';

/*--------------------------------------------------------------Fine-Grained Auditing--------------------------------------------------------------*/
grant EXECUTE ON DBMS_FGA to dbadmin;

create table ThanhVien
(
    Ma number(5) CONSTRAINT PK_ACCOUNTS PRIMARY KEY,
    TenThanhVien VARCHAR2(30),
    Luong NUMBER(10)
);

insert into ThanhVien values(1, 'Long', 10000);
insert into ThanhVien values(2, 'Phuong', 15000);
insert into ThanhVien values(3, 'Vy', 20000);
insert into ThanhVien values(4, 'Quang', 25000);
insert into ThanhVien values(5, 'Phung', 25000);


/*Cai dat chinh sach giam sat*/
begin
    DBMS_FGA.Add_Policy(
    object_schema => 'dbadmin',
    object_name    => 'ThanhVien',
    policy_name     => 'audit_user_access',
    audit_condition => 'Luong >= 20000',
    statement_types => 'select');
end;
/

/*Enable policy*/
begin
    DBMS_FGA.Enable_Policy(
    object_schema => 'dbadmin',
   object_name     => 'ThanhVien',
   policy_name     => 'audit_user_access',
   enable              => TRUE);
end;
/

/*Disable policy*/
begin
    DBMS_FGA.Disable_Policy(
    object_schema => 'dbadmin',
   object_name     => 'ThanhVien',
   policy_name     => 'audit_user_access');
end;
/
/*Huy chinh sach giam sat*/
begin
    dbms_fga.drop_policy(
    object_schema   => 'dbadmin',
    object_name      => 'ThanhVien',
    policy_name      => 'audit_user_access');
end;
/

-----------------------------------
/*Test*/
select DB_USER, Object_Name, sql_text,EXTENDED_TIMESTAMP  from DBA_FGA_AUDIT_TRAIL;
/*Tao user LongLy*/
alter session set "_ORACLE_SCRIPT"=true;
create user LongLy identified by LongLy
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
grant create session to LongLy;
grant select on dbadmin.ThanhVien to LongLy;
grant insert on dbadmin.ThanhVien to LongLy;
grant update on dbadmin.ThanhVien to LongLy;

---Conn LongLy/LongLy
select * from dbadmin.ThanhVien where Luong >= 20000;

