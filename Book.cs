using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga20241202
{
    internal class Book
    {
        Random rnd = new Random();
        private long isbn;
        private List<Author> author;
        private string cim;
        private int kiadasev;
        private string nyelv;
        public int keszlet;
        private int ar;

        public Book(long ISBN, List<Author> author, string cim, int kiadas, string nyelv, int keszlet, int ar)
        {
            if (isbn.ToString().Length != 10)
            {
                throw new ArgumentException("ISBN egy 10 jegyű számsorozat");
            }
            if(author.Count < 1 || author.Count > 3)
            {
                throw new ArgumentException("A szerzők listájának 1 és 3 között kell lennie");
            }
            if (cim.ToString().Length > 3 || cim.ToString().Length > 64)
            {
                throw new ArgumentException("A címnek 3 és 64 között kell lennie");
            }
            if(kiadasev > 2007 ||kiadasev > 2024)
            {
                throw new ArgumentException("A kiadás évének 2007 és 2024 között kell lennie");
            }
            if(nyelv.ToString() != "angol" ||nyelv.ToString() != "német" || nyelv.ToString() != "magyar")
            {
                throw new ArgumentException("A nyelv csak angol, német és magyar lehet");
            }
            if(keszlet < 0 || keszlet == .5)
            {
                throw new ArgumentException("A készlet csak egész szám lehet, illetve minimum 0");
            }
            if(ar < 1000 || ar > 10000|| ar != .0)
            {
                throw new ArgumentException("Az ár csak 1000 és 10000 közötti érték lehet, illetve csak egész szám 100-asra kerekítve");
            }

            this.isbn = ISBN;
            this.author = author;
            this.cim = cim;
            this.kiadasev = kiadas;
            this.nyelv = nyelv;
            this.keszlet = keszlet;
            this.ar = ar;
        }

        public Book(string szerzo, string cim)
        {
            isbn = rnd.Next(1000000, 9999999) * 100;
            this.cim = cim;
            this.author = new List<Author>() { new Author(szerzo) };
            this.kiadasev = 2024;
            this.nyelv = "magyar";
            this.keszlet = 0;
            this.ar = 4500;
        }

        public override string ToString()
        {
            string szerzo = "";
            foreach (var item in author)
            {
                szerzo += item.getNev() + " ";
            }

            return $"Könyv ISBN száma: {this.isbn}\n" +
                $"Címe: {this.cim}\n" +
                $"{(this.author.Count > 1 ? "Szerzők: " : "Szerző: ")}{szerzo.Trim()}\n" +
                $"Kiadás éve: {this.kiadasev}\n" +
                $"Nyelve: {this.nyelv}\n" +
                $"Készleten: {(this.keszlet > 0 ? $"{this.keszlet}db" : "beszerzés alatt")} \n" +
                $"Ára: {this.ar}";
        }

        public void setKeszlet(int ujKeszlet)
        {
            this.keszlet = ujKeszlet;
        }

        public long getISBN()
        {
            return this.isbn;
        }

        public List<Author> getSzerzok()
        {
            return author;
        }

        public string getCim()
        {
            return cim;
        }

        public int getKiadas()
        {
            return this.kiadasev;
        }

        public string getNyelv()
        {
            return this.nyelv;
        }

        public int getKeszlet()
        {
            return this.keszlet;
        }

        public int getAr()
        {
            return this.ar;
        }
    }
}
