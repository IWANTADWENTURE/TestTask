using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace TestTask
{
    public partial class ChartForm : Form
    {
        private XDocument xdoc;
        private Series series;
        private Dictionary<int, DateTime> dictionaryData;
        private CultureInfo culture;
        private DateTimeStyles styles;

        public ChartForm()
        {
            InitializeComponent();
            dateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpenFileDialog OpenDialog = new OpenFileDialog();
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                xdoc = XDocument.Load(OpenDialog.FileName);
                GetDataFromFile();
            }
            else
            {
                MessageBox.Show("You not choose file!");
                Application.Exit();
            }
        }

            private void ChartForm_Load(object sender, EventArgs e)
            {
            }

        private void GetDataFromFile()
        {
            float sumValueCancer;
            int numOfValue, index = 0;
            dictionaryData = new Dictionary<int, DateTime>();
            series = new Series("CancerSize", xdoc.Element("task").Element("groups").Element("group").Element("sessions").Elements("session").Count());
            series.ChartType = SeriesChartType.Line;
            DateTime dt = new DateTime();
            culture = CultureInfo.CreateSpecificCulture("en-US");
            styles = DateTimeStyles.None;
            foreach (XElement sessionElem in xdoc.Element("task").Element("groups").Element("group").Element("sessions").Elements("session"))
            {
                numOfValue = 0;
                sumValueCancer = 0.0f;
                foreach (XElement animalElem in sessionElem.Element("animals").Elements("animal"))
                {
                    sumValueCancer += float.Parse(
                        animalElem.Element("data").Element("datum").Element("customvalues").Element("customvalue").Element("value").Value,
                        CultureInfo.InvariantCulture.NumberFormat);
                    numOfValue++;
                }
                dt = DateTime.Parse(sessionElem.Element("sessiondate").Value, culture, styles);
                series.Points.AddXY(dt, sumValueCancer / numOfValue);
                index++;
                dictionaryData.Add(index, dt);
            }
            LoadDataToChart();
        }

        private void LoadDataToChart()
        {
            CancerChart.Series.Clear();
            CancerChart.ChartAreas.Clear();
            dateComboBox.Items.Clear();
            CancerChart.Series.Add(series);
            CancerChart.ChartAreas.Add(series.ChartArea);
            CancerChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            CancerChart.ChartAreas[0].Area3DStyle.Rotation = 30;
            foreach (DateTime str in dictionaryData.Values) {
                dateComboBox.Items.Add(str);
            }
            dateComboBox.Update();
        }        

        private void CancerChart_Click(object sender, EventArgs e)
        {

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            GetDataFromFile();
        }

        private void delPointButt_Click(object sender, EventArgs e)
        {
            if (dateComboBox.SelectedItem != null)
            {
                foreach (DataPoint point in CancerChart.Series[0].Points)
                {
                    if(point.XValue== DateTime.Parse(dateComboBox.SelectedItem.ToString()).ToOADate())
                    {
                        CancerChart.Series[0].Points.Remove(point);
                        dateComboBox.Items.Remove(dateComboBox.SelectedItem);
                        break;
                    }
                }
            }
            CancerChart.Update();
            dateComboBox.Update();
        }
    }
}
