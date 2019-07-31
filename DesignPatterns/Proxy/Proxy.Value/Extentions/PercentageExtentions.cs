using Proxy.Value.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Value.Extentions
{
    public static class PercentageExtentions
    {
        public static Percentage Percent(this int value)
        {
            return new Percentage(value / 100.0f);
        }
        public static Percentage Percent(this float value)
        {
            return new Percentage(value / 100.0f);
        }
    }
}
