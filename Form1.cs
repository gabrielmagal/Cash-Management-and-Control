using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace Docs_Haus
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();

        private IconButton currentBtn;
        private Panel leftBorderBtn;



        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
            ActiveButton(btn_newLogin);
            newLogin1.BringToFront();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(240, 41, 88);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(23, 21, 32);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border button
                leftBorderBtn.BackColor = Color.FromArgb(240, 41, 88);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //iconCurrent
                iconIndex.Text = currentBtn.Text;
            }
        }

        private void btn_newSale_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            newSales1.BringToFront();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            if ((newLogin1.varLogin == "AlefAdmin" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "FelipeLegado" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "GabrielAlmeida" && newLogin1.varSenha == "jane22472650"))
            {
                ActiveButton(sender);
                newProducts1.BringToFront();
            }
        }

        private void btn_saleCash_Click(object sender, EventArgs e)
        {
            if ((newLogin1.varLogin == "AlefAdmin" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "FelipeLegado" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "GabrielAlmeida" && newLogin1.varSenha == "jane22472650"))
            {
                ActiveButton(sender);
                newCash1.BringToFront();
            }
        }

        private void btn_notifications_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            newUpdates1.BringToFront();
        }

        private void btn_configs_Click(object sender, EventArgs e)
        {
            if ((newLogin1.varLogin == "AlefAdmin" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "FelipeLegado" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "GabrielAlmeida" && newLogin1.varSenha == "jane22472650"))
            {
                ActiveButton(sender);
                newConfigs1.BringToFront();
            }
        }

        private void btn_newLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_newLogin);
            newLogin1.BringToFront();
        }

        private void btn_registerClient_Click(object sender, EventArgs e)
        {
            if ((newLogin1.varLogin == "AlefAdmin" && newLogin1.varSenha == "123") ||
                 (newLogin1.varLogin == "FelipeLegado" && newLogin1.varSenha == "123") ||
                 (newLogin1.varLogin == "GabrielAlmeida" && newLogin1.varSenha == "jane22472650"))
            {
                ActiveButton(btn_registerClient);
                newRegisterClient1.BringToFront();
            }
        }

        private void btn_financial_Click(object sender, EventArgs e)
        {
            if ((newLogin1.varLogin == "AlefAdmin" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "FelipeLegado" && newLogin1.varSenha == "123") ||
                (newLogin1.varLogin == "GabrielAlmeida" && newLogin1.varSenha == "jane22472650"))
            {
                ActiveButton(btn_financial);
                newFinancial1.BringToFront();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void mouseClickFree (MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickFree(e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickFree(e);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickFree(e);
        }

        private void iconIndex_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickFree(e);
        }

        private void iconButton1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClickFree(e);
        }

        private void tCheckChange_Tick(object sender, EventArgs e)
        {
            
            if(newProducts1.bChangeDB || newSales1.bChangeDB || newRegisterClient1.bChangeDB || newFinancial1.bChangeDB)
            {
                newProducts1.updateData();
                newSales1.updateData();
                newRegisterClient1.updateData();
                newFinancial1.updateData();
                newProducts1.bChangeDB = false;
                newSales1.bChangeDB = false;
                newRegisterClient1.bChangeDB = false;
                newFinancial1.bChangeDB = false;
            }
        }   
    }
}
