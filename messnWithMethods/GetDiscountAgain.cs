namespace messnWithMethods
{
    internal class GetDiscountAgain
    {
        private static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else
            {
                discountPercent = .1m;
            }

            return discountPercent;
        }
    }
}