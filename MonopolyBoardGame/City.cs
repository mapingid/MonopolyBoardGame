using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class City : ISquare
  {
    public string Name { get; set; }
    public int OwnerID;
    int Level;
    int PriceLand;
    int PriceHouse;
    int PriceHotel;
    int RentLand;
    int RentHouse1;
    int RentHouse2;
    int RentHouse3;
    int RentHouse4;
    int RentHotel;
    public City( string name )
    {
      Name = name;
    }

    public void StepIn( int id )
    {
      //


      // Pay Rent
      if( id != OwnerID ) { } // bayar
      else { } //gausa bayar
      Board.Player[id].Balance -= 100;
      Board.Player[OwnerID].Balance += 100;

      

    }
    public void Transaction( int id, int act ) {  }

    // List Of Transaction
    int BuyLand( int id ) { setOwnership( id ); return PriceLand; }
    int BuyHouse( int id, int level ) { setOwnership( id ); return PriceHouse * level; }
    int BuyHotel( int id ) { setOwnership( id ); return PriceHouse; }

    // Support Method
    void setOwnership( int id ) { OwnerID = id; }
  }
}
