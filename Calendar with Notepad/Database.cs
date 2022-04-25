using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Calendar_with_Notepad
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Note>().Wait();
        }

        
        public Task<List<Note>> GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }

        
        public Task<int> SaveNotesAsync(Note note)
        {
            return _database.InsertAsync(note);
        }

        
        public Task<int> DeleteNotesAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }

        
        public Task<int> UpdateNotesAsync(Note note)
        {
            return _database.UpdateAsync(note);
        }
    }
}
