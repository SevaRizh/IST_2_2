namespace ЛР_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборКривойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кораблик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Свой пример";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 428);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параплан";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Закрась";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "Нарисуй";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(870, 428);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Слаймы и кривые Безье";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(810, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Упругость сплайна";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборКривойToolStripMenuItem,
            this.очисткаЭкранаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборКривойToolStripMenuItem
            // 
            this.выборКривойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.незамкнутаяЛоманаяToolStripMenuItem,
            this.замкнутаяЛоманаяToolStripMenuItem,
            this.незамкнутыйСплайнToolStripMenuItem,
            this.замкнутыйСплайнToolStripMenuItem,
            this.однаКриваяБезьеToolStripMenuItem,
            this.незамкнутаяКриваяБезьеToolStripMenuItem,
            this.замкнутаяКриваяБезьеToolStripMenuItem});
            this.выборКривойToolStripMenuItem.Name = "выборКривойToolStripMenuItem";
            this.выборКривойToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.выборКривойToolStripMenuItem.Text = "Выбор кривой";
            // 
            // незамкнутаяЛоманаяToolStripMenuItem
            // 
            this.незамкнутаяЛоманаяToolStripMenuItem.Name = "незамкнутаяЛоманаяToolStripMenuItem";
            this.незамкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутаяЛоманаяToolStripMenuItem.Text = "Незамкнутая ломаная";
            this.незамкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.OpenBrokenLine_Click);
            // 
            // замкнутаяЛоманаяToolStripMenuItem
            // 
            this.замкнутаяЛоманаяToolStripMenuItem.Name = "замкнутаяЛоманаяToolStripMenuItem";
            this.замкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяЛоманаяToolStripMenuItem.Text = "Замкнутая ломаная";
            this.замкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.ClosedBrokenLine_Click);
            // 
            // незамкнутыйСплайнToolStripMenuItem
            // 
            this.незамкнутыйСплайнToolStripMenuItem.Name = "незамкнутыйСплайнToolStripMenuItem";
            this.незамкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутыйСплайнToolStripMenuItem.Text = "Незамкнутый сплайн";
            this.незамкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.JptnSpline_Click);
            // 
            // замкнутыйСплайнToolStripMenuItem
            // 
            this.замкнутыйСплайнToolStripMenuItem.Name = "замкнутыйСплайнToolStripMenuItem";
            this.замкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутыйСплайнToolStripMenuItem.Text = "Замкнутый сплайн";
            this.замкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.ClosedSpline_Click);
            // 
            // однаКриваяБезьеToolStripMenuItem
            // 
            this.однаКриваяБезьеToolStripMenuItem.Name = "однаКриваяБезьеToolStripMenuItem";
            this.однаКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.однаКриваяБезьеToolStripMenuItem.Text = "Одна кривая Безье";
            this.однаКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.OneBezierCurve_Click);
            // 
            // незамкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Name = "незамкнутаяКриваяБезьеToolStripMenuItem";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Text = "Незамкнутая кривая Безье";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.OpenBezierCurve_Click);
            // 
            // замкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.замкнутаяКриваяБезьеToolStripMenuItem.Name = "замкнутаяКриваяБезьеToolStripMenuItem";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяКриваяБезьеToolStripMenuItem.Text = "Замкнутая кривая Безье";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.ClosedBezierCurve_Click);
            // 
            // очисткаЭкранаToolStripMenuItem
            // 
            this.очисткаЭкранаToolStripMenuItem.Name = "очисткаЭкранаToolStripMenuItem";
            this.очисткаЭкранаToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.очисткаЭкранаToolStripMenuItem.Text = "Очистка экрана";
            this.очисткаЭкранаToolStripMenuItem.Click += new System.EventHandler(this.CleanScreen_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(876, 434);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Свой пример";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnExamp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выборКривойToolStripMenuItem;
        private ToolStripMenuItem незамкнутаяЛоманаяToolStripMenuItem;
        private ToolStripMenuItem замкнутаяЛоманаяToolStripMenuItem;
        private ToolStripMenuItem незамкнутыйСплайнToolStripMenuItem;
        private ToolStripMenuItem замкнутыйСплайнToolStripMenuItem;
        private ToolStripMenuItem однаКриваяБезьеToolStripMenuItem;
        private ToolStripMenuItem незамкнутаяКриваяБезьеToolStripMenuItem;
        private ToolStripMenuItem замкнутаяКриваяБезьеToolStripMenuItem;
        private ToolStripMenuItem очисткаЭкранаToolStripMenuItem;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button4;
    }
}