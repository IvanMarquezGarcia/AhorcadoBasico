
namespace Practica01_Ahorcado
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.titulo_label = new System.Windows.Forms.Label();
            this.nombreJ1_textBox = new System.Windows.Forms.TextBox();
            this.nombreJ1_label = new System.Windows.Forms.Label();
            this.nombreJ2_label = new System.Windows.Forms.Label();
            this.nombreJ2_textBox = new System.Windows.Forms.TextBox();
            this.jugar_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dosJ_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salir_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo_label
            // 
            this.titulo_label.BackColor = System.Drawing.Color.Transparent;
            this.titulo_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.titulo_label.Location = new System.Drawing.Point(12, 53);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(592, 51);
            this.titulo_label.TabIndex = 2;
            this.titulo_label.Text = "AHORCADO";
            this.titulo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreJ1_textBox
            // 
            this.nombreJ1_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreJ1_textBox.Location = new System.Drawing.Point(302, 274);
            this.nombreJ1_textBox.Name = "nombreJ1_textBox";
            this.nombreJ1_textBox.Size = new System.Drawing.Size(191, 33);
            this.nombreJ1_textBox.TabIndex = 3;
            this.nombreJ1_textBox.TextChanged += new System.EventHandler(this.nombreCambia);
            // 
            // nombreJ1_label
            // 
            this.nombreJ1_label.AutoSize = true;
            this.nombreJ1_label.BackColor = System.Drawing.Color.Transparent;
            this.nombreJ1_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreJ1_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.nombreJ1_label.Location = new System.Drawing.Point(142, 277);
            this.nombreJ1_label.Name = "nombreJ1_label";
            this.nombreJ1_label.Size = new System.Drawing.Size(152, 25);
            this.nombreJ1_label.TabIndex = 4;
            this.nombreJ1_label.Text = "nombre de jugador 1";
            // 
            // nombreJ2_label
            // 
            this.nombreJ2_label.AutoSize = true;
            this.nombreJ2_label.BackColor = System.Drawing.Color.Transparent;
            this.nombreJ2_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreJ2_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.nombreJ2_label.Location = new System.Drawing.Point(140, 325);
            this.nombreJ2_label.Name = "nombreJ2_label";
            this.nombreJ2_label.Size = new System.Drawing.Size(154, 25);
            this.nombreJ2_label.TabIndex = 6;
            this.nombreJ2_label.Text = "nombre de jugador 2";
            this.nombreJ2_label.Visible = false;
            // 
            // nombreJ2_textBox
            // 
            this.nombreJ2_textBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreJ2_textBox.Location = new System.Drawing.Point(302, 322);
            this.nombreJ2_textBox.Name = "nombreJ2_textBox";
            this.nombreJ2_textBox.Size = new System.Drawing.Size(191, 33);
            this.nombreJ2_textBox.TabIndex = 5;
            this.nombreJ2_textBox.Visible = false;
            this.nombreJ2_textBox.TextChanged += new System.EventHandler(this.nombreCambia);
            // 
            // jugar_button
            // 
            this.jugar_button.BackColor = System.Drawing.Color.Transparent;
            this.jugar_button.Enabled = false;
            this.jugar_button.FlatAppearance.BorderSize = 0;
            this.jugar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar_button.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar_button.ForeColor = System.Drawing.Color.Gray;
            this.jugar_button.Location = new System.Drawing.Point(193, 428);
            this.jugar_button.Name = "jugar_button";
            this.jugar_button.Size = new System.Drawing.Size(231, 57);
            this.jugar_button.TabIndex = 8;
            this.jugar_button.Text = "JUGAR";
            this.jugar_button.UseVisualStyleBackColor = false;
            this.jugar_button.Click += new System.EventHandler(this.jugar);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dosJ_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(443, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de juego";
            // 
            // dosJ_button
            // 
            this.dosJ_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dosJ_button.BackgroundImage")));
            this.dosJ_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dosJ_button.FlatAppearance.BorderSize = 0;
            this.dosJ_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosJ_button.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.dosJ_button.Location = new System.Drawing.Point(115, 44);
            this.dosJ_button.Name = "dosJ_button";
            this.dosJ_button.Size = new System.Drawing.Size(29, 20);
            this.dosJ_button.TabIndex = 10;
            this.dosJ_button.UseVisualStyleBackColor = true;
            this.dosJ_button.Click += new System.EventHandler(this.dosJ_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "dos jugadores";
            // 
            // salir_button
            // 
            this.salir_button.BackColor = System.Drawing.Color.Transparent;
            this.salir_button.FlatAppearance.BorderSize = 0;
            this.salir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_button.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold);
            this.salir_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.salir_button.Location = new System.Drawing.Point(34, 436);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(112, 44);
            this.salir_button.TabIndex = 10;
            this.salir_button.Text = "SALIR";
            this.salir_button.UseVisualStyleBackColor = false;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 497);
            this.Controls.Add(this.salir_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jugar_button);
            this.Controls.Add(this.nombreJ2_label);
            this.Controls.Add(this.nombreJ2_textBox);
            this.Controls.Add(this.nombreJ1_label);
            this.Controls.Add(this.nombreJ1_textBox);
            this.Controls.Add(this.titulo_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado - Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox nombreJ1_textBox;
        private System.Windows.Forms.Label nombreJ1_label;
        private System.Windows.Forms.Label nombreJ2_label;
        private System.Windows.Forms.TextBox nombreJ2_textBox;
        private System.Windows.Forms.Button jugar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dosJ_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salir_button;
    }
}