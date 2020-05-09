namespace PaintMe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBufferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьВБуферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BinaryPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьПоследнееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.penSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.penWidthPanel = new System.Windows.Forms.Panel();
            this.penSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.resolutionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.borderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.borderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripSeparator4,
            this.openToolStripMenuItem,
            this.loadBufferToolStripMenuItem});
            this.imageToolStripMenuItem.Image = global::PaintMe.Properties.Resources.addIcon;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.imageToolStripMenuItem.Text = "Новое изображение";
            this.imageToolStripMenuItem.ToolTipText = "Новое изображение";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // loadBufferToolStripMenuItem
            // 
            this.loadBufferToolStripMenuItem.Name = "loadBufferToolStripMenuItem";
            this.loadBufferToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.loadBufferToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.loadBufferToolStripMenuItem.Text = "Вставить из буфера";
            this.loadBufferToolStripMenuItem.Click += new System.EventHandler(this.loadBufferToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.копироватьВБуферToolStripMenuItem});
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.ToolTipText = "Сохранение";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // копироватьВБуферToolStripMenuItem
            // 
            this.копироватьВБуферToolStripMenuItem.Name = "копироватьВБуферToolStripMenuItem";
            this.копироватьВБуферToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьВБуферToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.копироватьВБуферToolStripMenuItem.Text = "Копировать в буфер";
            this.копироватьВБуферToolStripMenuItem.Click += new System.EventHandler(this.copyToBufferToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.BinaryPictureToolStripMenuItem,
            this.ColorScrollToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.filtersToolStripMenuItem.Text = "Фильтры";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.invertToolStripMenuItem.Text = "Инверсия";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Чёрно-белый";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // BinaryPictureToolStripMenuItem
            // 
            this.BinaryPictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.monoToolStripMenuItem});
            this.BinaryPictureToolStripMenuItem.Name = "BinaryPictureToolStripMenuItem";
            this.BinaryPictureToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.BinaryPictureToolStripMenuItem.Text = "Недостаток тонов";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.colorToolStripMenuItem.Text = "Цветной";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorBinaryPictureToolStripMenuItem_Click);
            // 
            // monoToolStripMenuItem
            // 
            this.monoToolStripMenuItem.Name = "monoToolStripMenuItem";
            this.monoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.monoToolStripMenuItem.Text = "Монохромный";
            this.monoToolStripMenuItem.Click += new System.EventHandler(this.monoBinaryPictureToolStripMenuItem_Click);
            // 
            // ColorScrollToolStripMenuItem
            // 
            this.ColorScrollToolStripMenuItem.Name = "ColorScrollToolStripMenuItem";
            this.ColorScrollToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ColorScrollToolStripMenuItem.Text = "Сдвиг каналов";
            this.ColorScrollToolStripMenuItem.Click += new System.EventHandler(this.colorScrollToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьПоследнееToolStripMenuItem,
            this.сброситьВсёToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // отменитьПоследнееToolStripMenuItem
            // 
            this.отменитьПоследнееToolStripMenuItem.Name = "отменитьПоследнееToolStripMenuItem";
            this.отменитьПоследнееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьПоследнееToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отменитьПоследнееToolStripMenuItem.Text = "Отменить последнее";
            this.отменитьПоследнееToolStripMenuItem.Click += new System.EventHandler(this.backButton_Click);
            // 
            // сброситьВсёToolStripMenuItem
            // 
            this.сброситьВсёToolStripMenuItem.Name = "сброситьВсёToolStripMenuItem";
            this.сброситьВсёToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.сброситьВсёToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.сброситьВсёToolStripMenuItem.Text = "Сбросить всё";
            this.сброситьВсёToolStripMenuItem.Click += new System.EventHandler(this.rebootButton_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebootUIToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.programToolStripMenuItem.Text = "Программа";
            // 
            // rebootUIToolStripMenuItem
            // 
            this.rebootUIToolStripMenuItem.Name = "rebootUIToolStripMenuItem";
            this.rebootUIToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rebootUIToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.rebootUIToolStripMenuItem.Text = "Сброс интерфейса";
            this.rebootUIToolStripMenuItem.Click += new System.EventHandler(this.rebootUIToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.penSizeTrackBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colorPanel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.penWidthPanel);
            this.groupBox1.Controls.Add(this.penSizeNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры кисти";
            // 
            // penSizeTrackBar
            // 
            this.penSizeTrackBar.Location = new System.Drawing.Point(15, 26);
            this.penSizeTrackBar.Maximum = 1000;
            this.penSizeTrackBar.Minimum = 1;
            this.penSizeTrackBar.Name = "penSizeTrackBar";
            this.penSizeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.penSizeTrackBar.Size = new System.Drawing.Size(45, 196);
            this.penSizeTrackBar.TabIndex = 6;
            this.penSizeTrackBar.TabStop = false;
            this.penSizeTrackBar.TickFrequency = 0;
            this.penSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.penSizeTrackBar.Value = 1;
            this.penSizeTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цвет";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(66, 81);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(102, 20);
            this.colorPanel.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.colorPanel, "Цвет кисти");
            this.colorPanel.BackColorChanged += new System.EventHandler(this.colorPanel_BackColorChanged);
            this.colorPanel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер";
            // 
            // penWidthPanel
            // 
            this.penWidthPanel.BackColor = System.Drawing.Color.Transparent;
            this.penWidthPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.penWidthPanel.Location = new System.Drawing.Point(66, 107);
            this.penWidthPanel.Name = "penWidthPanel";
            this.penWidthPanel.Size = new System.Drawing.Size(102, 115);
            this.penWidthPanel.TabIndex = 8;
            // 
            // penSizeNumericUpDown
            // 
            this.penSizeNumericUpDown.BackColor = System.Drawing.Color.White;
            this.penSizeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penSizeNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.penSizeNumericUpDown.Location = new System.Drawing.Point(66, 42);
            this.penSizeNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.penSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeNumericUpDown.Name = "penSizeNumericUpDown";
            this.penSizeNumericUpDown.Size = new System.Drawing.Size(102, 20);
            this.penSizeNumericUpDown.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.penSizeNumericUpDown, "Толщина кисти в пикселях");
            this.penSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penSizeNumericUpDown.ValueChanged += new System.EventHandler(this.UpdatePenWidthElem);
            this.penSizeNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.penSizeNumericUpDown_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolutionToolStripStatusLabel,
            this.mainToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // resolutionToolStripStatusLabel
            // 
            this.resolutionToolStripStatusLabel.Name = "resolutionToolStripStatusLabel";
            this.resolutionToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.resolutionToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // mainToolStripProgressBar
            // 
            this.mainToolStripProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.mainToolStripProgressBar.Maximum = 150;
            this.mainToolStripProgressBar.Name = "mainToolStripProgressBar";
            this.mainToolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.mainToolStripProgressBar.Step = 1;
            this.mainToolStripProgressBar.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Все файлы (*.*)|*.*|Изображения (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            this.openFileDialog1.Title = "Открыть изображение";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Новый рисунок";
            this.saveFileDialog1.Filter = "Все файлы|*.*|JPEG (.jpeg)|*.jpeg|PNG (.png)|*.png|GIF (.gif)|*.gif|BMP (.bmp)|*." +
    "bmp";
            this.saveFileDialog1.Title = "Сохранить изображение";
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPanel.Controls.Add(this.pictureBox1);
            this.borderPanel.Location = new System.Drawing.Point(180, 27);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(592, 509);
            this.borderPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.borderPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.borderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.NumericUpDown penSizeNumericUpDown;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar mainToolStripProgressBar;
        private System.Windows.Forms.Panel penWidthPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BinaryPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorScrollToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel resolutionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem loadBufferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьВБуферToolStripMenuItem;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьПоследнееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьВсёToolStripMenuItem;
        private System.Windows.Forms.TrackBar penSizeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel borderPanel;
        private System.ComponentModel.BackgroundWorker mainBackgroundWorker;
    }
}

