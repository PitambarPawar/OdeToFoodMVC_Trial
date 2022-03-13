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

        public RESTAURANT GetById(int id)
        {
            var model = db.RESTAURANTS.Find(id);
            return model;
        }

        public void CreateRestaurant(RESTAURANT restaurant)
        {
            db.RESTAURANTS.Add(restaurant);
            db.SaveChanges();
        }

        public void DeleteResturant(int id)
        {
            var model = GetById(id);
            db.RESTAURANTS.Remove(model);
            db.SaveChanges();
        }

        public void EditRestaurant(RESTAURANT re)
        {
            RESTAURANT restaurant = new RESTAURANT();
            restaurant = GetById(re.ID);
            restaurant.NAME = re.NAME;
            db.SaveChanges();
        }

    }
}
