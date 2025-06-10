using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 양솔2_편솔1_수동자동제어
{
    public partial class FormGraph : Form
    {
        private List<(int a, int b, int c)> states;
        private Thread updateThread;
        private bool running = true;

        public FormGraph(List<(int a, int b, int c)> states)
        {
            InitializeComponent();
            this.states = states;
            this.DoubleBuffered = true;

            // 실시간 갱신용 스레드 시작
            updateThread = new Thread(UpdateLoop);
            updateThread.IsBackground = true;
            updateThread.Start();
        }

        private void UpdateLoop()
        {
            while (running)
            {
                if (!this.IsDisposed && this.IsHandleCreated)
                {
                    try
                    {
                        this.Invoke((MethodInvoker)(() => this.Invalidate()));
                    }
                    catch { /* 폼이 닫힐 때 예외 무시 */ }
                }
                Thread.Sleep(100); // 0.1초마다 갱신
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (states.Count < 2) return;

            int sectionCount = 7; // 7구간
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Y축 위치 (A, B, C 실린더)
            int yA = height / 6;
            int yB = height / 2;
            int yC = height * 5 / 6;
            int yStep = height / 6;

            // X축 구간
            int xStep = width / sectionCount;

            // 구간별로 선 그리기 (최대 7구간만)
            for (int i = 1; i < Math.Min(states.Count, sectionCount + 1); i++)
            {
                // A 실린더
                int prevYA = yA - states[i - 1].a * yStep;
                int currYA = yA - states[i].a * yStep;
                e.Graphics.DrawLine(Pens.Red, (i - 1) * xStep, prevYA, i * xStep, currYA);

                // B 실린더
                int prevYB = yB - states[i - 1].b * yStep;
                int currYB = yB - states[i].b * yStep;
                e.Graphics.DrawLine(Pens.Green, (i - 1) * xStep, prevYB, i * xStep, currYB);

                // C 실린더
                int prevYC = yC - states[i - 1].c * yStep;
                int currYC = yC - states[i].c * yStep;
                e.Graphics.DrawLine(Pens.Blue, (i - 1) * xStep, prevYC, i * xStep, currYC);
            }

            // X축 구간 라벨
            for (int i = 0; i <= sectionCount; i++)
            {
                int x = i * xStep;
                e.Graphics.DrawLine(Pens.Gray, x, 0, x, height);
                e.Graphics.DrawString((i + 1).ToString(), this.Font, Brushes.Black, x + 2, height - 20);
            }

            // Y축 실린더 라벨
            e.Graphics.DrawString("A 실린더", this.Font, Brushes.Red, 5, yA - yStep +10);
            e.Graphics.DrawString("B 실린더", this.Font, Brushes.Green, 5, yB - yStep +10);
            e.Graphics.DrawString("C 실린더", this.Font, Brushes.Blue, 5, yC - yStep +10);
        }

        private void FormGraph_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
            if (updateThread != null && updateThread.IsAlive)
            {
                updateThread.Abort();
            }
        }
    }
}
