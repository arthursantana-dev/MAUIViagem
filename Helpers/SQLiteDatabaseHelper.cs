using MAUIViagem.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIViagem.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Pedagio>().Wait();
        }

        public Task<int> Insert(Pedagio p)
        {
            return _connection.InsertAsync(p);
        }

        public Task<List<Pedagio>> GetAll() { 
            return _connection.Table<Pedagio>().ToListAsync();
        }

        public Task<int> Delete(Pedagio p)
        {
            return _connection.Table<Pedagio>().DeleteAsync(i => i.Id == p.Id);
        }
    }
}
