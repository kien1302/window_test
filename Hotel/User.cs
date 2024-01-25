using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    class User
    {
        DB db = new DB();
        public bool auth_register(string username, string password, string displayname)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (username, password, displayname, role)" +
                "VALUES (@username, @password, @displayname, @role)", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@displayname", SqlDbType.VarChar).Value = displayname;
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = "cus";
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }    
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool info_register(string username, int year, string gender, int phone, int inumber)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Customer (username, year, gender, inumber, phone)" +
                "VALUES (@username, @year, @gender, @inumber, @phone)", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@year", SqlDbType.Int).Value = year;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@inumber", SqlDbType.Int).Value = inumber;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool login(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @username and password = @password", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public string getrole(string username)
        {
            string rolename = "";
            SqlCommand command = new SqlCommand("SELECT role FROM Login WHERE username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataReader sda = command.ExecuteReader();
            while(sda.Read())
            {
                rolename = sda.GetString(0);
            }
            return rolename;
        }

        public bool checkUser(string username)
        {
            SqlCommand command = new SqlCommand("select * from LOGIN where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            db.openConnection();

            if ((dt.Rows.Count > 0))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
