using InterfaceSegregation.Burguer;
using InterfaceSegregation.Fries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Combo
{
    public interface IComboService : IFriesService, IBurguerService
    {
    }
}
