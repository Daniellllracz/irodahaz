using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodahaz
{
    internal class Iroda
    {
        public string cegNev { get; set; }
        public int kelletkez { get; set; }
        private readonly List<int> letszamadat;


        public Iroda(string adatok)
        {
            var v = adatok.Split(';');
            cegNev = v[0];
            kelletkez = int.Parse(v[1]);
            letszamadat = new List<int>();
        
        
        
        
        }
        public override string ToString()
        {
            return $"Cégneve: {cegNev}\nkelletkezés : {kelletkez}\nletszám egy iroda házba : {letszamadat}";
        }




    }
}
