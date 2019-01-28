using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treetest
{
   public static  class validateClass
    {
        //test if text box is not empty(required)
        public static bool isProvided(TextBox tb, String name)
        {
            bool result = true; //innocent until proven guilty

           

            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show(name + " is required","data entry error");
                tb.Focus();
            }

            return result;
        }
        //test if input is a non negative integer
        public static bool isNonNegativeInt(TextBox tb, String name)
        {
            bool result = true;
            int num; //parsed number
            if(!Int32.TryParse(tb.Text,out num))
            {
                result = false;
                MessageBox.Show(name + " has to be non-negative integer", "Data entry error");
                tb.Focus();
                tb.SelectAll();
            }
            else         //an int but non negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name, " has to be positive int");
                }    
            }
            {

            }
            return result;
        }





        public static bool isNonNegativeDoub(TextBox tb, String name)
        {
            bool result = true;
            double num; //parsed number
            if (!Double.TryParse(tb.Text, out num))
            {
                result = false;
                MessageBox.Show(name + " or has to be a positive whole number", "Data entry error");
                tb.Focus();
                tb.SelectAll();
            }
            else         //an int but non negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name, "  needs to be positive or zero");
                }
            }
            {

            }
            return result;
        }

        public static bool validateDate(DateTime sDate,DateTime eDate)
        {
            bool result = false;
            DateTime strtDate;
            DateTime endDate;
            strtDate =Convert.ToDateTime(sDate);
            endDate =Convert.ToDateTime(eDate);
            if (strtDate < endDate)
            {
                result = true;
            }
            else
            {
                MessageBox.Show("Invalied Date");
                result = false;
            }
            return result;
        }
    
    }
}
