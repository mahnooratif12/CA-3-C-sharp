using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricDB.Shared
{
    public class PlayerAPIReponse
    {
        public CricPlayer[]? list  {  get; set; }
        public string category { get; set; }
    }
}
