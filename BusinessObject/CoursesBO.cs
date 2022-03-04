using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    class CoursesBO
    {
     
            private int id;
            private string name;
            private DateTime duration;
            private string description;

            public CoursesBO()
            {

            }

            public CoursesBO(int id, string name, DateTime duration, string description)
            {
                this.Id = id;
                this.Name = name;
                this.Duration = duration;
                this.Description = description;
            }

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public DateTime Duration { get => duration; set => duration = value; }
            public string Description { get => description; set => description = value; }
        
    }
}
