using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Jail : ISquare
  {
    public string Name { get; }
    public Jail( string name )
    {
      Name = name;
    }
  }
}
