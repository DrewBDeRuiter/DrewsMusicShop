using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrewsMusicShop.Entity;



namespace DrewsMusicShop.Models
{
    public class GuitarViewModel : Product, IGuitar, IStringedInstrument
    {
       
        public string BodyType { get; set; }
        public int NumberOfStrings { get; set; }
        public string BodyWood { get; set; }
        public int Frets { get; set; }
        public override int Id { get; set; }
        public override string ItemNumber { get; set; }
        public override string Company { get; set; }
        public override double Cost { get; set; }
        public string BodyColor { get; set; }
        public string Model { get; set; }


        public override bool ValidateProduct()
        {
            throw new NotImplementedException();
        }

    }
}