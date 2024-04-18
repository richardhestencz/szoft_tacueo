namespace ZH2_tacueo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            konyvIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szerzoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kiadasEveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oldalszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            infokBindingSource = new BindingSource(components);
            Betoltes = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { konyvIDDataGridViewTextBoxColumn, szerzoDataGridViewTextBoxColumn, cimDataGridViewTextBoxColumn, kiadasEveDataGridViewTextBoxColumn, oldalszamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = infokBindingSource;
            dataGridView1.Location = new Point(26, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(627, 334);
            dataGridView1.TabIndex = 0;
            // 
            // konyvIDDataGridViewTextBoxColumn
            // 
            konyvIDDataGridViewTextBoxColumn.DataPropertyName = "KonyvID";
            konyvIDDataGridViewTextBoxColumn.HeaderText = "KonyvID";
            konyvIDDataGridViewTextBoxColumn.Name = "konyvIDDataGridViewTextBoxColumn";
            // 
            // szerzoDataGridViewTextBoxColumn
            // 
            szerzoDataGridViewTextBoxColumn.DataPropertyName = "Szerzo";
            szerzoDataGridViewTextBoxColumn.HeaderText = "Szerzo";
            szerzoDataGridViewTextBoxColumn.Name = "szerzoDataGridViewTextBoxColumn";
            // 
            // cimDataGridViewTextBoxColumn
            // 
            cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            cimDataGridViewTextBoxColumn.HeaderText = "Cim";
            cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            // 
            // kiadasEveDataGridViewTextBoxColumn
            // 
            kiadasEveDataGridViewTextBoxColumn.DataPropertyName = "KiadasEve";
            kiadasEveDataGridViewTextBoxColumn.HeaderText = "KiadasEve";
            kiadasEveDataGridViewTextBoxColumn.Name = "kiadasEveDataGridViewTextBoxColumn";
            // 
            // oldalszamDataGridViewTextBoxColumn
            // 
            oldalszamDataGridViewTextBoxColumn.DataPropertyName = "Oldalszam";
            oldalszamDataGridViewTextBoxColumn.HeaderText = "Oldalszam";
            oldalszamDataGridViewTextBoxColumn.Name = "oldalszamDataGridViewTextBoxColumn";
            // 
            // infokBindingSource
            // 
            infokBindingSource.DataSource = typeof(Infok);
            // 
            // Betoltes
            // 
            Betoltes.Location = new Point(713, 12);
            Betoltes.Name = "Betoltes";
            Betoltes.Size = new Size(75, 23);
            Betoltes.TabIndex = 1;
            Betoltes.Text = "Mentés";
            Betoltes.UseVisualStyleBackColor = true;
            Betoltes.Click += Betoltes_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Betöltés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(713, 406);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Új sor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(632, 406);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Törlés";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(26, 12);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 5;
            button5.Text = "Érdekességek";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Betoltes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)infokBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Betoltes;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn konyvIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szerzoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kiadasEveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oldalszamDataGridViewTextBoxColumn;
        private BindingSource infokBindingSource;
    }
}