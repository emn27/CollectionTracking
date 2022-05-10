using System.Data;
using System.Data.SqlClient;

namespace CollectionTracking.Core.DataAccess
{
    public abstract class AbstractRepository
    {
        public SqlConnection _connection;
        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
