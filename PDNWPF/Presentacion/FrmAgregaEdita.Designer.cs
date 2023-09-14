namespace PDNWPF.Presentacion
{
    partial class FrmAgregaEdita
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtSaldo = new TextBox();
            txtAm = new TextBox();
            txtAp = new TextBox();
            label6 = new Label();
            dtmFechaN = new DateTimePicker();
            dropArea = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 220);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de nacimiento";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 172);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Area";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 129);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 82);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido Paterno";
            label5.Click += label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(292, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(160, 257);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(292, 23);
            txtSaldo.TabIndex = 6;
            txtSaldo.TextChanged += textBox2_TextChanged;
            txtSaldo.KeyDown += textBox2_KeyDown;
            txtSaldo.KeyPress += textBox2_KeyPress;
            // 
            // txtAm
            // 
            txtAm.Location = new Point(160, 121);
            txtAm.Name = "txtAm";
            txtAm.Size = new Size(292, 23);
            txtAm.TabIndex = 7;
            // 
            // txtAp
            // 
            txtAp.Location = new Point(160, 74);
            txtAp.Name = "txtAp";
            txtAp.Size = new Size(292, 23);
            txtAp.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 265);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 9;
            label6.Text = "Sueldo";
            label6.Click += label6_Click;
            // 
            // dtmFechaN
            // 
            dtmFechaN.Location = new Point(160, 214);
            dtmFechaN.Name = "dtmFechaN";
            dtmFechaN.Size = new Size(292, 23);
            dtmFechaN.TabIndex = 10;
            dtmFechaN.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dropArea
            // 
            dropArea.FormattingEnabled = true;
            dropArea.Location = new Point(160, 164);
            dropArea.Name = "dropArea";
            dropArea.Size = new Size(292, 23);
            dropArea.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(356, 303);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmAgregaEdita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 371);
            Controls.Add(button1);
            Controls.Add(dropArea);
            Controls.Add(dtmFechaN);
            Controls.Add(label6);
            Controls.Add(txtAp);
            Controls.Add(txtAm);
            Controls.Add(txtSaldo);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAgregaEdita";
            Text = "Form1";
            Load += FrmAgregaEdita_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtSaldo;
        private TextBox txtAm;
        private TextBox txtAp;
        private Label label6;
        private DateTimePicker dtmFechaN;
        private ComboBox dropArea;
        private Button button1;
    }
}