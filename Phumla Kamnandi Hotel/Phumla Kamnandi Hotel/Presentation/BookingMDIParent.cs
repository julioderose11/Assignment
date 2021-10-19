
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Business;
using Phumla_Kamnandi_Hotel.Presentation;


namespace Phumla_Kamnandi_Hotel
{
    public partial class BookingMDIParent : Form
    {
        #region Variable declaration
        private int childFormNumber = 0;
        ExistingCustomersForm ecusForm;
        NewCustomersForm cusForm;
        bookingListingForm bookLForm;
        CustomerListingForm cusLForm;
        NewBookingUI NBUI;
        BookingController bookingController;
        #endregion

        #region Constructor
        public BookingMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            bookingController = new BookingController();
        }
        #endregion 

        #region ToolstripMenus
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region ToolstripMenus Bookings
        private void BookingMDIParent_Load(object sender, EventArgs e)
        {

        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking newBook = new Booking();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Create New Child Form

        private void CreateNewCustomerFsorm()
        {
            cusForm = new NewCustomersForm(bookingController);
            cusForm.MdiParent = this;
            cusForm.StartPosition = FormStartPosition.CenterParent;
        }
        private void CreateNewBookingUIForm()
        {
            NBUI = new NewBookingUI(bookingController);
            NBUI.MdiParent = this;
            NBUI.StartPosition = FormStartPosition.CenterParent;
        }

         
        private void CreateBookingListingForm()
        {
            bookLForm = new bookingListingForm(bookingController);
            bookLForm.MdiParent = this;
            bookLForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateCustomerListingForm()
        {
            cusLForm = new CustomerListingForm(bookingController);
            cusLForm.MdiParent = this;
            cusLForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateExistingCustomerForm()
        {
            ecusForm = new ExistingCustomersForm(bookingController);
            ecusForm.MdiParent = this;
            ecusForm.StartPosition = FormStartPosition.CenterParent;
        }
        #endregion
    }





}



