using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIViagem.Helpers
{
    internal class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            //_connection.CreateTableAsync
        }
    }
}
