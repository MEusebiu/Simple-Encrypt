using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security01
{
    class ComboBox
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ComboBox(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
