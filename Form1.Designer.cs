namespace BlackJack
{
    partial class BlackJack
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.CountText = new System.Windows.Forms.Label();
            this.DealCount = new System.Windows.Forms.Label();
            this.DealCountText = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.Dealer8 = new System.Windows.Forms.PictureBox();
            this.Dealer7 = new System.Windows.Forms.PictureBox();
            this.Dealer6 = new System.Windows.Forms.PictureBox();
            this.Dealer5 = new System.Windows.Forms.PictureBox();
            this.Dealer4 = new System.Windows.Forms.PictureBox();
            this.Dealer3 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Dealer2 = new System.Windows.Forms.PictureBox();
            this.Dealer1 = new System.Windows.Forms.PictureBox();
            this.Deck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(612, 11);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(168, 61);
            this.Start.TabIndex = 2;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.Location = new System.Drawing.Point(621, 503);
            this.Done.Margin = new System.Windows.Forms.Padding(2);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(168, 61);
            this.Done.TabIndex = 13;
            this.Done.Text = "DONE";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(371, 63);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(127, 46);
            this.Count.TabIndex = 14;
            this.Count.Text = "Count";
            // 
            // CountText
            // 
            this.CountText.AutoSize = true;
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountText.Location = new System.Drawing.Point(371, 114);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(31, 46);
            this.CountText.TabIndex = 15;
            this.CountText.Text = " ";
            // 
            // DealCount
            // 
            this.DealCount.AutoSize = true;
            this.DealCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DealCount.Location = new System.Drawing.Point(857, 20);
            this.DealCount.Name = "DealCount";
            this.DealCount.Size = new System.Drawing.Size(148, 92);
            this.DealCount.TabIndex = 16;
            this.DealCount.Text = "Dealer \r\nCount";
            // 
            // DealCountText
            // 
            this.DealCountText.AutoSize = true;
            this.DealCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DealCountText.Location = new System.Drawing.Point(884, 114);
            this.DealCountText.Name = "DealCountText";
            this.DealCountText.Size = new System.Drawing.Size(31, 46);
            this.DealCountText.TabIndex = 17;
            this.DealCountText.Text = " ";
            // 
            // GameOver
            // 
            this.GameOver.Image = global::BlackJack.Properties.Resources.GameOver;
            this.GameOver.InitialImage = null;
            this.GameOver.Location = new System.Drawing.Point(212, 438);
            this.GameOver.Margin = new System.Windows.Forms.Padding(2);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(943, 303);
            this.GameOver.TabIndex = 24;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            // 
            // Dealer8
            // 
            this.Dealer8.Location = new System.Drawing.Point(1092, 470);
            this.Dealer8.Name = "Dealer8";
            this.Dealer8.Size = new System.Drawing.Size(216, 300);
            this.Dealer8.TabIndex = 23;
            this.Dealer8.TabStop = false;
            // 
            // Dealer7
            // 
            this.Dealer7.Location = new System.Drawing.Point(1092, 408);
            this.Dealer7.Name = "Dealer7";
            this.Dealer7.Size = new System.Drawing.Size(216, 300);
            this.Dealer7.TabIndex = 22;
            this.Dealer7.TabStop = false;
            // 
            // Dealer6
            // 
            this.Dealer6.Location = new System.Drawing.Point(1092, 345);
            this.Dealer6.Name = "Dealer6";
            this.Dealer6.Size = new System.Drawing.Size(216, 300);
            this.Dealer6.TabIndex = 21;
            this.Dealer6.TabStop = false;
            // 
            // Dealer5
            // 
            this.Dealer5.Location = new System.Drawing.Point(1092, 282);
            this.Dealer5.Name = "Dealer5";
            this.Dealer5.Size = new System.Drawing.Size(216, 300);
            this.Dealer5.TabIndex = 20;
            this.Dealer5.TabStop = false;
            // 
            // Dealer4
            // 
            this.Dealer4.Location = new System.Drawing.Point(1092, 223);
            this.Dealer4.Name = "Dealer4";
            this.Dealer4.Size = new System.Drawing.Size(216, 300);
            this.Dealer4.TabIndex = 19;
            this.Dealer4.TabStop = false;
            // 
            // Dealer3
            // 
            this.Dealer3.Location = new System.Drawing.Point(1092, 161);
            this.Dealer3.Name = "Dealer3";
            this.Dealer3.Size = new System.Drawing.Size(216, 300);
            this.Dealer3.TabIndex = 18;
            this.Dealer3.TabStop = false;
            // 
            // Card8
            // 
            this.Card8.Location = new System.Drawing.Point(45, 467);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(216, 300);
            this.Card8.TabIndex = 12;
            this.Card8.TabStop = false;
            // 
            // Card7
            // 
            this.Card7.Location = new System.Drawing.Point(45, 408);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(216, 300);
            this.Card7.TabIndex = 11;
            this.Card7.TabStop = false;
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(45, 345);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(216, 300);
            this.Card6.TabIndex = 10;
            this.Card6.TabStop = false;
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(45, 282);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(216, 300);
            this.Card5.TabIndex = 9;
            this.Card5.TabStop = false;
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(45, 223);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(216, 300);
            this.Card4.TabIndex = 8;
            this.Card4.TabStop = false;
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(45, 161);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(216, 300);
            this.Card3.TabIndex = 7;
            this.Card3.TabStop = false;
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(45, 102);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(216, 300);
            this.Card2.TabIndex = 6;
            this.Card2.TabStop = false;
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(45, 39);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(216, 300);
            this.Card1.TabIndex = 5;
            this.Card1.TabStop = false;
            // 
            // Dealer2
            // 
            this.Dealer2.Location = new System.Drawing.Point(1092, 102);
            this.Dealer2.Name = "Dealer2";
            this.Dealer2.Size = new System.Drawing.Size(216, 300);
            this.Dealer2.TabIndex = 4;
            this.Dealer2.TabStop = false;
            // 
            // Dealer1
            // 
            this.Dealer1.AccessibleName = "DealerOne";
            this.Dealer1.Location = new System.Drawing.Point(1092, 39);
            this.Dealer1.Name = "Dealer1";
            this.Dealer1.Size = new System.Drawing.Size(216, 300);
            this.Dealer1.TabIndex = 3;
            this.Dealer1.TabStop = false;
            // 
            // Deck
            // 
            this.Deck.AccessibleName = "Deck";
            this.Deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Deck.Enabled = false;
            this.Deck.Image = global::BlackJack.Properties.Resources.back;
            this.Deck.Location = new System.Drawing.Point(598, 114);
            this.Deck.Margin = new System.Windows.Forms.Padding(2);
            this.Deck.Name = "Deck";
            this.Deck.Size = new System.Drawing.Size(216, 300);
            this.Deck.TabIndex = 0;
            this.Deck.UseVisualStyleBackColor = true;
            this.Deck.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlackJack
            // 
            this.AccessibleName = "BlackJack";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1399, 780);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Dealer8);
            this.Controls.Add(this.Dealer7);
            this.Controls.Add(this.Dealer6);
            this.Controls.Add(this.Dealer5);
            this.Controls.Add(this.Dealer4);
            this.Controls.Add(this.Dealer3);
            this.Controls.Add(this.DealCountText);
            this.Controls.Add(this.DealCount);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Card8);
            this.Controls.Add(this.Card7);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.Dealer2);
            this.Controls.Add(this.Dealer1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Deck);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dealer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deck;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox Dealer1;
        private System.Windows.Forms.PictureBox Dealer2;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label CountText;
        private System.Windows.Forms.Label DealCount;
        private System.Windows.Forms.Label DealCountText;
        private System.Windows.Forms.PictureBox Dealer3;
        private System.Windows.Forms.PictureBox Dealer4;
        private System.Windows.Forms.PictureBox Dealer5;
        private System.Windows.Forms.PictureBox Dealer6;
        private System.Windows.Forms.PictureBox Dealer7;
        private System.Windows.Forms.PictureBox Dealer8;
        private System.Windows.Forms.PictureBox GameOver;
    }
}

