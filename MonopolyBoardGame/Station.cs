using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Station : ISquare
  {
    public string Name { get; }
    public Station( string name )
    {
      Name = name;
    }
  }
}
