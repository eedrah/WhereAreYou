using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WhereAreYou.Models {
    public class UrlPicker {
        public const string Letters = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz123456789";
        public const int UrlLength = 4;

        public static string Encode(int id) {
            int numberBase = Letters.Length;
            if (id >= (int)Math.Pow(numberBase, UrlLength)) {
                throw new OverflowException("Exhausted all URLs");
            }

            var sb = new StringBuilder();
            for (int digit = UrlLength; digit > 0; digit--) {
                int divisor = (int)Math.Pow(numberBase, digit - 1);
                int index = id / divisor;
                sb.Append(Letters[index]);
                id -= index * divisor;
            }
            return sb.ToString();
        }
    }
}