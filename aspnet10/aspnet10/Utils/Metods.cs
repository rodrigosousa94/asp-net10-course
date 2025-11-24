
namespace aspnet10.Utils
{
    public static class Metods
    {
        public static decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue)
             )
            {
                return decimalValue;
            }
            return 0;
        }

        public static bool IsNumeric(string strNumber)
        {
            decimal decimalValue;

            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
            );

            return isNumber;

        }

        internal static bool IsNumeric(object number)
        {
            throw new NotImplementedException();
        }
    }
}
