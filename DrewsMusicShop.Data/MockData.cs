using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrewsMusicShop.Entity;


namespace DrewsMusicShop.Data
{
    public class MockData
    {
        List<Guitar> Guitars;
        public MockData(){

              Guitars = new List<Guitar>()
            {
                new Guitar{Id=1, NumberOfStrings=6, BodyColor="White", BodyType="Solid", Company="Fender", Cost=899.99, BodyWood="Alder", Frets=22, ItemNumber="F0001", Model="Stratocaster"},
                new Guitar{Id=2, NumberOfStrings=6, BodyColor="Red", BodyType="Solid", Company="Fender", Cost=899.99, BodyWood="Alder", Frets=22, ItemNumber="F0002" , Model="Telecaster"},
                new Guitar{Id=3, NumberOfStrings=6, BodyColor="Red", BodyType="Solid", Company="Kiesel", Cost=899.99, BodyWood="Alder", Frets=24, ItemNumber="K0001" , Model="Cresent C6"},
                new Guitar{Id=4, NumberOfStrings=6, BodyColor="Natural", BodyType="Acoustic", Company="Taylor", Cost=2299.99, BodyWood="Maple", Frets=22, ItemNumber="T0001" , Model="614 CE"},
                new Guitar{Id=5, NumberOfStrings=6, BodyColor="Black", BodyType="Solid", Company="Schecter", Cost=999.99, BodyWood="Alder", Frets=24, ItemNumber="S0001" , Model="S"},
                new Guitar{Id=6, NumberOfStrings=7, BodyColor="White", BodyType="Solid", Company="Ibanez", Cost=1299.99, BodyWood="Alder", Frets=24, ItemNumber="I0002" , Model="Jem"},
                new Guitar{Id=7, NumberOfStrings=6, BodyColor="Sunburst", BodyType="Solid", Company="Gibson", Cost=1699.99, BodyWood="Mahogany", Frets=22, ItemNumber="G0002" , Model="Les Paul Custom"},
                new Guitar{Id=8, NumberOfStrings=7, BodyColor="Black", BodyType="Solid", Company="Guerilla", Cost=2600.00, BodyWood="Poplar", Frets=24, ItemNumber="Gu0002" , Model="G"},
            };
        }
        

        public IEnumerable<Guitar> GetAllGuitars()
        {

            return Guitars.OrderBy(r => r.Company);

        }

        public Guitar GetGuitarDetails(string iNumber) {

            return Guitars.FirstOrDefault(g => g.ItemNumber == iNumber);
        }

    }
}
