using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San.Utils
{
        public class Utility
        {
            /**
             * Format: yyyy-MM-dd HH:mm:ss
             */
            public static DateTime ConvertStringToDateTime(String str)
            {
                DateTime outputDateTimeValue;
                if (DateTime.TryParseExact(str, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out outputDateTimeValue))
                {
                    return outputDateTimeValue;
                }
                return new DateTime();
            }

            /**
             * Format: yyyy-MM-dd HH:mm:ss
             */
            public static string ConvertDateTimeToString(DateTime dateTime)
            {
                return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
}
