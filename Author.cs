using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga20241202
{
    internal class Author
    {
        private string GUID;
        private string vezetekNev;
        private string keresztNev;

        public Author(string nev)
        {
            GUID = Guid.NewGuid().ToString();
            string[] nevreszletek = nev.Split(' ');
            this.vezetekNev = nevreszletek[0];
            this.keresztNev = nevreszletek[1];
        }

        private string GetGUID()
        {
            return this.GUID;
        }

        public string getNev()
        {
            return $"{this.vezetekNev} {this.keresztNev}";
        }
    }
}
