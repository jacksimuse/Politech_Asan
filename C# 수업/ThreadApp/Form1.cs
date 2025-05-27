using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadApp
{
    public partial class Form1: Form
    {
        #region 전역변수
        private enum Player
        {
            루피,
            조로,
            상디,
            나미,
            우솝
        }

        int locationX = 0;
        int locationY = 0;

        List<Play> lPlay = new List<Play>(); // [play1, play2, play3, play4]
        // List<int> lInt = new List<int>(); // lInt.Add(1);   -> [1,2,3,4,5,6]
        #endregion

        public Form1()
        {
            InitializeComponent();

            locationX = this.Location.X;
            locationY = this.Location.Y;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Play py in lPlay) 
            {
                py.ThreadAbort(); // 리스트 안에 있는 객체가 가지고 있는 스레드를 강제 종료
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (lPlay.Count > 0)
            {
                foreach (Play py in lPlay)
                {
                    py.ThreadAbort(); // 리스트 안에 있는 객체가 가지고 있는 스레드를 강제 종료
                    py.Close();
                }
            }
        
            // Form1의 x값과 사이즈를 locationX값에 넣어줌 -> 용도는 Form1 바로 옆에 Play 창을 띄우기 위함
            locationX = this.Location.X + this.Size.Width;
            // Form1의 y값을 locationY에 넣어줌 -> 용도는 Play창을 연속적으로 보이기 위함
            locationY = this.Location.Y;

            for (int i = 0; i < nud_player.Value;i++) //
            {
                Play py = new Play(((Player)i).ToString());
                py.Location = new Point(locationX, locationY + py.Height * i);
                py.eventDelMsg += Py_eventDelMsg; // Play.cs에 있는 event를 Form1에서 제어하기 위함

                py.Show(); // 창을 띄움
                py.ThreadStart(); // 객체의 스레드를 시작함
                lPlay.Add(py); // Play 객체 리스트에 새로만든 객체를 추가
            }
        }

        private int Py_eventDelMsg(object sender, string strResult)
        {
            if (this.InvokeRequired)
            {// 요청한 Thread가 현재 Main Thread에 있는 Control을 액세스 할 수 있는지 확인
                this.Invoke(new Action(delegate ()
                {
                    Play py = sender as Play;
                    lb_result.Items.Add($"Player : {py.SPlayerName}, Text : {strResult}");
                }
                ));
            }

            return 0;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            foreach (Play py in lPlay)
            {
                py.ThreadAbort(); // 리스트 안에 있는 객체가 가지고 있는 스레드를 강제 종료
                py.Close();
            }
        }
    }
}
