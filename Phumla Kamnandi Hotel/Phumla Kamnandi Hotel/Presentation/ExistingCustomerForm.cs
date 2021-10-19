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
    public partial class CustomerForm : Form
    {
        BookingController bookingController;
        public CustomerForm(BookingController BC)
        {
            InitializeComponent();
             bookingController=BC;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
