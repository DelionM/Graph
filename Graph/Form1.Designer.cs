namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.txtr1 = new System.Windows.Forms.TextBox();
            this.txtr2 = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tp1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblp1 = new System.Windows.Forms.Label();
            this.lbly1 = new System.Windows.Forms.Label();
            this.lbly2 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblp2 = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrafica = new System.Windows.Forms.Label();
            this.btnProcedimiento = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtx1
            // 
            this.txtx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx1.Location = new System.Drawing.Point(151, 90);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(51, 19);
            this.txtx1.TabIndex = 0;
            this.txtx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtx1.TextChanged += new System.EventHandler(this.txtx1_TextChanged);
            this.txtx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtx1_KeyPress);
            // 
            // txty1
            // 
            this.txty1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txty1.Location = new System.Drawing.Point(236, 90);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(51, 19);
            this.txty1.TabIndex = 1;
            this.txty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txty1.TextChanged += new System.EventHandler(this.txty1_TextChanged);
            this.txty1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txty1_KeyPress);
            // 
            // txtr1
            // 
            this.txtr1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtr1.Location = new System.Drawing.Point(336, 90);
            this.txtr1.Name = "txtr1";
            this.txtr1.Size = new System.Drawing.Size(51, 19);
            this.txtr1.TabIndex = 2;
            this.txtr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtr1.TextChanged += new System.EventHandler(this.txtr1_TextChanged);
            this.txtr1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtr1_KeyPress);
            // 
            // txtr2
            // 
            this.txtr2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtr2.Location = new System.Drawing.Point(336, 142);
            this.txtr2.Name = "txtr2";
            this.txtr2.Size = new System.Drawing.Size(51, 19);
            this.txtr2.TabIndex = 5;
            this.txtr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtr2.TextChanged += new System.EventHandler(this.txtr2_TextChanged);
            this.txtr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtr2_KeyPress);
            // 
            // txty2
            // 
            this.txty2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txty2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txty2.Location = new System.Drawing.Point(236, 142);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(51, 19);
            this.txty2.TabIndex = 4;
            this.txty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txty2.TextChanged += new System.EventHandler(this.txty2_TextChanged);
            this.txty2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txty2_KeyPress);
            // 
            // txtx2
            // 
            this.txtx2.BackColor = System.Drawing.SystemColors.Window;
            this.txtx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx2.Location = new System.Drawing.Point(151, 142);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(51, 19);
            this.txtx2.TabIndex = 3;
            this.txtx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtx2.TextChanged += new System.EventHandler(this.txtx2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "=";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.Location = new System.Drawing.Point(162, 240);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(24, 25);
            this.lblx.TabIndex = 12;
            this.lblx.Text = "x";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.BackColor = System.Drawing.Color.Transparent;
            this.lbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.Location = new System.Drawing.Point(162, 276);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(24, 25);
            this.lbly.TabIndex = 13;
            this.lbly.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(489, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingrese su sistema de ecuaciones lineales de 2x2";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y_1,
            this.Y_2});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv1.Location = new System.Drawing.Point(565, 48);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.Size = new System.Drawing.Size(201, 250);
            this.dgv1.TabIndex = 15;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y_1
            // 
            this.Y_1.HeaderText = "Y1";
            this.Y_1.Name = "Y_1";
            this.Y_1.ReadOnly = true;
            // 
            // Y_2
            // 
            this.Y_2.HeaderText = "Y2";
            this.Y_2.Name = "Y_2";
            this.Y_2.ReadOnly = true;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso1.Location = new System.Drawing.Point(31, 54);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(67, 24);
            this.lblPaso1.TabIndex = 20;
            this.lblPaso1.Text = "Paso 1";
            // 
            // lblp1
            // 
            this.lblp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp1.Location = new System.Drawing.Point(32, 77);
            this.lblp1.Name = "lblp1";
            this.lblp1.Size = new System.Drawing.Size(527, 40);
            this.lblp1.TabIndex = 21;
            this.lblp1.Text = "Se despeja una variable en ambas ecuaciones, (por lo general Y). Los despejes de " +
    "tu sistema de ecuaciones son los siguientes:";
            // 
            // lbly1
            // 
            this.lbly1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly1.Location = new System.Drawing.Point(222, 129);
            this.lbly1.Name = "lbly1";
            this.lbly1.Size = new System.Drawing.Size(189, 21);
            this.lbly1.TabIndex = 22;
            this.lbly1.Text = "Y1 =";
            // 
            // lbly2
            // 
            this.lbly2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly2.Location = new System.Drawing.Point(222, 150);
            this.lbly2.Name = "lbly2";
            this.lbly2.Size = new System.Drawing.Size(189, 21);
            this.lbly2.TabIndex = 23;
            this.lbly2.Text = "Y2 =";
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso2.Location = new System.Drawing.Point(31, 179);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(67, 24);
            this.lblPaso2.TabIndex = 24;
            this.lblPaso2.Text = "Paso 2";
            // 
            // lblp2
            // 
            this.lblp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp2.Location = new System.Drawing.Point(32, 203);
            this.lblp2.Name = "lblp2";
            this.lblp2.Size = new System.Drawing.Size(470, 74);
            this.lblp2.TabIndex = 25;
            this.lblp2.Text = resources.GetString("lblp2.Text");
            // 
            // lblTabla
            // 
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(566, 301);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(204, 15);
            this.lblTabla.TabIndex = 26;
            this.lblTabla.Text = "Tabla 1. Puntos (X,Y) para graficar.";
            // 
            // ch1
            // 
            this.ch1.BackColor = System.Drawing.Color.Transparent;
            this.ch1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.ch1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ch1.Legends.Add(legend5);
            this.ch1.Location = new System.Drawing.Point(491, 51);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(344, 250);
            this.ch1.TabIndex = 28;
            this.ch1.Text = "chart1";
            // 
            // lblGrafica
            // 
            this.lblGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafica.Location = new System.Drawing.Point(492, 304);
            this.lblGrafica.Name = "lblGrafica";
            this.lblGrafica.Size = new System.Drawing.Size(356, 19);
            this.lblGrafica.TabIndex = 29;
            this.lblGrafica.Text = "Gráfica 1. Representación gráfica del sistema de ecuaciones.";
            // 
            // btnProcedimiento
            // 
            this.btnProcedimiento.BackColor = System.Drawing.Color.GhostWhite;
            this.btnProcedimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcedimiento.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnProcedimiento.FlatAppearance.BorderSize = 2;
            this.btnProcedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcedimiento.Image = global::Graph.Properties.Resources._585e47b5cb11b227491c338b___copia30;
            this.btnProcedimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcedimiento.Location = new System.Drawing.Point(300, 266);
            this.btnProcedimiento.Name = "btnProcedimiento";
            this.btnProcedimiento.Size = new System.Drawing.Size(144, 35);
            this.btnProcedimiento.TabIndex = 18;
            this.btnProcedimiento.Text = "Procedimiento";
            this.btnProcedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcedimiento.UseVisualStyleBackColor = false;
            this.btnProcedimiento.Click += new System.EventHandler(this.btnProcedimiento_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.GhostWhite;
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnResultado.FlatAppearance.BorderSize = 2;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Image = global::Graph.Properties.Resources._585e47accb11b227491c338a30;
            this.btnResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultado.Location = new System.Drawing.Point(22, 287);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(123, 36);
            this.btnResultado.TabIndex = 27;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Graph.Properties.Resources.limpiar30;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(277, 190);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 35);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Graph.Properties.Resources.icons8_hojas_de_cálculo30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(151, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calcular";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(103, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 83);
            this.lbl1.TabIndex = 30;
            this.lbl1.Text = "{";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 343);
            this.Controls.Add(this.lblGrafica);
            this.Controls.Add(this.btnProcedimiento);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblPaso2);
            this.Controls.Add(this.lblPaso1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtr2);
            this.Controls.Add(this.txty2);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtr1);
            this.Controls.Add(this.txty1);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblp1);
            this.Controls.Add(this.lbly1);
            this.Controls.Add(this.lblp2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.lbly2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Graficador de sistemas de ecuaciones lineales 2x2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.TextBox txtr1;
        private System.Windows.Forms.TextBox txtr2;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.ToolTip tp1;
        private System.Windows.Forms.Button btnProcedimiento;
        private System.Windows.Forms.Label lblp2;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lbly2;
        private System.Windows.Forms.Label lbly1;
        private System.Windows.Forms.Label lblp1;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1;
        private System.Windows.Forms.Label lblGrafica;
        private System.Windows.Forms.Label lbl1;
    }
}

