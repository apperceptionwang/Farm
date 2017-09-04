namespace Farm
{
    partial class Select_Player
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Choose = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_SelectP = new System.Windows.Forms.Label();
            this.Pbx_P1 = new System.Windows.Forms.PictureBox();
            this.Pbx_P2 = new System.Windows.Forms.PictureBox();
            this.Pbx_P3 = new System.Windows.Forms.PictureBox();
            this.cbx_1 = new System.Windows.Forms.CheckBox();
            this.cbx_2 = new System.Windows.Forms.CheckBox();
            this.cbx_3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Choose
            // 
            this.btn_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Choose.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Choose.ForeColor = System.Drawing.Color.White;
            this.btn_Choose.Location = new System.Drawing.Point(242, 440);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(116, 39);
            this.btn_Choose.TabIndex = 7;
            this.btn_Choose.Text = "确认";
            this.btn_Choose.UseVisualStyleBackColor = false;
            this.btn_Choose.Click += new System.EventHandler(this.btn_Choose_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(34, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 328);
            this.listBox1.TabIndex = 8;
            // 
            // lbl_SelectP
            // 
            this.lbl_SelectP.AutoSize = true;
            this.lbl_SelectP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(101)))));
            this.lbl_SelectP.Font = new System.Drawing.Font("微软雅黑", 23F);
            this.lbl_SelectP.ForeColor = System.Drawing.Color.White;
            this.lbl_SelectP.Location = new System.Drawing.Point(223, 6);
            this.lbl_SelectP.Name = "lbl_SelectP";
            this.lbl_SelectP.Size = new System.Drawing.Size(172, 40);
            this.lbl_SelectP.TabIndex = 12;
            this.lbl_SelectP.Text = "请选择人物";
            // 
            // Pbx_P1
            // 
            this.Pbx_P1.Image = global::Farm.Properties.Resources.Player1;
            this.Pbx_P1.Location = new System.Drawing.Point(67, 120);
            this.Pbx_P1.Name = "Pbx_P1";
            this.Pbx_P1.Size = new System.Drawing.Size(87, 225);
            this.Pbx_P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_P1.TabIndex = 13;
            this.Pbx_P1.TabStop = false;
            // 
            // Pbx_P2
            // 
            this.Pbx_P2.Image = global::Farm.Properties.Resources.Player2;
            this.Pbx_P2.Location = new System.Drawing.Point(259, 120);
            this.Pbx_P2.Name = "Pbx_P2";
            this.Pbx_P2.Size = new System.Drawing.Size(87, 225);
            this.Pbx_P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_P2.TabIndex = 14;
            this.Pbx_P2.TabStop = false;
            // 
            // Pbx_P3
            // 
            this.Pbx_P3.Image = global::Farm.Properties.Resources.Player3;
            this.Pbx_P3.Location = new System.Drawing.Point(439, 120);
            this.Pbx_P3.Name = "Pbx_P3";
            this.Pbx_P3.Size = new System.Drawing.Size(87, 225);
            this.Pbx_P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_P3.TabIndex = 15;
            this.Pbx_P3.TabStop = false;
            // 
            // cbx_1
            // 
            this.cbx_1.AutoSize = true;
            this.cbx_1.Location = new System.Drawing.Point(105, 366);
            this.cbx_1.Name = "cbx_1";
            this.cbx_1.Size = new System.Drawing.Size(15, 14);
            this.cbx_1.TabIndex = 16;
            this.cbx_1.UseVisualStyleBackColor = true;
            this.cbx_1.CheckedChanged += new System.EventHandler(this.cbx_1_CheckedChanged);
            // 
            // cbx_2
            // 
            this.cbx_2.AutoSize = true;
            this.cbx_2.Location = new System.Drawing.Point(298, 366);
            this.cbx_2.Name = "cbx_2";
            this.cbx_2.Size = new System.Drawing.Size(15, 14);
            this.cbx_2.TabIndex = 17;
            this.cbx_2.UseVisualStyleBackColor = true;
            this.cbx_2.CheckedChanged += new System.EventHandler(this.cbx_2_CheckedChanged);
            // 
            // cbx_3
            // 
            this.cbx_3.AutoSize = true;
            this.cbx_3.Location = new System.Drawing.Point(479, 366);
            this.cbx_3.Name = "cbx_3";
            this.cbx_3.Size = new System.Drawing.Size(15, 14);
            this.cbx_3.TabIndex = 18;
            this.cbx_3.UseVisualStyleBackColor = true;
            this.cbx_3.CheckedChanged += new System.EventHandler(this.cbx_3_CheckedChanged);
            // 
            // Select_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 487);
            this.Controls.Add(this.cbx_3);
            this.Controls.Add(this.cbx_2);
            this.Controls.Add(this.cbx_1);
            this.Controls.Add(this.Pbx_P3);
            this.Controls.Add(this.Pbx_P2);
            this.Controls.Add(this.Pbx_P1);
            this.Controls.Add(this.lbl_SelectP);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Select_Player";
            this.Text = "人物选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Select_Player_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_P3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Choose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_SelectP;
        private System.Windows.Forms.PictureBox Pbx_P1;
        private System.Windows.Forms.PictureBox Pbx_P2;
        private System.Windows.Forms.PictureBox Pbx_P3;
        private System.Windows.Forms.CheckBox cbx_1;
        private System.Windows.Forms.CheckBox cbx_2;
        private System.Windows.Forms.CheckBox cbx_3;
    }
}