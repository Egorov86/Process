namespace Process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave_Click = new System.Windows.Forms.ToolStripButton();
            this.btnLoad_Click = new System.Windows.Forms.ToolStripButton();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.txtManufacturer = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtCores = new System.Windows.Forms.TextBox();
            this.txtCacheL3 = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.txtTechProcess = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkIsOnSale = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWarrantyPeriod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad_Click_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave_Click_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(1, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 423);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.toolStrip1);
            this.panel.Controls.Add(this.txtYear);
            this.panel.Controls.Add(this.txtManufacturer);
            this.panel.Controls.Add(this.txtCountry);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtModel);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.label1);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.ForeColor = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(8, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(763, 385);
            this.panel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(628, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 93);
            this.panel3.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave_Click,
            this.btnLoad_Click});
            this.toolStrip1.Location = new System.Drawing.Point(0, 360);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.RightToLeftAutoMirrorImage = true;
            this.btnSave_Click.Size = new System.Drawing.Size(70, 22);
            this.btnSave_Click.Text = "Сохранить";
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // btnLoad_Click
            // 
            this.btnLoad_Click.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad_Click.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad_Click.Name = "btnLoad_Click";
            this.btnLoad_Click.Size = new System.Drawing.Size(65, 22);
            this.btnLoad_Click.Text = "Загрузить";
            this.btnLoad_Click.Click += new System.EventHandler(this.btnLoad_Click_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(510, 37);
            this.txtYear.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.txtYear.Minimum = new decimal(new int[] {
            1971,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(68, 20);
            this.txtYear.TabIndex = 11;
            this.txtYear.Value = new decimal(new int[] {
            1971,
            0,
            0,
            0});
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.FormattingEnabled = true;
            this.txtManufacturer.Location = new System.Drawing.Point(170, 33);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(121, 21);
            this.txtManufacturer.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(403, 36);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(68, 20);
            this.txtCountry.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Страна";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(302, 36);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(42, 20);
            this.txtModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Производитель";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Персональные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtSlot);
            this.panel1.Controls.Add(this.txtCores);
            this.panel1.Controls.Add(this.txtCacheL3);
            this.panel1.Controls.Add(this.txtFrequency);
            this.panel1.Controls.Add(this.txtTechProcess);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 385);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(630, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 93);
            this.panel4.TabIndex = 14;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(428, 43);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(38, 20);
            this.txtSlot.TabIndex = 10;
            // 
            // txtCores
            // 
            this.txtCores.Location = new System.Drawing.Point(349, 43);
            this.txtCores.Name = "txtCores";
            this.txtCores.Size = new System.Drawing.Size(30, 20);
            this.txtCores.TabIndex = 9;
            // 
            // txtCacheL3
            // 
            this.txtCacheL3.Location = new System.Drawing.Point(222, 44);
            this.txtCacheL3.Name = "txtCacheL3";
            this.txtCacheL3.Size = new System.Drawing.Size(80, 20);
            this.txtCacheL3.TabIndex = 8;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(117, 44);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(61, 20);
            this.txtFrequency.TabIndex = 7;
            // 
            // txtTechProcess
            // 
            this.txtTechProcess.Location = new System.Drawing.Point(21, 44);
            this.txtTechProcess.Name = "txtTechProcess";
            this.txtTechProcess.Size = new System.Drawing.Size(69, 20);
            this.txtTechProcess.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Слот";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ядра";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Кэш-память L3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Частота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Техпроцесс";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Специальные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtPoints);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.chkIsOnSale);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtWarrantyPeriod);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtpProductionDate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 385);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(628, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 93);
            this.panel5.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(497, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Акция";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(417, 43);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(37, 20);
            this.txtPoints.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(339, 44);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(45, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // chkIsOnSale
            // 
            this.chkIsOnSale.AutoSize = true;
            this.chkIsOnSale.Location = new System.Drawing.Point(497, 43);
            this.chkIsOnSale.Name = "chkIsOnSale";
            this.chkIsOnSale.Size = new System.Drawing.Size(57, 17);
            this.chkIsOnSale.TabIndex = 6;
            this.chkIsOnSale.Text = "Акция";
            this.chkIsOnSale.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Баллы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Цена";
            // 
            // txtWarrantyPeriod
            // 
            this.txtWarrantyPeriod.Location = new System.Drawing.Point(199, 43);
            this.txtWarrantyPeriod.Name = "txtWarrantyPeriod";
            this.txtWarrantyPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtWarrantyPeriod.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Гарантийный срок";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.Location = new System.Drawing.Point(21, 44);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(140, 20);
            this.dtpProductionDate.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Дата производства";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(788, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad_Click_1,
            this.btnSave_Click_1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // btnLoad_Click_1
            // 
            this.btnLoad_Click_1.Name = "btnLoad_Click_1";
            this.btnLoad_Click_1.Size = new System.Drawing.Size(133, 22);
            this.btnLoad_Click_1.Text = "Загрузить";
            this.btnLoad_Click_1.Click += new System.EventHandler(this.OpenFileDialog);
            // 
            // btnSave_Click_1
            // 
            this.btnSave_Click_1.Name = "btnSave_Click_1";
            this.btnSave_Click_1.Size = new System.Drawing.Size(133, 22);
            this.btnSave_Click_1.Text = "Сохранить";
            this.btnSave_Click_1.Click += new System.EventHandler(this.SaveFileDialog);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Text = "Выход";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem5.Text = "Справка";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem6.Text = "О программе";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel.Text = "Загружаемся...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Процессоры";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtCores;
        private System.Windows.Forms.TextBox txtCacheL3;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtTechProcess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkIsOnSale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWarrantyPeriod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.ComboBox txtManufacturer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnLoad_Click_1;
        private System.Windows.Forms.ToolStripMenuItem btnSave_Click_1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave_Click;
        private System.Windows.Forms.ToolStripButton btnLoad_Click;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

