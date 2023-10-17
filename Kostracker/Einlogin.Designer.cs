namespace Kostracker
{
    partial class Einlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einlogin));
            this.abbrechenBtn = new System.Windows.Forms.Button();
            this.anmeldenBtn = new System.Windows.Forms.Button();
            this.KennwortVergesen = new System.Windows.Forms.LinkLabel();
            this.anzeigenCheckbox = new System.Windows.Forms.CheckBox();
            this.kennwortTxt = new System.Windows.Forms.TextBox();
            this.benuzterTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abbrechenBtn
            // 
            this.abbrechenBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbrechenBtn.Location = new System.Drawing.Point(224, 407);
            this.abbrechenBtn.Name = "abbrechenBtn";
            this.abbrechenBtn.Size = new System.Drawing.Size(114, 43);
            this.abbrechenBtn.TabIndex = 5;
            this.abbrechenBtn.Text = "Abbrechen";
            this.abbrechenBtn.UseVisualStyleBackColor = true;
            this.abbrechenBtn.Click += new System.EventHandler(this.abbrechenBtn_Click);
            // 
            // anmeldenBtn
            // 
            this.anmeldenBtn.Location = new System.Drawing.Point(80, 407);
            this.anmeldenBtn.Name = "anmeldenBtn";
            this.anmeldenBtn.Size = new System.Drawing.Size(114, 43);
            this.anmeldenBtn.TabIndex = 4;
            this.anmeldenBtn.Text = "Anmelden";
            this.anmeldenBtn.UseVisualStyleBackColor = true;
            this.anmeldenBtn.Click += new System.EventHandler(this.anmeldenBtn_Click);
            // 
            // KennwortVergesen
            // 
            this.KennwortVergesen.AutoSize = true;
            this.KennwortVergesen.BackColor = System.Drawing.Color.Transparent;
            this.KennwortVergesen.Location = new System.Drawing.Point(125, 360);
            this.KennwortVergesen.Name = "KennwortVergesen";
            this.KennwortVergesen.Size = new System.Drawing.Size(165, 22);
            this.KennwortVergesen.TabIndex = 3;
            this.KennwortVergesen.TabStop = true;
            this.KennwortVergesen.Text = "Kennwort vergesen";
            // 
            // anzeigenCheckbox
            // 
            this.anzeigenCheckbox.AutoSize = true;
            this.anzeigenCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.anzeigenCheckbox.Location = new System.Drawing.Point(105, 313);
            this.anzeigenCheckbox.Name = "anzeigenCheckbox";
            this.anzeigenCheckbox.Size = new System.Drawing.Size(185, 26);
            this.anzeigenCheckbox.TabIndex = 2;
            this.anzeigenCheckbox.Text = "Kennwort anzeigen";
            this.anzeigenCheckbox.UseVisualStyleBackColor = false;
            this.anzeigenCheckbox.CheckedChanged += new System.EventHandler(this.anzeigenCheckbox_CheckedChanged);
            // 
            // kennwortTxt
            // 
            this.kennwortTxt.Location = new System.Drawing.Point(83, 279);
            this.kennwortTxt.Name = "kennwortTxt";
            this.kennwortTxt.Size = new System.Drawing.Size(258, 28);
            this.kennwortTxt.TabIndex = 1;
            this.kennwortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kennwortTxt.UseSystemPasswordChar = true;
            // 
            // benuzterTxt
            // 
            this.benuzterTxt.Location = new System.Drawing.Point(83, 202);
            this.benuzterTxt.Name = "benuzterTxt";
            this.benuzterTxt.Size = new System.Drawing.Size(258, 28);
            this.benuzterTxt.TabIndex = 0;
            this.benuzterTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(79, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Benutzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(79, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kennwort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abbrechenBtn);
            this.groupBox1.Controls.Add(this.anmeldenBtn);
            this.groupBox1.Controls.Add(this.KennwortVergesen);
            this.groupBox1.Controls.Add(this.anzeigenCheckbox);
            this.groupBox1.Controls.Add(this.kennwortTxt);
            this.groupBox1.Controls.Add(this.benuzterTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(367, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 513);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benutzer Daten";
            // 
            // Einlogin
            // 
            this.AcceptButton = this.anmeldenBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.abbrechenBtn;
            this.ClientSize = new System.Drawing.Size(816, 513);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Einlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einlogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abbrechenBtn;
        private System.Windows.Forms.Button anmeldenBtn;
        private System.Windows.Forms.LinkLabel KennwortVergesen;
        private System.Windows.Forms.CheckBox anzeigenCheckbox;
        private System.Windows.Forms.TextBox kennwortTxt;
        private System.Windows.Forms.TextBox benuzterTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}