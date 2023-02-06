using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Chance : ISquare
  {
    public string Name { get; set; }
    public Chance( string name )
    {
      Name = name;
    }
    public void StepIn(int id )
    {
      DrawCard(id);
    }
    public void Transaction( int id, int act ) { }
    
    // Support Method
    void DrawCard(int id) {}

  }
}
