using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadApp
{
    public partial class Play: Form
    {
        #region 전역변수
        // delegate 선언 / 대리자로 스레드 권한을 이어 받을 때 사용
        public delegate int delMessage(object sender, string strResult);
        public event delMessage eventDelMsg;

        string sPlayerName = string.Empty; 
        public string SPlayerName { get => sPlayerName; set  => sPlayerName = value ; }
        //public string SPlayerName
        //{
        //    get { return sPlayerName; }
        //    set { sPlayerName = value; }
        //}

        Thread thread = null;

        bool bThreadStop = false; // Thread Stop을 위한 Flag

        #endregion

        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPName)
        {
            InitializeComponent();

            lbl_name.Text = SPlayerName = strPName;
        }

        #region 메서드(함수)
        // void 메서드명() / 반환없고 매개변수 없는 메서드
        public void ThreadStart()
        {
            // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김
            thread = new Thread(Run);
            thread.Start();
        }


        private void Run()
        {
            // UI Control이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Cross Thread가 발생
            try
            {
                int iVar = 0; // 랜덤으로 만들어진 수를 담는 변수
                Random rd = new Random(); // 랜덤으로 난수를 만들어줄 객체

                while (pgb_player.Value < 100 && !bThreadStop)
                { //  프로그레스 값이 100보다 작고 스레드 플레그가 참일때
                    if (this.InvokeRequired)
                    { // 요청한 Thread가 현재 Main Thread가 있는 Control을 액세스 할 수 있는지 확인

                        // this.Invoke(new Action(delegate() {} ));
                        this.Invoke(new Action(delegate ()
                        {
                            iVar = rd.Next(1, 11); // 랜덤으로 수를 받아옴
                            if (pgb_player.Value + iVar > 100) // 현재 프로그레스바 숫자 + 받아온 숫자가 100보다 크면
                            {
                                pgb_player.Value = 100;
                            }
                            else
                            {
                                pgb_player.Value = pgb_player.Value + iVar;
                            }

                            lbl_process.Text = $"진행 상황 표시 : {pgb_player.Value}";

                            this.Refresh();
                        }));

                        Thread.Sleep(300);
                    }
                }

                if (bThreadStop) // 스레드가 멈췄을 때 
                {
                    eventDelMsg(this, "중도 포기...(Thread Stop)");
                }
                else
                {
                    eventDelMsg(this, "완주!! (Thread Complete)");
                }
            }

            catch  (ThreadInterruptedException exInterrupt)
            {
                exInterrupt.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void ThreadAbort()
        {
            if (thread.IsAlive)
            {
                thread.Abort(); // 강제 종료
            }
        }

        public void ThreadJoin()
        {
            if (thread.IsAlive)
            {
                bool bThreadEnd = thread.Join(3000); // 3초간 스레드 호출 차단
            }
        }
        #endregion

        #region 이벤트
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                bThreadStop = true;
            }
        }
        #endregion

    }
}
