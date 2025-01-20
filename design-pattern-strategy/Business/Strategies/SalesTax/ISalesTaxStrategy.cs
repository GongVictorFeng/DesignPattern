using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax 
{
    public interface ISalesTaxStrategy
    {
        decimal GetTaxFor(Order order);
    }
}

