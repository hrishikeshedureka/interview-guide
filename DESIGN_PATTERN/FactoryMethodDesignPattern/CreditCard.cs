using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    // Product
    public abstract class CreditCard
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
    }

    // Concrete Products
    public class MoneyBackCard : CreditCard
    {
        public override string GetCardType() => "MoneyBack";
        public override int GetCreditLimit() => 50000;
    }

    public class PlatinumCard : CreditCard
    {
        public override string GetCardType() => "Platinum";
        public override int GetCreditLimit() => 100000;
    }

    // Creator
    public abstract class CreditCardFactory
    {
        public abstract CreditCard CreateCard();
    }

    // Concrete Creators
    public class MoneyBackFactory : CreditCardFactory
    {
        public override CreditCard CreateCard() => new MoneyBackCard();
    }

    public class PlatinumFactory : CreditCardFactory
    {
        public override CreditCard CreateCard() => new PlatinumCard();
    }
}
