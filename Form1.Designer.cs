
namespace MFPB
{
    partial class Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.myFragmentedProgressBar5 = new MFPB.MyFragmentedProgressBar();
            this.myFragmentedProgressBar4 = new MFPB.MyFragmentedProgressBar();
            this.myFragmentedProgressBar3 = new MFPB.MyFragmentedProgressBar();
            this.myFragmentedProgressBar2 = new MFPB.MyFragmentedProgressBar();
            this.myFragmentedProgressBar1 = new MFPB.MyFragmentedProgressBar();
            this.myFragmentedProgressBar0 = new MFPB.MyFragmentedProgressBar();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.AutoEllipsis = true;
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.BackColor = System.Drawing.SystemColors.Highlight;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button.Location = new System.Drawing.Point(16, 154);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(356, 39);
            this.button.TabIndex = 6;
            this.button.Text = "Start";
            this.button.UseMnemonic = false;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myFragmentedProgressBar5
            // 
            this.myFragmentedProgressBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar5.AutoSize = true;
            this.myFragmentedProgressBar5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.myFragmentedProgressBar5.Renk = System.Drawing.Color.SlateGray;
            this.myFragmentedProgressBar5.Location = new System.Drawing.Point(207, 112);
            this.myFragmentedProgressBar5.Margin = new System.Windows.Forms.Padding(40, 72, 40, 72);
            this.myFragmentedProgressBar5.EnFazlaDeger = 100;
            this.myFragmentedProgressBar5.Name = "myFragmentedProgressBar5";
            this.myFragmentedProgressBar5.DikdortgenBoyutu = 2;
            this.myFragmentedProgressBar5.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar5.TabIndex = 5;
            this.myFragmentedProgressBar5.TabStop = false;
            this.myFragmentedProgressBar5.Yuzde = 2;
            // 
            // myFragmentedProgressBar4
            // 
            this.myFragmentedProgressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar4.AutoSize = true;
            this.myFragmentedProgressBar4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.myFragmentedProgressBar4.Renk = System.Drawing.Color.OliveDrab;
            this.myFragmentedProgressBar4.Location = new System.Drawing.Point(207, 64);
            this.myFragmentedProgressBar4.Margin = new System.Windows.Forms.Padding(29, 48, 29, 48);
            this.myFragmentedProgressBar4.EnFazlaDeger = 100;
            this.myFragmentedProgressBar4.Name = "myFragmentedProgressBar4";
            this.myFragmentedProgressBar4.DikdortgenBoyutu = 4;
            this.myFragmentedProgressBar4.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar4.TabIndex = 4;
            this.myFragmentedProgressBar4.TabStop = false;
            this.myFragmentedProgressBar4.Yuzde = 4;
            // 
            // myFragmentedProgressBar3
            // 
            this.myFragmentedProgressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar3.AutoSize = true;
            this.myFragmentedProgressBar3.BackColor = System.Drawing.Color.DarkKhaki;
            this.myFragmentedProgressBar3.Renk = System.Drawing.Color.Khaki;
            this.myFragmentedProgressBar3.Location = new System.Drawing.Point(207, 16);
            this.myFragmentedProgressBar3.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.myFragmentedProgressBar3.EnFazlaDeger = 100;
            this.myFragmentedProgressBar3.Name = "myFragmentedProgressBar3";
            this.myFragmentedProgressBar3.DikdortgenBoyutu = 8;
            this.myFragmentedProgressBar3.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar3.TabIndex = 3;
            this.myFragmentedProgressBar3.TabStop = false;
            this.myFragmentedProgressBar3.Yuzde = 8;
            // 
            // myFragmentedProgressBar2
            // 
            this.myFragmentedProgressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar2.AutoSize = true;
            this.myFragmentedProgressBar2.BackColor = System.Drawing.Color.DarkBlue;
            this.myFragmentedProgressBar2.Renk = System.Drawing.Color.Blue;
            this.myFragmentedProgressBar2.Location = new System.Drawing.Point(16, 112);
            this.myFragmentedProgressBar2.Margin = new System.Windows.Forms.Padding(15, 21, 15, 21);
            this.myFragmentedProgressBar2.EnFazlaDeger = 100;
            this.myFragmentedProgressBar2.Name = "myFragmentedProgressBar2";
            this.myFragmentedProgressBar2.DikdortgenBoyutu = 16;
            this.myFragmentedProgressBar2.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar2.TabIndex = 2;
            this.myFragmentedProgressBar2.TabStop = false;
            this.myFragmentedProgressBar2.Yuzde = 16;
            // 
            // myFragmentedProgressBar1
            // 
            this.myFragmentedProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar1.AutoSize = true;
            this.myFragmentedProgressBar1.BackColor = System.Drawing.Color.DarkOrange;
            this.myFragmentedProgressBar1.Renk = System.Drawing.Color.Orange;
            this.myFragmentedProgressBar1.Location = new System.Drawing.Point(16, 64);
            this.myFragmentedProgressBar1.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.myFragmentedProgressBar1.EnFazlaDeger = 100;
            this.myFragmentedProgressBar1.Name = "myFragmentedProgressBar1";
            this.myFragmentedProgressBar1.DikdortgenBoyutu = 32;
            this.myFragmentedProgressBar1.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar1.TabIndex = 1;
            this.myFragmentedProgressBar1.TabStop = false;
            this.myFragmentedProgressBar1.Yuzde = 32;
            // 
            // myFragmentedProgressBar0
            // 
            this.myFragmentedProgressBar0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFragmentedProgressBar0.AutoSize = true;
            this.myFragmentedProgressBar0.BackColor = System.Drawing.Color.DarkRed;
            this.myFragmentedProgressBar0.Renk = System.Drawing.Color.Red;
            this.myFragmentedProgressBar0.Location = new System.Drawing.Point(16, 16);
            this.myFragmentedProgressBar0.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.myFragmentedProgressBar0.EnFazlaDeger = 100;
            this.myFragmentedProgressBar0.Name = "myFragmentedProgressBar0";
            this.myFragmentedProgressBar0.DikdortgenBoyutu = 64;
            this.myFragmentedProgressBar0.Size = new System.Drawing.Size(165, 32);
            this.myFragmentedProgressBar0.TabIndex = 0;
            this.myFragmentedProgressBar0.TabStop = false;
            this.myFragmentedProgressBar0.Yuzde = 64;
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.button);
            this.Controls.Add(this.myFragmentedProgressBar5);
            this.Controls.Add(this.myFragmentedProgressBar4);
            this.Controls.Add(this.myFragmentedProgressBar3);
            this.Controls.Add(this.myFragmentedProgressBar2);
            this.Controls.Add(this.myFragmentedProgressBar1);
            this.Controls.Add(this.myFragmentedProgressBar0);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFragmentedProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyFragmentedProgressBar myFragmentedProgressBar0;
        private MyFragmentedProgressBar myFragmentedProgressBar1;
        private MyFragmentedProgressBar myFragmentedProgressBar2;
        private MyFragmentedProgressBar myFragmentedProgressBar3;
        private MyFragmentedProgressBar myFragmentedProgressBar4;
        private MyFragmentedProgressBar myFragmentedProgressBar5;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Timer timer;
    }
}

