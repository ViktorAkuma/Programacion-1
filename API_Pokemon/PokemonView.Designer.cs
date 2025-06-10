namespace API_Pokemon.Views
{
    public partial class PokemonView
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
            labelBuscar = new Label();
            textBoxBuscar = new TextBox();
            GridPokemon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridPokemon).BeginInit();
            SuspendLayout();
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelBuscar.ForeColor = SystemColors.ActiveCaptionText;
            labelBuscar.Location = new Point(28, 37);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(75, 28);
            labelBuscar.TabIndex = 11;
            labelBuscar.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(153, 41);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(125, 27);
            textBoxBuscar.TabIndex = 12;
            textBoxBuscar.Enter += textBoxBuscar_Enter;
            // 
            // GridPokemon
            // 
            GridPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPokemon.Location = new Point(333, 21);
            GridPokemon.Name = "GridPokemon";
            GridPokemon.RowHeadersWidth = 51;
            GridPokemon.Size = new Size(445, 405);
            GridPokemon.TabIndex = 14;
            GridPokemon.CellContentClick += GridPokemon_CellContentClick;
            // 
            // Pokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(GridPokemon);
            Controls.Add(textBoxBuscar);
            Controls.Add(labelBuscar);
            Name = "Pokemon";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxPoke;
        private Label labelBuscar;
        private TextBox textBoxBuscar;
        private DataGridView GridPokemon;
    }
}
