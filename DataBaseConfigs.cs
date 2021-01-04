using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Docs_Buger
{
    public partial class DataBaseConfigs : Form
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=localhost;User ID=sa;Password=123"); // Coloque aqui seu login e senha

        public SqlConnection varCnn()
        {
            return cnn;
        }

        public void connectionDB()
        {
            try
            {
                if (cnn != null)
                {
                    varCnn().Open();
                    return;
                }
                else
                {
                    if (cnn != null) cnn.Close();
                    MetroFramework.MetroMessageBox.Show(this,
                    "Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
                MetroFramework.MetroMessageBox.Show(this,
                "Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }


        public void insertInDataBase(string DB, string varTableDB, string varParameters, string varValues)
        {
            try
            {
                connectionDB();
                String sql = "USE " + DB + " INSERT INTO " + varTableDB +
                    " (" + varParameters + ") " + " VALUES (" + varValues + ")";
                SqlDataAdapter nameDB = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql);
                nameDB.InsertCommand = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (varCnn() != null) varCnn().Close();
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
            }
            catch (Exception)
            {
                if (varCnn() != null) varCnn().Close();
            }
        }


        public void createDataBase(string DB, string varTableDB, string varParameters)
        {
            try
            {
                connectionDB();
                String sql = "USE " + DB + " CREATE TABLE " + varTableDB +
                    " (" + varParameters + ")";
                SqlDataAdapter nameDB = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql);
                nameDB.InsertCommand = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (varCnn() != null) varCnn().Close();
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
            }
            catch (Exception)
            {
                if (varCnn() != null) varCnn().Close();
            }
        }

        public void deleteDataBase(string DB, string varTableDB)
        {
            try
            {
                connectionDB();
                String sql = "USE " + DB + " DELETE FROM " + varTableDB;
                SqlDataAdapter nameDB = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql);
                nameDB.InsertCommand = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (varCnn() != null) varCnn().Close();
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
            }
            catch (Exception)
            {
                if (varCnn() != null) varCnn().Close();
            }
        }


        public void deleteDataBaseSpecificItems(string DB, string varTableDB, string varDB, string varSearch)
        {
            try
            {
                connectionDB();
                String sql = "USE " + DB + " DELETE FROM " + varTableDB + " WHERE " + varDB + " = " + varSearch;
                SqlDataAdapter nameDB = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql);
                nameDB.InsertCommand = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                if (varCnn() != null) varCnn().Close();
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
            }
            catch (Exception)
            {
                if (varCnn() != null) varCnn().Close();
            }
        }


        public String readDataBaseSpecificItems(string DB, string varTableDB, string varDB, string varSearch, string varReturn)
        {
            try
            {
                //Get Selected Item
                String sql = "USE " + DB +  " SELECT * FROM " + varTableDB + " WHERE " + varDB + " = " + varSearch;
                String returnFind = "";
                connectionDB();
                SqlDataAdapter nameDB = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand = new SqlCommand(sql, varCnn());
                nameDB.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                SqlDataReader executReader = command.ExecuteReader();
                // Read Selected Item
                while (executReader.Read())
                {
                    returnFind = executReader[varReturn].ToString();
                }
                if (varCnn() != null) varCnn().Close();
                return returnFind;
            }
            catch (SqlException)
            {
                if (varCnn() != null) varCnn().Close();
                return null;
            }
            catch (Exception)
            {
                if (varCnn() != null) varCnn().Close();
                return null;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DataBaseConfigs
            // 
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Name = "DataBaseConfigs";
            this.ResumeLayout(false);
        }
    }
}
