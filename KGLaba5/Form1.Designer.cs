namespace KGLaba5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTpov = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBuz = new System.Windows.Forms.TextBox();
            this.TBby = new System.Windows.Forms.TextBox();
            this.TBax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTsmesh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBdy = new System.Windows.Forms.TextBox();
            this.TBdx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBmash = new System.Windows.Forms.Button();
            this.TBkoef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTDefolt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 325);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTpov);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBuz);
            this.groupBox1.Controls.Add(this.TBby);
            this.groupBox1.Controls.Add(this.TBax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(495, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вращение вокруг оси";
            // 
            // BTpov
            // 
            this.BTpov.Location = new System.Drawing.Point(94, 37);
            this.BTpov.Name = "BTpov";
            this.BTpov.Size = new System.Drawing.Size(193, 73);
            this.BTpov.TabIndex = 7;
            this.BTpov.Text = "Применить";
            this.BTpov.UseVisualStyleBackColor = true;
            this.BTpov.Click += new System.EventHandler(this.BTpov_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Допускаются только целые значения!";
            // 
            // TBuz
            // 
            this.TBuz.Location = new System.Drawing.Point(28, 90);
            this.TBuz.Name = "TBuz";
            this.TBuz.Size = new System.Drawing.Size(61, 20);
            this.TBuz.TabIndex = 5;
            this.TBuz.Text = "0";
            // 
            // TBby
            // 
            this.TBby.Location = new System.Drawing.Point(28, 55);
            this.TBby.Name = "TBby";
            this.TBby.Size = new System.Drawing.Size(61, 20);
            this.TBby.TabIndex = 4;
            this.TBby.Text = "0";
            // 
            // TBax
            // 
            this.TBax.Location = new System.Drawing.Point(28, 20);
            this.TBax.Name = "TBax";
            this.TBax.Size = new System.Drawing.Size(61, 20);
            this.TBax.TabIndex = 3;
            this.TBax.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTsmesh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TBdy);
            this.groupBox2.Controls.Add(this.TBdx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(495, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 81);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Смещение по оси";
            // 
            // BTsmesh
            // 
            this.BTsmesh.Location = new System.Drawing.Point(96, 33);
            this.BTsmesh.Name = "BTsmesh";
            this.BTsmesh.Size = new System.Drawing.Size(191, 35);
            this.BTsmesh.TabIndex = 8;
            this.BTsmesh.Text = "Применить";
            this.BTsmesh.UseVisualStyleBackColor = true;
            this.BTsmesh.Click += new System.EventHandler(this.BTsmesh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Допускаются только целые значения!";
            // 
            // TBdy
            // 
            this.TBdy.Location = new System.Drawing.Point(26, 48);
            this.TBdy.Name = "TBdy";
            this.TBdy.Size = new System.Drawing.Size(63, 20);
            this.TBdy.TabIndex = 3;
            this.TBdy.Text = "0";
            // 
            // TBdx
            // 
            this.TBdx.Location = new System.Drawing.Point(26, 19);
            this.TBdx.Name = "TBdx";
            this.TBdx.Size = new System.Drawing.Size(63, 20);
            this.TBdx.TabIndex = 2;
            this.TBdx.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBmash);
            this.groupBox3.Controls.Add(this.TBkoef);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(495, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Маштабирование по всем осям";
            // 
            // TBmash
            // 
            this.TBmash.Location = new System.Drawing.Point(173, 9);
            this.TBmash.Name = "TBmash";
            this.TBmash.Size = new System.Drawing.Size(114, 48);
            this.TBmash.TabIndex = 2;
            this.TBmash.Text = "Применить";
            this.TBmash.UseVisualStyleBackColor = true;
            this.TBmash.Click += new System.EventHandler(this.TBmash_Click);
            // 
            // TBkoef
            // 
            this.TBkoef.Location = new System.Drawing.Point(7, 37);
            this.TBkoef.Name = "TBkoef";
            this.TBkoef.Size = new System.Drawing.Size(159, 20);
            this.TBkoef.TabIndex = 1;
            this.TBkoef.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Коэфициент маштабирования";
            // 
            // BTDefolt
            // 
            this.BTDefolt.Location = new System.Drawing.Point(495, 320);
            this.BTDefolt.Name = "BTDefolt";
            this.BTDefolt.Size = new System.Drawing.Size(293, 33);
            this.BTDefolt.TabIndex = 5;
            this.BTDefolt.Text = "Сбросить всё";
            this.BTDefolt.UseVisualStyleBackColor = true;
            this.BTDefolt.Click += new System.EventHandler(this.BTDefolt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.BTDefolt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Усеченный конус";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTpov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBuz;
        private System.Windows.Forms.TextBox TBby;
        private System.Windows.Forms.TextBox TBax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTsmesh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBdy;
        private System.Windows.Forms.TextBox TBdx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TBmash;
        private System.Windows.Forms.TextBox TBkoef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTDefolt;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

