using Phumla_Kamnandi_Hotel.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class HomeForm : Form
    {
        BookingController bookingController;
        public HomeForm(BookingController BC)
        {
            InitializeComponent();
            bookingController = BC;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
