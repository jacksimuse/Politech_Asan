using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openCV_img
{
    public partial class Form1: Form
    {
        Mat orgImg; // 원본 이미지 담는 변수
        Mat prcImg; // 원본 이미지를 변형하거나 수정하는 용으로 사용
        int rotateAngle = 0; // 회전 각도를 위한 변수
        bool loadpic = false;// 이미지 로드, 되돌리기 버튼에서는 원래 사진 크기로 나오는 것을 판단하는 플래그
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_imgLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog()) // 파일 불러오기
                {
                    ofd.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp"; // 이미지 파일 필터
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        // 불러온 파일을 원본 이미지 변수에 할당하기
                        orgImg = new Mat(ofd.FileName);
                        // 원본 이미지 복사
                        prcImg = orgImg.Clone();
                        loadpic = true; // 이미지 로드에서 클릭함
                        UpdatePictureBox();
                    }

                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_imgRotate_Click(object sender, EventArgs e)
        {
            if (ptb_img.Image != null) // ptb에 이미지가 있을 때 실행
            {
                try
                {
                    rotateAngle = (rotateAngle + 90) % 360; // 전역변수에 [90, 180, 270, 0]을 제공하여 클릭할 때마다 돌아가게 함

                    // ptb에 있는 이미지(비트맵)을 Mat로 변형해줌
                    // using (Mat src = BitmapConverter.ToMat(new Bitmap(ptb_img.Image)))
                    using (Mat srcCopy = orgImg.Clone()) // 원본 이미지를 기준으로 복사함 
                    {
                        prcImg?.Dispose(); // 변수?.함수() / 변수가 null인지 확인 후 값이 있으면 함수 진행
                        //if (prcImg != null && !prcImg.IsDisposed)
                        //{
                        //    prcImg.Dispose();
                        //}
                        prcImg = new Mat();
                        var center = new Point2f(srcCopy.Width / 2.0f, srcCopy.Height / 2.0f); // 회전 축이 되는 점 설정
                        var matrix = Cv2.GetRotationMatrix2D(center, rotateAngle, 1.0); // 회전축 중심으로 각도, 몇번 설정
                        Cv2.WarpAffine(srcCopy, prcImg, matrix, new OpenCvSharp.Size(srcCopy.Width, srcCopy.Height));
                        loadpic = false;
                        UpdatePictureBox();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// ptb 화면 수정될 때마다 업데이트 해주는 함수
        /// </summary>
        private void UpdatePictureBox()
        {
            byte[] imgData = prcImg.ToBytes(".bmp"); // 이미지를 바이트로 변환하여 배열로 저장
            using (var ms = new System.IO.MemoryStream(imgData)) // 바이트 배열을 읽어서 저장
            {
                if (loadpic)
                {
                    ptb_img.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    ptb_img.SizeMode = PictureBoxSizeMode.Normal;
                }
               loadpic = false;
               ptb_img.Image = new Bitmap(ms); // 저장된 변수를 읽어 이미지로 변환
            }
        }

        private void btn_imgBlur_Click(object sender, EventArgs e)
        {
            if (ptb_img.Image != null) // ptb에 이미지가 있을 때 실행
            {
                try
                {
                    // ptb에 있는 이미지(비트맵)을 Mat로 변형해줌
                    using (Mat src = BitmapConverter.ToMat(new Bitmap(ptb_img.Image)))
                    using (Mat srcCopy = src.Clone())
                    {
                        prcImg?.Dispose(); // 변수?.함수() / 변수가 null인지 확인 후 값이 있으면 함수 진행
                        //if (prcImg != null && !prcImg.IsDisposed)
                        //{
                        //    prcImg.Dispose();
                        //}
                        prcImg = new Mat();

                        int blursize = tb_blur.Value * 2 +1; // 블러처리를 위한 픽셀 사이즈 제공
                        Cv2.GaussianBlur(srcCopy, prcImg, new OpenCvSharp.Size(blursize, blursize),0);
                        loadpic = false;
                        UpdatePictureBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tb_blur_ValueChanged(object sender, EventArgs e)
        {
            lbl_blur.Text = $"블러 농도 : {tb_blur.Value}"; // 라벨에 트랙 밸류 표시
            if (orgImg != null)
            {
                btn_reset_Click(sender, e);
                btn_imgBlur_Click(sender, e); // 밸류 값이 변할 때 마다 버튼 이벤트 발동
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            prcImg.Dispose(); // 작업용 이미지 변수 할당 제거
            prcImg = orgImg.Clone(); // 다시 원본 이미지 복사
            loadpic = true;
            UpdatePictureBox();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            //  변수 = 변수1 ?? 변수2 /
            //  변수1이 null이면 변수2값을 할당 / 변수1이 null이 아니면 변수1값을 할당
            Mat src = prcImg ?? orgImg; 
            //if (prcImg == null)
            //{
            //    src = orgImg;
            //}
            //else
            //{
            //    src = prcImg;
            //}

            if (src != null)
            {
                try
                {
                    using (Mat srcCopy = src.Clone()) // 원본 이미지를 기준으로 복사함 
                    {
                        prcImg?.Dispose(); // 변수?.함수() / 변수가 null인지 확인 후 값이 있으면 함수 진행
                        //if (prcImg != null && !prcImg.IsDisposed)
                        //{
                        //    prcImg.Dispose();
                        //}
                        prcImg = new Mat();

                        int newwidth = (int)nud_width.Value;
                        int newheight = (int)nud_height.Value;

                        Cv2.Resize(srcCopy, prcImg, new OpenCvSharp.Size(newwidth, newheight));
                        loadpic = false;
                        UpdatePictureBox();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            try
            {
                using (Mat src = BitmapConverter.ToMat(new Bitmap(ptb_img.Image)))
                using (Mat srcCopy = src.Clone())
                {
                    prcImg?.Dispose(); // 변수?.함수() / 변수가 null인지 확인 후 값이 있으면 함수 진행
                    //if (prcImg != null && !prcImg.IsDisposed)
                    //{
                    //    prcImg.Dispose();
                    //}
                    prcImg = new Mat();
                    Cv2.CvtColor(srcCopy, prcImg, ColorConversionCodes.BGR2GRAY);
                    loadpic = true;
                    UpdatePictureBox();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
