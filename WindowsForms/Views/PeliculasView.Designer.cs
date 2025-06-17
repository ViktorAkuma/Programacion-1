namespace WindowsForms.Views
{
    public partial class PeliculasView
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
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            GridPeliculas = new DataGridView();
            FilmPicture = new PictureBox();
            TabPagesLista = new TabControl();
            TabLista = new TabPage();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label2 = new Label();
            TabAgregarEditar = new TabPage();
            NumericCalificacion = new NumericUpDown();
            NumericDuracion = new NumericUpDown();
            textBox4 = new TextBox();
            label = new Label();
            labelDuracion = new Label();
            labelPortada = new Label();
            textBox2 = new TextBox();
            labelTitulo = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            TabPagesLista.SuspendLayout();
            TabLista.SuspendLayout();
            statusStrip1.SuspendLayout();
            TabAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.BackColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(889, 147);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 49);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.BackColor = Color.White;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(889, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "&Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Display;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(889, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 52);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(889, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 52);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // GridPeliculas
            // 
            GridPeliculas.AllowUserToAddRows = false;
            GridPeliculas.AllowUserToDeleteRows = false;
            GridPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPeliculas.Location = new Point(6, 92);
            GridPeliculas.Name = "GridPeliculas";
            GridPeliculas.ReadOnly = true;
            GridPeliculas.RowHeadersWidth = 51;
            GridPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPeliculas.Size = new Size(667, 358);
            GridPeliculas.TabIndex = 5;
            GridPeliculas.SelectionChanged += GridPeliculas_SelectionChanged;
            // 
            // FilmPicture
            // 
            FilmPicture.Location = new Point(679, 92);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(204, 358);
            FilmPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FilmPicture.TabIndex = 6;
            FilmPicture.TabStop = false;
            // 
            // TabPagesLista
            // 
            TabPagesLista.Controls.Add(TabLista);
            TabPagesLista.Controls.Add(TabAgregarEditar);
            TabPagesLista.Location = new Point(12, 83);
            TabPagesLista.Name = "TabPagesLista";
            TabPagesLista.SelectedIndex = 0;
            TabPagesLista.Size = new Size(1040, 533);
            TabPagesLista.TabIndex = 7;
            // 
            // TabLista
            // 
            TabLista.Controls.Add(statusStrip1);
            TabLista.Controls.Add(btnBuscar);
            TabLista.Controls.Add(textBox1);
            TabLista.Controls.Add(label2);
            TabLista.Controls.Add(GridPeliculas);
            TabLista.Controls.Add(btnSalir);
            TabLista.Controls.Add(FilmPicture);
            TabLista.Controls.Add(btnEliminar);
            TabLista.Controls.Add(btnAgregar);
            TabLista.Controls.Add(btnModificar);
            TabLista.Location = new Point(4, 29);
            TabLista.Name = "TabLista";
            TabLista.Padding = new Padding(3);
            TabLista.Size = new Size(1032, 500);
            TabLista.TabIndex = 0;
            TabLista.Text = "Lista";
            TabLista.UseVisualStyleBackColor = true;
            TabLista.Click += tabPage1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage, toolStripStatusLabel1, toolStripStatusLabel3, toolStripStatusLabel2, toolStripStatusLabel4, toolStripStatusLabel5 });
            statusStrip1.Location = new Point(3, 471);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1026, 26);
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(151, 20);
            toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            toolStripStatusLabel5.Click += toolStripStatusLabel5_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.AllowDrop = true;
            btnBuscar.Anchor = AnchorStyles.Bottom;
            btnBuscar.BackColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(889, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 49);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(816, 27);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 11;
            label2.Text = "Buscar:";
            label2.Click += label2_Click;
            // 
            // TabAgregarEditar
            // 
            TabAgregarEditar.Controls.Add(NumericCalificacion);
            TabAgregarEditar.Controls.Add(NumericDuracion);
            TabAgregarEditar.Controls.Add(textBox4);
            TabAgregarEditar.Controls.Add(label);
            TabAgregarEditar.Controls.Add(labelDuracion);
            TabAgregarEditar.Controls.Add(labelPortada);
            TabAgregarEditar.Controls.Add(textBox2);
            TabAgregarEditar.Controls.Add(labelTitulo);
            TabAgregarEditar.Controls.Add(BtnCancelar);
            TabAgregarEditar.Controls.Add(BtnGuardar);
            TabAgregarEditar.Location = new Point(4, 29);
            TabAgregarEditar.Name = "TabAgregarEditar";
            TabAgregarEditar.Padding = new Padding(3);
            TabAgregarEditar.Size = new Size(1032, 500);
            TabAgregarEditar.TabIndex = 1;
            TabAgregarEditar.Text = "Agregar/Editar";
            TabAgregarEditar.UseVisualStyleBackColor = true;
            TabAgregarEditar.Click += TabAgregarEditar_Click;
            // 
            // NumericCalificacion
            // 
            NumericCalificacion.DecimalPlaces = 2;
            NumericCalificacion.Location = new Point(434, 276);
            NumericCalificacion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericCalificacion.Name = "NumericCalificacion";
            NumericCalificacion.Size = new Size(150, 27);
            NumericCalificacion.TabIndex = 13;
            // 
            // NumericDuracion
            // 
            NumericDuracion.Location = new Point(434, 198);
            NumericDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericDuracion.Name = "NumericDuracion";
            NumericDuracion.Size = new Size(150, 27);
            NumericDuracion.TabIndex = 12;
            NumericDuracion.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 27);
            textBox4.TabIndex = 10;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(264, 278);
            label.Name = "label";
            label.Size = new Size(89, 20);
            label.TabIndex = 8;
            label.Text = "Calificación:";
            // 
            // labelDuracion
            // 
            labelDuracion.AutoSize = true;
            labelDuracion.Location = new Point(264, 198);
            labelDuracion.Name = "labelDuracion";
            labelDuracion.Size = new Size(149, 20);
            labelDuracion.TabIndex = 7;
            labelDuracion.Text = "Duración en Minutos:";
            // 
            // labelPortada
            // 
            labelPortada.AutoSize = true;
            labelPortada.Location = new Point(264, 123);
            labelPortada.Name = "labelPortada";
            labelPortada.Size = new Size(63, 20);
            labelPortada.TabIndex = 6;
            labelPortada.Text = "Portada:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 27);
            textBox2.TabIndex = 5;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(264, 50);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(50, 20);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Titulo:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.BackColor = Color.White;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(535, 385);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(137, 49);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.BackColor = Color.White;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(264, 385);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(137, 49);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 65);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Serif Lao", 18F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 49);
            label1.TabIndex = 0;
            label1.Text = "Películas";
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1064, 648);
            Controls.Add(panel1);
            Controls.Add(TabPagesLista);
            Name = "PeliculasView";
            Load += PeliculasView_Load;
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            TabPagesLista.ResumeLayout(false);
            TabLista.ResumeLayout(false);
            TabLista.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TabAgregarEditar.ResumeLayout(false);
            TabAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView GridPeliculas;
        private PictureBox FilmPicture;
        private TabControl TabPagesLista;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox textBox4;
        private Label label;
        private Label labelDuracion;
        private Label labelPortada;
        private TextBox textBox2;
        private Label labelTitulo;
        private NumericUpDown NumericDuracion;
        private NumericUpDown NumericCalificacion;
        private TabPage TabLista;
        private TabPage TabAgregarEditar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer TimerStatusBar;
    }
}