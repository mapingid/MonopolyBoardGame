using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Station : ISquare
  {
    public string Name { get; set; }
    int OwnerID;
    int Level;
    int PriceLand;
    int RentLand;

    public Station( string name )
    {
      Name = name;
    }

    public void StepIn( int id )
    {
      //balance -= ( RentLand * Level );
    }
    public void Transaction( int id, int act ) { }

    // List Of Action
    int BuyLand( int id ) { setOwnership( id ); return PriceLand; }

    // Support Method
    void setOwnership( int id ) { OwnerID = id; }
  }
}
