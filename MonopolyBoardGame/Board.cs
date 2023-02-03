using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Board
  {
    Dictionary<int, ISquare> board = new Dictionary<int, ISquare>();
    void Initialize()
    {
      board.Add( 0, new Start( "Start" ) );
      board.Add( 1, new City( "KotaA" ) );
      board.Add( 2, new Card( "Card" ) );
      board.Add( 3, new City( "KotaA" ) );
      board.Add( 4, new Tax( "Tax1", 200 ) );
      board.Add( 5, new Station( "Station A" ) );
      board.Add( 6, new City( "KotaA" ) );
      board.Add( 7, new Card( "Card" ) );
      board.Add( 8, new City( "KotaA" ) );
      board.Add( 9, new City( "KotaA" ) );
      board.Add( 10, new Jail( "Jail" ) );
      //board.Add( 10, new FreePark( "Jail" ) );
      //board.Add( 10, new GotoJail( "Jail" ) );
    }
  }
}
