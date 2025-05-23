namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTask = new System.Windows.Forms.Label();
            this.txbTask = new System.Windows.Forms.TextBox();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.lblTaskk = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.txbResp = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pibTask = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.grbTask = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.grbTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Marlett", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTask.Location = new System.Drawing.Point(162, 35);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(244, 41);
            this.lblTask.TabIndex = 1;
            this.lblTask.Text = "Task Manager";
            // 
            // txbTask
            // 
            this.txbTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txbTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTask.ForeColor = System.Drawing.Color.White;
            this.txbTask.Location = new System.Drawing.Point(151, 32);
            this.txbTask.Name = "txbTask";
            this.txbTask.Size = new System.Drawing.Size(231, 19);
            this.txbTask.TabIndex = 2;
            // 
            // grbAdd
            // 
            this.grbAdd.Controls.Add(this.btnDelete);
            this.grbAdd.Controls.Add(this.btnAdd);
            this.grbAdd.Controls.Add(this.lblDate);
            this.grbAdd.Controls.Add(this.dtpLimite);
            this.grbAdd.Controls.Add(this.cmbSector);
            this.grbAdd.Controls.Add(this.lblSector);
            this.grbAdd.Controls.Add(this.txbResp);
            this.grbAdd.Controls.Add(this.lblResp);
            this.grbAdd.Controls.Add(this.lblTaskk);
            this.grbAdd.Controls.Add(this.txbTask);
            this.grbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbAdd.Location = new System.Drawing.Point(18, 117);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(476, 246);
            this.grbAdd.TabIndex = 3;
            this.grbAdd.TabStop = false;
            this.grbAdd.Text = "Adicionar";
            // 
            // lblTaskk
            // 
            this.lblTaskk.AutoSize = true;
            this.lblTaskk.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskk.Location = new System.Drawing.Point(36, 32);
            this.lblTaskk.Name = "lblTaskk";
            this.lblTaskk.Size = new System.Drawing.Size(109, 19);
            this.lblTaskk.TabIndex = 3;
            this.lblTaskk.Text = "Nome da Tarefa:";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(6, 62);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(140, 19);
            this.lblResp.TabIndex = 4;
            this.lblResp.Text = "Nome do Resposável:";
            // 
            // txbResp
            // 
            this.txbResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txbResp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResp.ForeColor = System.Drawing.Color.White;
            this.txbResp.Location = new System.Drawing.Point(151, 62);
            this.txbResp.Name = "txbResp";
            this.txbResp.Size = new System.Drawing.Size(231, 19);
            this.txbResp.TabIndex = 5;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(101, 99);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(44, 19);
            this.lblSector.TabIndex = 6;
            this.lblSector.Text = "Setor:";
            // 
            // cmbSector
            // 
            this.cmbSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cmbSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSector.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSector.ForeColor = System.Drawing.Color.White;
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(151, 93);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(237, 29);
            this.cmbSector.Sorted = true;
            this.cmbSector.TabIndex = 7;
            // 
            // dtpLimite
            // 
            this.dtpLimite.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLimite.CalendarForeColor = System.Drawing.Color.White;
            this.dtpLimite.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtpLimite.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpLimite.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpLimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpLimite.Location = new System.Drawing.Point(151, 137);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(231, 20);
            this.dtpLimite.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(63, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Data Limite: ";
            // 
            // pibTask
            // 
            this.pibTask.Image = global::TaskManager.Properties.Resources.task;
            this.pibTask.Location = new System.Drawing.Point(103, 13);
            this.pibTask.Name = "pibTask";
            this.pibTask.Size = new System.Drawing.Size(53, 80);
            this.pibTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTask.TabIndex = 0;
            this.pibTask.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(151, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AllowUserToResizeColumns = false;
            this.dgvTask.AllowUserToResizeRows = false;
            this.dgvTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTask.Location = new System.Drawing.Point(6, 19);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTask.RowTemplate.ReadOnly = true;
            this.dgvTask.Size = new System.Drawing.Size(464, 274);
            this.dgvTask.TabIndex = 4;
            // 
            // grbTask
            // 
            this.grbTask.Controls.Add(this.dgvTask);
            this.grbTask.ForeColor = System.Drawing.Color.White;
            this.grbTask.Location = new System.Drawing.Point(18, 381);
            this.grbTask.Name = "grbTask";
            this.grbTask.Size = new System.Drawing.Size(476, 299);
            this.grbTask.TabIndex = 5;
            this.grbTask.TabStop = false;
            this.grbTask.Text = "Tarefas";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(288, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(535, 692);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.pibTask);
            this.Controls.Add(this.grbAdd);
            this.Controls.Add(this.grbTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.grbTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txbTask;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.TextBox txbResp;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label lblTaskk;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.GroupBox grbTask;
        private System.Windows.Forms.Button btnDelete;
    }
}

