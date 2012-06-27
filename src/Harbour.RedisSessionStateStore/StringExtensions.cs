using System;

namespace Harbour.RedisSessionStateStore
{
    /// <summary>
    /// String extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Extension method for .Net #3.5 to mimic 4.0's IsNullOrWhiteSpace
        /// </summary>
        public static bool IsNullOrWhiteSpace(this String value)
        {
            if (value == null) 
                return true;

            return string.IsNullOrEmpty(value.Trim());
        }
    }
}
