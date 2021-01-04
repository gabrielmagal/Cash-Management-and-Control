using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.SqlClient;
using Docs_Buger;

namespace Docs_Haus
{
    public partial class newCash : UserControl
    {
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})",
                chartpoint.Y, chartpoint.Participation);

        DataBaseConfigs DataBaseConfig = new DataBaseConfigs();

        public newCash()
        {
            InitializeComponent();
            DataBaseConfig.insertInDataBase("Sales", "Sales_Resume",
                "DATE_SALE_COMPLETED, DATE_SALE_DAY, DATE_SALE_MONTH, DATE_SALE_YEAR, PROFITS",
                "'" + DateTime.Now.ToString("dd/MM/yyyy") +
                "', '" + DateTime.Now.Day.ToString() +
                "', '" + DateTime.Now.Month.ToString() +
                "', '" + DateTime.Now.Year.ToString() +
                "', " + 0);
            cb_Date.SelectedIndex = 0;
        }

        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            // Selected date to view
            //
            SeriesCollection series = new SeriesCollection();
            DateTime dateTime = DateTime.Today;
            SqlCommand commandUpdate;
            SqlDataReader executReader;
            DataBaseConfig.connectionDB();
            switch (cb_Date.SelectedIndex)
            {
                case 0:
                    try
                    {
                        // Case Day
                        commandUpdate = new SqlCommand("USE Sales SELECT * FROM Sales_Resume ORDER BY DATE_SALE_COMPLETED", DataBaseConfig.varCnn());
                        executReader = commandUpdate.ExecuteReader();
                        while (executReader.Read())
                        {
                            if (executReader["DATE_SALE_DAY"].ToString() == dateTime.Day.ToString())
                            {
                                series.Add(new PieSeries()
                                {
                                    Title = executReader["DATE_SALE_COMPLETED"].ToString(),
                                    Values = new ChartValues<int> { Convert.ToInt32(executReader["PROFITS"]) },
                                    DataLabels = true,
                                    LabelPoint = labelPoint
                                });
                            }
                        }
                        pieChart1.Series = series;
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    }
                    catch(SqlException)
                    {
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                        MetroFramework.MetroMessageBox.Show(this,
                       "Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                break;
                case 1:
                    // Case Month
                    try
                    {

                        commandUpdate = new SqlCommand("USE Sales SELECT * FROM Sales_Resume ORDER BY DATE_SALE_COMPLETED", DataBaseConfig.varCnn());
                        executReader = commandUpdate.ExecuteReader();
                        while (executReader.Read())
                        {
                            if (executReader["DATE_SALE_MONTH"].ToString() == dateTime.Month.ToString())
                            {
                                series.Add(new PieSeries()
                                {
                                    Title = executReader["DATE_SALE_COMPLETED"].ToString(),
                                    Values = new ChartValues<int> { Convert.ToInt32(executReader["PROFITS"]) },
                                    DataLabels = true,
                                    LabelPoint = labelPoint
                                });
                            }
                        }
                        pieChart1.Series = series;
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    }
                    catch (SqlException)
                    {
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                        MetroFramework.MetroMessageBox.Show(this,
                       "Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    // Case Year
                    try
                    {
                        commandUpdate = new SqlCommand("USE Sales SELECT * FROM Sales_Resume ORDER BY DATE_SALE_COMPLETED", DataBaseConfig.varCnn());
                        executReader = commandUpdate.ExecuteReader();
                        while (executReader.Read())
                        {
                            if (executReader["DATE_SALE_YEAR"].ToString() == dateTime.Year.ToString())
                            {
                                series.Add(new PieSeries()
                                {
                                    Title = executReader["DATE_SALE_COMPLETED"].ToString(),
                                    Values = new ChartValues<int> { Convert.ToInt32(executReader["PROFITS"]) },
                                    DataLabels = true,
                                    LabelPoint = labelPoint
                                });
                            }
                        }
                        pieChart1.Series = series;
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                    }
                    catch (SqlException)
                    {
                        if (DataBaseConfig.varCnn() != null) DataBaseConfig.varCnn().Close();
                        MetroFramework.MetroMessageBox.Show(this,
                       "Não foi possível se conectar ao Banco de Dados, contate o administrador do Sistema.",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                break;
            }
        }
    }
}
