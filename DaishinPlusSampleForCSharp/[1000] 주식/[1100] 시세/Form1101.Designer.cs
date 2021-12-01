namespace DaishinPlusSampleForCSharp._1000__주식._1100__시세
{
    partial class Form1101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1101));
            this.GroupBoxRQ = new System.Windows.Forms.GroupBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ButtonSelectCode = new System.Windows.Forms.Button();
            this.ButtonReal = new System.Windows.Forms.Button();
            this.ButtonRQ = new System.Windows.Forms.Button();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelContinue = new System.Windows.Forms.Label();
            this.LabelMsg2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelMsg1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBoxRQ.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxRQ
            // 
            this.GroupBoxRQ.Controls.Add(this.TextBoxName);
            this.GroupBoxRQ.Controls.Add(this.Label2);
            this.GroupBoxRQ.Controls.Add(this.ButtonSelectCode);
            this.GroupBoxRQ.Controls.Add(this.ButtonReal);
            this.GroupBoxRQ.Controls.Add(this.ButtonRQ);
            this.GroupBoxRQ.Controls.Add(this.TextBoxCode);
            this.GroupBoxRQ.Controls.Add(this.Label1);
            this.GroupBoxRQ.Location = new System.Drawing.Point(13, 9);
            this.GroupBoxRQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxRQ.Name = "GroupBoxRQ";
            this.GroupBoxRQ.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBoxRQ.Size = new System.Drawing.Size(646, 96);
            this.GroupBoxRQ.TabIndex = 21;
            this.GroupBoxRQ.TabStop = false;
            this.GroupBoxRQ.Text = "요청";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.White;
            this.TextBoxName.Location = new System.Drawing.Point(110, 58);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Size = new System.Drawing.Size(210, 28);
            this.TextBoxName.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 66);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 18);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "종목명";
            // 
            // ButtonSelectCode
            // 
            this.ButtonSelectCode.Location = new System.Drawing.Point(333, 16);
            this.ButtonSelectCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSelectCode.Name = "ButtonSelectCode";
            this.ButtonSelectCode.Size = new System.Drawing.Size(76, 72);
            this.ButtonSelectCode.TabIndex = 3;
            this.ButtonSelectCode.Text = "종목\r\n선택";
            this.ButtonSelectCode.UseVisualStyleBackColor = true;
            this.ButtonSelectCode.Click += new System.EventHandler(this.ButtonSelectCode_Click);
            // 
            // ButtonReal
            // 
            this.ButtonReal.Location = new System.Drawing.Point(501, 18);
            this.ButtonReal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonReal.Name = "ButtonReal";
            this.ButtonReal.Size = new System.Drawing.Size(136, 72);
            this.ButtonReal.TabIndex = 1;
            this.ButtonReal.Text = "실시간(시작)";
            this.ButtonReal.UseVisualStyleBackColor = true;
            this.ButtonReal.Click += new System.EventHandler(this.ButtonReal_Click);
            // 
            // ButtonRQ
            // 
            this.ButtonRQ.Location = new System.Drawing.Point(421, 18);
            this.ButtonRQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRQ.Name = "ButtonRQ";
            this.ButtonRQ.Size = new System.Drawing.Size(76, 72);
            this.ButtonRQ.TabIndex = 2;
            this.ButtonRQ.Text = "조회";
            this.ButtonRQ.UseVisualStyleBackColor = true;
            this.ButtonRQ.Click += new System.EventHandler(this.ButtonRQ_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Location = new System.Drawing.Point(110, 18);
            this.TextBoxCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(210, 28);
            this.TextBoxCode.TabIndex = 1;
            this.TextBoxCode.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "종목코드";
            // 
            // LabelContinue
            // 
            this.LabelContinue.AutoSize = true;
            this.LabelContinue.ForeColor = System.Drawing.Color.Blue;
            this.LabelContinue.Location = new System.Drawing.Point(871, 27);
            this.LabelContinue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelContinue.Name = "LabelContinue";
            this.LabelContinue.Size = new System.Drawing.Size(0, 18);
            this.LabelContinue.TabIndex = 25;
            // 
            // LabelMsg2
            // 
            this.LabelMsg2.AutoSize = true;
            this.LabelMsg2.ForeColor = System.Drawing.Color.Blue;
            this.LabelMsg2.Location = new System.Drawing.Point(514, 27);
            this.LabelMsg2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMsg2.Name = "LabelMsg2";
            this.LabelMsg2.Size = new System.Drawing.Size(0, 18);
            this.LabelMsg2.TabIndex = 24;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.LabelContinue);
            this.GroupBox1.Controls.Add(this.LabelMsg2);
            this.GroupBox1.Controls.Add(this.LabelMsg1);
            this.GroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox1.Location = new System.Drawing.Point(13, 114);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(816, 62);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "조회 상태";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
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
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button2.Location = new System.Drawing.Point(683, 62);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(146, 51);
            this.Button2.TabIndex = 23;
            this.Button2.Text = "도움말\r\n(현재가 실시간)";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 184);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(837, 68);
            this.DataGridView1.TabIndex = 20;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button1.Location = new System.Drawing.Point(683, 6);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(146, 52);
            this.Button1.TabIndex = 22;
            this.Button1.Text = "도움말\r\n(현재가 조회)";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1101
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 260);
            this.Controls.Add(this.GroupBoxRQ);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1101";
            this.Text = "[1101] 주식현재가 (단일종목) (CpDib.StockMst)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1101_FormClosed);
            this.Load += new System.EventHandler(this.Form1101_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1101_KeyDown);
            this.GroupBoxRQ.ResumeLayout(false);
            this.GroupBoxRQ.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxRQ;
        internal System.Windows.Forms.TextBox TextBoxName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button ButtonSelectCode;
        internal System.Windows.Forms.Button ButtonReal;
        internal System.Windows.Forms.Button ButtonRQ;
        internal System.Windows.Forms.TextBox TextBoxCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabelContinue;
        internal System.Windows.Forms.Label LabelMsg2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label LabelMsg1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button1;
    }
}