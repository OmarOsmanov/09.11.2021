using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Ticket
    {
        public string Price { get; set; }
        public string poster { get; set; }
        public kInoInfo kInoInfo { get; set; }

    }



    class kInoInfo
    {
        public string MovieName { get; set; }
        public int ganre { get; set; }
        public kinoIleVaxtlar kinoDaxili { get; set; }
    }


    class kinoIleVaxtlar
    {
        public int duration { get; set; }
        public  TimeSpan time{ get; set; }

        public kinonunKommeriyaVaxtlari kinonunKommeriyaVaxtlari { get; set; }
    }

    class kinonunKommeriyaVaxtlari
    {
        public DateTime Time { get; set; }
        public DateTime sellTime { get; set; }
    }
}
