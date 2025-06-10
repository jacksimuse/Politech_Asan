using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIFX_50RE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace 양솔2_편솔1_수동자동제어
{
    public partial class Form1 : Form

    {
        int A = 0; //전역변수 선언
        int Auto = 0;
        int Count = 0;
        bool Autostop = false;

        byte[] Writedata = new byte[8];
        byte[] Readdata = new byte[34];


        private string ReadDataConv = "00000000";
        private string WriteDataConv = "00000000";

        List<(int a, int b, int c)> cylinderStates = new List<(int, int, int)>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            uint connect = CIFX.DriveConnect();

            if (connect != 0)
            {
                button1.Text = "OK";
                button1.ForeColor = Color.Blue;
                timer1.Interval = 300;
                timer1.Start();

            }
            else
            {
                button1.Text = "NG";
                button1.ForeColor = Color.DarkRed;
            }

        }

        private void timer1_Tick(object sender, EventArgs e) // 통신 연결 상태 확인, 자동 운전 횟수
        {
            if (button1.Text == "OK")
            {
                Readdata = CIFX.xChannelRead();
                ReadDataConv = Convert.ToString(Readdata[18], 2).PadLeft(8, '0');
                label4.Text = ReadDataConv;
                WriteDataConv = Convert.ToString(Writedata[0], 2).PadLeft(8, '0');
                label6.Text = WriteDataConv;
                cylinderStates.Add((
                    ReadDataConv[7] == '1' ? 1 : 0,
                    ReadDataConv[5] == '1' ? 1 : 0,
                    ReadDataConv[3] == '1' ? 1 : 0
                ));
            }
            int Counting = Convert.ToInt32(numericUpDown1.Value);
            label15.Text = Count.ToString(); //동작 횟수 숫자

            // 실시간 CSV 저장 및 DataGridView 갱신
            CreateCsv();
            SaveCsv();

        }

        private void SaveCsv()
        {
            string filePath = "cylinder_states.csv";
            if (!File.Exists(filePath)) return;
            var dt = new DataTable();
            using (var sr = new StreamReader(filePath, Encoding.UTF8))
            {
                bool isHeader = true;
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(',');
                    if (isHeader)
                    {
                        foreach (var header in values)
                            dt.Columns.Add(header);
                        isHeader = false;
                    }
                    else
                    {
                        dt.Rows.Add(values);
                    }
                }
            }
            CSVRead csvForm = new CSVRead();
            csvForm.dataGridView1.DataSource = dt;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //ReadDataConv = "10011010";
            Readdata = CIFX.xChannelRead();
            string ReadDataConv = Convert.ToString(Readdata[18], 2).PadLeft(8, '0');  // 최신 데이터
           
            int counting = Convert.ToInt32(numericUpDown1.Value);

            if (cylinderStates.Count >= 8)
            {
                cylinderStates.Clear();
            }
            cylinderStates.Add((
                    ReadDataConv[7] == '1' ? 0 : 1,
                    ReadDataConv[5] == '1' ? 0 : 1,
                    ReadDataConv[3] == '1' ? 0 : 1
                ));

            CreateCsv();
            SaveCsv();

            if (A == 1 || (A == 2 && Count < counting) || (A == 3 && Autostop == true))
            {
                switch (Auto)
                {
                    case 0: //  a, c 전진 

                        if (ReadDataConv[7] == '1' && ReadDataConv[5] == '1' && ReadDataConv[3] == '1')
                        {
                            Writedata[0] |= 0x11; //11  a,c 켜기 |=
                            Writedata[0] &= unchecked((byte)~0x22); // &=
                            CIFX.xChannelWrite(Writedata);
                            if (A != 3) Auto++;
                            Autostop = false;
                        }
                        break;

                    case 1: // c (후진)
                        if (ReadDataConv[7] == '0' && ReadDataConv[5] == '1' && ReadDataConv[3] == '0') // 실린더 3 후진 조건
                        {
                            Writedata[0] |= 0x20; // 3번 실린더 후진 값
                            Writedata[0] &= unchecked((byte)~0x10);
                            CIFX.xChannelWrite(Writedata); // 데이터 전송
                            Auto++; // 상태 증가
                        }
                        break;
                    case 2:
                        // a 후진 완료 후 b,c 전진
                        if (ReadDataConv[7] == '0' && ReadDataConv[5] == '1' && ReadDataConv[3] == '1')
                        {
                            Writedata[0] |= 0x16; // 2+4+10=16
                            Writedata[0] &= unchecked((byte)~0x29); // 1 8 20
                            CIFX.xChannelWrite(Writedata);
                            if (A != 3) Auto++;
                            Autostop = false;
                        }
                        break;

                    case 3:
                        //  c 후진
                        if (ReadDataConv[7] == '1' && ReadDataConv[5] == '0' && ReadDataConv[3] == '0')
                        {

                            Writedata[0] |= 0x20;
                            Writedata[0] &= unchecked((byte)~0x10);
                            CIFX.xChannelWrite(Writedata);
                            if (A != 3) Auto++;
                            Autostop = false;
                        }
                        break;

                    case 4:
                        //  b 후진 완료 후 a, c 전진
                        if (ReadDataConv[7] == '1' && ReadDataConv[5] == '0' && ReadDataConv[3] == '1')
                        {

                            Writedata[0] |= 0x19; // 1  8 10
                            Writedata[0] &= unchecked((byte)~0x26); // 2 4 20
                            CIFX.xChannelWrite(Writedata);
                            if (A != 3) Auto++;
                            Autostop = false;
                        }
                        break;

                    case 5:
                        // 
                        if (ReadDataConv[7] == '0' && ReadDataConv[5] == '1' && ReadDataConv[3] == '0') //c후진
                        {

                            Writedata[0] |= 0x22; // a 후진값과 c 후진값만 넣어봄  // 2  20
                            Writedata[0] &= unchecked((byte)~0x11); // 1 10
                            CIFX.xChannelWrite(Writedata);
                            if (A != 3) Auto++;
                            Autostop = false;
                            stepcount = 0; //실질적으로 동작은 여기서 끝났으므로 여기서 0을 줌
                        }
                        break;

                    case 6:

                        if (A != 3/*ReadDataConv[7] == '1' && ReadDataConv[5] == '1' && ReadDataConv[3] == '1'*/)
                        {
                            Count++;
                            Auto = 0;
                        }
                        break;
                }
                if (A == 2 && Count >= counting) //자동운전(횟수지정) 멈추게
                {
                    timer2.Stop(); // 타이머 중지
                    button2.BackColor = Color.LightGreen;
                    button2.Text = "운전 완료";
                    A = 0; // 모드 초기화
                }
            }
        }
        private void button1_Click(object sender, EventArgs e) //통신 연결 상태 확인 버튼
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //실린더 A 수동 전진7
        {
            if (ReadDataConv[7] == '1')
            {
                Writedata[0] |= 0x01;
                Writedata[0] &= unchecked((byte)~0x02);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //실린더 A 수동 후진6
        {
            if (ReadDataConv[6] == '1')
            {
                Writedata[0] |= 0x02;
                Writedata[0] &= unchecked((byte)~0x01);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //실린더 B 수동 전진5
        {
            if (ReadDataConv[5] == '1')
            {
                Writedata[0] |= 0x04;
                Writedata[0] &= unchecked((byte)~0x08);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //실린더 B 수동 후진4
        {
            if (ReadDataConv[4] == '1')
            {
                Writedata[0] |= 0x08;
                Writedata[0] &= unchecked((byte)~0x04);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //실린더 C 수동 전진
        {
            if (ReadDataConv[3] == '1')
            {
                Writedata[0] |= 0x10;
                Writedata[0] &= unchecked((byte)~0x20);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) //실린더 C 수동 후진
        {
            if (ReadDataConv[2] == '1')
            {
                Writedata[0] |= 0x20;
                Writedata[0] &= unchecked((byte)~0x10);
                CIFX.xChannelWrite(Writedata);
                button2.Text = "수동 운전 상태";
            }

        }

        private void button3_Click(object sender, EventArgs e) //자동 운전
        {
            timer2.Interval = 500;
            timer2.Start();
            Auto = 0;
            A = 1; //
            Count = 0;
            button2.BackColor = Color.LightPink;
            button2.Text = "자동 운전 상태";
        }

        private void button4_Click(object sender, EventArgs e) ////자동 운전(횟수 지정)
        {
            timer2.Start();
            timer2.Interval = 500;
            Count = (int)numericUpDown1.Value;
            A = 2; // = mode = 2; count = 0;
            Auto = 0;
            Count = 0;
            button2.BackColor = Color.LightPink;
            button2.Text = "자동 운전 상태";
        }

        private void button5_Click(object sender, EventArgs e) //운전 정지
        {
            button2.BackColor = Color.LightCoral;
            button2.Text = "운전 정지";
            timer2.Stop();
            Auto = 0;
        }

        private void button6_Click(object sender, EventArgs e) //초기화
        {
            timer2.Stop();
            Auto = 0;
            Writedata[0] = (byte)0x0a;
            CIFX.xChannelWrite(Writedata);
        }

        private int stepcount = 0; //STEP
        private void button7_Click(object sender, EventArgs e) //STEP
        {
            timer2.Interval = 500;
            timer2.Start();
            button2.Text = "step";
            A = 3;
            Count = 0;

            Autostop = true;
            Auto = stepcount;
            stepcount++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var graphForm = new FormGraph(cylinderStates);
            graphForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CreateCsv();

            ShowCsvData();
        }

        private void ShowCsvData()
        {
            string filePath = "cylinder_states.csv"; // CSV 파일 경로
            DataTable csvData = ReadCsvFile(filePath);

            // 새 폼 생성
            CSVRead csvForm = new CSVRead();
            csvForm.dataGridView1.DataSource = csvData;
            csvForm.Show();
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
        

        private void CreateCsv()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A,B,C");
            int countToSave = Count > 0 && Count < cylinderStates.Count ? Count : cylinderStates.Count;
            var statesToSave = cylinderStates.Skip(cylinderStates.Count - countToSave).Take(countToSave);
            foreach (var state in statesToSave)
            {
                string a = state.a == 1 ? "후진" : "전진";
                string b = state.b == 1 ? "후진" : "전진";
                string c = state.c == 1 ? "후진" : "전진";
                sb.AppendLine($"{a},{b},{c}");
            }
            string filePath = "cylinder_states.csv";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            else
            {
                if (IsFileLocked(filePath))
                {
                    DialogResult result = MessageBox.Show("파일이 실행중입니다. 창을 닫아주세요", "창 닫기", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        CreateCsv();
                    }
                }
                else
                {
                    File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                }
            }
        }

        private bool IsFileLocked(string path)
        {
            try
            {
                using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false; // 파일 열 수 있음
                }
            }
            catch (IOException)
            {
                return true; // 파일이 열려 있어서 잠김
            }
        }
    }
}
