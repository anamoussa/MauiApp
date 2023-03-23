using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HITSMauiApp.Models
{
   public class Vacation
    {
        public string tybe { get; set; }
        public DateOnly from  { get; set; }
        public string Details { get; set; }
        public DateOnly to { get; set; }
        public string category { get; set; }
        public int noOfDays { get; set; }
        public bool IsFavorite { get; set; }

    }
}
