using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirsModul.Models
{
    internal class House
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public int QuentityRooms { get; set; }

    }
}
