namespace Exchange_Office_Using_XML
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
            this.label1 = new System.Windows.Forms.Label();
            this.blb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDolarBuying = new System.Windows.Forms.Label();
            this.LblDolarSelling = new System.Windows.Forms.Label();
            this.LblEuroBuying = new System.Windows.Forms.Label();
            this.LblEuroSelling = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtExchange = new System.Windows.Forms.Button();
            this.TbxReminder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbxAmount = new System.Windows.Forms.TextBox();
            this.TbxCurrency = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtEURSell = new System.Windows.Forms.Button();
            this.BtEURBuy = new System.Windows.Forms.Button();
            this.BtUSDSell = new System.Windows.Forms.Button();
            this.BtUSDBuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Buying:";
            // 
            // blb
            // 
            this.blb.AutoSize = true;
            this.blb.BackColor = System.Drawing.Color.Transparent;
            this.blb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.blb.ForeColor = System.Drawing.Color.Black;
            this.blb.Location = new System.Drawing.Point(10, 56);
            this.blb.Name = "blb";
            this.blb.Size = new System.Drawing.Size(140, 24);
            this.blb.TabIndex = 1;
            this.blb.Text = "Dollar Selling:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "EURO Buying:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "EURO Selling:";
            // 
            // LblDolarBuying
            // 
            this.LblDolarBuying.AutoSize = true;
            this.LblDolarBuying.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDolarBuying.ForeColor = System.Drawing.Color.Black;
            this.LblDolarBuying.Location = new System.Drawing.Point(149, 32);
            this.LblDolarBuying.Name = "LblDolarBuying";
            this.LblDolarBuying.Size = new System.Drawing.Size(21, 24);
            this.LblDolarBuying.TabIndex = 4;
            this.LblDolarBuying.Text = "0";
            // 
            // LblDolarSelling
            // 
            this.LblDolarSelling.AutoSize = true;
            this.LblDolarSelling.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDolarSelling.ForeColor = System.Drawing.Color.Black;
            this.LblDolarSelling.Location = new System.Drawing.Point(149, 56);
            this.LblDolarSelling.Name = "LblDolarSelling";
            this.LblDolarSelling.Size = new System.Drawing.Size(21, 24);
            this.LblDolarSelling.TabIndex = 5;
            this.LblDolarSelling.Text = "0";
            // 
            // LblEuroBuying
            // 
            this.LblEuroBuying.AutoSize = true;
            this.LblEuroBuying.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEuroBuying.ForeColor = System.Drawing.Color.Black;
            this.LblEuroBuying.Location = new System.Drawing.Point(149, 93);
            this.LblEuroBuying.Name = "LblEuroBuying";
            this.LblEuroBuying.Size = new System.Drawing.Size(21, 24);
            this.LblEuroBuying.TabIndex = 6;
            this.LblEuroBuying.Text = "0";
            // 
            // LblEuroSelling
            // 
            this.LblEuroSelling.AutoSize = true;
            this.LblEuroSelling.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEuroSelling.ForeColor = System.Drawing.Color.Black;
            this.LblEuroSelling.Location = new System.Drawing.Point(149, 117);
            this.LblEuroSelling.Name = "LblEuroSelling";
            this.LblEuroSelling.Size = new System.Drawing.Size(21, 24);
            this.LblEuroSelling.TabIndex = 7;
            this.LblEuroSelling.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtExchange);
            this.groupBox1.Controls.Add(this.TbxReminder);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TbxTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TbxAmount);
            this.groupBox1.Controls.Add(this.TbxCurrency);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BtExchange
            // 
            this.BtExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtExchange.Location = new System.Drawing.Point(27, 179);
            this.BtExchange.Name = "BtExchange";
            this.BtExchange.Size = new System.Drawing.Size(131, 34);
            this.BtExchange.TabIndex = 12;
            this.BtExchange.Text = "Selling";
            this.BtExchange.UseVisualStyleBackColor = true;
            this.BtExchange.Click += new System.EventHandler(this.BtExchange_Click);
            // 
            // TbxReminder
            // 
            this.TbxReminder.Location = new System.Drawing.Point(210, 134);
            this.TbxReminder.Name = "TbxReminder";
            this.TbxReminder.Size = new System.Drawing.Size(106, 29);
            this.TbxReminder.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(51, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Reminder:";
            // 
            // TbxTotal
            // 
            this.TbxTotal.Location = new System.Drawing.Point(210, 99);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(106, 29);
            this.TbxTotal.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(96, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Total:";
            // 
            // TbxAmount
            // 
            this.TbxAmount.Location = new System.Drawing.Point(210, 64);
            this.TbxAmount.Name = "TbxAmount";
            this.TbxAmount.Size = new System.Drawing.Size(106, 29);
            this.TbxAmount.TabIndex = 6;
            // 
            // TbxCurrency
            // 
            this.TbxCurrency.Location = new System.Drawing.Point(210, 31);
            this.TbxCurrency.Name = "TbxCurrency";
            this.TbxCurrency.Size = new System.Drawing.Size(106, 29);
            this.TbxCurrency.TabIndex = 5;
            this.TbxCurrency.TextChanged += new System.EventHandler(this.TbxCurrency_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(70, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(57, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Currency:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtEURSell);
            this.groupBox2.Controls.Add(this.BtEURBuy);
            this.groupBox2.Controls.Add(this.BtUSDSell);
            this.groupBox2.Controls.Add(this.BtUSDBuy);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LblEuroSelling);
            this.groupBox2.Controls.Add(this.blb);
            this.groupBox2.Controls.Add(this.LblEuroBuying);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LblDolarSelling);
            this.groupBox2.Controls.Add(this.LblDolarBuying);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 164);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // BtEURSell
            // 
            this.BtEURSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtEURSell.Location = new System.Drawing.Point(278, 118);
            this.BtEURSell.Name = "BtEURSell";
            this.BtEURSell.Size = new System.Drawing.Size(38, 22);
            this.BtEURSell.TabIndex = 17;
            this.BtEURSell.Text = "...";
            this.BtEURSell.UseVisualStyleBackColor = true;
            this.BtEURSell.Click += new System.EventHandler(this.BtEURSell_Click);
            // 
            // BtEURBuy
            // 
            this.BtEURBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtEURBuy.Location = new System.Drawing.Point(278, 94);
            this.BtEURBuy.Name = "BtEURBuy";
            this.BtEURBuy.Size = new System.Drawing.Size(38, 22);
            this.BtEURBuy.TabIndex = 16;
            this.BtEURBuy.Text = "...";
            this.BtEURBuy.UseVisualStyleBackColor = true;
            this.BtEURBuy.Click += new System.EventHandler(this.BtEURBuy_Click);
            // 
            // BtUSDSell
            // 
            this.BtUSDSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUSDSell.Location = new System.Drawing.Point(278, 57);
            this.BtUSDSell.Name = "BtUSDSell";
            this.BtUSDSell.Size = new System.Drawing.Size(38, 22);
            this.BtUSDSell.TabIndex = 15;
            this.BtUSDSell.Text = "...";
            this.BtUSDSell.UseVisualStyleBackColor = true;
            this.BtUSDSell.Click += new System.EventHandler(this.BtUSDSell_Click);
            // 
            // BtUSDBuy
            // 
            this.BtUSDBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUSDBuy.Location = new System.Drawing.Point(278, 33);
            this.BtUSDBuy.Name = "BtUSDBuy";
            this.BtUSDBuy.Size = new System.Drawing.Size(38, 22);
            this.BtUSDBuy.TabIndex = 14;
            this.BtUSDBuy.Text = "...";
            this.BtUSDBuy.UseVisualStyleBackColor = true;
            this.BtUSDBuy.Click += new System.EventHandler(this.BtUSDBuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(226, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "TRY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(226, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "TRY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(226, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "TRY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(226, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "TRY";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(185, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buying";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Exchange Office";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDolarBuying;
        private System.Windows.Forms.Label LblDolarSelling;
        private System.Windows.Forms.Label LblEuroBuying;
        private System.Windows.Forms.Label LblEuroSelling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxReminder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbxAmount;
        private System.Windows.Forms.TextBox TbxCurrency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtEURSell;
        private System.Windows.Forms.Button BtEURBuy;
        private System.Windows.Forms.Button BtUSDSell;
        private System.Windows.Forms.Button BtUSDBuy;
        private System.Windows.Forms.Button button1;
    }
}

