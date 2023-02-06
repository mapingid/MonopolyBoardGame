using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Community : ISquare
  {
    public string Name { get; set; }
    public Community( string name )
    {
      Name = name;
    }
    public void StepIn( int id )
    {
      DrawCard( id );
    }
    public void Transaction( int id, int act ) { }

    // Support Method
    void DrawCard( int id ) { }

  }
}
