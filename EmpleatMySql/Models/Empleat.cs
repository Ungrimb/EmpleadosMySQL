using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmpleatMySql.Models
{
    public class Empleat
    {

        private EmpleatContext context;
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public string Càrrec { get; set; }
        public string Sou { get; set; }

    }
}
