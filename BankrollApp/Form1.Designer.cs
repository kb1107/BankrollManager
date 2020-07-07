namespace BankrollApp
{
    partial class BankrollApp
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
            this.buttonUpdateBankroll = new System.Windows.Forms.Button();
            this.EntryFeeAmount = new System.Windows.Forms.NumericUpDown();
            this.radioCurrencyEuro = new System.Windows.Forms.RadioButton();
            this.radioCurrencyPound = new System.Windows.Forms.RadioButton();
            this.radioCurrencyDollar = new System.Windows.Forms.RadioButton();
            this.labelEntryFee = new System.Windows.Forms.Label();
            this.labelPrizeMoney = new System.Windows.Forms.Label();
            this.PrizeAmount = new System.Windows.Forms.NumericUpDown();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.pokerSite = new System.Windows.Forms.Label();
            this.comboBoxPokerSite = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntryFeeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateBankroll
            // 
            this.buttonUpdateBankroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonUpdateBankroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateBankroll.Location = new System.Drawing.Point(643, 184);
            this.buttonUpdateBankroll.Name = "buttonUpdateBankroll";
            this.buttonUpdateBankroll.Size = new System.Drawing.Size(187, 43);
            this.buttonUpdateBankroll.TabIndex = 7;
            this.buttonUpdateBankroll.Text = "Update Bankroll";
            this.buttonUpdateBankroll.UseVisualStyleBackColor = true;
            this.buttonUpdateBankroll.Click += new System.EventHandler(this.FinalClick);
            // 
            // EntryFeeAmount
            // 
            this.EntryFeeAmount.DecimalPlaces = 2;
            this.EntryFeeAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.EntryFeeAmount.Location = new System.Drawing.Point(310, 70);
            this.EntryFeeAmount.Name = "EntryFeeAmount";
            this.EntryFeeAmount.Size = new System.Drawing.Size(146, 26);
            this.EntryFeeAmount.TabIndex = 11;
            this.EntryFeeAmount.ValueChanged += new System.EventHandler(this.EntryFee_ValueChanged);
            // 
            // radioCurrencyEuro
            // 
            this.radioCurrencyEuro.AutoSize = true;
            this.radioCurrencyEuro.Location = new System.Drawing.Point(190, 115);
            this.radioCurrencyEuro.Name = "radioCurrencyEuro";
            this.radioCurrencyEuro.Size = new System.Drawing.Size(43, 24);
            this.radioCurrencyEuro.TabIndex = 14;
            this.radioCurrencyEuro.Text = "€";
            this.radioCurrencyEuro.UseVisualStyleBackColor = true;
            this.radioCurrencyEuro.CheckedChanged += new System.EventHandler(this.radioButtonEuro_CheckedChanged);
            // 
            // radioCurrencyPound
            // 
            this.radioCurrencyPound.AutoSize = true;
            this.radioCurrencyPound.Location = new System.Drawing.Point(190, 85);
            this.radioCurrencyPound.Name = "radioCurrencyPound";
            this.radioCurrencyPound.Size = new System.Drawing.Size(43, 24);
            this.radioCurrencyPound.TabIndex = 13;
            this.radioCurrencyPound.Text = "£";
            this.radioCurrencyPound.UseVisualStyleBackColor = true;
            this.radioCurrencyPound.CheckedChanged += new System.EventHandler(this.radioButtonPound_CheckedChanged);
            // 
            // radioCurrencyDollar
            // 
            this.radioCurrencyDollar.AutoSize = true;
            this.radioCurrencyDollar.Location = new System.Drawing.Point(190, 55);
            this.radioCurrencyDollar.Name = "radioCurrencyDollar";
            this.radioCurrencyDollar.Size = new System.Drawing.Size(43, 24);
            this.radioCurrencyDollar.TabIndex = 12;
            this.radioCurrencyDollar.Text = "$";
            this.radioCurrencyDollar.UseVisualStyleBackColor = true;
            this.radioCurrencyDollar.CheckedChanged += new System.EventHandler(this.radioButtonDollar_CheckedChanged);
            // 
            // labelEntryFee
            // 
            this.labelEntryFee.AutoSize = true;
            this.labelEntryFee.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntryFee.Location = new System.Drawing.Point(306, 32);
            this.labelEntryFee.Name = "labelEntryFee";
            this.labelEntryFee.Size = new System.Drawing.Size(91, 23);
            this.labelEntryFee.TabIndex = 15;
            this.labelEntryFee.Text = "Entry fee";
            // 
            // labelPrizeMoney
            // 
            this.labelPrizeMoney.AutoSize = true;
            this.labelPrizeMoney.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrizeMoney.Location = new System.Drawing.Point(474, 32);
            this.labelPrizeMoney.Name = "labelPrizeMoney";
            this.labelPrizeMoney.Size = new System.Drawing.Size(54, 23);
            this.labelPrizeMoney.TabIndex = 17;
            this.labelPrizeMoney.Text = "Prize";
            // 
            // PrizeAmount
            // 
            this.PrizeAmount.DecimalPlaces = 2;
            this.PrizeAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PrizeAmount.Location = new System.Drawing.Point(478, 70);
            this.PrizeAmount.Name = "PrizeAmount";
            this.PrizeAmount.Size = new System.Drawing.Size(146, 26);
            this.PrizeAmount.TabIndex = 16;
            this.PrizeAmount.ValueChanged += new System.EventHandler(this.numericUpDownPrizeMoney_ValueChanged);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(186, 32);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(91, 23);
            this.labelCurrency.TabIndex = 18;
            this.labelCurrency.Text = "Currency";
            // 
            // pokerSite
            // 
            this.pokerSite.AutoSize = true;
            this.pokerSite.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokerSite.Location = new System.Drawing.Point(56, 32);
            this.pokerSite.Name = "pokerSite";
            this.pokerSite.Size = new System.Drawing.Size(45, 23);
            this.pokerSite.TabIndex = 19;
            this.pokerSite.Text = "Site";
            // 
            // comboBoxPokerSite
            // 
            this.comboBoxPokerSite.FormattingEnabled = true;
            this.comboBoxPokerSite.Items.AddRange(new object[] {
            "PokerStars",
            "PartyPoker",
            "888Poker",
            "365Poker",
            "SkyPoker",
            "LadbrokesPoker"});
            this.comboBoxPokerSite.Location = new System.Drawing.Point(12, 70);
            this.comboBoxPokerSite.Name = "comboBoxPokerSite";
            this.comboBoxPokerSite.Size = new System.Drawing.Size(141, 28);
            this.comboBoxPokerSite.TabIndex = 20;
            this.comboBoxPokerSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokerSite_SelectedIndexChanged);
            this.comboBoxPokerSite.ValueMemberChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BankrollApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 239);
            this.Controls.Add(this.comboBoxPokerSite);
            this.Controls.Add(this.pokerSite);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelPrizeMoney);
            this.Controls.Add(this.PrizeAmount);
            this.Controls.Add(this.labelEntryFee);
            this.Controls.Add(this.radioCurrencyEuro);
            this.Controls.Add(this.radioCurrencyPound);
            this.Controls.Add(this.radioCurrencyDollar);
            this.Controls.Add(this.EntryFeeAmount);
            this.Controls.Add(this.buttonUpdateBankroll);
            this.Name = "BankrollApp";
            this.Text = "Bankroll";
            ((System.ComponentModel.ISupportInitialize)(this.EntryFeeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdateBankroll;
        private System.Windows.Forms.NumericUpDown EntryFeeAmount;
        private System.Windows.Forms.RadioButton radioCurrencyEuro;
        private System.Windows.Forms.RadioButton radioCurrencyPound;
        private System.Windows.Forms.RadioButton radioCurrencyDollar;
        private System.Windows.Forms.Label labelEntryFee;
        private System.Windows.Forms.Label labelPrizeMoney;
        private System.Windows.Forms.NumericUpDown PrizeAmount;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label pokerSite;
        private System.Windows.Forms.ComboBox comboBoxPokerSite;
    }
}

