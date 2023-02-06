using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class FreePark : ISquare
  {
    public string Name { get; set; }
    public FreePark( string name )
    {
      Name = name;
    }

    

    public void StepIn( int id)
    {
      
    }
    public void Transaction( int id, int act ) { } //select keliling dunia or take taxfund


  }
}
