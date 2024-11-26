using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD16_Assignment3_4wpf
{
    public enum Roast { light, medium, dark }
    public enum Temp { hot, cold, iced }
    public class Coffee : Beverage
    {
        public Roast Roast { get; set; }
        public Temp Temp { get; set; }
    }
}