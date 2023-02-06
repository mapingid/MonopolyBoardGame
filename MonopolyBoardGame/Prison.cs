using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Prison : ISquare
  {
    public string Name { get; set; }
    public Prison( string name )
    {
      Name = name;
    }
    public void StepIn( int id)
    {
      bool kembar = RollDice();
    } 
    public void Transaction( int id, int act ) { }

    // Support Method
    bool RollDice() { return false; }
  }
}
