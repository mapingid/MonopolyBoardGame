using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Board
  {
    public static Dictionary<int, ISquare> Square = new Dictionary<int, ISquare>();
    public static Dictionary<int, Player> Player = new Dictionary<int, Player>();
    public static int TaxFund;

    public Board()
    {
      Player.Add( 0, new Player() );
      Player.Add( 1, new Player() );

      Square.Add( 0, new Start( "Start", 100 ) );
      Square.Add( 1, new City( "City 1" ) );
      Square.Add( 2, new Community( "Dana Umum" ) );
      Square.Add( 3, new City( "City 2" ) );
      Square.Add( 4, new Tax( "Tax 1", 100 ) );
    }

    public static void RollDice( int id )
    {
      Random dice1 = new Random();
      Random dice2 = new Random();
      //Player[id].Position = dice1.Next( 1, 6 ) + dice2.Next( 1, 6 );
    }
    public static void TakeAction( int id )
    {
      int pos = Player[id].Position;

      if( Square[pos] is Start )
      {
        Square[pos].StepIn( id );
      }
      else if( Square[pos] is City )
      {
        Square[pos].StepIn( id );
        Console.WriteLine( "Select Available Action" );
        int act = 0;


        Square[pos].Transaction( id, act);
      }
      else if( Square[pos] is Station )
      {
        Square[pos].StepIn( id );
        Console.WriteLine( "Select Available Action" );
        int act = 0;
        Square[pos].Transaction( id, act );
      }
      else if( Square[pos] is Company )
      {
        Square[pos].StepIn( id );
        Console.WriteLine( "Select Available Action" );
        int act = 0;
        Square[pos].Transaction( id, act );
      }
      else if( Square[pos] is Community )
      {
        Square[pos].StepIn( id );
      }
      else if( Square[pos] is Chance )
      {
        Square[pos].StepIn( id );
      }
      else if( Square[pos] is Tax )
      {
        Square[pos].StepIn( id );
      }
      else if( Square[pos] is Prison )
      {
        Console.WriteLine( "Select Available Action" );
        int act = 0;
        Square[pos].Transaction( id, act );
      }
      else if( Square[pos] is FreePark )
      {
        Console.WriteLine( "Select Available Action" );
        int act = 0;
        Square[pos].Transaction( id, act );
      }
      else if( Square[pos] is GoToJail )
      {
        Square[pos].StepIn( id );
      }


    }
    public static void GetWealth( int id ) { }
    public static void InitPlayer() { }
    public static void InitBoard() { }
    public static void KillPlayer( int id ) { }
  }
}
