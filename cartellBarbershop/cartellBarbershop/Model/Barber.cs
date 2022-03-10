using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Model
{
    public class Barber
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Barber(int _id, string _name)
        {
            Id = _id;
            Name = _name;   
        }

    }
}
