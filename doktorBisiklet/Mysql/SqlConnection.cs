using MySql.Data.MySqlClient;

namespace Mysql
{
    internal class SqlConnection
    {
        public MySqlConnection baglan()
        {
            string conString = "server=localhost;user=root;database=doktorbisiklet;password=32731219222Ar";
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            MySqlConnection.ClearPool(conn);
            MySqlConnection.ClearAllPools();
            return (conn);
        }
    }
}