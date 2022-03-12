using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.DB.Barbers
{
    public interface BarberIF
    {
        public void CreateBarber(string nickname);
        public void DeleteBarber(string nickname);
        public void FindBarber(string nickname);
        public void UpdateBarber(string nickname, string newNickname);
    }
}
