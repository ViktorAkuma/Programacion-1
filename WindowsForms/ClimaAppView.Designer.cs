namespace WindowsForms
{
    partial class ClimaAppView
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
            toolStrip1 = new ToolStrip();
            BotonNosotrosView = new FontAwesome.Sharp.IconToolStripButton();
            btnSalirApp = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton3 = new FontAwesome.Sharp.IconToolStripButton();
            labelTituloApp = new Label();
            iconToolStripButton4 = new FontAwesome.Sharp.IconToolStripButton();
            menuStrip1 = new MenuStrip();
            acercaDe = new FontAwesome.Sharp.IconMenuItem();
            subMenuNosotros = new FontAwesome.Sharp.IconMenuItem();
            salir = new FontAwesome.Sharp.IconMenuItem();
            subMenuSalirdelaApp = new FontAwesome.Sharp.IconMenuItem();
            iconToolStripButton5 = new FontAwesome.Sharp.IconToolStripButton();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BotonNosotrosView, btnSalirApp });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 47);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // BotonNosotrosView
            // 
            BotonNosotrosView.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BotonNosotrosView.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BotonNosotrosView.IconColor = Color.Black;
            BotonNosotrosView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonNosotrosView.IconSize = 40;
            BotonNosotrosView.ImageScaling = ToolStripItemImageScaling.None;
            BotonNosotrosView.ImageTransparentColor = Color.Magenta;
            BotonNosotrosView.Name = "BotonNosotrosView";
            BotonNosotrosView.Size = new Size(44, 44);
            BotonNosotrosView.Text = "Nosotros View";
            BotonNosotrosView.ToolTipText = "Nosotros";
            BotonNosotrosView.Click += iconToolStripButton1_Click;
            // 
            // btnSalirApp
            // 
            btnSalirApp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalirApp.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalirApp.IconColor = Color.Black;
            btnSalirApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalirApp.IconSize = 40;
            btnSalirApp.ImageScaling = ToolStripItemImageScaling.None;
            btnSalirApp.ImageTransparentColor = Color.Magenta;
            btnSalirApp.Name = "btnSalirApp";
            btnSalirApp.Size = new Size(44, 44);
            btnSalirApp.Text = "iconToolStripButton2";
            btnSalirApp.Click += iconToolStripButton2_Click;
            // 
            // iconToolStripButton3
            // 
            iconToolStripButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton3.IconColor = Color.Black;
            iconToolStripButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton3.Name = "iconToolStripButton3";
            iconToolStripButton3.Size = new Size(23, 23);
            iconToolStripButton3.Text = "iconToolStripButton3";
            // 
            // labelTituloApp
            // 
            labelTituloApp.AutoSize = true;
            labelTituloApp.Location = new Point(280, 400);
            labelTituloApp.Name = "labelTituloApp";
            labelTituloApp.Size = new Size(346, 20);
            labelTituloApp.TabIndex = 2;
            labelTituloApp.Text = "App del Clima de Hoy - ISPN20 - 2do año - TSDS";
            labelTituloApp.Click += label1_Click;
            // 
            // iconToolStripButton4
            // 
            iconToolStripButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton4.IconColor = Color.Black;
            iconToolStripButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton4.Name = "iconToolStripButton4";
            iconToolStripButton4.Size = new Size(23, 23);
            iconToolStripButton4.Text = "iconToolStripButton4";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { acercaDe, salir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // acercaDe
            // 
            acercaDe.DropDownItems.AddRange(new ToolStripItem[] { subMenuNosotros });
            acercaDe.IconChar = FontAwesome.Sharp.IconChar.House;
            acercaDe.IconColor = Color.Black;
            acercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            acercaDe.Name = "acercaDe";
            acercaDe.Size = new Size(118, 24);
            acercaDe.Text = "Acerca de...";
            // 
            // subMenuNosotros
            // 
            subMenuNosotros.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            subMenuNosotros.IconColor = Color.Black;
            subMenuNosotros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuNosotros.Name = "subMenuNosotros";
            subMenuNosotros.Size = new Size(224, 26);
            subMenuNosotros.Text = "Nosotros";
            subMenuNosotros.Click += iconMenuItem1_Click;
            // 
            // salir
            // 
            salir.DropDownItems.AddRange(new ToolStripItem[] { subMenuSalirdelaApp });
            salir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            salir.IconColor = Color.Black;
            salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salir.Name = "salir";
            salir.Size = new Size(72, 24);
            salir.Text = "Salir";
            // 
            // subMenuSalirdelaApp
            // 
            subMenuSalirdelaApp.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            subMenuSalirdelaApp.IconColor = Color.Black;
            subMenuSalirdelaApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuSalirdelaApp.Name = "subMenuSalirdelaApp";
            subMenuSalirdelaApp.Size = new Size(224, 26);
            subMenuSalirdelaApp.Text = "Salir de la App";
            subMenuSalirdelaApp.Click += subMenuSalirdelaApp_Click;
            // 
            // iconToolStripButton5
            // 
            iconToolStripButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton5.IconColor = Color.Black;
            iconToolStripButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton5.Name = "iconToolStripButton5";
            iconToolStripButton5.Size = new Size(23, 23);
            iconToolStripButton5.Text = "iconToolStripButton5";
            // 
            // ClimaAppView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(labelTituloApp);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "ClimaAppView";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "App del Clima de Hoy: 2° año TSDS";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton BotonNosotrosView;
        private FontAwesome.Sharp.IconToolStripButton btnSalirApp;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton3;
        private Label labelTituloApp;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton4;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton5;
        private FontAwesome.Sharp.IconMenuItem acercaDe;
        private FontAwesome.Sharp.IconMenuItem salir;
        private FontAwesome.Sharp.IconMenuItem subMenuSalirdelaApp;
        private FontAwesome.Sharp.IconMenuItem subMenuNosotros;
    }
}