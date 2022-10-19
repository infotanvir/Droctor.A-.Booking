using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dr.A.Booking
{
    public partial class Dr_A_Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar1.TodaysDate)
            {
                Label7.Text = "<br>Patient Name :" + TextBox1.Text + "<br>Age : " + TextBox2.Text + "<br>Gender :" + TextBox3.Text + "<br>Department : " + TextBox4.Text + "<br>Doctor Name : " + TextBox5.Text + "<br> Your Appointment Booked on " + Calendar1.SelectedDate.ToShortDateString();


            }
            else
                Label7.Text = "Sorry! Your appointment with Doctor \n" + TextBox5.Text + " is not available on " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox6.Text = Calendar1.SelectedDate.ToLongDateString();

        }
    }
}