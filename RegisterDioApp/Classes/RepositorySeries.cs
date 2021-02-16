using System;
using System.Collections.Generic;
using RegisterDioApp.Interfaces;

namespace RegisterDioApp
{
    public class RepositorySeries : IRepository<Series>
    {

        private List<Series> listSeries = new List<Series>();

        public void Update(int id, Series entidy)
        {
            listSeries[id] = entidy;
        }      
        public void Delete(int id)
        {
            listSeries[id]._Delete();
        }
        public void Insert(Series entidy)
        {
            listSeries.Add(entidy);
        }
        public List<Series> List()
        {
            return listSeries;
        }
        public int NextId()
        {
            return listSeries.Count;
        }
        public Series ReturnById(int id)
        {
            return listSeries[id];
        }
    }
}