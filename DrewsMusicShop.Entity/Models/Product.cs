using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrewsMusicShop.Entity
{
    public interface IProduct
    {
        int Id { get; set; }
        string ItemNumber { get; set; }
        string Company { get; set; }
        double Cost { get; set; }
        bool ValidateProduct();

    }

    public abstract class Product : IProduct //, IEnumerable
    {
        public abstract int Id { get; set; }
        public abstract string ItemNumber { get; set; }
        public abstract string Company { get; set; }
        public abstract double Cost { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    return (IEnumerator) GetEnumerator();
        //}

        public abstract bool ValidateProduct();
    }
}
