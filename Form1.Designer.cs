namespace lab2
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
            this.dgMatrix = new System.Windows.Forms.DataGridView();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAnalitic = new System.Windows.Forms.Button();
            this.btnLobachevskogo = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatrix
            // 
            this.dgMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix.Location = new System.Drawing.Point(12, 12);
            this.dgMatrix.Name = "dgMatrix";
            this.dgMatrix.RowHeadersWidth = 51;
            this.dgMatrix.RowTemplate.Height = 24;
            this.dgMatrix.Size = new System.Drawing.Size(664, 159);
            this.dgMatrix.TabIndex = 0;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(720, 12);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 22);
            this.tbSize.TabIndex = 1;
            this.tbSize.Text = "4";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(720, 53);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 31);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(720, 100);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 31);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(759, 271);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 22);
            this.tbH.TabIndex = 4;
            this.tbH.Text = "0,5";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(759, 233);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 5;
            this.tbB.Text = "5";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(759, 196);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 22);
            this.tbA.TabIndex = 6;
            this.tbA.Text = "-5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "H = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "B = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "A = ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(901, 193);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 292);
            this.listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(35, 257);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(357, 228);
            this.listBox2.TabIndex = 17;
            // 
            // btnAnalitic
            // 
            this.btnAnalitic.Location = new System.Drawing.Point(759, 321);
            this.btnAnalitic.Name = "btnAnalitic";
            this.btnAnalitic.Size = new System.Drawing.Size(88, 31);
            this.btnAnalitic.TabIndex = 18;
            this.btnAnalitic.Text = "Analitics";
            this.btnAnalitic.UseVisualStyleBackColor = true;
            this.btnAnalitic.Click += new System.EventHandler(this.btnAnalitic_Click);
            // 
            // btnLobachevskogo
            // 
            this.btnLobachevskogo.Location = new System.Drawing.Point(35, 196);
            this.btnLobachevskogo.Name = "btnLobachevskogo";
            this.btnLobachevskogo.Size = new System.Drawing.Size(127, 33);
            this.btnLobachevskogo.TabIndex = 19;
            this.btnLobachevskogo.Text = "Lobachevskogo";
            this.btnLobachevskogo.UseVisualStyleBackColor = true;
            this.btnLobachevskogo.Click += new System.EventHandler(this.btnLobachevskogo_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(902, 71);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(283, 100);
            this.listBox3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 527);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnLobachevskogo);
            this.Controls.Add(this.btnAnalitic);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dgMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatrix;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAnalitic;
        private System.Windows.Forms.Button btnLobachevskogo;
        private System.Windows.Forms.ListBox listBox3;
    }
}

