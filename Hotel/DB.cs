using System.Data.SqlClient;

namespace Hotel
{
    class DB
    {

        SqlConnection con = new SqlConnection(@"Data Source=FOX\FOX;Initial Catalog=HotelMA;Integrated Security=True");

        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
