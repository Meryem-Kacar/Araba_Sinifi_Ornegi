using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba_sinifi_ornek_proje
{
    internal class Musteri
    {
        public int id;
        private string name;
        public string surname;
        public string city;

        public string Name { get => name; set => name = value.ToLower(); }
        public string Surname
        {
            get => surname; set => surname = value.ToUpper();
        }
    }
}
