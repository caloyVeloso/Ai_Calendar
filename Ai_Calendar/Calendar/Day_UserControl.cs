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
    public partial class Day_UserControl : UserControl
    {
        public Day_UserControl()
        {
            InitializeComponent();
        }

        public void setDate(int num)
        {
            dayNo.Text = num.ToString();
        }
    }
}
