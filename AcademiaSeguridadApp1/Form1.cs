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
            progressContrase�a = new ProgressBar();
            Usuario = new Label();
            Contrase�a = new Label();
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
            progressContrase�a.Location = new Point(302, 349);
            progressContrase�a.Name = "progressBar2";
            progressContrase�a.Size = new Size(173, 39);
            progressContrase�a.TabIndex = 1;
            progressContrase�a.Click += progressBar2_Click;
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
            Contrase�a.AutoSize = true;
            Contrase�a.Location = new Point(226, 359);
            Contrase�a.Name = "label2";
            Contrase�a.Size = new Size(59, 20);
            Contrase�a.TabIndex = 3;
            Contrase�a.Text = "Usuario";
            Contrase�a.Click += label2_Click;
            // 
            // AcademiaTiroSeguridad
            // 
            ClientSize = new Size(796, 515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressContrase�a);
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

        private ProgressBar progressContrase�a;

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private Label Usuario;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label Contrase�a;

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
