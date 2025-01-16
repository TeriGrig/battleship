namespace battleship
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Play_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.d_image = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.b_image = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.s_image = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ac_image = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submarine = new System.Windows.Forms.PictureBox();
            this.battleship = new System.Windows.Forms.PictureBox();
            this.destroyer = new System.Windows.Forms.PictureBox();
            this.aircraft_carrier = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ac_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submarine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft_carrier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.Play_Btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Clear_Btn);
            this.panel2.Controls.Add(this.d_image);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.b_image);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.s_image);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.ac_image);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel2.Location = new System.Drawing.Point(70, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 564);
            this.panel2.TabIndex = 2;
            // 
            // Play_Btn
            // 
            this.Play_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Play_Btn.Location = new System.Drawing.Point(870, 433);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(75, 30);
            this.Play_Btn.TabIndex = 26;
            this.Play_Btn.Text = "Play";
            this.Play_Btn.UseVisualStyleBackColor = true;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = " Επέλεξε πλοίο ";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Clear_Btn.Location = new System.Drawing.Point(870, 372);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(75, 30);
            this.Clear_Btn.TabIndex = 24;
            this.Clear_Btn.Text = "Clear";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // d_image
            // 
            this.d_image.Image = global::battleship.Properties.Resources.d;
            this.d_image.Location = new System.Drawing.Point(24, 316);
            this.d_image.Name = "d_image";
            this.d_image.Size = new System.Drawing.Size(180, 40);
            this.d_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.d_image.TabIndex = 6;
            this.d_image.TabStop = false;
            this.d_image.Click += new System.EventHandler(this.d_image_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "K";
            // 
            // b_image
            // 
            this.b_image.Image = global::battleship.Properties.Resources.b;
            this.b_image.Location = new System.Drawing.Point(24, 230);
            this.b_image.Name = "b_image";
            this.b_image.Size = new System.Drawing.Size(135, 40);
            this.b_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_image.TabIndex = 5;
            this.b_image.TabStop = false;
            this.b_image.Click += new System.EventHandler(this.b_image_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "I ";
            // 
            // s_image
            // 
            this.s_image.Image = global::battleship.Properties.Resources.s;
            this.s_image.Location = new System.Drawing.Point(24, 149);
            this.s_image.Name = "s_image";
            this.s_image.Size = new System.Drawing.Size(90, 40);
            this.s_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.s_image.TabIndex = 4;
            this.s_image.TabStop = false;
            this.s_image.Click += new System.EventHandler(this.s_image_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "Θ";
            // 
            // ac_image
            // 
            this.ac_image.Image = global::battleship.Properties.Resources.ac;
            this.ac_image.Location = new System.Drawing.Point(24, 413);
            this.ac_image.Name = "ac_image";
            this.ac_image.Size = new System.Drawing.Size(225, 40);
            this.ac_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ac_image.TabIndex = 3;
            this.ac_image.TabStop = false;
            this.ac_image.Click += new System.EventHandler(this.ac_image_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Η";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ζ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ε";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Δ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Γ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Β";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "1     2    3     4    5     6    7     8     9   10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImage = global::battleship.Properties.Resources.Στιγμιότυπο_οθόνης_2025_01_12_195630;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.submarine);
            this.panel1.Controls.Add(this.battleship);
            this.panel1.Controls.Add(this.destroyer);
            this.panel1.Controls.Add(this.aircraft_carrier);
            this.panel1.Location = new System.Drawing.Point(315, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // submarine
            // 
            this.submarine.Image = global::battleship.Properties.Resources.s;
            this.submarine.Location = new System.Drawing.Point(0, 0);
            this.submarine.Name = "submarine";
            this.submarine.Size = new System.Drawing.Size(100, 50);
            this.submarine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.submarine.TabIndex = 29;
            this.submarine.TabStop = false;
            this.submarine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submarine_MouseClick);
            this.submarine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.submarine_MouseDown);
            this.submarine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.submarine_MouseMove);
            this.submarine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.submarine_MouseUp);
            // 
            // battleship
            // 
            this.battleship.Image = global::battleship.Properties.Resources.b;
            this.battleship.Location = new System.Drawing.Point(0, 0);
            this.battleship.Name = "battleship";
            this.battleship.Size = new System.Drawing.Size(150, 50);
            this.battleship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.battleship.TabIndex = 30;
            this.battleship.TabStop = false;
            this.battleship.MouseClick += new System.Windows.Forms.MouseEventHandler(this.battleship_MouseClick);
            this.battleship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.battleship_MouseDown);
            this.battleship.MouseMove += new System.Windows.Forms.MouseEventHandler(this.battleship_MouseMove);
            this.battleship.MouseUp += new System.Windows.Forms.MouseEventHandler(this.battleship_MouseUp);
            // 
            // destroyer
            // 
            this.destroyer.Image = global::battleship.Properties.Resources.d;
            this.destroyer.Location = new System.Drawing.Point(0, 0);
            this.destroyer.Name = "destroyer";
            this.destroyer.Size = new System.Drawing.Size(200, 50);
            this.destroyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destroyer.TabIndex = 31;
            this.destroyer.TabStop = false;
            this.destroyer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.destroyer_MouseClick);
            this.destroyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.destroyer_MouseDown);
            this.destroyer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.destroyer_MouseMove);
            this.destroyer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.destroyer_MouseUp);
            // 
            // aircraft_carrier
            // 
            this.aircraft_carrier.Image = global::battleship.Properties.Resources.ac;
            this.aircraft_carrier.Location = new System.Drawing.Point(-4, 3);
            this.aircraft_carrier.Name = "aircraft_carrier";
            this.aircraft_carrier.Size = new System.Drawing.Size(250, 50);
            this.aircraft_carrier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aircraft_carrier.TabIndex = 32;
            this.aircraft_carrier.TabStop = false;
            this.aircraft_carrier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.aircraft_carrier_MouseClick);
            this.aircraft_carrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aircraft_carrier_MouseDown);
            this.aircraft_carrier.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aircraft_carrier_MouseMove);
            this.aircraft_carrier.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aircraft_carrier_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::battleship.Properties.Resources.w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1171, 599);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ac_image)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submarine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraft_carrier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_Btn;
        private System.Windows.Forms.PictureBox d_image;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox b_image;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox s_image;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ac_image;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox submarine;
        private System.Windows.Forms.PictureBox battleship;
        private System.Windows.Forms.PictureBox destroyer;
        private System.Windows.Forms.PictureBox aircraft_carrier;
        private System.Windows.Forms.Button Play_Btn;
    }
}

