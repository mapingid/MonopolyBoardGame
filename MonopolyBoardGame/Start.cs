﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBoardGame
{
  class Start : ISquare
  {
    public string Name { get; set; }
    int Money;
    public Start( string name, int money )
    {
      Name = name;
      Money = money;
    }



    public void StepIn( int id )
    {
      //balance += Money;
    }
    public void Transaction( int id, int act ) {}
  }
}
