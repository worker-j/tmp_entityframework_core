namespace GetStartedWinform
{
    partial class Form_codeMaster1
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
            components = new System.ComponentModel.Container();
            button_close = new Button();
            dataGridView1 = new DataGridView();
            dataMastercellBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button_insert = new Button();
            button_save = new Button();
            cellModeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cellTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cellLockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemCellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lotCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataMastercellBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button_close
            // 
            button_close.Location = new Point(685, 8);
            button_close.Name = "button_close";
            button_close.Size = new Size(75, 23);
            button_close.TabIndex = 0;
            button_close.Text = "close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cellModeDataGridViewTextBoxColumn, cellTypeDataGridViewTextBoxColumn, cellLockDataGridViewTextBoxColumn, deliveryDataGridViewTextBoxColumn, itemCodeDataGridViewTextBoxColumn, itemCellDataGridViewTextBoxColumn, lotCountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dataMastercellBindingSource;
            dataGridView1.Location = new Point(13, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 338);
            dataGridView1.TabIndex = 1;
            // 
            // dataMastercellBindingSource
            // 
            dataMastercellBindingSource.DataSource = typeof(Model.DataMaster_cell);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "CellMode";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "CellType";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 75);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "CellLock";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(268, 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 11);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 10;
            label4.Text = "Delivery";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(268, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 42);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "ItemCode";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(268, 71);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 75);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "ItemCell";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(454, 8);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 12);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "LotCount";
            // 
            // button_insert
            // 
            button_insert.Location = new Point(574, 8);
            button_insert.Name = "button_insert";
            button_insert.Size = new Size(75, 23);
            button_insert.TabIndex = 18;
            button_insert.Text = "Insert";
            button_insert.UseVisualStyleBackColor = true;
            button_insert.Click += button_insert_Click;
            // 
            // button_save
            // 
            button_save.Location = new Point(574, 38);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 19;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            // 
            // cellModeDataGridViewTextBoxColumn
            // 
            cellModeDataGridViewTextBoxColumn.DataPropertyName = "CellMode";
            cellModeDataGridViewTextBoxColumn.HeaderText = "CellMode";
            cellModeDataGridViewTextBoxColumn.Name = "cellModeDataGridViewTextBoxColumn";
            cellModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellTypeDataGridViewTextBoxColumn
            // 
            cellTypeDataGridViewTextBoxColumn.DataPropertyName = "CellType";
            cellTypeDataGridViewTextBoxColumn.HeaderText = "CellType";
            cellTypeDataGridViewTextBoxColumn.Name = "cellTypeDataGridViewTextBoxColumn";
            cellTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellLockDataGridViewTextBoxColumn
            // 
            cellLockDataGridViewTextBoxColumn.DataPropertyName = "CellLock";
            cellLockDataGridViewTextBoxColumn.HeaderText = "CellLock";
            cellLockDataGridViewTextBoxColumn.Name = "cellLockDataGridViewTextBoxColumn";
            cellLockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            deliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            itemCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCellDataGridViewTextBoxColumn
            // 
            itemCellDataGridViewTextBoxColumn.DataPropertyName = "itemCell";
            itemCellDataGridViewTextBoxColumn.HeaderText = "itemCell";
            itemCellDataGridViewTextBoxColumn.Name = "itemCellDataGridViewTextBoxColumn";
            itemCellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lotCountDataGridViewTextBoxColumn
            // 
            lotCountDataGridViewTextBoxColumn.DataPropertyName = "LotCount";
            lotCountDataGridViewTextBoxColumn.HeaderText = "LotCount";
            lotCountDataGridViewTextBoxColumn.Name = "lotCountDataGridViewTextBoxColumn";
            lotCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_codeMaster1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(button_save);
            Controls.Add(button_insert);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button_close);
            Name = "Form_codeMaster1";
            Text = "Form_codeMaster1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataMastercellBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_close;
        private DataGridView dataGridView1;
        private BindingSource dataMastercellBindingSource;
        private DataGridViewTextBoxColumn dataMastercellIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rowNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bayNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelNoDataGridViewTextBoxColumn;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button_insert;
        private Button button_save;
        private DataGridViewTextBoxColumn cellModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellLockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lotCountDataGridViewTextBoxColumn;
    }
}