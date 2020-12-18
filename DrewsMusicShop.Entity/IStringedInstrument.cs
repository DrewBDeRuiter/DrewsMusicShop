using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrewsMusicShop.Entity
{
    public interface IStringedInstrument
    {
        int NumberOfStrings { get; set; }
        string BodyWood { get; set; }
        int Frets { get; set; }
    }
}
