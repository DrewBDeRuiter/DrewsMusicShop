using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrewsMusicShop.Data;
using DrewsMusicShop.Entity;

namespace DrewsMusicShop.Service
{
    public class InventoryService
    {
        public List<Guitar> GetAllGuitars()
        {
            MockData md = new MockData();

            return md.GetAllGuitars().ToList();
        }
    }
}
