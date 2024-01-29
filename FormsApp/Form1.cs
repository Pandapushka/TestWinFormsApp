using Dll;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateLabel()
        {
            label1.Text = "Количество готовых пользователей" + FileProvider.GlobalResultList.Count.ToString();
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Csv files(*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;

            var csvList = CsvReader.Read(filename);
            FileProvider.Result(FileProvider.GlobalXmlList, csvList, false);
            UpdateLabel();
        }

        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Xml files(*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;

            var xmlList = XmlReader.Read(filename);
            FileProvider.Result(xmlList, FileProvider.GlobalCsvList, true);
            UpdateLabel();
        }

        private void buttonFormReport_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Result " + DateTime.Now.ToString("dd.MM.yyyy");
            saveFileDialog1.Filter = "Json files(*.json)|*.json";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Stream stream;
            if ((stream = saveFileDialog1.OpenFile()) != null)
            {
                var jsonString = FileProvider.GetResult();
                var bites = Encoding.UTF8.GetBytes(jsonString);
                stream.Write(bites, 0, bites.Length);
                stream.Close();
            }
            UpdateLabel();

        }
    }
}
