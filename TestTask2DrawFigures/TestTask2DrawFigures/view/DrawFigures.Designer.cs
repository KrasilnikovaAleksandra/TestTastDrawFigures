namespace TestTask2DrawFigures
{
    partial class DrawFigures
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateFigure = new System.Windows.Forms.Button();
            this.textBoxForWriteDescrideFigure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateFigure
            // 
            this.buttonCreateFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCreateFigure.Location = new System.Drawing.Point(474, 100);
            this.buttonCreateFigure.Name = "buttonCreateFigure";
            this.buttonCreateFigure.Size = new System.Drawing.Size(115, 32);
            this.buttonCreateFigure.TabIndex = 0;
            this.buttonCreateFigure.Text = "Нарисовать!";
            this.buttonCreateFigure.UseVisualStyleBackColor = true;
            this.buttonCreateFigure.Click += new System.EventHandler(this.buttonCreateFigure_Click);
            // 
            // textBoxForWriteDescrideFigure
            // 
            this.textBoxForWriteDescrideFigure.Location = new System.Drawing.Point(222, 41);
            this.textBoxForWriteDescrideFigure.Multiline = true;
            this.textBoxForWriteDescrideFigure.Name = "textBoxForWriteDescrideFigure";
            this.textBoxForWriteDescrideFigure.Size = new System.Drawing.Size(550, 53);
            this.textBoxForWriteDescrideFigure.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите текстовую строку \r\nописания фигуры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp.Location = new System.Drawing.Point(678, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(94, 32);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 69);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(394, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 276);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // DrawFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreateFigure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForWriteDescrideFigure);
            this.Controls.Add(this.buttonHelp);
            this.Name = "DrawFigures";
            this.Text = "Draw figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateFigure;
        private System.Windows.Forms.TextBox textBoxForWriteDescrideFigure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

