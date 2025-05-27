namespace AcademiaSeguridadApp1
{
    public partial class AcademiaTiroSeguridad : Form
    {
        public AcademiaTiroSeguridad()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            progressUsuario = new ProgressBar();
            progressContraseña = new ProgressBar();
            Usuario = new Label();
            Contraseña = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressUsuario.Location = new Point(302, 270);
            progressUsuario.Name = "progressBar1";
            progressUsuario.Size = new Size(173, 39);
            progressUsuario.TabIndex = 0;
            progressUsuario.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressContraseña.Location = new Point(302, 349);
            progressContraseña.Name = "progressBar2";
            progressContraseña.Size = new Size(173, 39);
            progressContraseña.TabIndex = 1;
            progressContraseña.Click += progressBar2_Click;
            // 
            // label1
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(226, 279);
            Usuario.Name = "label1";
            Usuario.Size = new Size(59, 20);
            Usuario.TabIndex = 2;
            Usuario.Text = "Usuario";
            Usuario.Click += label1_Click;
            // 
            // label2
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(226, 359);
            Contraseña.Name = "label2";
            Contraseña.Size = new Size(59, 20);
            Contraseña.TabIndex = 3;
            Contraseña.Text = "Usuario";
            Contraseña.Click += label2_Click;
            // 
            // AcademiaTiroSeguridad
            // 
            ClientSize = new Size(796, 515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressContraseña);
            Controls.Add(progressUsuario);
            Name = "AcademiaTiroSeguridad";
            Text = "AcademiaTiroSeguridad";
            Load += AcademiaTiroSeguridad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void AcademiaTiroSeguridad_Load(object sender, EventArgs e)
        {

        }

        private System.ComponentModel.IContainer components;

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private ProgressBar progressUsuario;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private ProgressBar progressContraseña;

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private Label Usuario;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label Contraseña;

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
