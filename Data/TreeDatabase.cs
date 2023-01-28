using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Composite.Models;

namespace Composite.Data
{
    public class TreeDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public TreeDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Trees>();
        }

        public int AddNewTree(Trees trees)
        {
            Init();
            int result = conn.Insert(trees);
            return result;
        }
        public List<Trees> GetAllTrees()
        {
            Init();
            List<Trees> trees = conn.Table<Trees>().ToList();
            return trees;
        }

    }
}
