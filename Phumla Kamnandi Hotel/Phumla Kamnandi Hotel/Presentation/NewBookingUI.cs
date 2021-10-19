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
    public partial class NewBookingUI : Form
    {
        BookingController bookingController;
        public NewBookingUI(BookingController BC)
        {
            InitializeComponent();
            bookingController = BC;
        }

        private void NewBookingUI_Load(object sender, EventArgs e)
        {

        }
    }
}
