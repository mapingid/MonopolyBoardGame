using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  interface ISquare
  {
    string Name { get; set; }
    void StepIn( int id);
    void Transaction( int id, int act);


  }
}
