namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database_moiDataSet = new GUI.database_moiDataSet();
            this.infinityStonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infinityStonesTableAdapter = new GUI.database_moiDataSetTableAdapters.InfinityStonesTableAdapter();
            this.stoneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoneColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_moiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityStonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stoneIDDataGridViewTextBoxColumn,
            this.stoneNameDataGridViewTextBoxColumn,
            this.stoneColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infinityStonesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // database_moiDataSet
            // 
            this.database_moiDataSet.DataSetName = "database_moiDataSet";
            this.database_moiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infinityStonesBindingSource
            // 
            this.infinityStonesBindingSource.DataMember = "InfinityStones";
            this.infinityStonesBindingSource.DataSource = this.database_moiDataSet;
            // 
            // infinityStonesTableAdapter
            // 
            this.infinityStonesTableAdapter.ClearBeforeFill = true;
            // 
            // stoneIDDataGridViewTextBoxColumn
            // 
            this.stoneIDDataGridViewTextBoxColumn.DataPropertyName = "StoneID";
            this.stoneIDDataGridViewTextBoxColumn.HeaderText = "StoneID";
            this.stoneIDDataGridViewTextBoxColumn.Name = "stoneIDDataGridViewTextBoxColumn";
            // 
            // stoneNameDataGridViewTextBoxColumn
            // 
            this.stoneNameDataGridViewTextBoxColumn.DataPropertyName = "StoneName";
            this.stoneNameDataGridViewTextBoxColumn.HeaderText = "StoneName";
            this.stoneNameDataGridViewTextBoxColumn.Name = "stoneNameDataGridViewTextBoxColumn";
            // 
            // stoneColorDataGridViewTextBoxColumn
            // 
            this.stoneColorDataGridViewTextBoxColumn.DataPropertyName = "StoneColor";
            this.stoneColorDataGridViewTextBoxColumn.HeaderText = "StoneColor";
            this.stoneColorDataGridViewTextBoxColumn.Name = "stoneColorDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm bằng ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(111, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "BÀI TẬP 3 LỚP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_moiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityStonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private database_moiDataSet database_moiDataSet;
        private System.Windows.Forms.BindingSource infinityStonesBindingSource;
        private database_moiDataSetTableAdapters.InfinityStonesTableAdapter infinityStonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoneColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

