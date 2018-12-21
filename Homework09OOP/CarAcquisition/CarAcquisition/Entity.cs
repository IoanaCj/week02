using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAcquisition
{
   abstract class Entity
    {
        public abstract string GetName();
        public string Address { get; set; }

        public Entity()
        {

        }
    }
}
