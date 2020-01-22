using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace arjasb_mobile
{
    class PersianDate
    {
       

        public static string GetPersianDate()
        {
             PersianCalendar pcalender = new PersianCalendar();

            string d = pcalender.GetDayOfMonth(DateTime.Now).ToString();
            string m = pcalender.GetMonth(DateTime.Now).ToString();
            string y = pcalender.GetYear(DateTime.Now).ToString();

            return y + "/" + m + "/" + d;
        }
       

    }
}
