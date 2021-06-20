using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHuman
{
    public abstract class Human
    {
        public string fio { get; set; }
        Gender gen;
        public enum Gender { мужской, женский};
        public DateTime birthdate { get; set; }

        public Human()
        {
            fio = "Unknown";
            gen = Gender.мужской;
            birthdate = new DateTime(1900, 01, 01);
        }

        public Human(string humfio, Gender g, DateTime bd)
        {
            fio = humfio;
            gen = g;
            birthdate = bd;
        }

        public abstract string GetInfo();
    }
}
