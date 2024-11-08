
namespace game
{
    partial class cars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cars));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemycar1 = new System.Windows.Forms.PictureBox();
            this.enemycar3 = new System.Windows.Forms.PictureBox();
            this.enemycar2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(280, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(280, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 129);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(280, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 125);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(280, 560);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 136);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 654);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(573, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 654);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car.BackgroundImage")));
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car.Location = new System.Drawing.Point(117, 502);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(44, 108);
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // enemycar1
            // 
            this.enemycar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemycar1.BackgroundImage")));
            this.enemycar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemycar1.Location = new System.Drawing.Point(43, 247);
            this.enemycar1.Name = "enemycar1";
            this.enemycar1.Size = new System.Drawing.Size(57, 64);
            this.enemycar1.TabIndex = 7;
            this.enemycar1.TabStop = false;
            // 
            // enemycar3
            // 
            this.enemycar3.BackgroundImage = global::game.Properties.Resources.e2;
            this.enemycar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemycar3.Location = new System.Drawing.Point(436, 260);
            this.enemycar3.Name = "enemycar3";
            this.enemycar3.Size = new System.Drawing.Size(57, 64);
            this.enemycar3.TabIndex = 8;
            this.enemycar3.TabStop = false;
            // 
            // enemycar2
            // 
            this.enemycar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemycar2.BackgroundImage")));
            this.enemycar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemycar2.Location = new System.Drawing.Point(318, 75);
            this.enemycar2.Name = "enemycar2";
            this.enemycar2.Size = new System.Drawing.Size(57, 64);
            this.enemycar2.TabIndex = 9;
            this.enemycar2.TabStop = false;
            this.enemycar2.Click += new System.EventHandler(this.enemycar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Игра окончена!";
            // 
            // coin1
            // 
            this.coin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin1.BackgroundImage")));
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin1.Location = new System.Drawing.Point(52, 75);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(36, 36);
            this.coin1.TabIndex = 11;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin2.BackgroundImage")));
            this.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin2.Location = new System.Drawing.Point(469, 137);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(36, 36);
            this.coin2.TabIndex = 12;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin3.BackgroundImage")));
            this.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin3.Location = new System.Drawing.Point(220, 184);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(36, 36);
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Coins = 0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(176, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 73);
            this.button1.TabIndex = 15;
            this.button1.Text = "МЕНЮ ИГР";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemycar2);
            this.Controls.Add(this.enemycar3);
            this.Controls.Add(this.enemycar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cars";
            this.Text = "ГОНКИ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemycar1;
        private System.Windows.Forms.PictureBox enemycar3;
        private System.Windows.Forms.PictureBox enemycar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

