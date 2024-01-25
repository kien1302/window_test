using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    class CustomerInfo
    {
        DB db = new DB();

        public DataTable getcustomerlist()
        {
            SqlCommand command = new SqlCommand("select username 'Customer', rid 'Room ID', year 'Year', gender 'Gender', phone 'Phone', inumber 'Identity Number' from Customer", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        
        public DataTable check_user_room(string username)
        {
            SqlCommand command = new SqlCommand("select rid from Customer where username = '" + username + "'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getdisplayname(string username)
        {
            SqlCommand command = new SqlCommand("select displayname from Login where username = '" +username+ "'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getuser_roomid(string username)
        {
            SqlCommand command = new SqlCommand("select rid from RoomOrder where username = '" + username + "'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getuser_room_dayleft(string username)
        {
            SqlCommand command = new SqlCommand("select datediff(day,(cast(GETDATE() as date)), edate) from RoomOrder where username = '" + username + "'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable get_free_room()
        {
            SqlCommand command = new SqlCommand("SELECT a.rid,a.status, b.rid,b.status "+
                "FROM(select rid, status, row_number() over(order by rid, status) rownum from RoomOrder) a "+
                "LEFT JOIN(Select rid, status, lag(rid) over(order by rid, status) previous from RoomOrder) b "+
                "ON a.rid = b.previous "+
                "WHERE rownum% 2 = 1 ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable get_status_from_rid(int rid)
        {
            SqlCommand command = new SqlCommand("select status from RoomOrder where rid = "+rid, db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool store_log(string message)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Log (text)" +
                "VALUES (@text)", db.GetConnection);
            command.Parameters.Add("@text", SqlDbType.VarChar).Value = message;
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

        public DataTable read_log()
        {
            SqlCommand command = new SqlCommand("select * from Log", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
