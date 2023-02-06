using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Tax : ISquare
  {
    public string Name { get; set; }
    int TaxAmmount;
    public Tax( string name, int taxAmmount )
    {
      Name = name;
      TaxAmmount = taxAmmount;
    }
    public void StepIn( int id) 
    {
      //balance -= TaxAmmount;
      //Board.TaxFund += TaxAmmount;
    }
    public void Transaction( int id, int act ) {  }
  }
}
