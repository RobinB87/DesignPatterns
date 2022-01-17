using Strategy_UseDifferentShippingProviders.Business.Models;

namespace Strategy_UseDifferentShippingProviders.Business.Strategies.Shipping
{
    public interface IShippingStrategy
    {
        void Ship(Order order);
    }
}