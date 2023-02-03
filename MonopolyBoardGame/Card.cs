using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Card : ISquare, ICard
  {
    public string Name { get; }
    public Card(string name)
    {
      Name = name;
    }
    public void DrawCard() { }
  }
}
