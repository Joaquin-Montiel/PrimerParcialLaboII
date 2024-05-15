namespace PrimerParcialMontielJoaquin
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            bindingSource1 = new BindingSource(components);
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(650, 40);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(121, 62);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(650, 345);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 61);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicos.Location = new Point(12, 9);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(98, 15);
            lblMedicos.TabIndex = 2;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacientes.Location = new Point(362, 9);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(60, 15);
            lblPacientes.TabIndex = 3;
            lblPacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 40);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(286, 124);
            lstMedicos.TabIndex = 4;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(335, 40);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(286, 124);
            lstPacientes.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
        private BindingSource bindingSource1;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
    }
}
