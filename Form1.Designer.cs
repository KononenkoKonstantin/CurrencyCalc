namespace _01_FormCurrencyCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbCurSource = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsdBuy = new System.Windows.Forms.TextBox();
            this.tbUsdSale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEurBuy = new System.Windows.Forms.TextBox();
            this.tbEurSale = new System.Windows.Forms.TextBox();
            this.tbGbpBuy = new System.Windows.Forms.TextBox();
            this.tbGbpSale = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbCurTarget = new System.Windows.Forms.ComboBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCurSource
            // 
            this.cbCurSource.Enabled = false;
            this.cbCurSource.FormattingEnabled = true;
            this.cbCurSource.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "UAH"});
            this.cbCurSource.Location = new System.Drawing.Point(7, 55);
            this.cbCurSource.Name = "cbCurSource";
            this.cbCurSource.Size = new System.Drawing.Size(55, 24);
            this.cbCurSource.TabIndex = 0;
            this.cbCurSource.Text = "USD";
            this.cbCurSource.SelectedIndexChanged += new System.EventHandler(this.cbCurSource_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "==>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Направление обмена";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(70, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Покупка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(137, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Продажа";
            // 
            // tbUsdBuy
            // 
            this.tbUsdBuy.Enabled = false;
            this.tbUsdBuy.Location = new System.Drawing.Point(73, 49);
            this.tbUsdBuy.Name = "tbUsdBuy";
            this.tbUsdBuy.Size = new System.Drawing.Size(46, 22);
            this.tbUsdBuy.TabIndex = 9;
            this.tbUsdBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsdBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsdBuy_KeyPress);
            // 
            // tbUsdSale
            // 
            this.tbUsdSale.Enabled = false;
            this.tbUsdSale.Location = new System.Drawing.Point(138, 49);
            this.tbUsdSale.Name = "tbUsdSale";
            this.tbUsdSale.Size = new System.Drawing.Size(46, 22);
            this.tbUsdSale.TabIndex = 10;
            this.tbUsdSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsdSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsdSale_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "USD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(16, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "GBP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "EUR";
            // 
            // tbEurBuy
            // 
            this.tbEurBuy.Enabled = false;
            this.tbEurBuy.Location = new System.Drawing.Point(73, 99);
            this.tbEurBuy.Name = "tbEurBuy";
            this.tbEurBuy.Size = new System.Drawing.Size(46, 22);
            this.tbEurBuy.TabIndex = 20;
            this.tbEurBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEurBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEurBuy_KeyPress);
            // 
            // tbEurSale
            // 
            this.tbEurSale.Enabled = false;
            this.tbEurSale.Location = new System.Drawing.Point(138, 98);
            this.tbEurSale.Name = "tbEurSale";
            this.tbEurSale.Size = new System.Drawing.Size(46, 22);
            this.tbEurSale.TabIndex = 21;
            this.tbEurSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEurSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEurSale_KeyPress);
            // 
            // tbGbpBuy
            // 
            this.tbGbpBuy.Enabled = false;
            this.tbGbpBuy.Location = new System.Drawing.Point(73, 151);
            this.tbGbpBuy.Name = "tbGbpBuy";
            this.tbGbpBuy.Size = new System.Drawing.Size(46, 22);
            this.tbGbpBuy.TabIndex = 22;
            this.tbGbpBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGbpBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGbpBuy_KeyPress);
            // 
            // tbGbpSale
            // 
            this.tbGbpSale.Enabled = false;
            this.tbGbpSale.Location = new System.Drawing.Point(138, 151);
            this.tbGbpSale.Name = "tbGbpSale";
            this.tbGbpSale.Size = new System.Drawing.Size(46, 22);
            this.tbGbpSale.TabIndex = 23;
            this.tbGbpSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGbpSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGbpSale_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.tbGbpSale);
            this.groupBox1.Controls.Add(this.tbGbpBuy);
            this.groupBox1.Controls.Add(this.tbEurSale);
            this.groupBox1.Controls.Add(this.tbEurBuy);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbUsdSale);
            this.groupBox1.Controls.Add(this.tbUsdBuy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 250);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Курс на сегодня";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(126, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(16, 203);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 24;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(104, 186);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(83, 58);
            this.btnCalc.TabIndex = 25;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.cbCurTarget);
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbCurSource);
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 250);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(11, 186);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 25);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbCurTarget
            // 
            this.cbCurTarget.Enabled = false;
            this.cbCurTarget.FormattingEnabled = true;
            this.cbCurTarget.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "UAH"});
            this.cbCurTarget.Location = new System.Drawing.Point(132, 55);
            this.cbCurTarget.Name = "cbCurTarget";
            this.cbCurTarget.Size = new System.Drawing.Size(55, 24);
            this.cbCurTarget.TabIndex = 30;
            this.cbCurTarget.Text = "UAH";
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(104, 137);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(83, 29);
            this.tbResult.TabIndex = 29;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Сумма";
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(104, 92);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(83, 29);
            this.tbInput.TabIndex = 26;
            this.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Валютный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsdBuy;
        private System.Windows.Forms.TextBox tbUsdSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEurBuy;
        private System.Windows.Forms.TextBox tbEurSale;
        private System.Windows.Forms.TextBox tbGbpBuy;
        private System.Windows.Forms.TextBox tbGbpSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbCurTarget;
        private System.Windows.Forms.Button btnReset;
    }
}

