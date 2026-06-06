namespace Практическая_работа__1_КИС
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.cat_button = new System.Windows.Forms.Button();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.textBoxOtter = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКошкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВыдруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.labelOtterName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(562, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать выдру!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonCreateOtter);
            // 
            // labelAnimal
            // 
            this.labelAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnimal.Location = new System.Drawing.Point(371, 49);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(369, 25);
            this.labelAnimal.TabIndex = 4;
            this.labelAnimal.Text = "Выберите создаваемое животное...";
            this.labelAnimal.Click += new System.EventHandler(this.label1_Click);
            // 
            // cat_button
            // 
            this.cat_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cat_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat_button.Location = new System.Drawing.Point(562, 172);
            this.cat_button.Name = "cat_button";
            this.cat_button.Size = new System.Drawing.Size(119, 39);
            this.cat_button.TabIndex = 5;
            this.cat_button.Text = "Создать кощку!";
            this.cat_button.UseVisualStyleBackColor = false;
            this.cat_button.Click += new System.EventHandler(this.buttonCreateCat);
            // 
            // textBoxCat
            // 
            this.textBoxCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCat.Location = new System.Drawing.Point(506, 142);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(234, 13);
            this.textBoxCat.TabIndex = 6;
            this.textBoxCat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOtter
            // 
            this.textBoxOtter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOtter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOtter.Location = new System.Drawing.Point(506, 288);
            this.textBoxOtter.Name = "textBoxOtter";
            this.textBoxOtter.Size = new System.Drawing.Size(234, 13);
            this.textBoxOtter.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(700, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonClear);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКошкуToolStripMenuItem,
            this.создатьВыдруToolStripMenuItem,
            this.toolStripMenuItem1,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьКошкуToolStripMenuItem
            // 
            this.создатьКошкуToolStripMenuItem.Name = "создатьКошкуToolStripMenuItem";
            this.создатьКошкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьКошкуToolStripMenuItem.Text = "Создать кошку";
            this.создатьКошкуToolStripMenuItem.Click += new System.EventHandler(this.создатьКошкуToolStripMenuItem_Click);
            // 
            // создатьВыдруToolStripMenuItem
            // 
            this.создатьВыдруToolStripMenuItem.Name = "создатьВыдруToolStripMenuItem";
            this.создатьВыдруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьВыдруToolStripMenuItem.Text = "Создать выдру";
            this.создатьВыдруToolStripMenuItem.Click += new System.EventHandler(this.создатьВыдруToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Практическая_работа__1_КИС.Properties.Resources.rechnoy_bobr;
            this.pictureBox3.Location = new System.Drawing.Point(24, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(292, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBoxBeaver3Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Практическая_работа__1_КИС.Properties.Resources.bobri_jivut_aktivno;
            this.pictureBox1.Location = new System.Drawing.Point(180, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxBeaver1Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Практическая_работа__1_КИС.Properties.Resources.chem_pitaetsya_bobr;
            this.pictureBox2.Location = new System.Drawing.Point(24, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxBeaver2Click);
            // 
            // labelCatName
            // 
            this.labelCatName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(514, 126);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(91, 13);
            this.labelCatName.TabIndex = 10;
            this.labelCatName.Text = "Имя для кошки: ";
            // 
            // labelOtterName
            // 
            this.labelOtterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOtterName.AutoSize = true;
            this.labelOtterName.Location = new System.Drawing.Point(514, 272);
            this.labelOtterName.Name = "labelOtterName";
            this.labelOtterName.Size = new System.Drawing.Size(93, 13);
            this.labelOtterName.TabIndex = 11;
            this.labelOtterName.Text = "Имя для выдры: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(799, 464);
            this.Controls.Add(this.labelOtterName);
            this.Controls.Add(this.labelCatName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxOtter);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.cat_button);
            this.Controls.Add(this.labelAnimal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая работа №1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.Button cat_button;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.TextBox textBoxOtter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКошкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВыдруToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.Label labelOtterName;
    }
}

