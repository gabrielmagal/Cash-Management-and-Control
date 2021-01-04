using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Docs_Buger;

namespace Docs_Haus
{
    public partial class newLogin : UserControl
    {
        public String varLogin = "";
        public String varSenha = "";

        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();

        public newLogin()
        {
            InitializeComponent();

            //
            // Insert New Table Sales_DB
            //
            DataBaseConfig.createDataBase("Sales", "Sales_DB", "PRODUCT VARCHAR(50) UNIQUE NOT NULL," +
                                        "QUANT_PRODUCT INT NOT NULL," +
                                        "VALUE_COST_PRODUCT FLOAT NOT NULL," +
                                        "VALUE_FINAL_PRODUCT FLOAT NOT NULL," +
                                        "CODIGO_PRODUCT VARCHAR(50) UNIQUE NOT NULL," +
                                        "DISCOUNT INT NOT NULL");

            //
            // Insert New Table Client_DB
            //
            DataBaseConfig.createDataBase("Sales", "Client_DB", "NOME_CLIENT VARCHAR(50)," +
                                        "EMAIL_CLIENT VARCHAR(50) UNIQUE," +
                                        "PHONE1_CLIENT VARCHAR(13) UNIQUE," +
                                        "PHONE2_CLIENT VARCHAR(13)," +
                                        "BAIRRO_CLIENT VARCHAR(30)," +
                                        "CEP_CLIENT VARCHAR(8)," +
                                        "NUMBER_CLIENT INT," +
                                        "REFERENCE_CLIENT VARCHAR(50)");


            //
            // Insert New Table Sales_Resume
            //
            DataBaseConfig.createDataBase("Sales", "Sales_Resume", "DATE_SALE_COMPLETED VARCHAR(20) UNIQUE NOT NULL," +
                                        "DATE_SALE_DAY VARCHAR(10) NOT NULL," +
                                        "DATE_SALE_MONTH VARCHAR(10) NOT NULL," +
                                        "DATE_SALE_YEAR VARCHAR(10) NOT NULL," +
                                        "PROFITS FLOAT NOT NULL");
            
            //
            // Insert New Table Sales_Historic
            //
            DataBaseConfig.createDataBase("Sales", "Sales_Historic", "DATE_SALE_COMPLETED VARCHAR(30) NOT NULL,  VALUE_AMOUNT FLOAT NOT NULL, " +
                                          "VALUE_PROFIT FLOAT NOT NULL");



            //
            // Insert New Financial_Month_Spend_DB
            //
            DataBaseConfig.createDataBase("Sales", "Financial_Month_Spend_DB", "PRODUCT VARCHAR(50) UNIQUE NOT NULL," + "QUANT_PRODUCT INT NOT NULL," +
                                          "PAY_PRODUCT VARCHAR(20) NOT NULL," + "VALUE_PRODUCT FLOAT NOT NULL," + "DATE_PRODUCT  VARCHAR(10) NOT NULL");

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if ((txb_User.Text == "AlefAdmin" && txb_Pass.Text == "123") ||
               (txb_User.Text == "FelipeLegado" && txb_Pass.Text == "123") ||
               (txb_User.Text == "GabrielAlmeida" && txb_Pass.Text == "123"))
            {
                varLogin = txb_User.Text;
                varSenha = txb_Pass.Text;
                MetroFramework.MetroMessageBox.Show(this,
                    "Seja bem vindo(a) " + txb_User.Text + ", sistema disponível para uso!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                                   "Usuário e/ou senha inseridos incorretamente!",
                                   "Info",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
    }
}
