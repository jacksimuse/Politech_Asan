namespace Sync_Async
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
            this.p_rightdoor = new System.Windows.Forms.Panel();
            this.p_robot = new System.Windows.Forms.Panel();
            this.p_leftdoor = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_async = new System.Windows.Forms.Button();
            this.btn_sync = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_robotrotate = new System.Windows.Forms.Button();
            this.btn_robotback = new System.Windows.Forms.Button();
            this.btn_robotgo = new System.Windows.Forms.Button();
            this.btn_rightclose = new System.Windows.Forms.Button();
            this.btn_leftclose = new System.Windows.Forms.Button();
            this.btn_rightopen = new System.Windows.Forms.Button();
            this.btn_leftopen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_log = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p_rightdoor);
            this.groupBox1.Controls.Add(this.p_robot);
            this.groupBox1.Controls.Add(this.p_leftdoor);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(306, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // p_rightdoor
            // 
            this.p_rightdoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_rightdoor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_rightdoor.Location = new System.Drawing.Point(255, 20);
            this.p_rightdoor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_rightdoor.Name = "p_rightdoor";
            this.p_rightdoor.Size = new System.Drawing.Size(40, 200);
            this.p_rightdoor.TabIndex = 1;
            // 
            // p_robot
            // 
            this.p_robot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_robot.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_robot.Location = new System.Drawing.Point(53, 20);
            this.p_robot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_robot.Name = "p_robot";
            this.p_robot.Size = new System.Drawing.Size(200, 200);
            this.p_robot.TabIndex = 1;
            // 
            // p_leftdoor
            // 
            this.p_leftdoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p_leftdoor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_leftdoor.Location = new System.Drawing.Point(11, 20);
            this.p_leftdoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p_leftdoor.Name = "p_leftdoor";
            this.p_leftdoor.Size = new System.Drawing.Size(40, 200);
            this.p_leftdoor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_speed);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_async);
            this.groupBox2.Controls.Add(this.btn_sync);
            this.groupBox2.Controls.Add(this.btn_init);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(172, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전체 동작";
            // 
            // txt_speed
            // 
            this.txt_speed.Location = new System.Drawing.Point(84, 81);
            this.txt_speed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(45, 21);
            this.txt_speed.TabIndex = 5;
            this.txt_speed.Text = "100";
            this.txt_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_speed.TextChanged += new System.EventHandler(this.txt_speed_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "m/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "동작 Delay :";
            // 
            // btn_async
            // 
            this.btn_async.Location = new System.Drawing.Point(6, 172);
            this.btn_async.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_async.Name = "btn_async";
            this.btn_async.Size = new System.Drawing.Size(162, 43);
            this.btn_async.TabIndex = 2;
            this.btn_async.Text = "비동기 동작";
            this.btn_async.UseVisualStyleBackColor = true;
            this.btn_async.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_sync
            // 
            this.btn_sync.Location = new System.Drawing.Point(6, 129);
            this.btn_sync.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sync.Name = "btn_sync";
            this.btn_sync.Size = new System.Drawing.Size(162, 39);
            this.btn_sync.TabIndex = 1;
            this.btn_sync.Text = "동기 동작";
            this.btn_sync.UseVisualStyleBackColor = true;
            this.btn_sync.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(4, 18);
            this.btn_init.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(164, 43);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_robotrotate);
            this.groupBox3.Controls.Add(this.btn_robotback);
            this.groupBox3.Controls.Add(this.btn_robotgo);
            this.groupBox3.Controls.Add(this.btn_rightclose);
            this.groupBox3.Controls.Add(this.btn_leftclose);
            this.groupBox3.Controls.Add(this.btn_rightopen);
            this.groupBox3.Controls.Add(this.btn_leftopen);
            this.groupBox3.Location = new System.Drawing.Point(500, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(258, 226);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "단위 동작";
            // 
            // btn_robotrotate
            // 
            this.btn_robotrotate.Location = new System.Drawing.Point(4, 180);
            this.btn_robotrotate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_robotrotate.Name = "btn_robotrotate";
            this.btn_robotrotate.Size = new System.Drawing.Size(250, 42);
            this.btn_robotrotate.TabIndex = 7;
            this.btn_robotrotate.Text = "로봇 회전";
            this.btn_robotrotate.UseVisualStyleBackColor = true;
            this.btn_robotrotate.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_robotback
            // 
            this.btn_robotback.Location = new System.Drawing.Point(4, 143);
            this.btn_robotback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_robotback.Name = "btn_robotback";
            this.btn_robotback.Size = new System.Drawing.Size(250, 33);
            this.btn_robotback.TabIndex = 6;
            this.btn_robotback.Text = "로봇 팔 돌아오기";
            this.btn_robotback.UseVisualStyleBackColor = true;
            this.btn_robotback.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_robotgo
            // 
            this.btn_robotgo.Location = new System.Drawing.Point(4, 110);
            this.btn_robotgo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_robotgo.Name = "btn_robotgo";
            this.btn_robotgo.Size = new System.Drawing.Size(250, 29);
            this.btn_robotgo.TabIndex = 5;
            this.btn_robotgo.Text = "로봇 팔 나가기";
            this.btn_robotgo.UseVisualStyleBackColor = true;
            this.btn_robotgo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_rightclose
            // 
            this.btn_rightclose.Location = new System.Drawing.Point(125, 61);
            this.btn_rightclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rightclose.Name = "btn_rightclose";
            this.btn_rightclose.Size = new System.Drawing.Size(129, 34);
            this.btn_rightclose.TabIndex = 4;
            this.btn_rightclose.Text = "오른쪽 문 닫기";
            this.btn_rightclose.UseVisualStyleBackColor = true;
            this.btn_rightclose.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_leftclose
            // 
            this.btn_leftclose.Location = new System.Drawing.Point(4, 61);
            this.btn_leftclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_leftclose.Name = "btn_leftclose";
            this.btn_leftclose.Size = new System.Drawing.Size(117, 34);
            this.btn_leftclose.TabIndex = 3;
            this.btn_leftclose.Text = "왼쪽 문 닫기";
            this.btn_leftclose.UseVisualStyleBackColor = true;
            this.btn_leftclose.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_rightopen
            // 
            this.btn_rightopen.Location = new System.Drawing.Point(125, 18);
            this.btn_rightopen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rightopen.Name = "btn_rightopen";
            this.btn_rightopen.Size = new System.Drawing.Size(129, 34);
            this.btn_rightopen.TabIndex = 2;
            this.btn_rightopen.Text = "오른쪽 문 열기";
            this.btn_rightopen.UseVisualStyleBackColor = true;
            this.btn_rightopen.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_leftopen
            // 
            this.btn_leftopen.Location = new System.Drawing.Point(4, 18);
            this.btn_leftopen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_leftopen.Name = "btn_leftopen";
            this.btn_leftopen.Size = new System.Drawing.Size(117, 34);
            this.btn_leftopen.TabIndex = 1;
            this.btn_leftopen.Text = "왼쪽 문 열기";
            this.btn_leftopen.UseVisualStyleBackColor = true;
            this.btn_leftopen.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_log);
            this.groupBox4.Location = new System.Drawing.Point(8, 242);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(754, 331);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "log View";
            // 
            // lb_log
            // 
            this.lb_log.FormattingEnabled = true;
            this.lb_log.ItemHeight = 12;
            this.lb_log.Location = new System.Drawing.Point(4, 18);
            this.lb_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(746, 304);
            this.lb_log.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btn_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel p_rightdoor;
        private System.Windows.Forms.Panel p_robot;
        private System.Windows.Forms.Panel p_leftdoor;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_async;
        private System.Windows.Forms.Button btn_sync;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_leftopen;
        private System.Windows.Forms.Button btn_robotrotate;
        private System.Windows.Forms.Button btn_robotback;
        private System.Windows.Forms.Button btn_robotgo;
        private System.Windows.Forms.Button btn_rightclose;
        private System.Windows.Forms.Button btn_leftclose;
        private System.Windows.Forms.Button btn_rightopen;
        private System.Windows.Forms.ListBox lb_log;
    }
}

