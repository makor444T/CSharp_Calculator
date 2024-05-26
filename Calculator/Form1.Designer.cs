namespace Calculator
{
    partial class Calculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.Btnx2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnSinh = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnDec = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btnx3 = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnCosh = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.BtnBin = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn1x = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnTanh = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.BtnHex = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btnlnx = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.BtnExp = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.BtnOct = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnBS = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.BtnPi = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fileToolStripMenuItem.Text = "Calculator";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(300, 151);
            this.BtnDivide.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(83, 51);
            this.BtnDivide.TabIndex = 20;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.numberOper);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(300, 405);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(83, 51);
            this.BtnEquals.TabIndex = 19;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.Location = new System.Drawing.Point(205, 405);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(83, 51);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.White;
            this.BtnLog.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.Location = new System.Drawing.Point(687, 88);
            this.BtnLog.Margin = new System.Windows.Forms.Padding(6);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(83, 51);
            this.BtnLog.TabIndex = 23;
            this.BtnLog.Text = "log";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(110, 405);
            this.Btn0.Margin = new System.Windows.Forms.Padding(6);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(83, 51);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSqrt.Location = new System.Drawing.Point(205, 151);
            this.BtnSqrt.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(83, 51);
            this.BtnSqrt.TabIndex = 24;
            this.BtnSqrt.Text = "sqrt";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMult.Location = new System.Drawing.Point(300, 214);
            this.BtnMult.Margin = new System.Windows.Forms.Padding(6);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(83, 51);
            this.BtnMult.TabIndex = 16;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.numberOper);
            // 
            // Btnx2
            // 
            this.Btnx2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnx2.Location = new System.Drawing.Point(110, 151);
            this.Btnx2.Margin = new System.Windows.Forms.Padding(6);
            this.Btnx2.Name = "Btnx2";
            this.Btnx2.Size = new System.Drawing.Size(83, 51);
            this.Btnx2.TabIndex = 25;
            this.Btnx2.Text = "x²";
            this.Btnx2.UseVisualStyleBackColor = true;
            this.Btnx2.Click += new System.EventHandler(this.Btnx2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(205, 342);
            this.Btn3.Margin = new System.Windows.Forms.Padding(6);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(83, 51);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnSinh
            // 
            this.BtnSinh.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinh.Location = new System.Drawing.Point(592, 151);
            this.BtnSinh.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSinh.Name = "BtnSinh";
            this.BtnSinh.Size = new System.Drawing.Size(83, 51);
            this.BtnSinh.TabIndex = 26;
            this.BtnSinh.Text = "sinh";
            this.BtnSinh.UseVisualStyleBackColor = true;
            this.BtnSinh.Click += new System.EventHandler(this.BtnSinh_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(110, 342);
            this.Btn2.Margin = new System.Windows.Forms.Padding(6);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(83, 51);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnSin
            // 
            this.BtnSin.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSin.Location = new System.Drawing.Point(687, 151);
            this.BtnSin.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(83, 51);
            this.BtnSin.TabIndex = 27;
            this.BtnSin.Text = "sin";
            this.BtnSin.UseVisualStyleBackColor = true;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnDec
            // 
            this.BtnDec.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDec.Location = new System.Drawing.Point(782, 87);
            this.BtnDec.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(83, 51);
            this.BtnDec.TabIndex = 28;
            this.BtnDec.Text = "dec";
            this.BtnDec.UseVisualStyleBackColor = true;
            this.BtnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(15, 342);
            this.Btn1.Margin = new System.Windows.Forms.Padding(6);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(83, 51);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btnx3
            // 
            this.Btnx3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btnx3.Location = new System.Drawing.Point(782, 150);
            this.Btnx3.Margin = new System.Windows.Forms.Padding(6);
            this.Btnx3.Name = "Btnx3";
            this.Btnx3.Size = new System.Drawing.Size(83, 51);
            this.Btnx3.TabIndex = 29;
            this.Btnx3.Text = "x³";
            this.Btnx3.UseVisualStyleBackColor = true;
            this.Btnx3.Click += new System.EventHandler(this.Btnx3_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(300, 279);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(83, 51);
            this.BtnSub.TabIndex = 12;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.numberOper);
            // 
            // BtnCosh
            // 
            this.BtnCosh.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCosh.Location = new System.Drawing.Point(592, 214);
            this.BtnCosh.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCosh.Name = "BtnCosh";
            this.BtnCosh.Size = new System.Drawing.Size(83, 51);
            this.BtnCosh.TabIndex = 30;
            this.BtnCosh.Text = "cosh";
            this.BtnCosh.UseVisualStyleBackColor = true;
            this.BtnCosh.Click += new System.EventHandler(this.BtnCosh_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(205, 277);
            this.Btn6.Margin = new System.Windows.Forms.Padding(6);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(83, 51);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnCos
            // 
            this.BtnCos.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCos.Location = new System.Drawing.Point(687, 214);
            this.BtnCos.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(83, 51);
            this.BtnCos.TabIndex = 31;
            this.BtnCos.Text = "cos";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(110, 277);
            this.Btn5.Margin = new System.Windows.Forms.Padding(6);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(83, 51);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnBin
            // 
            this.BtnBin.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBin.Location = new System.Drawing.Point(782, 214);
            this.BtnBin.Margin = new System.Windows.Forms.Padding(6);
            this.BtnBin.Name = "BtnBin";
            this.BtnBin.Size = new System.Drawing.Size(83, 51);
            this.BtnBin.TabIndex = 32;
            this.BtnBin.Text = "bin";
            this.BtnBin.UseVisualStyleBackColor = true;
            this.BtnBin.Click += new System.EventHandler(this.BtnBin_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(15, 277);
            this.Btn4.Margin = new System.Windows.Forms.Padding(6);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(83, 51);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btn1x
            // 
            this.Btn1x.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1x.Location = new System.Drawing.Point(15, 151);
            this.Btn1x.Margin = new System.Windows.Forms.Padding(6);
            this.Btn1x.Name = "Btn1x";
            this.Btn1x.Size = new System.Drawing.Size(83, 51);
            this.Btn1x.TabIndex = 33;
            this.Btn1x.Text = "1/x";
            this.Btn1x.UseVisualStyleBackColor = true;
            this.Btn1x.Click += new System.EventHandler(this.Btn1x_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(300, 342);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(83, 51);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.numberOper);
            // 
            // BtnTanh
            // 
            this.BtnTanh.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTanh.Location = new System.Drawing.Point(592, 277);
            this.BtnTanh.Margin = new System.Windows.Forms.Padding(6);
            this.BtnTanh.Name = "BtnTanh";
            this.BtnTanh.Size = new System.Drawing.Size(83, 51);
            this.BtnTanh.TabIndex = 34;
            this.BtnTanh.Text = "tanh";
            this.BtnTanh.UseVisualStyleBackColor = true;
            this.BtnTanh.Click += new System.EventHandler(this.BtnTanh_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(205, 214);
            this.Btn9.Margin = new System.Windows.Forms.Padding(6);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(83, 51);
            this.Btn9.TabIndex = 7;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnTan
            // 
            this.BtnTan.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTan.Location = new System.Drawing.Point(687, 277);
            this.BtnTan.Margin = new System.Windows.Forms.Padding(6);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(83, 51);
            this.BtnTan.TabIndex = 35;
            this.BtnTan.Text = "tan";
            this.BtnTan.UseVisualStyleBackColor = true;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(110, 214);
            this.Btn8.Margin = new System.Windows.Forms.Padding(6);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(83, 51);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // BtnHex
            // 
            this.BtnHex.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHex.Location = new System.Drawing.Point(782, 277);
            this.BtnHex.Margin = new System.Windows.Forms.Padding(6);
            this.BtnHex.Name = "BtnHex";
            this.BtnHex.Size = new System.Drawing.Size(83, 51);
            this.BtnHex.TabIndex = 36;
            this.BtnHex.Text = "hex";
            this.BtnHex.UseVisualStyleBackColor = true;
            this.BtnHex.Click += new System.EventHandler(this.BtnHex_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(15, 214);
            this.Btn7.Margin = new System.Windows.Forms.Padding(6);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(83, 51);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // Btnlnx
            // 
            this.Btnlnx.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlnx.Location = new System.Drawing.Point(687, 405);
            this.Btnlnx.Margin = new System.Windows.Forms.Padding(6);
            this.Btnlnx.Name = "Btnlnx";
            this.Btnlnx.Size = new System.Drawing.Size(83, 51);
            this.Btnlnx.TabIndex = 37;
            this.Btnlnx.Text = "ln x";
            this.Btnlnx.UseVisualStyleBackColor = true;
            this.Btnlnx.Click += new System.EventHandler(this.Btnlnx_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.Location = new System.Drawing.Point(15, 405);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(83, 51);
            this.BtnPM.TabIndex = 4;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = true;
            this.BtnPM.Click += new System.EventHandler(this.BtnPM_Click);
            // 
            // BtnExp
            // 
            this.BtnExp.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExp.Location = new System.Drawing.Point(592, 342);
            this.BtnExp.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExp.Name = "BtnExp";
            this.BtnExp.Size = new System.Drawing.Size(83, 51);
            this.BtnExp.TabIndex = 38;
            this.BtnExp.Text = "exp";
            this.BtnExp.UseVisualStyleBackColor = true;
            this.BtnExp.Click += new System.EventHandler(this.numberOper);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(205, 88);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(83, 51);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMod.Location = new System.Drawing.Point(687, 342);
            this.BtnMod.Margin = new System.Windows.Forms.Padding(6);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(83, 51);
            this.BtnMod.TabIndex = 39;
            this.BtnMod.Text = "mod";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.numberOper);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearEntry.Location = new System.Drawing.Point(110, 88);
            this.BtnClearEntry.Margin = new System.Windows.Forms.Padding(6);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(83, 51);
            this.BtnClearEntry.TabIndex = 2;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = true;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // BtnOct
            // 
            this.BtnOct.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOct.Location = new System.Drawing.Point(782, 342);
            this.BtnOct.Margin = new System.Windows.Forms.Padding(6);
            this.BtnOct.Name = "BtnOct";
            this.BtnOct.Size = new System.Drawing.Size(83, 51);
            this.BtnOct.TabIndex = 40;
            this.BtnOct.Text = "oct";
            this.BtnOct.UseVisualStyleBackColor = true;
            this.BtnOct.Click += new System.EventHandler(this.BtnOct_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(15, 30);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(368, 46);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnPercent
            // 
            this.BtnPercent.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.Location = new System.Drawing.Point(15, 88);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(83, 51);
            this.BtnPercent.TabIndex = 41;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            this.BtnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // BtnBS
            // 
            this.BtnBS.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBS.Location = new System.Drawing.Point(300, 89);
            this.BtnBS.Margin = new System.Windows.Forms.Padding(6);
            this.BtnBS.Name = "BtnBS";
            this.BtnBS.Size = new System.Drawing.Size(83, 51);
            this.BtnBS.TabIndex = 0;
            this.BtnBS.Text = "◄";
            this.BtnBS.UseVisualStyleBackColor = true;
            this.BtnBS.Click += new System.EventHandler(this.BtnBS_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHistory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHistory.Location = new System.Drawing.Point(392, 61);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(190, 395);
            this.txtHistory.TabIndex = 42;
            this.txtHistory.Text = "There\'s no history yet";
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // BtnPi
            // 
            this.BtnPi.Font = new System.Drawing.Font("Centaur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPi.Location = new System.Drawing.Point(592, 88);
            this.BtnPi.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPi.Name = "BtnPi";
            this.BtnPi.Size = new System.Drawing.Size(83, 51);
            this.BtnPi.TabIndex = 22;
            this.BtnPi.Text = "π";
            this.BtnPi.UseVisualStyleBackColor = true;
            this.BtnPi.Click += new System.EventHandler(this.BtnPi_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.ForeColor = System.Drawing.Color.Black;
            this.btnClearHistory.Location = new System.Drawing.Point(392, 30);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(174, 25);
            this.btnClearHistory.TabIndex = 43;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.UseCompatibleTextRendering = true;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Visible = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(880, 464);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.BtnPi);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.BtnOct);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnBS);
            this.Controls.Add(this.BtnExp);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Btnlnx);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnHex);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnTanh);
            this.Controls.Add(this.BtnClearEntry);
            this.Controls.Add(this.Btn1x);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnBin);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCosh);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btnx3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnDec);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnSinh);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.Btnx2);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn9);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.Button BtnPi;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Button BtnBS;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button BtnOct;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExp;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button Btnlnx;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnHex;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnTanh;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn1x;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnBin;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnCosh;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button Btnx3;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnDec;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button BtnSinh;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btnx2;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button btnClearHistory;
    }
}

