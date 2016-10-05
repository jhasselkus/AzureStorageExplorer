using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageExplorer.Helpers
{
    public static class StringExtensions
    {
        /// <summary>
        /// Truncate a string to being no longer than a maximum length.
        /// </summary>
        /// <param name="str">The string this is called on.</param>
        /// <param name="maxLength">The maximum length of the string.</param>
        /// <returns>The truncated string.</returns>
        /// <remarks>If str is null, null is returned.</remarks>
        public static string Truncate(this string str, int maxLength, bool ellipses = false)
        {
            return str != null && str.Length > maxLength ? str.Substring(0, maxLength) + (ellipses ? "..." : "") : str;
        }
    }
}
