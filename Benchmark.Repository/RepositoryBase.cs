using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Benchmark.Repository
{
    public class RepositoryBase : IDisposable
    {
        public IDbConnection _db;

        public RepositoryBase()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);
            _db.Open();
        }

        public RepositoryBase(IDbConnection db)
        {
            _db = db;
            if(_db.State != ConnectionState.Open)
              _db.Open();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Close();
            }
        }
        ~RepositoryBase()
        {
            Dispose(false);
        }
    }
}
