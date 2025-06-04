namespace WindowsForms.Views
{
    partial class PeliculasView
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
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            GridPeliculas = new DataGridView();
            FilmPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(295, 519);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(470, 519);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(625, 519);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(948, 533);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // GridPeliculas
            // 
            GridPeliculas.AllowUserToAddRows = false;
            GridPeliculas.AllowUserToDeleteRows = false;
            GridPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPeliculas.Location = new Point(26, 21);
            GridPeliculas.Name = "GridPeliculas";
            GridPeliculas.ReadOnly = true;
            GridPeliculas.RowHeadersWidth = 51;
            GridPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPeliculas.Size = new Size(693, 464);
            GridPeliculas.TabIndex = 5;
            GridPeliculas.SelectionChanged += GridPeliculas_SelectionChanged;
            // 
            // FilmPicture
            // 
            FilmPicture.Location = new Point(753, 21);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(289, 464);
            FilmPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FilmPicture.TabIndex = 6;
            FilmPicture.TabStop = false;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 584);
            Controls.Add(FilmPicture);
            Controls.Add(GridPeliculas);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "PeliculasView";
            Text = "PeliculasView";
            Load += PeliculasView_Load;
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView GridPeliculas;
        private PictureBox FilmPicture;
    }
}