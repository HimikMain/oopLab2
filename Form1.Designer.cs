﻿namespace Lab1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonArc = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonFifthangle = new System.Windows.Forms.Button();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.labelX5 = new System.Windows.Forms.Label();
            this.labelY4 = new System.Windows.Forms.Label();
            this.labelY5 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSweepAngle = new System.Windows.Forms.TextBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 486);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRect
            // 
            this.buttonRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRect.Location = new System.Drawing.Point(824, 12);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(124, 30);
            this.buttonRect.TabIndex = 1;
            this.buttonRect.TabStop = false;
            this.buttonRect.Text = "Прямоугольник";
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLine.Location = new System.Drawing.Point(694, 12);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(124, 30);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(725, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(855, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(725, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(855, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(93, 26);
            this.textBox4.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(760, 468);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEllipse.Location = new System.Drawing.Point(694, 48);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(124, 30);
            this.buttonEllipse.TabIndex = 8;
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonArc
            // 
            this.buttonArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArc.Location = new System.Drawing.Point(824, 48);
            this.buttonArc.Name = "buttonArc";
            this.buttonArc.Size = new System.Drawing.Size(124, 30);
            this.buttonArc.TabIndex = 9;
            this.buttonArc.Text = "Дуга";
            this.buttonArc.UseVisualStyleBackColor = true;
            this.buttonArc.Click += new System.EventHandler(this.buttonArc_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.Location = new System.Drawing.Point(694, 84);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(124, 30);
            this.buttonTriangle.TabIndex = 11;
            this.buttonTriangle.Text = "Треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonFifthangle
            // 
            this.buttonFifthangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFifthangle.Location = new System.Drawing.Point(824, 84);
            this.buttonFifthangle.Name = "buttonFifthangle";
            this.buttonFifthangle.Size = new System.Drawing.Size(124, 30);
            this.buttonFifthangle.TabIndex = 12;
            this.buttonFifthangle.Text = "Пятиугольник";
            this.buttonFifthangle.UseVisualStyleBackColor = true;
            this.buttonFifthangle.Click += new System.EventHandler(this.buttonFifthangle_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(694, 173);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(25, 20);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "x1";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(725, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(93, 26);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(855, 234);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(93, 26);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(725, 266);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(93, 26);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(855, 266);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(93, 26);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(725, 298);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(93, 26);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(855, 298);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(93, 26);
            this.textBox10.TabIndex = 19;
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY1.Location = new System.Drawing.Point(824, 173);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(25, 20);
            this.labelY1.TabIndex = 20;
            this.labelY1.Text = "y1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.Location = new System.Drawing.Point(694, 205);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(25, 20);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "x2";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY2.Location = new System.Drawing.Point(824, 205);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(25, 20);
            this.labelY2.TabIndex = 22;
            this.labelY2.Text = "y2";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX3.Location = new System.Drawing.Point(694, 237);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(25, 20);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "x3";
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY3.Location = new System.Drawing.Point(824, 237);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(25, 20);
            this.labelY3.TabIndex = 24;
            this.labelY3.Text = "y3";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(695, 333);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(67, 20);
            this.labelWidth.TabIndex = 25;
            this.labelWidth.Text = "Ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(695, 365);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(66, 20);
            this.labelHeight.TabIndex = 26;
            this.labelHeight.Text = "Высота";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX4.Location = new System.Drawing.Point(694, 269);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(25, 20);
            this.labelX4.TabIndex = 27;
            this.labelX4.Text = "x4";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX5.Location = new System.Drawing.Point(694, 301);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(25, 20);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "x5";
            // 
            // labelY4
            // 
            this.labelY4.AutoSize = true;
            this.labelY4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY4.Location = new System.Drawing.Point(824, 269);
            this.labelY4.Name = "labelY4";
            this.labelY4.Size = new System.Drawing.Size(25, 20);
            this.labelY4.TabIndex = 29;
            this.labelY4.Text = "y4";
            // 
            // labelY5
            // 
            this.labelY5.AutoSize = true;
            this.labelY5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY5.Location = new System.Drawing.Point(824, 301);
            this.labelY5.Name = "labelY5";
            this.labelY5.Size = new System.Drawing.Size(25, 20);
            this.labelY5.TabIndex = 30;
            this.labelY5.Text = "y5";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(767, 330);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(181, 26);
            this.textBoxWidth.TabIndex = 31;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(767, 362);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(181, 26);
            this.textBoxHeight.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(695, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Начальный угол";
            // 
            // textBoxStartAngle
            // 
            this.textBoxStartAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartAngle.Location = new System.Drawing.Point(834, 395);
            this.textBoxStartAngle.Name = "textBoxStartAngle";
            this.textBoxStartAngle.Size = new System.Drawing.Size(114, 26);
            this.textBoxStartAngle.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(695, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Конечный угол";
            // 
            // textBoxSweepAngle
            // 
            this.textBoxSweepAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSweepAngle.Location = new System.Drawing.Point(834, 427);
            this.textBoxSweepAngle.Name = "textBoxSweepAngle";
            this.textBoxSweepAngle.Size = new System.Drawing.Size(114, 26);
            this.textBoxSweepAngle.TabIndex = 36;
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Location = new System.Drawing.Point(760, 127);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(124, 30);
            this.buttonColor.TabIndex = 37;
            this.buttonColor.Text = "Выбор цвета";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 510);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textBoxSweepAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStartAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelY5);
            this.Controls.Add(this.labelY4);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonFifthangle);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonArc);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonRect);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Рисуем";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonArc;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonFifthangle;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelX4;
        private System.Windows.Forms.Label labelX5;
        private System.Windows.Forms.Label labelY4;
        private System.Windows.Forms.Label labelY5;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSweepAngle;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

