namespace SystemReliability
{
    partial class SystemReliabilityForm
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ProbBlockGB = new System.Windows.Forms.GroupBox();
            this.BlockC_TB = new System.Windows.Forms.TextBox();
            this.BlockC_Label = new System.Windows.Forms.Label();
            this.BlockB_TB = new System.Windows.Forms.TextBox();
            this.BlockB_Label = new System.Windows.Forms.Label();
            this.BlockA_TB = new System.Windows.Forms.TextBox();
            this.BlockA_Label = new System.Windows.Forms.Label();
            this.ExampleBtn = new System.Windows.Forms.Button();
            this.TestsCount_TB = new System.Windows.Forms.TextBox();
            this.TestCount_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ProbBlockGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemReliability.Properties.Resources.SchemeScr;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Enabled = false;
            this.CalcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcBtn.Location = new System.Drawing.Point(488, 249);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(84, 23);
            this.CalcBtn.TabIndex = 1;
            this.CalcBtn.Text = "Вычислить";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ProbBlockGB
            // 
            this.ProbBlockGB.Controls.Add(this.BlockC_TB);
            this.ProbBlockGB.Controls.Add(this.BlockC_Label);
            this.ProbBlockGB.Controls.Add(this.BlockB_TB);
            this.ProbBlockGB.Controls.Add(this.BlockB_Label);
            this.ProbBlockGB.Controls.Add(this.BlockA_TB);
            this.ProbBlockGB.Controls.Add(this.BlockA_Label);
            this.ProbBlockGB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProbBlockGB.Location = new System.Drawing.Point(333, 33);
            this.ProbBlockGB.Name = "ProbBlockGB";
            this.ProbBlockGB.Size = new System.Drawing.Size(255, 105);
            this.ProbBlockGB.TabIndex = 2;
            this.ProbBlockGB.TabStop = false;
            this.ProbBlockGB.Text = "Вероятности безотказной работы блоков:";
            // 
            // BlockC_TB
            // 
            this.BlockC_TB.Location = new System.Drawing.Point(75, 73);
            this.BlockC_TB.Name = "BlockC_TB";
            this.BlockC_TB.Size = new System.Drawing.Size(164, 23);
            this.BlockC_TB.TabIndex = 5;
            this.BlockC_TB.TextChanged += new System.EventHandler(this.Block_TB_TextChanged);
            this.BlockC_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Block_TB_KeyPress);
            // 
            // BlockC_Label
            // 
            this.BlockC_Label.AutoSize = true;
            this.BlockC_Label.Location = new System.Drawing.Point(11, 76);
            this.BlockC_Label.Name = "BlockC_Label";
            this.BlockC_Label.Size = new System.Drawing.Size(45, 15);
            this.BlockC_Label.TabIndex = 4;
            this.BlockC_Label.Text = "Блок C";
            // 
            // BlockB_TB
            // 
            this.BlockB_TB.Location = new System.Drawing.Point(75, 47);
            this.BlockB_TB.Name = "BlockB_TB";
            this.BlockB_TB.Size = new System.Drawing.Size(164, 23);
            this.BlockB_TB.TabIndex = 3;
            this.BlockB_TB.TextChanged += new System.EventHandler(this.Block_TB_TextChanged);
            this.BlockB_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Block_TB_KeyPress);
            // 
            // BlockB_Label
            // 
            this.BlockB_Label.AutoSize = true;
            this.BlockB_Label.Location = new System.Drawing.Point(11, 50);
            this.BlockB_Label.Name = "BlockB_Label";
            this.BlockB_Label.Size = new System.Drawing.Size(44, 15);
            this.BlockB_Label.TabIndex = 2;
            this.BlockB_Label.Text = "Блок B";
            // 
            // BlockA_TB
            // 
            this.BlockA_TB.Location = new System.Drawing.Point(75, 21);
            this.BlockA_TB.Name = "BlockA_TB";
            this.BlockA_TB.Size = new System.Drawing.Size(164, 23);
            this.BlockA_TB.TabIndex = 1;
            this.BlockA_TB.TextChanged += new System.EventHandler(this.Block_TB_TextChanged);
            this.BlockA_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Block_TB_KeyPress);
            // 
            // BlockA_Label
            // 
            this.BlockA_Label.AutoSize = true;
            this.BlockA_Label.Location = new System.Drawing.Point(11, 24);
            this.BlockA_Label.Name = "BlockA_Label";
            this.BlockA_Label.Size = new System.Drawing.Size(45, 15);
            this.BlockA_Label.TabIndex = 0;
            this.BlockA_Label.Text = "Блок A";
            // 
            // ExampleBtn
            // 
            this.ExampleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleBtn.Location = new System.Drawing.Point(333, 249);
            this.ExampleBtn.Name = "ExampleBtn";
            this.ExampleBtn.Size = new System.Drawing.Size(84, 23);
            this.ExampleBtn.TabIndex = 3;
            this.ExampleBtn.Text = "Пример";
            this.ExampleBtn.UseVisualStyleBackColor = true;
            this.ExampleBtn.Click += new System.EventHandler(this.ExampleBtn_Click);
            // 
            // TestsCount_TB
            // 
            this.TestsCount_TB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestsCount_TB.Location = new System.Drawing.Point(380, 163);
            this.TestsCount_TB.Name = "TestsCount_TB";
            this.TestsCount_TB.Size = new System.Drawing.Size(164, 23);
            this.TestsCount_TB.TabIndex = 7;
            this.TestsCount_TB.TextChanged += new System.EventHandler(this.Block_TB_TextChanged);
            // 
            // TestCount_Label
            // 
            this.TestCount_Label.AutoSize = true;
            this.TestCount_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestCount_Label.Location = new System.Drawing.Point(405, 147);
            this.TestCount_Label.Name = "TestCount_Label";
            this.TestCount_Label.Size = new System.Drawing.Size(106, 15);
            this.TestCount_Label.TabIndex = 6;
            this.TestCount_Label.Text = "Число испытаний";
            // 
            // SystemReliabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 312);
            this.Controls.Add(this.TestsCount_TB);
            this.Controls.Add(this.TestCount_Label);
            this.Controls.Add(this.ExampleBtn);
            this.Controls.Add(this.ProbBlockGB);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SystemReliabilityForm";
            this.Text = "Оценка надёжности системы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ProbBlockGB.ResumeLayout(false);
            this.ProbBlockGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.GroupBox ProbBlockGB;
        private System.Windows.Forms.TextBox BlockC_TB;
        private System.Windows.Forms.Label BlockC_Label;
        private System.Windows.Forms.TextBox BlockB_TB;
        private System.Windows.Forms.Label BlockB_Label;
        private System.Windows.Forms.TextBox BlockA_TB;
        private System.Windows.Forms.Label BlockA_Label;
        private System.Windows.Forms.Button ExampleBtn;
        private System.Windows.Forms.TextBox TestsCount_TB;
        private System.Windows.Forms.Label TestCount_Label;
    }
}

