/*Tao user dbadmin*/
--->Login vao sys
alter session set "_ORACLE_SCRIPT"=true;
create user dbadmin identified by dbadmin
        default tablespace users
        TEMPORARY TABLESPACE temp
        Quota 10M on users;
/
--Grant quyen cho dbadmin
grant create session, create user, drop user, create role, 
drop any role, create procedure, execute any procedure, 
alter any procedure, drop any procedure, select any table,
create table, insert any table, update any table, drop any table to dbadmin with admin option;
grant select on sys.dba_sys_privs to dbadmin;
grant select on sys.dba_role_privs to dbadmin;
grant all privileges to dbadmin;

-->Login dbadmin 

/*Create /drop user*/
--Procedure thuc thi create user
create or replace procedure sp_create_user(username in varchar2, pw in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    EXECUTE IMMEDIATE('create user ' || username || ' identified by ' || pw || ' default tablespace users TEMPORARY TABLESPACE temp Quota 10M on users');
    EXECUTE IMMEDIATE('grant create session to ' || username);
    EXECUTE IMMEDIATE('commit');
end;
/
--Procedure thuc thi drop user
create or replace procedure sp_Drop_user(username in varchar2)
is
begin
     EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
     execute IMMEDIATE('drop user ' || username);
     EXECUTE IMMEDIATE('commit');
end;
/
/*Create/drop role*/
--Procedure tao role
create or replace procedure sp_create_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('create role ' || rolename);
    EXECUTE IMMEDIATE('commit');
end;
/
--Procedure drop role
create or replace procedure sp_drop_role(rolename in varchar2)
is
begin
    EXECUTE IMMEDIATE('alter session set "_ORACLE_SCRIPT"=true');
    execute IMMEDIATE('drop role ' || rolename);
    EXECUTE IMMEDIATE('commit');
end;
/
/*Cap/Thu hoi quyen cua user*/
--Procedure grant quyen cho user
create or replace procedure sp_grant_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username);
    EXECUTE IMMEDIATE('commit');
end;
/
---Procedure grant quyen cho user voi with admin option
create or replace procedure sp_grant(username in varchar2, name_privs in varchar2, with_option in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username || ' ' || with_option);
    EXECUTE IMMEDIATE('commit');
end;
--Procedure revoke quyen user
create or replace procedure sp_revoke_user(username in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || name_privs || ' from ' || username);
    EXECUTE IMMEDIATE('commit');
end;
/

---Procedure grant quyen cho user voi with admin option
create or replace procedure sp_grant(username in varchar2, name_privs in varchar2, with_option in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || username || ' ' || with_option);
    EXECUTE IMMEDIATE('commit');
end;
/
/*Cap va thu hoi role cua user*/
--Procedure grant role cho user
create or replace procedure sp_grant_role_user(namerole in varchar2, username in varchar2)
is
begin
    execute IMMEDIATE('grant ' || namerole || ' to ' || username);
    EXECUTE IMMEDIATE('commit');
end;
/
--Procedure revoke role cho user
create or replace procedure sp_revoke_role_user(namerole in varchar2, username in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || namerole || ' from ' || username);
    EXECUTE IMMEDIATE('commit');
end;
/

/*Cap / thu hoi quyen cua role*/
--Procedure grant quyen cho role
create or replace procedure sp_grant_role(namerole in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('grant ' || name_privs || ' to ' || namerole);
    EXECUTE IMMEDIATE('commit');
end;
/
--Procedure revoke quyen cho role
create or replace procedure sp_revoke_role(namerole in varchar2, name_privs in varchar2)
is
begin
    execute IMMEDIATE('revoke ' || name_privs || ' from ' || namerole);
    EXECUTE IMMEDIATE('commit');
end;


