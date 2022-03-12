using cartellBarbershop.DB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Controller
{
    public class ServiceController
    {
        public ServiceIF serviceDB;

        public ServiceController()
        {
            serviceDB = new ServiceDB();
        }

        public void CreateService(string name, string description, float price)
        {
            serviceDB.CreateService(name, description, price);
        }

        public void DeleteService(string name)
        {
            serviceDB.DeleteService(name);
        }

        public void FindService(string name)
        {
            serviceDB.FindService(name);
        }

        public void UpdateService(string name, float newPrice)
        {
            serviceDB.UpdateService(name, newPrice);
        }
    }
}
