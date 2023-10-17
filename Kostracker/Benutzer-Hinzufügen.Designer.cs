namespace Kostracker
{
    partial class Benutzer_Hinzufügen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benutzer_Hinzufügen));
            this.benutzerTxt = new System.Windows.Forms.TextBox();
            this.KennwortTxt = new System.Windows.Forms.TextBox();
            this.BestätigunTxt = new System.Windows.Forms.TextBox();
            this.kennwortAnzegenChkBox = new System.Windows.Forms.CheckBox();
            this.adminRdBtn = new System.Windows.Forms.RadioButton();
            this.normalerBenutzerRdBtn = new System.Windows.Forms.RadioButton();
            this.hinzufügenbtn = new System.Windows.Forms.Button();
            this.zurückSetzen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msglab2 = new System.Windows.Forms.Label();
            this.msglab1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // benutzerTxt
            // 
            this.benutzerTxt.Location = new System.Drawing.Point(148, 36);
            this.benutzerTxt.Name = "benutzerTxt";
            this.benutzerTxt.Size = new System.Drawing.Size(234, 28);
            this.benutzerTxt.TabIndex = 0;
            this.benutzerTxt.TextChanged += new System.EventHandler(this.benutzerTxt_TextChanged);
            // 
            // KennwortTxt
            // 
            this.KennwortTxt.Location = new System.Drawing.Point(148, 93);
            this.KennwortTxt.Name = "KennwortTxt";
            this.KennwortTxt.Size = new System.Drawing.Size(234, 28);
            this.KennwortTxt.TabIndex = 1;
            // 
            // BestätigunTxt
            // 
            this.BestätigunTxt.Location = new System.Drawing.Point(148, 136);
            this.BestätigunTxt.Name = "BestätigunTxt";
            this.BestätigunTxt.Size = new System.Drawing.Size(234, 28);
            this.BestätigunTxt.TabIndex = 2;
            this.BestätigunTxt.UseSystemPasswordChar = true;
            this.BestätigunTxt.TextChanged += new System.EventHandler(this.BestätigunTxt_TextChanged);
            // 
            // kennwortAnzegenChkBox
            // 
            this.kennwortAnzegenChkBox.AutoSize = true;
            this.kennwortAnzegenChkBox.Location = new System.Drawing.Point(148, 191);
            this.kennwortAnzegenChkBox.Name = "kennwortAnzegenChkBox";
            this.kennwortAnzegenChkBox.Size = new System.Drawing.Size(185, 25);
            this.kennwortAnzegenChkBox.TabIndex = 3;
            this.kennwortAnzegenChkBox.Text = "Kennwort anzeigen";
            this.kennwortAnzegenChkBox.UseVisualStyleBackColor = true;
            this.kennwortAnzegenChkBox.CheckedChanged += new System.EventHandler(this.kennwortAnzegenChkBox_CheckedChanged);
            // 
            // adminRdBtn
            // 
            this.adminRdBtn.AutoSize = true;
            this.adminRdBtn.Location = new System.Drawing.Point(27, 39);
            this.adminRdBtn.Name = "adminRdBtn";
            this.adminRdBtn.Size = new System.Drawing.Size(80, 25);
            this.adminRdBtn.TabIndex = 4;
            this.adminRdBtn.Text = "Admin";
            this.adminRdBtn.UseVisualStyleBackColor = true;
            // 
            // normalerBenutzerRdBtn
            // 
            this.normalerBenutzerRdBtn.AutoSize = true;
            this.normalerBenutzerRdBtn.Checked = true;
            this.normalerBenutzerRdBtn.Location = new System.Drawing.Point(218, 39);
            this.normalerBenutzerRdBtn.Name = "normalerBenutzerRdBtn";
            this.normalerBenutzerRdBtn.Size = new System.Drawing.Size(180, 25);
            this.normalerBenutzerRdBtn.TabIndex = 5;
            this.normalerBenutzerRdBtn.TabStop = true;
            this.normalerBenutzerRdBtn.Text = "Normaler Benutzer";
            this.normalerBenutzerRdBtn.UseVisualStyleBackColor = true;
            // 
            // hinzufügenbtn
            // 
            this.hinzufügenbtn.Location = new System.Drawing.Point(26, 374);
            this.hinzufügenbtn.Name = "hinzufügenbtn";
            this.hinzufügenbtn.Size = new System.Drawing.Size(142, 51);
            this.hinzufügenbtn.TabIndex = 6;
            this.hinzufügenbtn.Text = "Hinzufügen";
            this.hinzufügenbtn.UseVisualStyleBackColor = true;
            this.hinzufügenbtn.Click += new System.EventHandler(this.hinzufügenbtn_Click);
            // 
            // zurückSetzen
            // 
            this.zurückSetzen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zurückSetzen.Location = new System.Drawing.Point(288, 374);
            this.zurückSetzen.Name = "zurückSetzen";
            this.zurückSetzen.Size = new System.Drawing.Size(142, 51);
            this.zurückSetzen.TabIndex = 7;
            this.zurückSetzen.Text = "ZurückSetzen";
            this.zurückSetzen.UseVisualStyleBackColor = true;
            this.zurückSetzen.Click += new System.EventHandler(this.zurückSetzen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kennwort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Benutzer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kennwort";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.msglab2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msglab1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BestätigunTxt);
            this.groupBox1.Controls.Add(this.KennwortTxt);
            this.groupBox1.Controls.Add(this.kennwortAnzegenChkBox);
            this.groupBox1.Controls.Add(this.benutzerTxt);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benutzer daten";
            // 
            // msglab2
            // 
            this.msglab2.AutoSize = true;
            this.msglab2.ForeColor = System.Drawing.Color.Red;
            this.msglab2.Location = new System.Drawing.Point(247, 167);
            this.msglab2.Name = "msglab2";
            this.msglab2.Size = new System.Drawing.Size(25, 21);
            this.msglab2.TabIndex = 12;
            this.msglab2.Text = "...";
            this.msglab2.Visible = false;
            // 
            // msglab1
            // 
            this.msglab1.AutoSize = true;
            this.msglab1.ForeColor = System.Drawing.Color.Red;
            this.msglab1.Location = new System.Drawing.Point(247, 67);
            this.msglab1.Name = "msglab1";
            this.msglab1.Size = new System.Drawing.Size(25, 21);
            this.msglab1.TabIndex = 11;
            this.msglab1.Text = "...";
            this.msglab1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.normalerBenutzerRdBtn);
            this.groupBox2.Controls.Add(this.adminRdBtn);
            this.groupBox2.Location = new System.Drawing.Point(26, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benutzer Type";
            // 
            // Benutzer_Hinzufügen
            // 
            this.AcceptButton = this.hinzufügenbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.zurückSetzen;
            this.ClientSize = new System.Drawing.Size(447, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zurückSetzen);
            this.Controls.Add(this.hinzufügenbtn);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Benutzer_Hinzufügen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer Hinzufügen";
            this.Load += new System.EventHandler(this.Benutzer_Hinzufügen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox benutzerTxt;
        private System.Windows.Forms.TextBox KennwortTxt;
        private System.Windows.Forms.TextBox BestätigunTxt;
        private System.Windows.Forms.CheckBox kennwortAnzegenChkBox;
        private System.Windows.Forms.RadioButton adminRdBtn;
        private System.Windows.Forms.RadioButton normalerBenutzerRdBtn;
        private System.Windows.Forms.Button hinzufügenbtn;
        private System.Windows.Forms.Button zurückSetzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label msglab2;
        private System.Windows.Forms.Label msglab1;
    }
}