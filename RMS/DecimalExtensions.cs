namespace RMS
{
    public static class DecimalExtensions
    {
        public static decimal ToConvertedCurrency(this decimal price, int currencyType = (int)CurrencyType.US)
        {
            return currencyType == (int)CurrencyType.EUR  ? price * 1.1m : price;
        }
    }
}
