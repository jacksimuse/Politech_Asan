namespace openCV_img
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
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.btn_imgLoad = new System.Windows.Forms.Button();
            this.btn_imgRotate = new System.Windows.Forms.Button();
            this.btn_imgBlur = new System.Windows.Forms.Button();
            this.tb_blur = new System.Windows.Forms.TrackBar();
            this.lbl_blur = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.btn_grayscale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_img
            // 
            this.ptb_img.Location = new System.Drawing.Point(23, 29);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(328, 184);
            this.ptb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_img.TabIndex = 0;
            this.ptb_img.TabStop = false;
            // 
            // btn_imgLoad
            // 
            this.btn_imgLoad.Location = new System.Drawing.Point(23, 363);
            this.btn_imgLoad.Name = "btn_imgLoad";
            this.btn_imgLoad.Size = new System.Drawing.Size(154, 75);
            this.btn_imgLoad.TabIndex = 1;
            this.btn_imgLoad.Text = "이미지 로드";
            this.btn_imgLoad.UseVisualStyleBackColor = true;
            this.btn_imgLoad.Click += new System.EventHandler(this.btn_imgLoad_Click);
            // 
            // btn_imgRotate
            // 
            this.btn_imgRotate.Location = new System.Drawing.Point(183, 363);
            this.btn_imgRotate.Name = "btn_imgRotate";
            this.btn_imgRotate.Size = new System.Drawing.Size(154, 75);
            this.btn_imgRotate.TabIndex = 2;
            this.btn_imgRotate.Text = "회전";
            this.btn_imgRotate.UseVisualStyleBackColor = true;
            this.btn_imgRotate.Click += new System.EventHandler(this.btn_imgRotate_Click);
            // 
            // btn_imgBlur
            // 
            this.btn_imgBlur.Location = new System.Drawing.Point(343, 363);
            this.btn_imgBlur.Name = "btn_imgBlur";
            this.btn_imgBlur.Size = new System.Drawing.Size(154, 75);
            this.btn_imgBlur.TabIndex = 3;
            this.btn_imgBlur.Text = "블러";
            this.btn_imgBlur.UseVisualStyleBackColor = true;
            this.btn_imgBlur.Click += new System.EventHandler(this.btn_imgBlur_Click);
            // 
            // tb_blur
            // 
            this.tb_blur.Location = new System.Drawing.Point(503, 363);
            this.tb_blur.Name = "tb_blur";
            this.tb_blur.Size = new System.Drawing.Size(104, 56);
            this.tb_blur.TabIndex = 4;
            this.tb_blur.Value = 5;
            this.tb_blur.ValueChanged += new System.EventHandler(this.tb_blur_ValueChanged);
            // 
            // lbl_blur
            // 
            this.lbl_blur.AutoSize = true;
            this.lbl_blur.Location = new System.Drawing.Point(512, 413);
            this.lbl_blur.Name = "lbl_blur";
            this.lbl_blur.Size = new System.Drawing.Size(95, 15);
            this.lbl_blur.TabIndex = 5;
            this.lbl_blur.Text = "블러 농도 : 5";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(613, 153);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(175, 53);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "되돌리기";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.Location = new System.Drawing.Point(613, 97);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(175, 50);
            this.btn_resize.TabIndex = 7;
            this.btn_resize.Text = "크기 조정";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "너비";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "높이";
            // 
            // nud_width
            // 
            this.nud_width.Location = new System.Drawing.Point(671, 22);
            this.nud_width.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_width.Name = "nud_width";
            this.nud_width.Size = new System.Drawing.Size(106, 25);
            this.nud_width.TabIndex = 10;
            this.nud_width.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nud_height
            // 
            this.nud_height.Location = new System.Drawing.Point(671, 66);
            this.nud_height.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(106, 25);
            this.nud_height.TabIndex = 11;
            this.nud_height.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Location = new System.Drawing.Point(613, 363);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(175, 75);
            this.btn_grayscale.TabIndex = 12;
            this.btn_grayscale.Text = "그레이스케일";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_grayscale);
            this.Controls.Add(this.nud_height);
            this.Controls.Add(this.nud_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_blur);
            this.Controls.Add(this.tb_blur);
            this.Controls.Add(this.btn_imgBlur);
            this.Controls.Add(this.btn_imgRotate);
            this.Controls.Add(this.btn_imgLoad);
            this.Controls.Add(this.ptb_img);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_img;
        private System.Windows.Forms.Button btn_imgLoad;
        private System.Windows.Forms.Button btn_imgRotate;
        private System.Windows.Forms.Button btn_imgBlur;
        private System.Windows.Forms.TrackBar tb_blur;
        private System.Windows.Forms.Label lbl_blur;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.Button btn_grayscale;
    }
}

