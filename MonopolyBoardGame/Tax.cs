using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Tax : ISquare, ITax
  {
    public string Name { get; }
    public int Charge { get; }
    public Tax( string name, int charge )
    {
      Name = name;
      Charge = charge;
    }
    public int Arrival() { return Charge; }
  }
}
