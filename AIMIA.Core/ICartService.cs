using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMIA;

namespace AIMIA.Core
{
    public interface ICartService
    {
       int AddCart(int petId, int itemCount);
    }
}
