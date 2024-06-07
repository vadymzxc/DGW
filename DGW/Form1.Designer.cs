namespace DGW
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMass
            // 
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(302, 12);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.Size = new System.Drawing.Size(474, 366);
            this.dgvMass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество строк n=";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(25, 52);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(110, 20);
            this.txtn.TabIndex = 2;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество столбцов m=";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(28, 129);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(130, 20);
            this.txtm.TabIndex = 4;
            this.txtm.TextChanged += new System.EventHandler(this.txtm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(28, 191);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(249, 187);
            this.txtRez.TabIndex = 6;
            this.txtRez.TextChanged += new System.EventHandler(this.txtRez_TextChanged);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(28, 395);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(118, 23);
            this.cmdStart.TabIndex = 7;
            this.cmdStart.Text = "Вычислить";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(302, 394);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(123, 23);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Очистка полей";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(648, 395);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(109, 23);
            this.cmdExit.TabIndex = 9;
            this.cmdExit.Text = "Завершить работу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMass);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExit;
    }
}

