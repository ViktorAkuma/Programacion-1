
namespace API_Pokemon
{
    partial class Pokemon
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
            dataGridPokedex = new DataGridView();
            labelNom = new Label();
            NomTextBox = new TextBox();
            labelTipo = new Label();
            TipoTextBox = new TextBox();
            buttonSalir = new FontAwesome.Sharp.IconButton();
            labelGen = new Label();
            textBoxGen = new TextBox();
            labelEvo = new Label();
            textBoxEvo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPokedex).BeginInit();
            SuspendLayout();
            // 
            // dataGridPokedex
            // 
            dataGridPokedex.AllowUserToAddRows = false;
            dataGridPokedex.AllowUserToDeleteRows = false;
            dataGridPokedex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPokedex.GridColor = SystemColors.Info;
            dataGridPokedex.Location = new Point(370, 12);
            dataGridPokedex.Name = "dataGridPokedex";
            dataGridPokedex.ReadOnly = true;
            dataGridPokedex.RowHeadersWidth = 51;
            dataGridPokedex.Size = new Size(418, 426);
            dataGridPokedex.TabIndex = 0;
            dataGridPokedex.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(12, 9);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(64, 20);
            labelNom.TabIndex = 1;
            labelNom.Text = "Nombre";
            // 
            // NomTextBox
            // 
            NomTextBox.Location = new Point(139, 6);
            NomTextBox.Name = "NomTextBox";
            NomTextBox.Size = new Size(125, 27);
            NomTextBox.TabIndex = 2;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(12, 66);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(39, 20);
            labelTipo.TabIndex = 3;
            labelTipo.Text = "Tipo";
            // 
            // TipoTextBox
            // 
            TipoTextBox.Location = new Point(139, 63);
            TipoTextBox.Name = "TipoTextBox";
            TipoTextBox.Size = new Size(125, 27);
            TipoTextBox.TabIndex = 4;
            // 
            // ButtonSalir
            // 
            buttonSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            buttonSalir.IconColor = Color.Black;
            buttonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSalir.Location = new Point(12, 409);
            buttonSalir.Name = "ButtonSalir";
            buttonSalir.Size = new Size(333, 29);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir de la Pokedex";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Location = new Point(12, 123);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(84, 20);
            labelGen.TabIndex = 6;
            labelGen.Text = "Generación";
            // 
            // textBoxGen
            // 
            textBoxGen.Location = new Point(139, 123);
            textBoxGen.Name = "textBoxGen";
            textBoxGen.Size = new Size(125, 27);
            textBoxGen.TabIndex = 7;
            // 
            // labelEvo
            // 
            labelEvo.AutoSize = true;
            labelEvo.Location = new Point(12, 192);
            labelEvo.Name = "labelEvo";
            labelEvo.Size = new Size(73, 20);
            labelEvo.TabIndex = 8;
            labelEvo.Text = "Evolución";
            labelEvo.Click += this.labelEvo_Click;
            // 
            // EvoTextBox
            // 
            textBoxEvo.Location = new Point(139, 189);
            textBoxEvo.Name = "EvoTextBox";
            textBoxEvo.Size = new Size(125, 27);
            textBoxEvo.TabIndex = 9;
            // 
            // Pokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEvo);
            Controls.Add(labelEvo);
            Controls.Add(textBoxGen);
            Controls.Add(labelGen);
            Controls.Add(buttonSalir);
            Controls.Add(TipoTextBox);
            Controls.Add(labelTipo);
            Controls.Add(NomTextBox);
            Controls.Add(labelNom);
            Controls.Add(dataGridPokedex);
            Name = "Pokemon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)dataGridPokedex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPokedex;
        private Label labelNom;
        private TextBox NomTextBox;
        private Label labelTipo;
        private TextBox TipoTextBox;
        private FontAwesome.Sharp.IconButton buttonSalir;
        private Label labelGen;
        private TextBox textBoxGen;
        private Label labelEvo;
        private TextBox textBoxEvo;
        private EventHandler labelEvo_Click;

        public DataGridViewCellEventHandler dataGridView1_CellContentClick { get; private set; }
    }
}
