
namespace Testing_XML
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SureNameBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.AppendBox = new System.Windows.Forms.GroupBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DataGridCastom = new System.Windows.Forms.DataGridView();
            this.AppendBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCastom)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(15, 55);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(165, 28);
            this.NameBox.TabIndex = 2;
            // 
            // SureNameBox
            // 
            this.SureNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SureNameBox.Location = new System.Drawing.Point(15, 124);
            this.SureNameBox.Multiline = true;
            this.SureNameBox.Name = "SureNameBox";
            this.SureNameBox.Size = new System.Drawing.Size(165, 28);
            this.SureNameBox.TabIndex = 3;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightBlue;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(195, 55);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(159, 28);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurNameLabel.Location = new System.Drawing.Point(12, 100);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(71, 18);
            this.SurNameLabel.TabIndex = 7;
            this.SurNameLabel.Text = "SurName";
            // 
            // AppendBox
            // 
            this.AppendBox.BackColor = System.Drawing.Color.DarkCyan;
            this.AppendBox.Controls.Add(this.EditBtn);
            this.AppendBox.Controls.Add(this.DeleteBtn);
            this.AppendBox.Controls.Add(this.AddBtn);
            this.AppendBox.Controls.Add(this.SurNameLabel);
            this.AppendBox.Controls.Add(this.NameBox);
            this.AppendBox.Controls.Add(this.SureNameBox);
            this.AppendBox.Controls.Add(this.NameLabel);
            this.AppendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppendBox.Location = new System.Drawing.Point(12, 17);
            this.AppendBox.Name = "AppendBox";
            this.AppendBox.Size = new System.Drawing.Size(370, 175);
            this.AppendBox.TabIndex = 9;
            this.AppendBox.TabStop = false;
            this.AppendBox.Text = "Tools";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightBlue;
            this.EditBtn.Enabled = false;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(195, 90);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(159, 28);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(195, 124);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(159, 28);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DataGridCastom
            // 
            this.DataGridCastom.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridCastom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCastom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCastom.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCastom.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCastom.Location = new System.Drawing.Point(12, 198);
            this.DataGridCastom.Name = "DataGridCastom";
            this.DataGridCastom.RowHeadersWidth = 70;
            this.DataGridCastom.Size = new System.Drawing.Size(370, 358);
            this.DataGridCastom.TabIndex = 12;
            this.DataGridCastom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCastom_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(394, 568);
            this.Controls.Add(this.DataGridCastom);
            this.Controls.Add(this.AppendBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Parsing";
            this.AppendBox.ResumeLayout(false);
            this.AppendBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCastom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SureNameBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.GroupBox AppendBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView DataGridCastom;
    }
}

