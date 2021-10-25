
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
            //childForm.Text = "Window " + childFormNumber++;
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

        #region ToolstripMenu Items 
        private void addBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewBookingUI newBookingUI = new NewBookingUI(bookingController);
            this.Hide();

            if (newBookingUI.ShowDialog() == DialogResult.OK)
            {
                newBookingUI.Close();
                this.Show();
            }
            

        }


        private void updateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingListingForm bookingListingForm = new BookingListingForm(bookingController);
            this.Hide();

            //Checks if dialog response is OK in bookingListingForm form and closes that form if it is
            if (bookingListingForm.ShowDialog() == DialogResult.OK)
            {
                bookingListingForm.Close();
                this.Show();
            }
        }


        private void newCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NewCustomersForm newCustomersForm = new NewCustomersForm(bookingController);
            this.Hide();

            //Checks if dialog response is OK in newCustomersForm form and closes that form if it is
            if (newCustomersForm.ShowDialog() == DialogResult.OK)
            {
                newCustomersForm.Close();
                this.Show();
            }
            
        }

        private void occupancyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OccupancyReport occupancyReport = new OccupancyReport(bookingController);
            this.Hide();

            //Checks if dialog response is OK in occupancyReport form and closes that form if it is
            if (occupancyReport.ShowDialog() == DialogResult.OK)
            {
                occupancyReport.Close();
                this.Show();
            }
        }

        private void customerRecordsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListingForm newCustomerListForm = new CustomerListingForm(bookingController);
            this.Hide();

            //Checks if dialog response is OK in newCustomerListForm form and closes that form if it is
            if (newCustomerListForm.ShowDialog() == DialogResult.OK)
            {
                newCustomerListForm.Close();
                this.Show();
            }
        }


        #endregion




    }

}



