/* Make Some Helper Methods to Simplify Converting a C# String to Int */
namespace CustomExtensions {

    public static class IntegerExtensions {
        public static int ParseInt(this string value, int defaultIntValue = 0) {
            int parsedInt;
            if(int.TryParse(value, out parsedInt)) { 
                return parsedInt;
            }
            return defaultIntValue;
        }

        public static int? ParseNullableInt(this string value) {
            if(string.IsNullOrEmpty(value)) {
                return null;
            }
            return value.ParseInt();
        }
    }

}