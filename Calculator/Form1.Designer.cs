
namespace Calculator
{
    partial class Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_squareInput = new System.Windows.Forms.NumericUpDown();
            this.bt_calc = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_squareInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_input);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод";
            // 
            // tb_input
            // 
            this.tb_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_input.Location = new System.Drawing.Point(3, 19);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(201, 23);
            this.tb_input.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_squareInput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Степень корня";
            // 
            // num_squareInput
            // 
            this.num_squareInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_squareInput.Location = new System.Drawing.Point(3, 19);
            this.num_squareInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_squareInput.Name = "num_squareInput";
            this.num_squareInput.Size = new System.Drawing.Size(201, 23);
            this.num_squareInput.TabIndex = 0;
            this.num_squareInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bt_calc
            // 
            this.bt_calc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_calc.Location = new System.Drawing.Point(0, 241);
            this.bt_calc.Name = "bt_calc";
            this.bt_calc.Size = new System.Drawing.Size(207, 23);
            this.bt_calc.TabIndex = 2;
            this.bt_calc.Text = "Вычислить";
            this.bt_calc.UseVisualStyleBackColor = true;
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_output.Location = new System.Drawing.Point(0, 226);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(0, 15);
            this.lb_output.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // langToolStripMenuItem
            // 
            this.langToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.langToolStripMenuItem.Name = "langToolStripMenuItem";
            this.langToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.langToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 264);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.bt_calc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_squareInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_squareInput;
        private System.Windows.Forms.Button bt_calc;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

