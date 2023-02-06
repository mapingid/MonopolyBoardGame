using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Company : ISquare
  {
    public string Name { get; set; }
    int OwnerID;
    int Level;
    int PriceLand;
    int RentLand;

    public Company( string name )
    {
      Name = name;
    }

    public void StepIn( int id)
    {
      //pay rent
    }
    public void Transaction( int id, int act ) {  }

    // List Of Action
    int BuyLand( int id ) { setOwnership( id ); return PriceLand; }

    // Support Method
    void setOwnership( int id ) { OwnerID = id; }
  }
}
