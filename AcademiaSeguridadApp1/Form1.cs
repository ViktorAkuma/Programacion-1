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
            // progressUsuario
            // 
            progressUsuario.Location = new Point(302, 270);
            progressUsuario.Name = "progressUsuario";
            progressUsuario.Size = new Size(173, 39);
            progressUsuario.TabIndex = 0;
            progressUsuario.Click += progressBar1_Click;
            // 
            // progressContraseña
            // 
            progressContraseña.Location = new Point(302, 349);
            progressContraseña.Name = "progressContraseña";
            progressContraseña.Size = new Size(173, 39);
            progressContraseña.TabIndex = 1;
            progressContraseña.Click += progressBar2_Click;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(212, 280);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(59, 20);
            Usuario.TabIndex = 2;
            Usuario.Text = "Usuario";
            Usuario.Click += label1_Click;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(202, 359);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(83, 20);
            Contraseña.TabIndex = 3;
            Contraseña.Text = "Contraseña";
            Contraseña.Click += label2_Click;
            // 
            // AcademiaTiroSeguridad
            // 
            ClientSize = new Size(796, 515);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Controls.Add(progressContraseña);
            Controls.Add(progressUsuario);
            FormBorderStyle = FormBorderStyle.None;
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
