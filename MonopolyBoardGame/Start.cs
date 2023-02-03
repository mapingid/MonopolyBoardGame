using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Start : ISquare
  {
    public string Name { get; }
    public Start( string name )
    {
      Name = name;
    }
    public int Transaction()
    {
      return 200;
    }

  }
}
