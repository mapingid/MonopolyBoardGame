using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{

  class Program
  {
    static void Main( string[] args )
    {
      Board board = new Board();
      //Player player1 = new Player( 1 );
      //Player player2 = new Player( 2 );

      //while( true )
      //{
      Board.RollDice( 0 );
      Board.TakeAction( 0 );
      
      //Board.RollDice( 1 );
      Board.TakeAction( 1 );


      Console.Read();
      //}



    }
  }
}
