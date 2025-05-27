using OpenCvSharp;
using OpenCvSharp.Extensions;
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

namespace openCV_cam
{
    public partial class Form1: Form
    {
        VideoCapture cap; // 카메라 정보 받아오는 변수
        Thread camThread; // 카메라 동작하는 스레드
        bool isCamRunning = false; // 카메라 동작 확인 변수

        VideoCapture video; // 영상 파일 정보 받아오는 변수
        Thread videoThread; // 영상 동작하는 스레드
        bool isVideoRunning = false; // 영상 동작 확인 변수
        bool isVideoPaused = false; // 영상 멈춤 확인 변수
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_camstart_Click(object sender, EventArgs e)
        {
            // 영상이 재생중인지 확인하여 멈추기
            if (isVideoRunning)
            { 
                isVideoRunning = false;
                video?.Dispose();
                ptb_video.Image?.Dispose();
            }
            if (!isCamRunning)
            {
                cap = new VideoCapture(0); // 컴퓨터와 연결된 첫번째 카메라
                isCamRunning = true; // 카메라 동작중
                camThread = new Thread(CameraLoop); // 카메라를 스레드로 돌림
                camThread.Start();
            }
        }

        private void CameraLoop()
        {
            while (isCamRunning) // 카메라 켜진동안 계속 동작
            {
                using (Mat frame = new Mat()) // 한 장면을 담을 변수
                {
                    if (cap.Read(frame) && !frame.Empty())
                    {
                        Bitmap img = BitmapConverter.ToBitmap(frame); // 한 장면을 이미지로 변경
                        ptb_video.Invoke((MethodInvoker)(() =>
                        {
                            ptb_video.Image?.Dispose();
                            ptb_video.Image = new Bitmap(img);
                        }));
                        img.Dispose();
                    }
                }
                Thread.Sleep(30);
            }
        }

        private void btn_camstop_Click(object sender, EventArgs e)
        {
            if (isCamRunning)
            {
                isCamRunning = false; // 카메라 정지
                camThread?.Join(); // 스레드 호출 차단
                cap?.Release(); // 연결된 카메라 정보 해제
                cap?.Dispose();
            }
        }

        private void btn_videostart_Click(object sender, EventArgs e)
        {
            // 카메라가 진행중인지 확인하여 멈추기
            if (isCamRunning)
            {
                isCamRunning = false;
                cap?.Dispose();
                ptb_video.Image?.Dispose();
            }
            using (OpenFileDialog ofd = new OpenFileDialog()) // 파일 불러오기
            {
                ofd.Filter = "Video Files|*.mp4;*.avi;*.mov"; // 비디오 파일 필터
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    video = new VideoCapture(ofd.FileName); // 불러온 영상을 변수에 담음
                    isVideoRunning = true; // 영상 동작중
                    videoThread = new Thread(VideoLoop); // 영상을 스레드로 돌림
                    videoThread.Start();
                }
            }
        }

        private void VideoLoop()
        {
            while (isVideoRunning) 
            {
                if (isVideoPaused)
                {
                    Thread.Sleep(30);
                    continue;
                    isVideoPaused = false;
                }
                using (Mat frame = new Mat()) // 한 장면을 담을 변수
                {
                    if (video.Read(frame) && !frame.Empty())
                    {
                        Bitmap img = BitmapConverter.ToBitmap(frame); // 한 장면을 이미지로 변경
                        ptb_video.Invoke((MethodInvoker)(() =>
                        {
                            ptb_video.Image?.Dispose();
                            ptb_video.Image = new Bitmap(img);
                        }));
                        img.Dispose();
                    }
                    else
                    {
                        isVideoRunning = false;
                    }
                }
                Thread.Sleep(30);
            }
        }

        private void btn_videostop_Click(object sender, EventArgs e)
        {
            if (isVideoRunning && !isVideoPaused)
            {
                isVideoPaused = true;
                (sender as Button).Text = "비디오 재생";
            }
            else
            {
                isVideoPaused = false;
                (sender as Button).Text = "비디오 정지";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCamRunning) // 카메라가 켜져있으면 끄고, 변수 할당 제거
            {
                isCamRunning = false;
                camThread.Abort(); // 카메라 스레드 강제 종료
                cap?.Release();
                cap?.Dispose();
            }

            if (isVideoRunning) // 영상 켜져있으면 끄고, 변수 할당 제거
            {
                isVideoRunning = false;
                videoThread.Abort(); // 영상 스레드 강제 종료
                video?.Release();
                video?.Dispose();
            }
        }
    }
}
