using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Services
{
    public interface ServiceIF
    {
        public void CreateService(string name, string description, float prcice);
        public void DeleteService(string name);
        public void FindService(string name);
        public void UpdateService(string name, float newPrice);
    }
}
