
namespace AlgorithmDijkstra
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
            this.DrawLinebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.Xlabel = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Vertex1label = new System.Windows.Forms.Label();
            this.Vetex2label = new System.Windows.Forms.Label();
            this.Vetex1numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Vetex2numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LenghtNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForAlgorithmNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.ForAlgorithmNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddRandomGraphButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CountVertexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CountEdgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FloydButton = new System.Windows.Forms.Button();
            this.ResetColorButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetex1numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetex2numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForAlgorithmNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForAlgorithmNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountVertexNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEdgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawLinebutton
            // 
            this.DrawLinebutton.BackColor = System.Drawing.Color.Transparent;
            this.DrawLinebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawLinebutton.Location = new System.Drawing.Point(12, 285);
            this.DrawLinebutton.Name = "DrawLinebutton";
            this.DrawLinebutton.Size = new System.Drawing.Size(120, 30);
            this.DrawLinebutton.TabIndex = 1;
            this.DrawLinebutton.Text = "Соединить веришны";
            this.DrawLinebutton.UseVisualStyleBackColor = false;
            this.DrawLinebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(554, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVertexButton.Location = new System.Drawing.Point(19, 95);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(120, 30);
            this.AddVertexButton.TabIndex = 3;
            this.AddVertexButton.Text = "Добавить веришну";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(16, 34);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(97, 13);
            this.Xlabel.TabIndex = 4;
            this.Xlabel.Text = "Координаты по X:";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(119, 32);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX.TabIndex = 5;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(119, 59);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownY.TabIndex = 7;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(16, 61);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(97, 13);
            this.Ylabel.TabIndex = 6;
            this.Ylabel.Text = "Координаты по Y:";
            // 
            // Vertex1label
            // 
            this.Vertex1label.AutoSize = true;
            this.Vertex1label.Location = new System.Drawing.Point(16, 191);
            this.Vertex1label.Name = "Vertex1label";
            this.Vertex1label.Size = new System.Drawing.Size(64, 13);
            this.Vertex1label.TabIndex = 8;
            this.Vertex1label.Text = "Вершина 1:";
            // 
            // Vetex2label
            // 
            this.Vetex2label.AutoSize = true;
            this.Vetex2label.Location = new System.Drawing.Point(16, 220);
            this.Vetex2label.Name = "Vetex2label";
            this.Vetex2label.Size = new System.Drawing.Size(64, 13);
            this.Vetex2label.TabIndex = 9;
            this.Vetex2label.Text = "Веришна 2:";
            // 
            // Vetex1numericUpDown
            // 
            this.Vetex1numericUpDown.Location = new System.Drawing.Point(104, 184);
            this.Vetex1numericUpDown.Name = "Vetex1numericUpDown";
            this.Vetex1numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Vetex1numericUpDown.TabIndex = 10;
            // 
            // Vetex2numericUpDown
            // 
            this.Vetex2numericUpDown.Location = new System.Drawing.Point(104, 213);
            this.Vetex2numericUpDown.Name = "Vetex2numericUpDown";
            this.Vetex2numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Vetex2numericUpDown.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Длинна  ребра:";
            // 
            // LenghtNumericUpDown
            // 
            this.LenghtNumericUpDown.Location = new System.Drawing.Point(104, 244);
            this.LenghtNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LenghtNumericUpDown.Name = "LenghtNumericUpDown";
            this.LenghtNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LenghtNumericUpDown.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Добавить связь между вершинами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Найти кратчайший путь между вершинами";
            // 
            // ForAlgorithmNumeric2
            // 
            this.ForAlgorithmNumeric2.Location = new System.Drawing.Point(365, 213);
            this.ForAlgorithmNumeric2.Name = "ForAlgorithmNumeric2";
            this.ForAlgorithmNumeric2.Size = new System.Drawing.Size(120, 20);
            this.ForAlgorithmNumeric2.TabIndex = 18;
            // 
            // ForAlgorithmNumeric1
            // 
            this.ForAlgorithmNumeric1.Location = new System.Drawing.Point(365, 184);
            this.ForAlgorithmNumeric1.Name = "ForAlgorithmNumeric1";
            this.ForAlgorithmNumeric1.Size = new System.Drawing.Size(120, 20);
            this.ForAlgorithmNumeric1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "В вершину:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Из вершины:";
            // 
            // FindButton
            // 
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Location = new System.Drawing.Point(273, 261);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(120, 30);
            this.FindButton.TabIndex = 20;
            this.FindButton.Text = "Dijkstra";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(270, 302);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(143, 13);
            this.ResultLabel.TabIndex = 21;
            this.ResultLabel.Text = "Наименьшая длинна  пути:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1148, 321);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(97, 36);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddRandomGraphButton
            // 
            this.AddRandomGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRandomGraphButton.Location = new System.Drawing.Point(275, 95);
            this.AddRandomGraphButton.Name = "AddRandomGraphButton";
            this.AddRandomGraphButton.Size = new System.Drawing.Size(120, 30);
            this.AddRandomGraphButton.TabIndex = 23;
            this.AddRandomGraphButton.Text = "Создать";
            this.AddRandomGraphButton.UseVisualStyleBackColor = true;
            this.AddRandomGraphButton.Click += new System.EventHandler(this.AddRandomGraphButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Создать случайный граф";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Количество вершин:";
            // 
            // CountVertexNumericUpDown
            // 
            this.CountVertexNumericUpDown.Location = new System.Drawing.Point(390, 32);
            this.CountVertexNumericUpDown.Name = "CountVertexNumericUpDown";
            this.CountVertexNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountVertexNumericUpDown.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Количество связей";
            // 
            // CountEdgeNumericUpDown
            // 
            this.CountEdgeNumericUpDown.Location = new System.Drawing.Point(390, 59);
            this.CountEdgeNumericUpDown.Name = "CountEdgeNumericUpDown";
            this.CountEdgeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CountEdgeNumericUpDown.TabIndex = 30;
            // 
            // FloydButton
            // 
            this.FloydButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FloydButton.Location = new System.Drawing.Point(399, 261);
            this.FloydButton.Name = "FloydButton";
            this.FloydButton.Size = new System.Drawing.Size(120, 30);
            this.FloydButton.TabIndex = 31;
            this.FloydButton.Text = "Floyd";
            this.FloydButton.UseVisualStyleBackColor = true;
            this.FloydButton.Click += new System.EventHandler(this.FloydButton_Click);
            // 
            // ResetColorButton
            // 
            this.ResetColorButton.Location = new System.Drawing.Point(1045, 321);
            this.ResetColorButton.Name = "ResetColorButton";
            this.ResetColorButton.Size = new System.Drawing.Size(97, 36);
            this.ResetColorButton.TabIndex = 32;
            this.ResetColorButton.Text = "Сбросить цвета";
            this.ResetColorButton.UseVisualStyleBackColor = true;
            this.ResetColorButton.Click += new System.EventHandler(this.ResetColorButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Создать вершину по координтам";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 365);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResetColorButton);
            this.Controls.Add(this.FloydButton);
            this.Controls.Add(this.CountEdgeNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CountVertexNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddRandomGraphButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForAlgorithmNumeric2);
            this.Controls.Add(this.ForAlgorithmNumeric1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LenghtNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vetex2numericUpDown);
            this.Controls.Add(this.Vetex1numericUpDown);
            this.Controls.Add(this.Vetex2label);
            this.Controls.Add(this.Vertex1label);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.AddVertexButton);
            this.Controls.Add(this.DrawLinebutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetex1numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetex2numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForAlgorithmNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForAlgorithmNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountVertexNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountEdgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawLinebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label Vertex1label;
        private System.Windows.Forms.Label Vetex2label;
        private System.Windows.Forms.NumericUpDown Vetex1numericUpDown;
        private System.Windows.Forms.NumericUpDown Vetex2numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LenghtNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ForAlgorithmNumeric2;
        private System.Windows.Forms.NumericUpDown ForAlgorithmNumeric1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddRandomGraphButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CountVertexNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CountEdgeNumericUpDown;
        private System.Windows.Forms.Button FloydButton;
        private System.Windows.Forms.Button ResetColorButton;
        private System.Windows.Forms.Label label9;
    }
}

