using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_3.Classes;
using System.IO;
using System.Reflection;

namespace Proiect_3
{
    public partial class MainForm : Form
    {
        List<RawHouseData> rawHouseDatas = new List<RawHouseData>();

        List<NormHouseData> training_normData = new List<NormHouseData>();
        List<NormHouseData> testing_normData = new List<NormHouseData>();

        public MainForm()
        {
            InitializeComponent();
        }

        //TODO: 
        public Task GetDataFromCSV()
        {
            lblStatus.Text = "Status: LOADING...";
            lblStatus.Visible = true;

            using (var reader = new StreamReader(@"D:\Facultate\Inteligenta Artificiala\Proiecte\Proiect_3\Assets\train_updated_program.csv"))
            {
                PropertyInfo[] propertyInfo = typeof(RawHouseData).GetProperties();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\u002C'); // \u002C = ,

                    RawHouseData temp_rawHouseData = new RawHouseData();

                    int i = 0;
                    foreach (var item in propertyInfo)
                    {
                        item.SetValue(temp_rawHouseData, values[i]);
                        i++;
                    }

                    rawHouseDatas.Add(temp_rawHouseData);
                }
            }

            return Task.CompletedTask;
        }

        private async void btnReadCSV_Click(object sender, EventArgs e)
        {
            await GetDataFromCSV();

            dgv.DataSource = rawHouseDatas;
            dgv.Visible = true;
            lblStatus.Visible = false;

            btnNormalize.Enabled = true;
            btnReadCSV.Enabled = false;
        }

        private void splitData(List<NormHouseData> data)
        {
            Random random = new Random();

            foreach (NormHouseData item in data)
            {
                int generatedNumber = random.Next(1, 100);

                if (generatedNumber <= 70)
                {
                    training_normData.Add(item);
                }
                else
                {
                    testing_normData.Add(item);
                }
            }
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker();

            //Converting
            List<NormHouseData> normHouseData = worker.ConvertRawData(rawHouseDatas);

            //Normalizing
            normHouseData = worker.NormalizeData(normHouseData);

            splitData(normHouseData);

            dgv.DataSource = normHouseData;
            btnNormalize.Enabled = false;
            btnTestingData.Enabled = true;
            btnTrainingData.Enabled = true;
        }

        private void btnTrainingData_Click(object sender, EventArgs e)
        {
            dgv.DataSource = training_normData;
        }

        private void btnTestingData_Click(object sender, EventArgs e)
        {
            dgv.DataSource = testing_normData;
        }
    }
}
