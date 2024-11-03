namespace FazendaUrbana
{
    partial class TesteBD
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
            lbTeste = new Label();
            SuspendLayout();
            // 
            // lbTeste
            // 
            lbTeste.AutoSize = true;
            lbTeste.Location = new Point(362, 85);
            lbTeste.Name = "lbTeste";
            lbTeste.Size = new Size(41, 20);
            lbTeste.TabIndex = 0;
            lbTeste.Text = "teste";
            // 
            // TesteBD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTeste);
            Name = "TesteBD";
            Text = "TesteBD";
            Load += TesteBD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTeste;
    }
}
