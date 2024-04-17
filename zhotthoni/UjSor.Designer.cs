namespace zhotthoni
{
    partial class UjSor
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
            textBox5 = new TextBox();
            kerdesekBindingSource = new BindingSource(components);
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)kerdesekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "V1", true));
            textBox5.Location = new Point(45, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(347, 23);
            textBox5.TabIndex = 5;
            // 
            // kerdesekBindingSource
            // 
            kerdesekBindingSource.DataSource = typeof(kerdesek);
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "Kerdes", true));
            textBox6.Location = new Point(45, 73);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(347, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "Szam", true));
            textBox7.Location = new Point(45, 35);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(347, 23);
            textBox7.TabIndex = 7;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "V2", true));
            textBox1.Location = new Point(227, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "V3", true));
            textBox2.Location = new Point(235, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "Kep", true));
            textBox3.Location = new Point(243, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", kerdesekBindingSource, "HelyesValasz", true));
            textBox4.Location = new Point(251, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(347, 23);
            textBox4.TabIndex = 12;
            // 
            // UjSor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Name = "UjSor";
            Text = "UjSor";
            Load += UjSor_Load;
            ((System.ComponentModel.ISupportInitialize)kerdesekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private BindingSource kerdesekBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}