﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestructureDemo1
{
 public   abstract class Price
 {
     public abstract int GetPriceCode();
     public abstract double GetChange(int daysRented);
   
     public virtual int GetFrequentRenterPoints(int daysRented)
     {
         return 1;
     }
 }
}