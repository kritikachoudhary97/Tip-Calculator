namespace TipCalculator
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.billperperson_label = new System.Windows.Forms.Label();
            this.tipperperson_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bill_amttxtbox = new System.Windows.Forms.TextBox();
            this.tipcent_txtbox = new System.Windows.Forms.TextBox();
            this.people_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inctip_btn = new System.Windows.Forms.Button();
            this.peopleinc_btn = new System.Windows.Forms.Button();
            this.peopledec_btn = new System.Windows.Forms.Button();
            this.dectip_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(458, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Per Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(458, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Per Person";
            // 
            // billperperson_label
            // 
            this.billperperson_label.AutoSize = true;
            this.billperperson_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billperperson_label.Location = new System.Drawing.Point(634, 261);
            this.billperperson_label.Name = "billperperson_label";
            this.billperperson_label.Size = new System.Drawing.Size(0, 44);
            this.billperperson_label.TabIndex = 23;
            // 
            // tipperperson_label
            // 
            this.tipperperson_label.AutoSize = true;
            this.tipperperson_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipperperson_label.Location = new System.Drawing.Point(634, 134);
            this.tipperperson_label.Name = "tipperperson_label";
            this.tipperperson_label.Size = new System.Drawing.Size(0, 44);
            this.tipperperson_label.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tip ";
            // 
            // bill_amttxtbox
            // 
            this.bill_amttxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_amttxtbox.Location = new System.Drawing.Point(115, 117);
            this.bill_amttxtbox.Multiline = true;
            this.bill_amttxtbox.Name = "bill_amttxtbox";
            this.bill_amttxtbox.Size = new System.Drawing.Size(231, 41);
            this.bill_amttxtbox.TabIndex = 28;
            this.bill_amttxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bill_amttxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bill_amttxtbox_KeyPress);
            this.bill_amttxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.bill_amttxtbox_Validating);
            // 
            // tipcent_txtbox
            // 
            this.tipcent_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipcent_txtbox.Location = new System.Drawing.Point(158, 232);
            this.tipcent_txtbox.Multiline = true;
            this.tipcent_txtbox.Name = "tipcent_txtbox";
            this.tipcent_txtbox.Size = new System.Drawing.Size(145, 41);
            this.tipcent_txtbox.TabIndex = 29;
            this.tipcent_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipcent_txtbox.TextChanged += new System.EventHandler(this.tipcent_txtbox_TextChanged);
            this.tipcent_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipcent_txtbox_KeyPress);
            this.tipcent_txtbox.Validating += new System.ComponentModel.CancelEventHandler(this.tipcent_txtbox_Validating);
            // 
            // people_txtbox
            // 
            this.people_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.people_txtbox.Location = new System.Drawing.Point(158, 345);
            this.people_txtbox.Multiline = true;
            this.people_txtbox.Name = "people_txtbox";
            this.people_txtbox.Size = new System.Drawing.Size(145, 41);
            this.people_txtbox.TabIndex = 30;
            this.people_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.people_txtbox.TextChanged += new System.EventHandler(this.people_txtbox_TextChanged);
            this.people_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.people_txtbox_KeyPress);
            this.people_txtbox.Validating += new System.ComponentModel.CancelEventHandler(this.people_txtbox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(110, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bill Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(110, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(110, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Number of People";
            // 
            // inctip_btn
            // 
            this.inctip_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inctip_btn.Location = new System.Drawing.Point(300, 231);
            this.inctip_btn.Name = "inctip_btn";
            this.inctip_btn.Size = new System.Drawing.Size(46, 42);
            this.inctip_btn.TabIndex = 34;
            this.inctip_btn.Text = "+";
            this.inctip_btn.UseVisualStyleBackColor = true;
            this.inctip_btn.Click += new System.EventHandler(this.inctip_btn_Click);
            // 
            // peopleinc_btn
            // 
            this.peopleinc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleinc_btn.Location = new System.Drawing.Point(300, 344);
            this.peopleinc_btn.Name = "peopleinc_btn";
            this.peopleinc_btn.Size = new System.Drawing.Size(46, 42);
            this.peopleinc_btn.TabIndex = 35;
            this.peopleinc_btn.Text = "+";
            this.peopleinc_btn.UseVisualStyleBackColor = true;
            this.peopleinc_btn.Click += new System.EventHandler(this.peopleinc_btn_Click);
            // 
            // peopledec_btn
            // 
            this.peopledec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopledec_btn.Location = new System.Drawing.Point(115, 344);
            this.peopledec_btn.Name = "peopledec_btn";
            this.peopledec_btn.Size = new System.Drawing.Size(46, 42);
            this.peopledec_btn.TabIndex = 37;
            this.peopledec_btn.Text = "-";
            this.peopledec_btn.UseVisualStyleBackColor = true;
            this.peopledec_btn.Click += new System.EventHandler(this.peopledec_btn_Click);
            // 
            // dectip_btn
            // 
            this.dectip_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dectip_btn.Location = new System.Drawing.Point(115, 231);
            this.dectip_btn.Name = "dectip_btn";
            this.dectip_btn.Size = new System.Drawing.Size(46, 42);
            this.dectip_btn.TabIndex = 38;
            this.dectip_btn.Text = "-";
            this.dectip_btn.UseVisualStyleBackColor = true;
            this.dectip_btn.Click += new System.EventHandler(this.dectip_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dectip_btn);
            this.Controls.Add(this.peopledec_btn);
            this.Controls.Add(this.peopleinc_btn);
            this.Controls.Add(this.inctip_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.people_txtbox);
            this.Controls.Add(this.tipcent_txtbox);
            this.Controls.Add(this.bill_amttxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.billperperson_label);
            this.Controls.Add(this.tipperperson_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label billperperson_label;
        private System.Windows.Forms.Label tipperperson_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bill_amttxtbox;
        private System.Windows.Forms.TextBox tipcent_txtbox;
        private System.Windows.Forms.TextBox people_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inctip_btn;
        private System.Windows.Forms.Button peopleinc_btn;
        private System.Windows.Forms.Button peopledec_btn;
        private System.Windows.Forms.Button dectip_btn;
    }
}

