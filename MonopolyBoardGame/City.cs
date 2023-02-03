using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class City : ISquare, ICity
  {
    public string Name { get; }
    public string Owner { get; set; }
    public int PriceBuyLand { get; }
    public int PriceBuyHouse { get; }
    public int PriceBuyHotel { get; }
    public int PriceRentLand { get; }
    public int PriceRentHouse1 { get; }
    public int PriceRentHouse2 { get; }
    public int PriceRentHouse3 { get; }
    public int PriceRentHouse4 { get; }
    public int PriceRentHotel { get; }
    public int Model { get; set; }
    public City( string name )
    {
      Name = name;
    }




    public int Arrival()
    {
      //check ini tipe apa apakah mbayar atau malah dapet uang
      return 0;
    }
    public int Transaction( int level )
    {
      //apakah berkunjung pertamakali ? beli tanah : beli rumah sesuai level
      //apakah sudah punya rumah ? jika iya beli hotel
      //setmodel
      //setOwnership

      return 0;
    }


  }
}
