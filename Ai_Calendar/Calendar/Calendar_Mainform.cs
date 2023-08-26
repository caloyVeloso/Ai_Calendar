using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_Calendar.Calendar
{
    public partial class Calendar_Mainform : UserControl
    {
        public Calendar_Mainform()
        {
            InitializeComponent();

            DisplayDate();
        }

        private void DisplayDate()
        {
            Calendar_Flowpanel.Controls.Clear();

            for (int i = 0; i < 42; i++)
            {
                Day_UserControl day = new Day_UserControl();
                day.setDate(i);

                Calendar_Flowpanel.Controls.Add(day);
            }
        }
    }
}
