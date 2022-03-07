using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CollegesBO
    {
       
       
            private string name;
            private int id;
            public CollegesBO()
            {

            }
            public CollegesBO(string name, int id)
            {
                this.name = name;
                this.id = id;
            }

            public string Name { get => name; set => name = value; }
            public int Id { get => id; set => id = value; }
        
    }
}
