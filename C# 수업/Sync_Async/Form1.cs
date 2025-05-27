using Sync_Async.CObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sync_Async
{
    public partial class Form1: Form
    {
        #region 전역변수
        Cdoor cdoor1, cdoor2; // 문 class 객체 1,2  / 왼쪽 오른쪽으로 사용
        Crobot crobot; // 로봇 class 객체
        int irobotRotate = 0; // 로봇 회전
        int ispeed = 0; // Thread Sleep
        bool bobject = false; // 로봇이 물건을 가지고 있는지 여부
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region 함수(메서드)

        private int RobotRotate()
        {
            Log("개별 동작", "RobotRotate");

            for (int i = 0; i < 12; i++)
            {
                Thread.Sleep(ispeed);
                irobotRotate = irobotRotate + 15;
                RobotDraw(irobotRotate, 0, bobject);
            }

            if (irobotRotate > 360)
            {
                irobotRotate -= 360;
            }

            return 0;
        }

        private void RobotBack()
        {
            Log("개별 동작", "RobotBack");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                RobotDraw(irobotRotate, 5, bobject);
            }
        }

        private void RobotGo()
        {
            Log("개별 동작", "RobotGo");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                RobotDraw(irobotRotate, -5, bobject);
            }
        }

        private void RightClose()
        {
            Log("개별 동작", "RightClose");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                DoorDraw2(5);
            }
        }

        private void LeftClose()
        {
            Log("개별 동작", "LeftClose");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                DoorDraw1(5);
            }
        }

        private void RightOpen()
        {
            Log("개별 동작", "RightOpen");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                DoorDraw2(-5);
            }
        }

        private async void StartMove_async()
        {
            Log("단체 동작", "StartMove_async 시작");

            Task task;

            task = Task.Run(() => RobotGo());
            await Task.Run(() => LeftOpen());

            Thread.Sleep(500);
            bobject = true;

            await Task.Run(() => RobotBack());

            task = Task.Run(() => LeftClose());
            await Task.Run(() => async_RobotRotate());

            task = Task.Run(() => RobotGo());
            await Task.Run(() => RightOpen());

            Thread.Sleep(500);
            bobject = false;

            await Task.Run(() => RobotBack());

            task = Task.Run(() => RightClose());
            await Task.Run(() => async_RobotRotate());

            Log("단체 동작", "StartMove_async 끝");
        }

        private Task<int> async_RobotRotate()
        {
            var task = Task.Run(() => RobotRotate());
            
            return task;
        }

        /// <summary>
        /// 함수가 종료되고 다음 함수를 호출하여 순차적으로 작동하게 만듦
        /// </summary>
        private void StartMove()
        {
            Task.Run(() =>
            {
                Log("단체 동작", "StartMove 시작");

                LeftOpen();              // 1. 왼쪽문 열기
                RobotGo();              // 2. 로봇팔 뻗기
                Thread.Sleep(500);
                bobject = true;
                RobotBack();           // 3. 로봇팔 돌아오기
                LeftClose();              // 4. 왼쪽문 닫기
                RobotRotate();         // 5. 로봇 회전
                RightOpen();            // 6. 오른쪽문 열기
                RobotGo();              // 7. 로봇팔 뻗기
                Thread.Sleep(500);
                bobject = false;
                RobotBack();           // 8. 로봇팔 돌아오기
                RightClose();           // 9. 오른쪽문 닫기
                RobotRotate();         // 10. 로봇 회전

                Log("단체 동작", "StartMove 끝");
            });
        }

        private void InitDraw()
        {
            cdoor1 = cdoor2 = null; // door 클래스 초기화
            crobot = null; // robot 클래스 초기화
            irobotRotate = 0; // 회전 초기화
            ispeed = 100; // Thread Time Sleep 초기화

            cdoor1 = new Cdoor("DoorLeft"); // 생성자
            cdoor2 = new Cdoor("DoorRight");
            crobot = new Crobot("Robot");

            RobotDraw(irobotRotate, 0, false); // 로봇 그리는 함수
            DoorDraw1(0); // 왼쪽 문 그리는 함수
            DoorDraw2(0); // 오른쪽 문 그리는 함수
        }

        private void DoorDraw2(int imove)
        {
            this.Invoke(new Action(delegate ()
            {
                p_rightdoor.Refresh();
                cdoor2.DMove(imove);
                Graphics g = p_rightdoor.CreateGraphics();
                g.FillRectangle(cdoor2.BrushInfo(), cdoor2.rt_door);
                g.DrawRectangle(cdoor2.PenInfo(), cdoor2.rt_doorside);
            }
            ));
        }

        private void DoorDraw1(int imove)
        {
            this.Invoke(new Action(delegate ()
            {
                p_leftdoor.Refresh();
                cdoor1.DMove(imove);
                Graphics g = p_leftdoor.CreateGraphics();
                g.FillRectangle(cdoor1.BrushInfo(), cdoor1.rt_door);
                g.DrawRectangle(cdoor1.PenInfo(), cdoor1.rt_doorside);
            }
            ));
        }

        /// <summary>
        /// 로봇을 그리는 메서드
        /// </summary>
        /// <param name="irotate"></param>
        /// <param name="iarmMove"></param>
        /// <param name="isobject"></param>
        private void RobotDraw(int irotate, int iarmMove, bool isobject)
        {
            this.Invoke(new Action(delegate ()
            {
                p_robot.Refresh(); // 새로고침

                Graphics g = p_robot.CreateGraphics();

                g.FillEllipse(crobot.BrushInfo(), crobot.rtCircleRobot); // FillEllipse, Brush / 브러쉬로 색을 채움

                crobot.DMove(iarmMove);

                Point center = new Point(100, 100); // 좌표 값
                g.Transform = GetMatrix(center, irotate);

                g.DrawRectangle(crobot.PenInfo(), crobot.rtRobotArm); // DrawRectangle, Pen / 펜으로 네모 그림

                if (isobject) // 물건이 있으면 그리고 없으면 패스
                {
                    g.FillRectangle(crobot.BrushInfo(), crobot.rtObject);
                }
            }));
        }

        private Matrix GetMatrix(Point center, int irotate)
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(irotate, center);
            return matrix;
        }

        private void LeftOpen()
        {
            Log("개별 동작", "LeftOpen");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(ispeed);
                DoorDraw1(-5);
            }
        }

        private void Log(string stype, string slogdesc)
        {
            this.Invoke((new Action(delegate ()
            {
                DateTime dt = DateTime.Now;
                string slog = $"{dt:yyyy-MM-dd hh:mm:ss}  [{stype}]  {slogdesc}";
                lb_log.Items.Insert(0, slog);
            })));
        }

        #endregion

        #region 이벤트

        private void Form1_Load(object sender, EventArgs e)
        {
            cdoor1 = new Cdoor("DoorLeft");
            cdoor2 = new Cdoor("DoorRight");
            crobot = new Crobot("Robot");
        }

        private void txt_speed_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_speed.Text, out int iset))
            {
                ispeed = iset;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn_init":
                    InitDraw();
                    break;
                case "btn_sync":
                    StartMove();
                    break;
                case "btn_async":
                    StartMove_async();
                    break;
                case "btn_leftopen":
                    LeftOpen();
                    break;
                case "btn_rightopen":
                    RightOpen();
                    break;
                case "btn_leftclose":
                    LeftClose();
                    break;
                case "btn_rightclose":
                    RightClose();
                    break;
                case "btn_robotgo":
                    RobotGo();
                    break;
                case "btn_robotback":
                    RobotBack();
                    break;
                case "btn_robotrotate":
                    RobotRotate();
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
