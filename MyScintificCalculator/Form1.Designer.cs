
namespace MyScintificCalculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 52);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(378, 40);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Location = new System.Drawing.Point(15, 55);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(10, 15);
            this.lblShowOp.TabIndex = 1;
            this.lblShowOp.Text = " ";
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(14, 115);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(90, 70);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<--";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(14, 191);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(90, 70);
            this.btnNum7.TabIndex = 2;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(14, 267);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(90, 70);
            this.btnNum4.TabIndex = 2;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(15, 343);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(90, 70);
            this.btnNum1.TabIndex = 2;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(14, 419);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(90, 70);
            this.btnNum0.TabIndex = 2;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(110, 115);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(90, 70);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(110, 191);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(90, 70);
            this.btnNum8.TabIndex = 2;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(110, 267);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(90, 70);
            this.btnNum5.TabIndex = 2;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(110, 343);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(90, 70);
            this.btnNum2.TabIndex = 2;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(110, 419);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 70);
            this.btnDot.TabIndex = 2;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 70);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(206, 191);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(90, 70);
            this.btnNum9.TabIndex = 2;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(206, 267);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(90, 70);
            this.btnNum6.TabIndex = 2;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(206, 343);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(90, 70);
            this.btnNum3.TabIndex = 2;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNumPadClick);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(206, 419);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(90, 70);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(302, 115);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(90, 70);
            this.btnPlusMinus.TabIndex = 2;
            this.btnPlusMinus.Text = "+-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(302, 191);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(90, 70);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(302, 267);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(90, 70);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(302, 343);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(90, 70);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(302, 419);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(90, 70);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(440, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 70);
            this.button6.TabIndex = 2;
            this.button6.Text = "Pi";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(440, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 70);
            this.button12.TabIndex = 2;
            this.button12.Text = "Sinh";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(536, 115);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 70);
            this.button18.TabIndex = 2;
            this.button18.Text = "log";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(440, 267);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(90, 70);
            this.button24.TabIndex = 2;
            this.button24.Text = "Cosh";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(632, 115);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(90, 70);
            this.button25.TabIndex = 2;
            this.button25.Text = "Sqrt";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(536, 191);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(90, 70);
            this.button26.TabIndex = 2;
            this.button26.Text = "Sin";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(728, 115);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(90, 70);
            this.button27.TabIndex = 2;
            this.button27.Text = "x^2";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(440, 343);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(90, 70);
            this.button28.TabIndex = 2;
            this.button28.Text = "Tanh";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(632, 191);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(90, 70);
            this.button29.TabIndex = 2;
            this.button29.Text = "Dec";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(536, 267);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(90, 70);
            this.button30.TabIndex = 2;
            this.button30.Text = "Cos";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(728, 191);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(90, 70);
            this.button31.TabIndex = 2;
            this.button31.Text = "x^3";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(440, 419);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(90, 70);
            this.button32.TabIndex = 2;
            this.button32.Text = "^";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(632, 267);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(90, 70);
            this.button33.TabIndex = 2;
            this.button33.Text = "Bin";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(536, 343);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(90, 70);
            this.button34.TabIndex = 2;
            this.button34.Text = "Tan";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(728, 267);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(90, 70);
            this.button35.TabIndex = 2;
            this.button35.Text = "1/x";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(632, 343);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(90, 70);
            this.button36.TabIndex = 2;
            this.button36.Text = "Hex";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(536, 419);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(90, 70);
            this.button37.TabIndex = 2;
            this.button37.Text = "Mod";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.arithmeticOperato);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(728, 343);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(90, 70);
            this.button38.TabIndex = 2;
            this.button38.Text = "ln";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(632, 419);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(90, 70);
            this.button39.TabIndex = 2;
            this.button39.Text = "Oct";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(728, 419);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(90, 70);
            this.button40.TabIndex = 2;
            this.button40.Text = "%";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 651);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Scientific Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
    }
}

