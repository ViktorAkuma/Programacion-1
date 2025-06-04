namespace API_Pokemon
{
    public partial class Pokemon
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
            labelNom = new Label();
            labelTipo = new Label();
            labelGen = new Label();
            labelEvo = new Label();
            btnSalir = new FontAwesome.Sharp.IconButton();
            GridPokedex = new DataGridView();
            textBoxNom = new TextBox();
            textBoxTipo = new TextBox();
            textBoxGen = new TextBox();
            textBoxEvo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridPokedex).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 12);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(64, 20);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nombre";
            labelNom.Click += labelNom_Click;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(12, 63);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(39, 20);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "Tipo";
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Location = new Point(12, 121);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(84, 20);
            labelGen.TabIndex = 2;
            labelGen.Text = "Generación";
            // 
            // labelEvo
            // 
            labelEvo.AutoSize = true;
            labelEvo.Location = new Point(12, 178);
            labelEvo.Name = "labelEvo";
            labelEvo.Size = new Size(73, 20);
            labelEvo.TabIndex = 3;
            labelEvo.Text = "Evolución";
            // 
            // btnSalir
            // 
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(12, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir de la Pokedex";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // GridPokedex
            // 
            GridPokedex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPokedex.Location = new Point(406, 12);
            GridPokedex.Name = "GridPokedex";
            GridPokedex.RowHeadersWidth = 51;
            GridPokedex.Size = new Size(382, 426);
            GridPokedex.TabIndex = 5;
            GridPokedex.CellContentClick += GridPokedex_CellContentClick;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(139, 12);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(125, 27);
            textBoxNom.TabIndex = 6;
            // 
            // textBoxTipo
            // 
            textBoxTipo.Location = new Point(139, 63);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(125, 27);
            textBoxTipo.TabIndex = 7;
            // 
            // textBoxGen
            // 
            textBoxGen.Location = new Point(139, 118);
            textBoxGen.Name = "textBoxGen";
            textBoxGen.Size = new Size(125, 27);
            textBoxGen.TabIndex = 8;
            // 
            // textBoxEvo
            // 
            textBoxEvo.Location = new Point(139, 175);
            textBoxEvo.Name = "textBoxEvo";
            textBoxEvo.Size = new Size(125, 27);
            textBoxEvo.TabIndex = 9;
            // 
            // Pokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEvo);
            Controls.Add(textBoxGen);
            Controls.Add(textBoxTipo);
            Controls.Add(textBoxNom);
            Controls.Add(GridPokedex);
            Controls.Add(btnSalir);
            Controls.Add(labelEvo);
            Controls.Add(labelGen);
            Controls.Add(labelTipo);
            Controls.Add(labelNom);
            Name = "Pokemon";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridPokedex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion 

        private Label labelNom;
        private Label labelTipo;
        private Label labelGen;
        private Label labelEvo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView GridPokedex;
        private TextBox textBoxNom;
        private TextBox textBoxTipo;
        private TextBox textBoxGen;
        private TextBox textBoxEvo;
    }
}
