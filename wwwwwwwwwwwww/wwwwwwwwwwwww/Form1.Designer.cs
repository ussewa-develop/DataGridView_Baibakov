namespace wwwwwwwwwwwww
{
    partial class frmMass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість строк n=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість стовбців m=";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(32, 629);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(175, 35);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Вычислить";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(614, 629);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(192, 35);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Завершить работу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(50, 107);
            this.txtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(148, 26);
            this.txtn.TabIndex = 5;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(50, 190);
            this.txtm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(148, 26);
            this.txtm.TabIndex = 6;
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(50, 267);
            this.txtRez.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(330, 182);
            this.txtRez.TabIndex = 7;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(388, 82);
            this.dgvMass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.Size = new System.Drawing.Size(425, 367);
            this.dgvMass.TabIndex = 8;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(327, 629);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(178, 35);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "Очистка полей";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // frmMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.dgvMass);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMass";
            this.Text = "Двувимерні масиви  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button cmdClear;
    }
}

