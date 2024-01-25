using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Hotel
{
    class Room
    {
        DB db = new DB();

        public DataTable getsingleroomlist()
        {
            SqlCommand command = new SqlCommand("select ('Room ' + cast(rid as varchar)),"+
            " case when status = 'no' then cast(l.displayname as varchar)" +
            " when status = 'yes' then 'FREE'"+
            " end as status from RoomOrder r full join Login l on r.username=l.username where roomtype = 'single'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getdoubleroomlist()
        {
            SqlCommand command = new SqlCommand("select ('Room ' + cast(rid as varchar))," +
            " case when status = 'no' then cast(l.displayname as varchar)" +
            " when status = 'yes' then 'FREE'" +
            " end as status from RoomOrder r full join Login l on r.username=l.username where roomtype = 'double'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getallroom_name()
        { 
            SqlCommand command = new SqlCommand("select rid as 'Room ID', username as 'Customer', roomtype as 'Type', status as 'Avalibility', sdate as 'Entry Date', edate as 'Depart Date',"
            +" totaldate 'Total Days', totalprice 'Total Price' from RoomOrder ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getallroom()
        {
            SqlCommand command = new SqlCommand("select rid, username, roomtype, status, sdate, edate from RoomOrder", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getroomorderbyid(int rid)
        {
            SqlCommand command = new SqlCommand("select username, roomtype, status, sdate, edate from RoomOrder where rid = "+rid, db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool update_price()
        {
            SqlCommand command = new SqlCommand("update RoomOrder set totalprice = totaldate * rp.fee from RoomOrder ro left join RoomPrice rp on ro.roomtype = rp.roomtype", db.GetConnection);
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

        public bool roomorder_update(int rid, string username, string roomtype, string status, DateTime sdate, DateTime edate)
        {
            SqlCommand command = new SqlCommand("UPDATE RoomOrder SET rid = @rid, username = @username, roomtype = @roomtype, status = @status, sdate = @sdate, edate = @edate where rid = @rid", db.GetConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@roomtype", SqlDbType.VarChar).Value = roomtype;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            command.Parameters.Add("@sdate", SqlDbType.DateTime).Value = sdate;
            command.Parameters.Add("@edate", SqlDbType.DateTime).Value = edate;
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

        public bool roomorder_delete(int rid)
        {
            SqlCommand command = new SqlCommand("UPDATE RoomOrder SET username = null , status = 'yes', sdate = null, edate = null where rid = " + rid, db.GetConnection);
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

        public bool customer_add_rid(string username, int rid)
        {
            SqlCommand command = new SqlCommand("UPDATE Customer SET rid = " + rid + " where username = '" + username + "'", db.GetConnection);
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

        public bool customer_del_rid(string username)
        {
            SqlCommand command = new SqlCommand("UPDATE Customer SET rid = null where username = '" + username + "'", db.GetConnection);
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

        public DataTable get_services_list()
        {
            SqlCommand command = new SqlCommand("SELECT a.sname,a.sprice, b.sname, b.sprice " +
               "FROM(select sname, sprice, row_number() over(order by sprice, sname) rownum from Services) a " +
               "LEFT JOIN(select sname, sprice, lag(sprice) over(order by sprice, sname) previous from Services) b "+
               "ON a.sprice = b.previous "+
               "WHERE rownum % 2 = 1", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable display_services_list()
        {
            SqlCommand command = new SqlCommand("SELECT sid, sname from Services", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable service_price_cal(int sid, int amount)
        {
            SqlCommand command = new SqlCommand("select sprice * "+amount+" as 'price' from Services where sid = "+ sid , db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable update_customer_price(double new_price, string username)
        {
            SqlCommand command = new SqlCommand("Update RoomOrder set totalprice = totalprice + " + new_price+ " where username = '" +username+"'", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
