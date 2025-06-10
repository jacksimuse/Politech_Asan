using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 양솔2_편솔1_수동자동제어
{
    public partial class CSVRead : Form
    {
        private Thread csvUpdateThread;
        private bool csvThreadRunning = false;

        public CSVRead()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "data.csv"; // CSV 파일 경로
            DataTable csvData = ReadCsvFile(filePath);

            dataGridView1.DataSource = csvData;
        }

        private DataTable ReadCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dataTable.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"CSV 파일 오류: {ex.Message}");
            }
            return dataTable;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            StartCsvUpdateThread();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCsvUpdateThread();
            base.OnFormClosing(e);
        }

        private void StartCsvUpdateThread()
        {
            if (csvUpdateThread != null && csvUpdateThread.IsAlive)
                return;

            csvThreadRunning = true;
            csvUpdateThread = new Thread(() =>
            {
                while (csvThreadRunning)
                {
                    UpdateDataGridViewFromCsv();
                    Thread.Sleep(100); // 0.1초마다 갱신
                }
            });
            csvUpdateThread.IsBackground = true;
            csvUpdateThread.Start();
        }

        private void StopCsvUpdateThread()
        {
            csvThreadRunning = false;
            if (csvUpdateThread != null && csvUpdateThread.IsAlive)
            {
                csvUpdateThread.Abort();
            }
        }

        private void UpdateDataGridViewFromCsv()
        {
            string filePath = "cylinder_states.csv";
            if (!File.Exists(filePath)) return;
            DataTable dt = ReadCsvFile(filePath);

            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = dt));
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
