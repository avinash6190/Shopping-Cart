using AIMIA.Core;
using AIMIA.Repository;

namespace AIMIA.BLService
{
    public class CartService : ICartService
    {
        private ICartRepository cartRepository;

        public int AddCart(int petId, int itemCount)
        {
            int count = 0;
            if (petId != null && itemCount!=null)
            {
                count = itemCount + 1;
            }
            return count;
        }
    }
}