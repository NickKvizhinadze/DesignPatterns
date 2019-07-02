using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.Models
{
    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
