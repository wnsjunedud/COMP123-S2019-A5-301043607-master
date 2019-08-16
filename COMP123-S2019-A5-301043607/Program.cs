using COMP123_S2019_A5_301043607.Models;
using COMP123_S2019_A5_301043607.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name : Juneyeong Lee
 * Student Id : 301043697
 * Description : This is Program Class
 */

namespace COMP123_S2019_A5_301043607
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        //public static AboutForm aboutForm;

        //public static Product product;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            //product = new Product();

            Application.Run(orderForm);
        }
    }
}
