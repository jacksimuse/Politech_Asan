using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIFX_50RE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace 양솔2_편솔1_수동자동제어
{
    public partial class Form1: Form

    {
        int A = 0; //전역변수 선언
        int Auto = 0;
        int Count = 0;
        bool Autostop = false;

        byte[] Writedata = new byte[8];
        byte[] Readdata = new byte[34];


        private string ReadDataConv = "00000000";
        private string WriteDataConv = "00000000";
 
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
                //string ReadDataConv = Convert.ToString(Readdata[18], 2).PadLeft(8, '0');
                ReadDataConv = Convert.ToString(Readdata[18], 2).PadLeft(8, '0');
                label4.Text = ReadDataConv;

                //string WriteDataConv = Convert.ToString(Writedata[0], 2).PadLeft(8, '0');
                WriteDataConv = Convert.ToString(Writedata[0], 2).PadLeft(8, '0');
                label6.Text = WriteDataConv;

                label8.ForeColor = (ReadDataConv[6] == '1') ? Color.Red : Color.Black; //a전진
                label7.ForeColor = (ReadDataConv[7] == '1') ? Color.GreenYellow : Color.Black; //a후진
                label10.ForeColor = (ReadDataConv[4] == '1') ? Color.Red : Color.Black; //b전진
                label9.ForeColor = (ReadDataConv[5] == '1') ? Color.GreenYellow : Color.Black; //b후진
                label12.ForeColor = (ReadDataConv[2] == '1') ? Color.Red : Color.Black; //c전진
                label11.ForeColor = (ReadDataConv[3] == '1') ? Color.GreenYellow : Color.Black; //c후진

            }
            int Counting = Convert.ToInt32(numericUpDown1.Value);
            
            label15.Text = Count.ToString(); //동작 횟수 숫자
           
        }
     
      


        private void timer2_Tick(object sender, EventArgs e)
        {
            string ReadDataConv = Convert.ToString(Readdata[18], 2).PadLeft(8, '0');  // 최신 데이터
                                                                                      //int counting = convert.toint32(numericupdown1.value)
                                                                                      //if(mode == 1 || (mode ==2 && count < counting))
                                                                                      //{
                                                                                      //
                                                                                      //}  int counting = convert.toint32(numericupdown1.value);
            int counting = Convert.ToInt32(numericUpDown1.Value);



            if (A == 1 || (A == 2 && Count < counting) || (A == 3 && Autostop    == true))  
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
                            CIFX .xChannelWrite(Writedata); // 데이터 전송
                            Auto++; // 상태 증가
                        }
                        break;
                    case 2:
                        // a 후진 완료 후 b,c 전진
                        if (ReadDataConv[7] == '0' && ReadDataConv[5] == '1' && ReadDataConv[3] == '1')
                        {
                            Writedata [0] |= 0x16; // 2+4+10=16
                            Writedata [0] &= unchecked((byte)~0x29); // 1 8 20
                            CIFX .xChannelWrite (Writedata );
                            if ( A != 3) Auto ++;
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
                            // writedata[0] &= unchecked((byte)~0x10);
                            //Writedata[0] &= unchecked((byte)~0x08); // 수정
                            //CIFX.xChannelWrite(Writedata);
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
    }

}
