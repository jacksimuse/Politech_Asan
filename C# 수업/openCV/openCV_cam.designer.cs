namespace openCV_cam
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_video = new System.Windows.Forms.PictureBox();
            this.btn_camstart = new System.Windows.Forms.Button();
            this.btn_camstop = new System.Windows.Forms.Button();
            this.btn_videostop = new System.Windows.Forms.Button();
            this.btn_videostart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_video)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_video
            // 
            this.ptb_video.Location = new System.Drawing.Point(12, 12);
            this.ptb_video.Name = "ptb_video";
            this.ptb_video.Size = new System.Drawing.Size(776, 375);
            this.ptb_video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_video.TabIndex = 0;
            this.ptb_video.TabStop = false;
            // 
            // btn_camstart
            // 
            this.btn_camstart.Location = new System.Drawing.Point(12, 405);
            this.btn_camstart.Name = "btn_camstart";
            this.btn_camstart.Size = new System.Drawing.Size(111, 23);
            this.btn_camstart.TabIndex = 1;
            this.btn_camstart.Text = "카메라 시작";
            this.btn_camstart.UseVisualStyleBackColor = true;
            this.btn_camstart.Click += new System.EventHandler(this.btn_camstart_Click);
            // 
            // btn_camstop
            // 
            this.btn_camstop.Location = new System.Drawing.Point(139, 405);
            this.btn_camstop.Name = "btn_camstop";
            this.btn_camstop.Size = new System.Drawing.Size(111, 23);
            this.btn_camstop.TabIndex = 2;
            this.btn_camstop.Text = "카메라 정지";
            this.btn_camstop.UseVisualStyleBackColor = true;
            this.btn_camstop.Click += new System.EventHandler(this.btn_camstop_Click);
            // 
            // btn_videostop
            // 
            this.btn_videostop.Location = new System.Drawing.Point(393, 405);
            this.btn_videostop.Name = "btn_videostop";
            this.btn_videostop.Size = new System.Drawing.Size(111, 23);
            this.btn_videostop.TabIndex = 4;
            this.btn_videostop.Text = "비디오 정지";
            this.btn_videostop.UseVisualStyleBackColor = true;
            this.btn_videostop.Click += new System.EventHandler(this.btn_videostop_Click);
            // 
            // btn_videostart
            // 
            this.btn_videostart.Location = new System.Drawing.Point(266, 405);
            this.btn_videostart.Name = "btn_videostart";
            this.btn_videostart.Size = new System.Drawing.Size(111, 23);
            this.btn_videostart.TabIndex = 3;
            this.btn_videostart.Text = "비디오 시작";
            this.btn_videostart.UseVisualStyleBackColor = true;
            this.btn_videostart.Click += new System.EventHandler(this.btn_videostart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_videostop);
            this.Controls.Add(this.btn_videostart);
            this.Controls.Add(this.btn_camstop);
            this.Controls.Add(this.btn_camstart);
            this.Controls.Add(this.ptb_video);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_video;
        private System.Windows.Forms.Button btn_camstart;
        private System.Windows.Forms.Button btn_camstop;
        private System.Windows.Forms.Button btn_videostop;
        private System.Windows.Forms.Button btn_videostart;
    }
}

