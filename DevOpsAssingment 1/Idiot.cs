using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsAssingment_1
{
    class Idiot
    {
        String name;
        String lastName;

        public Idiot()
        {
            this.Name = "Dylan";
            this.LastName = "Hailes";
        }

        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
    }
}
