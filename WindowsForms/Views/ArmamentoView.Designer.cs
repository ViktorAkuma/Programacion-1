namespace WindowsForms.Views
{
    partial class ArmamentoView
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
            tabArmamento = new TabControl();
            tabLista = new TabPage();
            tabAgregar = new TabPage();
            panelArma = new Panel();
            labelArma = new Label();
            label1 = new Label();
            tabArmamento.SuspendLayout();
            tabLista.SuspendLayout();
            panelArma.SuspendLayout();
            SuspendLayout();
            // 
            // tabArmamento
            // 
            tabArmamento.Controls.Add(tabLista);
            tabArmamento.Controls.Add(tabAgregar);
            tabArmamento.Location = new Point(12, 89);
            tabArmamento.Name = "tabArmamento";
            tabArmamento.SelectedIndex = 0;
            tabArmamento.Size = new Size(930, 404);
            tabArmamento.TabIndex = 0;
            tabArmamento.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(label1);
            tabLista.Location = new Point(4, 29);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(922, 371);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabAgregar
            // 
            tabAgregar.Location = new Point(4, 29);
            tabAgregar.Name = "tabAgregar";
            tabAgregar.Padding = new Padding(3);
            tabAgregar.Size = new Size(922, 448);
            tabAgregar.TabIndex = 1;
            tabAgregar.Text = "Agregar";
            tabAgregar.UseVisualStyleBackColor = true;
            // 
            // panelArma
            // 
            panelArma.BackColor = Color.Green;
            panelArma.Controls.Add(labelArma);
            panelArma.Location = new Point(12, 12);
            panelArma.Name = "panelArma";
            panelArma.Size = new Size(930, 71);
            panelArma.TabIndex = 1;
            panelArma.Paint += panel1_Paint;
            // 
            // labelArma
            // 
            labelArma.AutoSize = true;
            labelArma.Font = new Font("Trebuchet MS", 20F);
            labelArma.Location = new Point(4, 13);
            labelArma.Name = "labelArma";
            labelArma.Size = new Size(195, 43);
            labelArma.TabIndex = 0;
            labelArma.Text = "Armamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // ArmamentoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 505);
            Controls.Add(panelArma);
            Controls.Add(tabArmamento);
            Name = "ArmamentoView";
            Text = "ArmamentoView";
            tabArmamento.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            panelArma.ResumeLayout(false);
            panelArma.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabArmamento;
        private TabPage tabLista;
        private TabPage tabAgregar;
        private Panel panelArma;
        private Label labelArma;
        private Label label1;
    }
}