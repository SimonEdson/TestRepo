namespace Helpers
{
    public static class Addition
    {
        public static int? ValidateValue(string? value)
        {
            if (value != null && int.TryParse(value, out int result))
            {
                return result;
            }

            return null;
        }
    }
}
