namespace ThreadApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_player = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_player)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_player);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "플레이어 추가";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 수 :";
            // 
            // nud_player
            // 
            this.nud_player.Location = new System.Drawing.Point(98, 44);
            this.nud_player.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_player.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_player.Name = "nud_player";
            this.nud_player.Size = new System.Drawing.Size(120, 25);
            this.nud_player.TabIndex = 2;
            this.nud_player.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(320, 169);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_result
            // 
            this.lb_result.FormattingEnabled = true;
            this.lb_result.ItemHeight = 15;
            this.lb_result.Location = new System.Drawing.Point(12, 198);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(383, 169);
            this.lb_result.TabIndex = 4;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(239, 169);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "종료";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 382);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_player;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Button btn_stop;
    }
}

