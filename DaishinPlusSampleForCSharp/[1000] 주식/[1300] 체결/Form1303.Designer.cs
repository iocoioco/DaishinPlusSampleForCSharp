namespace DaishinPlusSampleForCSharp._1000__주식._1300__체결
{
    partial class Form1303
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1303));
            this.ComboBoxAccountKind = new System.Windows.Forms.ComboBox();
            this.ComboBoxQueryKind = new System.Windows.Forms.ComboBox();
            this.TextBoxAccountNo1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LabelContinue = new System.Windows.Forms.Label();
            this.LabelMsg1 = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonHelp1 = new System.Windows.Forms.Button();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonSelectCode = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxAccountNo2 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxAccountKind
            // 
            this.ComboBoxAccountKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAccountKind.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBoxAccountKind.FormattingEnabled = true;
            this.ComboBoxAccountKind.Location = new System.Drawing.Point(177, 63);
            this.ComboBoxAccountKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxAccountKind.Name = "ComboBoxAccountKind";
            this.ComboBoxAccountKind.Size = new System.Drawing.Size(53, 26);
            this.ComboBoxAccountKind.TabIndex = 3;
            this.ComboBoxAccountKind.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAccountKind_SelectedIndexChanged);
            // 
            // ComboBoxQueryKind
            // 
            this.ComboBoxQueryKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxQueryKind.FormattingEnabled = true;
            this.ComboBoxQueryKind.Items.AddRange(new object[] {
            "전체 조회",
            "종목별 조회"});
            this.ComboBoxQueryKind.Location = new System.Drawing.Point(666, 48);
            this.ComboBoxQueryKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxQueryKind.Name = "ComboBoxQueryKind";
            this.ComboBoxQueryKind.Size = new System.Drawing.Size(163, 26);
            this.ComboBoxQueryKind.TabIndex = 72;
            this.ComboBoxQueryKind.SelectedIndexChanged += new System.EventHandler(this.ComboBoxQueryKind_SelectedIndexChanged);
            // 
            // TextBoxAccountNo1
            // 
            this.TextBoxAccountNo1.BackColor = System.Drawing.Color.White;
            this.TextBoxAccountNo1.Enabled = false;
            this.TextBoxAccountNo1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBoxAccountNo1.Location = new System.Drawing.Point(16, 62);
            this.TextBoxAccountNo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxAccountNo1.Name = "TextBoxAccountNo1";
            this.TextBoxAccountNo1.ReadOnly = true;
            this.TextBoxAccountNo1.Size = new System.Drawing.Size(44, 28);
            this.TextBoxAccountNo1.TabIndex = 1;
            this.TextBoxAccountNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(34, 32);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 18);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "종합계좌번호";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(190, 32);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(44, 18);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "구분";
            // 
            // LabelContinue
            // 
            this.LabelContinue.AutoSize = true;
            this.LabelContinue.ForeColor = System.Drawing.Color.Blue;
            this.LabelContinue.Location = new System.Drawing.Point(631, 26);
            this.LabelContinue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContinue.Name = "LabelContinue";
            this.LabelContinue.Size = new System.Drawing.Size(0, 18);
            this.LabelContinue.TabIndex = 26;
            // 
            // LabelMsg1
            // 
            this.LabelMsg1.AutoSize = true;
            this.LabelMsg1.ForeColor = System.Drawing.Color.Blue;
            this.LabelMsg1.Location = new System.Drawing.Point(24, 27);
            this.LabelMsg1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMsg1.Name = "LabelMsg1";
            this.LabelMsg1.Size = new System.Drawing.Size(0, 18);
            this.LabelMsg1.TabIndex = 23;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(951, 30);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(107, 64);
            this.ButtonNext.TabIndex = 71;
            this.ButtonNext.Text = "다음\r\n";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonHelp1
            // 
            this.ButtonHelp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonHelp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHelp1.Location = new System.Drawing.Point(1144, 32);
            this.ButtonHelp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonHelp1.Name = "ButtonHelp1";
            this.ButtonHelp1.Size = new System.Drawing.Size(83, 64);
            this.ButtonHelp1.TabIndex = 70;
            this.ButtonHelp1.Text = "도움말";
            this.ButtonHelp1.UseVisualStyleBackColor = false;
            this.ButtonHelp1.Click += new System.EventHandler(this.ButtonHelp1_Click);
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.Location = new System.Drawing.Point(837, 30);
            this.ButtonQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(107, 64);
            this.ButtonQuery.TabIndex = 69;
            this.ButtonQuery.Text = "조회";
            this.ButtonQuery.UseVisualStyleBackColor = true;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TextBoxCode);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.TextBoxName);
            this.GroupBox2.Controls.Add(this.ButtonSelectCode);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(263, 4);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(393, 114);
            this.GroupBox2.TabIndex = 68;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "종목 정보";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Location = new System.Drawing.Point(107, 27);
            this.TextBoxCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(175, 28);
            this.TextBoxCode.TabIndex = 1;
            this.TextBoxCode.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 34);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "종목코드";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.White;
            this.TextBoxName.Location = new System.Drawing.Point(107, 68);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Size = new System.Drawing.Size(175, 28);
            this.TextBoxName.TabIndex = 5;
            // 
            // ButtonSelectCode
            // 
            this.ButtonSelectCode.Location = new System.Drawing.Point(299, 26);
            this.ButtonSelectCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSelectCode.Name = "ButtonSelectCode";
            this.ButtonSelectCode.Size = new System.Drawing.Size(76, 72);
            this.ButtonSelectCode.TabIndex = 3;
            this.ButtonSelectCode.Text = "종목\r\n선택";
            this.ButtonSelectCode.UseVisualStyleBackColor = true;
            this.ButtonSelectCode.Click += new System.EventHandler(this.ButtonSelectCode_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 75);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 18);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "종목명";
            // 
            // TextBoxAccountNo2
            // 
            this.TextBoxAccountNo2.BackColor = System.Drawing.Color.White;
            this.TextBoxAccountNo2.Enabled = false;
            this.TextBoxAccountNo2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBoxAccountNo2.Location = new System.Drawing.Point(81, 62);
            this.TextBoxAccountNo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxAccountNo2.Name = "TextBoxAccountNo2";
            this.TextBoxAccountNo2.ReadOnly = true;
            this.TextBoxAccountNo2.Size = new System.Drawing.Size(81, 28);
            this.TextBoxAccountNo2.TabIndex = 2;
            this.TextBoxAccountNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(63, 68);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(17, 18);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "-";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LabelContinue);
            this.GroupBox3.Controls.Add(this.LabelMsg1);
            this.GroupBox3.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox3.Location = new System.Drawing.Point(7, 128);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Size = new System.Drawing.Size(1231, 62);
            this.GroupBox3.TabIndex = 65;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "조회 상태";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.TextBoxAccountNo2);
            this.GroupBox1.Controls.Add(this.ComboBoxAccountKind);
            this.GroupBox1.Controls.Add(this.TextBoxAccountNo1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Location = new System.Drawing.Point(7, 4);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(247, 114);
            this.GroupBox1.TabIndex = 67;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "계좌 정보";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 196);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1243, 525);
            this.DataGridView1.TabIndex = 66;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            this.DataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // Form1303
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 728);
            this.Controls.Add(this.ComboBoxQueryKind);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonHelp1);
            this.Controls.Add(this.ButtonQuery);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1303";
            this.Text = "[1303] 계좌별 미체결잔량 (CpTrade.CpTd5339)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1303_FormClosed);
            this.Load += new System.EventHandler(this.Form1303_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1303_KeyDown);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox ComboBoxAccountKind;
        internal System.Windows.Forms.ComboBox ComboBoxQueryKind;
        internal System.Windows.Forms.TextBox TextBoxAccountNo1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabelContinue;
        internal System.Windows.Forms.Label LabelMsg1;
        internal System.Windows.Forms.Button ButtonNext;
        internal System.Windows.Forms.Button ButtonHelp1;
        internal System.Windows.Forms.Button ButtonQuery;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TextBoxCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxName;
        internal System.Windows.Forms.Button ButtonSelectCode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxAccountNo2;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}