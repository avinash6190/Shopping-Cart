using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMIA.Repository
{
    public interface ICartRepository
    {
        string AddCart(int petId, string userFeedBack);
    }
}
