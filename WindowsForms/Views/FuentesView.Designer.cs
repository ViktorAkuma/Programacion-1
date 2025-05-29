namespace WindowsForms.Views
{
    partial class FuentesView
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
            Texto = new Label();
            txt = new TextBox();
            btnAplicar = new Button();
            SuspendLayout();
            // 
            // Texto
            // 
            Texto.AutoSize = true;
            Texto.Location = new Point(151, 56);
            Texto.Name = "Texto";
            Texto.Size = new Size(91, 20);
            Texto.TabIndex = 0;
            Texto.Text = "FuentesView";
            Texto.Click += Texto_Click;
            // 
            // txt
            // 
            txt.Location = new Point(308, 53);
            txt.Name = "txt";
            txt.Size = new Size(125, 27);
            txt.TabIndex = 1;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(469, 52);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(94, 29);
            btnAplicar.TabIndex = 2;
            btnAplicar.Text = "button1";
            btnAplicar.UseVisualStyleBackColor = true;
            // 
            // FuentesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAplicar);
            Controls.Add(txt);
            Controls.Add(Texto);
            Name = "FuentesView";
            Text = "FuentesView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Texto;
        private TextBox txt;
        private Button btnAplicar;
    }
}