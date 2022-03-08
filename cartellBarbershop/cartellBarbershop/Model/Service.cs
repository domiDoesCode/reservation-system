using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartellBarbershop.Model
{
    internal class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Price Price { get; set; }

        public Service(int _id, string _name, string _description, Price p)
        {
            this.Id = _id;
            this.Name = _name;
            this.Description = _description;
            this.Price = p;
        }
    }
}
