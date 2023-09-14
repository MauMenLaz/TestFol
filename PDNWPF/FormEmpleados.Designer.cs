namespace PDNWPF
{
    partial class FormEmpleados
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
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apaternoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amaternoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaCreacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sueldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exaTEmpleado2BindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exaTEmpleado2BindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(847, 450);
            splitContainer1.SplitterDistance = 65;
            splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(362, 23);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 23);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 1;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 23);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idEmpleadoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apaternoDataGridViewTextBoxColumn, amaternoDataGridViewTextBoxColumn, areaDescDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, fechaCreacionDataGridViewTextBoxColumn, sueldoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = exaTEmpleado2BindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(847, 381);
            dataGridView1.TabIndex = 0;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apaternoDataGridViewTextBoxColumn
            // 
            apaternoDataGridViewTextBoxColumn.DataPropertyName = "Apaterno";
            apaternoDataGridViewTextBoxColumn.HeaderText = "Apaterno";
            apaternoDataGridViewTextBoxColumn.Name = "apaternoDataGridViewTextBoxColumn";
            apaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amaternoDataGridViewTextBoxColumn
            // 
            amaternoDataGridViewTextBoxColumn.DataPropertyName = "Amaterno";
            amaternoDataGridViewTextBoxColumn.HeaderText = "Amaterno";
            amaternoDataGridViewTextBoxColumn.Name = "amaternoDataGridViewTextBoxColumn";
            amaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDescDataGridViewTextBoxColumn
            // 
            areaDescDataGridViewTextBoxColumn.DataPropertyName = "areaDesc";
            areaDescDataGridViewTextBoxColumn.HeaderText = "areaDesc";
            areaDescDataGridViewTextBoxColumn.Name = "areaDescDataGridViewTextBoxColumn";
            areaDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            sueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo";
            sueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
            sueldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exaTEmpleado2BindingSource
            // 
            exaTEmpleado2BindingSource.DataSource = typeof(ConexionDatos.ExaTEmpleado2);
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(splitContainer1);
            Name = "FormEmpleados";
            Text = "Empleados";
            Activated += FormEmpleados_Activated;
            Load += FormEmpleados_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exaTEmpleado2BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private BindingSource exaTEmpleado2BindingSource;
    }
}