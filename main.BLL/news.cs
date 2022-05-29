using main.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using main.Entities;


namespace main.BLL
{
    public class News
    {
        public List<khabar> loadfirstnews()
        {
            newsDao newsDao = new newsDao();
            return newsDao.loadfirstnews();
        }

        public static void AddToDatabase(khabar khabar)
        {
            newsDao newsDao = new newsDao();
            newsDao.AddToDatabase();
        }

        public void RemoveFromDatabase(string id)
        {
            newsDao newsDao = new newsDao();
            newsDao.removefromdatabase(id);
        }

    }
}
