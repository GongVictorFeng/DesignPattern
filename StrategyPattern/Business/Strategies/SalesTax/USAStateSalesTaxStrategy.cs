using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class USAStateSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationState.ToLowerInvariant();
            switch (destination)
                {
                    case "la": return order.TotalPrice * 0.095m;
                    case "ny": return order.TotalPrice * 0.04m;
                    case "nyc": return order.TotalPrice * 0.045m;
                    default: return 0m;
                }
        }
    }
}

