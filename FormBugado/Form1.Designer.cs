namespace FormBugado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnBota = new Button();
            imgViado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgViado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Coral;
            panel1.Location = new Point(231, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 0);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnBota
            // 
            btnBota.Location = new Point(44, 367);
            btnBota.Name = "btnBota";
            btnBota.Size = new Size(140, 49);
            btnBota.TabIndex = 0;
            btnBota.Text = "bota";
            btnBota.UseVisualStyleBackColor = true;
            btnBota.Click += bota_Click;
            // 
            // imgViado
            // 
            imgViado.Image = (Image)resources.GetObject("imgViado.Image");
            imgViado.Location = new Point(6, 12);
            imgViado.Name = "imgViado";
            imgViado.Size = new Size(219, 349);
            imgViado.SizeMode = PictureBoxSizeMode.StretchImage;
            imgViado.TabIndex = 1;
            imgViado.TabStop = false;
            imgViado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 428);
            Controls.Add(imgViado);
            Controls.Add(btnBota);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgViado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBota;
        private PictureBox imgViado;
    }
}