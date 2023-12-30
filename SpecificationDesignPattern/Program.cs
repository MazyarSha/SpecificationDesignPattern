// See https://aka.ms/new-console-template for more information
using SpecificationDesignPattern;

Console.WriteLine("Hello, World!");

var customer = new Customer
{
    Name =  "Ali",
    IsPremium = true,
    TotalPurchases = 1000,
};

var discountSpecification = new DiscountSpecification();
bool isAligibleToDiscount = discountSpecification.IsSatisfied(customer);
Console.WriteLine("isAligibleToDiscount : " + isAligibleToDiscount.ToString());
FreeDeliverySpecification freeDeliverySpecification = new FreeDeliverySpecification();
bool isAligibleTofreeDelivery = freeDeliverySpecification.IsSatisfied(customer);
Console.WriteLine("isAligibleTofreeDelivery : " + isAligibleTofreeDelivery.ToString());
