using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BussinessLogic {
    public class ConvertTime {

        public int DateTimeConvertToInt(DateTime input) {
            int output = 0;
            if(DateTimeFormatInfo.CurrentInfo.AMDesignator == "") {
                output = int.Parse(input.ToString("ddMMyyyyHHmmss"));
            }
            else {
                
            }
            return output;
        }

        public DateTime IntConvertToDateTime(int input) {
            DateTime output = new DateTime();
            if(DateTimeFormatInfo.CurrentInfo.AMDesignator == "") {

            }
            else {

            }
            return output;
        }
    }
}
