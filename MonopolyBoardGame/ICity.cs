using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  interface ICity
  {
    string Owner { get; set; }
    int PriceBuyLand { get; }
    int PriceBuyHouse { get; }
    int PriceBuyHotel { get; }
    int PriceRentLand { get; }
    int PriceRentHouse1 { get; }
    int PriceRentHouse2 { get; }
    int PriceRentHouse3 { get; }
    int PriceRentHouse4 { get; }
    int PriceRentHotel { get; }
    int Model { get; set; }



    int Arrival();
    int Transaction(int level);
  }
}
