namespace WindowsFormsApplication1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.text_qus = new System.Windows.Forms.TextBox();
            this.text_min = new System.Windows.Forms.TextBox();
            this.text_goal = new System.Windows.Forms.TextBox();
            this.text_ans = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.text_max = new System.Windows.Forms.TextBox();
            this.text_no = new System.Windows.Forms.TextBox();
            this.text_path = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.check_title = new System.Windows.Forms.CheckBox();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(422, 382);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(325, 40);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = ">>>>>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(5, 382);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(317, 40);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "<<<<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // text_qus
            // 
            this.text_qus.Font = new System.Drawing.Font("굴림", 12F);
            this.text_qus.Location = new System.Drawing.Point(5, 66);
            this.text_qus.Multiline = true;
            this.text_qus.Name = "text_qus";
            this.text_qus.ReadOnly = true;
            this.text_qus.Size = new System.Drawing.Size(742, 108);
            this.text_qus.TabIndex = 1;
            // 
            // text_min
            // 
            this.text_min.Location = new System.Drawing.Point(6, 39);
            this.text_min.Name = "text_min";
            this.text_min.ReadOnly = true;
            this.text_min.Size = new System.Drawing.Size(100, 21);
            this.text_min.TabIndex = 2;
            // 
            // text_goal
            // 
            this.text_goal.Font = new System.Drawing.Font("굴림", 12F);
            this.text_goal.Location = new System.Drawing.Point(5, 270);
            this.text_goal.Multiline = true;
            this.text_goal.Name = "text_goal";
            this.text_goal.ReadOnly = true;
            this.text_goal.Size = new System.Drawing.Size(742, 106);
            this.text_goal.TabIndex = 1;
            this.text_goal.Click += new System.EventHandler(this.text_goal_TextChanged);
            // 
            // text_ans
            // 
            this.text_ans.Font = new System.Drawing.Font("굴림", 15F);
            this.text_ans.Location = new System.Drawing.Point(6, 180);
            this.text_ans.Multiline = true;
            this.text_ans.Name = "text_ans";
            this.text_ans.Size = new System.Drawing.Size(742, 55);
            this.text_ans.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(5, 241);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(742, 23);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "답 확인";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // text_max
            // 
            this.text_max.Location = new System.Drawing.Point(647, 38);
            this.text_max.Name = "text_max";
            this.text_max.ReadOnly = true;
            this.text_max.Size = new System.Drawing.Size(100, 21);
            this.text_max.TabIndex = 2;
            // 
            // text_no
            // 
            this.text_no.Location = new System.Drawing.Point(323, 38);
            this.text_no.Name = "text_no";
            this.text_no.Size = new System.Drawing.Size(96, 21);
            this.text_no.TabIndex = 2;
            // 
            // text_path
            // 
            this.text_path.Location = new System.Drawing.Point(5, 12);
            this.text_path.Name = "text_path";
            this.text_path.Size = new System.Drawing.Size(567, 21);
            this.text_path.TabIndex = 2;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(666, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(81, 21);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(328, 382);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(88, 40);
            this.btn_hide.TabIndex = 0;
            this.btn_hide.Text = "hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(578, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 21);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "찾아보기";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // check_title
            // 
            this.check_title.AutoSize = true;
            this.check_title.Location = new System.Drawing.Point(113, 41);
            this.check_title.Name = "check_title";
            this.check_title.Size = new System.Drawing.Size(128, 16);
            this.check_title.TabIndex = 3;
            this.check_title.Text = "설명과 이름 반대로";
            this.check_title.UseVisualStyleBackColor = true;
            // 
            // btn_X
            // 
            this.btn_X.Location = new System.Drawing.Point(560, 39);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(81, 21);
            this.btn_X.TabIndex = 0;
            this.btn_X.Text = "틀린문제";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(473, 39);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(81, 21);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 430);
            this.Controls.Add(this.check_title);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.text_no);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.text_min);
            this.Controls.Add(this.text_ans);
            this.Controls.Add(this.text_goal);
            this.Controls.Add(this.text_qus);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_next);
            this.Name = "Form1";
            this.Text = "문제연습장";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.TextBox text_qus;
        private System.Windows.Forms.TextBox text_min;
        private System.Windows.Forms.TextBox text_goal;
        private System.Windows.Forms.TextBox text_ans;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.TextBox text_no;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox check_title;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_init;
    }
}

