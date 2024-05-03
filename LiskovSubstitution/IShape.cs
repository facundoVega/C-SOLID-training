using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public interface IBaseShape
    {
        public int Width { get; }
        public void SetWidth(int width);
        public void CalculateArea();
    }
}
