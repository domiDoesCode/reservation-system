using cartellBarbershop.DB.Barbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Controller
{
    public class BarberController
    {
        public BarberIF barberDB;

        public BarberController()
        {
            barberDB = new BarberDB();
        }

        public void CreateBarber(string nickname)
        {
            barberDB.CreateBarber(nickname);
        }

        public void DeleteBarber(string nickname)
        {
            barberDB.DeleteBarber(nickname);
        }

        public void FindBarber(string nickname)
        {
            barberDB.FindBarber(nickname);
        }

        public void UpdateBarber(string nickname, string newNickname)
        {
            barberDB.UpdateBarber(nickname, newNickname);
        }
    }
}
