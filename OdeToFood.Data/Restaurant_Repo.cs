using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class Restaurant_Repo
    {
        OdeToFoodMVCEntities db = null;

        public Restaurant_Repo()
        {
            db = new OdeToFoodMVCEntities();
        }

        public IEnumerable<RESTAURANT> GetAll()
        {
            return db.RESTAURANTS.ToList();
        }
    }
}
