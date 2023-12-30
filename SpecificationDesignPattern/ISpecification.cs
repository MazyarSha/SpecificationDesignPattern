using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationDesignPattern
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T entity);
    }
    public class DiscountSpecification: ISpecification<Customer>
    {
        public bool IsSatisfied(Customer  entity) 
        {
            return entity.TotalPurchases >= 2000 && entity.IsPremium;
        }
    }
    public class FreeDeliverySpecification: ISpecification<Customer>
    {
        public bool IsSatisfied(Customer entity) 
        { 
            return entity.TotalPurchases >= 1000; 
        }
    }
}
