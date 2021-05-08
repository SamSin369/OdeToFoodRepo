using OdeToFood.Datas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Datas.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);

        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
    }
}
