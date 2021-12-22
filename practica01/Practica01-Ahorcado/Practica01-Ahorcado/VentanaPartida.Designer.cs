
using System.Windows.Forms;

namespace Practica01_Ahorcado
{
    partial class VentanaPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPartida));
            this.aLetra_button = new System.Windows.Forms.Button();
            this.bLetra_Button = new System.Windows.Forms.Button();
            this.dLetra_Button = new System.Windows.Forms.Button();
            this.cLetra_Button = new System.Windows.Forms.Button();
            this.hLetra_Button = new System.Windows.Forms.Button();
            this.gLetra_Button = new System.Windows.Forms.Button();
            this.fLetra_Button = new System.Windows.Forms.Button();
            this.eLetra_Button = new System.Windows.Forms.Button();
            this.pLetra_Button = new System.Windows.Forms.Button();
            this.oLetra_Button = new System.Windows.Forms.Button();
            this.nLetra_Button = new System.Windows.Forms.Button();
            this.mLetra_Button = new System.Windows.Forms.Button();
            this.lLetra_Button = new System.Windows.Forms.Button();
            this.kLetra_Button = new System.Windows.Forms.Button();
            this.jLetra_Button = new System.Windows.Forms.Button();
            this.iLetra_Button = new System.Windows.Forms.Button();
            this.wLetra_Button = new System.Windows.Forms.Button();
            this.vLetra_Button = new System.Windows.Forms.Button();
            this.uLetra_Button = new System.Windows.Forms.Button();
            this.ñLetra_Button = new System.Windows.Forms.Button();
            this.tLetra_Button = new System.Windows.Forms.Button();
            this.sLetra_Button = new System.Windows.Forms.Button();
            this.rLetra_Button = new System.Windows.Forms.Button();
            this.qLetra_Button = new System.Windows.Forms.Button();
            this.zLetra_Button = new System.Windows.Forms.Button();
            this.yLetra_Button = new System.Windows.Forms.Button();
            this.xLetra_Button = new System.Windows.Forms.Button();
            this.puntuacion_label = new System.Windows.Forms.Label();
            this.valorPuntuacion_label = new System.Windows.Forms.Label();
            this.valorIntentos_label = new System.Windows.Forms.Label();
            this.intentos_label = new System.Windows.Forms.Label();
            this.adivinar_button = new System.Windows.Forms.Button();
            this.sugerida_textBox = new System.Windows.Forms.TextBox();
            this.misteriosa_label = new System.Windows.Forms.Label();
            this.volver_button = new System.Windows.Forms.Button();
            this.categorias_comboBox = new System.Windows.Forms.ComboBox();
            this.categoria_label = new System.Windows.Forms.Label();
            this.controlesPartida_panel = new System.Windows.Forms.Panel();
            this.sugeridas_FlowPane = new System.Windows.Forms.FlowLayoutPanel();
            this.jugar_button = new System.Windows.Forms.Button();
            this.resultado_label = new System.Windows.Forms.Label();
            this.resultado_button = new System.Windows.Forms.Button();
            this.controlesConfiguracion_panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.resultado_panel = new System.Windows.Forms.Panel();
            this.controlesPartida_panel.SuspendLayout();
            this.controlesConfiguracion_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.resultado_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLetra_button
            // 
            this.aLetra_button.BackColor = System.Drawing.Color.Transparent;
            this.aLetra_button.FlatAppearance.BorderSize = 0;
            this.aLetra_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aLetra_button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.aLetra_button.Location = new System.Drawing.Point(18, 103);
            this.aLetra_button.Name = "aLetra_button";
            this.aLetra_button.Size = new System.Drawing.Size(40, 40);
            this.aLetra_button.TabIndex = 0;
            this.aLetra_button.Text = "A";
            this.aLetra_button.UseVisualStyleBackColor = false;
            this.aLetra_button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // bLetra_Button
            // 
            this.bLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.bLetra_Button.FlatAppearance.BorderSize = 0;
            this.bLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.bLetra_Button.Location = new System.Drawing.Point(64, 103);
            this.bLetra_Button.Name = "bLetra_Button";
            this.bLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.bLetra_Button.TabIndex = 1;
            this.bLetra_Button.Text = "B";
            this.bLetra_Button.UseVisualStyleBackColor = false;
            this.bLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // dLetra_Button
            // 
            this.dLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.dLetra_Button.FlatAppearance.BorderSize = 0;
            this.dLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.dLetra_Button.Location = new System.Drawing.Point(156, 103);
            this.dLetra_Button.Name = "dLetra_Button";
            this.dLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.dLetra_Button.TabIndex = 3;
            this.dLetra_Button.Text = "D";
            this.dLetra_Button.UseVisualStyleBackColor = false;
            this.dLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // cLetra_Button
            // 
            this.cLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.cLetra_Button.FlatAppearance.BorderSize = 0;
            this.cLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.cLetra_Button.Location = new System.Drawing.Point(110, 103);
            this.cLetra_Button.Name = "cLetra_Button";
            this.cLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.cLetra_Button.TabIndex = 2;
            this.cLetra_Button.Text = "C";
            this.cLetra_Button.UseVisualStyleBackColor = false;
            this.cLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // hLetra_Button
            // 
            this.hLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.hLetra_Button.FlatAppearance.BorderSize = 0;
            this.hLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.hLetra_Button.Location = new System.Drawing.Point(340, 103);
            this.hLetra_Button.Name = "hLetra_Button";
            this.hLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.hLetra_Button.TabIndex = 7;
            this.hLetra_Button.Text = "H";
            this.hLetra_Button.UseVisualStyleBackColor = false;
            this.hLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // gLetra_Button
            // 
            this.gLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.gLetra_Button.FlatAppearance.BorderSize = 0;
            this.gLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.gLetra_Button.Location = new System.Drawing.Point(294, 103);
            this.gLetra_Button.Name = "gLetra_Button";
            this.gLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.gLetra_Button.TabIndex = 6;
            this.gLetra_Button.Text = "G";
            this.gLetra_Button.UseVisualStyleBackColor = false;
            this.gLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // fLetra_Button
            // 
            this.fLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.fLetra_Button.FlatAppearance.BorderSize = 0;
            this.fLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.fLetra_Button.Location = new System.Drawing.Point(248, 103);
            this.fLetra_Button.Name = "fLetra_Button";
            this.fLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.fLetra_Button.TabIndex = 5;
            this.fLetra_Button.Text = "F";
            this.fLetra_Button.UseVisualStyleBackColor = false;
            this.fLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // eLetra_Button
            // 
            this.eLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.eLetra_Button.FlatAppearance.BorderSize = 0;
            this.eLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.eLetra_Button.Location = new System.Drawing.Point(202, 103);
            this.eLetra_Button.Name = "eLetra_Button";
            this.eLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.eLetra_Button.TabIndex = 4;
            this.eLetra_Button.Text = "E";
            this.eLetra_Button.UseVisualStyleBackColor = false;
            this.eLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // pLetra_Button
            // 
            this.pLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.pLetra_Button.FlatAppearance.BorderSize = 0;
            this.pLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.pLetra_Button.Location = new System.Drawing.Point(340, 149);
            this.pLetra_Button.Name = "pLetra_Button";
            this.pLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.pLetra_Button.TabIndex = 15;
            this.pLetra_Button.Text = "P";
            this.pLetra_Button.UseVisualStyleBackColor = false;
            this.pLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // oLetra_Button
            // 
            this.oLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.oLetra_Button.FlatAppearance.BorderSize = 0;
            this.oLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.oLetra_Button.Location = new System.Drawing.Point(294, 149);
            this.oLetra_Button.Name = "oLetra_Button";
            this.oLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.oLetra_Button.TabIndex = 14;
            this.oLetra_Button.Text = "O";
            this.oLetra_Button.UseVisualStyleBackColor = false;
            this.oLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // nLetra_Button
            // 
            this.nLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.nLetra_Button.FlatAppearance.BorderSize = 0;
            this.nLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.nLetra_Button.Location = new System.Drawing.Point(202, 149);
            this.nLetra_Button.Name = "nLetra_Button";
            this.nLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.nLetra_Button.TabIndex = 13;
            this.nLetra_Button.Text = "N";
            this.nLetra_Button.UseVisualStyleBackColor = false;
            this.nLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // mLetra_Button
            // 
            this.mLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.mLetra_Button.FlatAppearance.BorderSize = 0;
            this.mLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.mLetra_Button.Location = new System.Drawing.Point(156, 149);
            this.mLetra_Button.Name = "mLetra_Button";
            this.mLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.mLetra_Button.TabIndex = 12;
            this.mLetra_Button.Text = "M";
            this.mLetra_Button.UseVisualStyleBackColor = false;
            this.mLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // lLetra_Button
            // 
            this.lLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.lLetra_Button.FlatAppearance.BorderSize = 0;
            this.lLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lLetra_Button.Location = new System.Drawing.Point(110, 149);
            this.lLetra_Button.Name = "lLetra_Button";
            this.lLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.lLetra_Button.TabIndex = 11;
            this.lLetra_Button.Text = "L";
            this.lLetra_Button.UseVisualStyleBackColor = false;
            this.lLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // kLetra_Button
            // 
            this.kLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.kLetra_Button.FlatAppearance.BorderSize = 0;
            this.kLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.kLetra_Button.Location = new System.Drawing.Point(64, 149);
            this.kLetra_Button.Name = "kLetra_Button";
            this.kLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.kLetra_Button.TabIndex = 10;
            this.kLetra_Button.Text = "K";
            this.kLetra_Button.UseVisualStyleBackColor = false;
            this.kLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // jLetra_Button
            // 
            this.jLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.jLetra_Button.FlatAppearance.BorderSize = 0;
            this.jLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.jLetra_Button.Location = new System.Drawing.Point(18, 149);
            this.jLetra_Button.Name = "jLetra_Button";
            this.jLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.jLetra_Button.TabIndex = 9;
            this.jLetra_Button.Text = "J";
            this.jLetra_Button.UseVisualStyleBackColor = false;
            this.jLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // iLetra_Button
            // 
            this.iLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.iLetra_Button.FlatAppearance.BorderSize = 0;
            this.iLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.iLetra_Button.Location = new System.Drawing.Point(386, 103);
            this.iLetra_Button.Name = "iLetra_Button";
            this.iLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.iLetra_Button.TabIndex = 8;
            this.iLetra_Button.Text = "I";
            this.iLetra_Button.UseVisualStyleBackColor = false;
            this.iLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // wLetra_Button
            // 
            this.wLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.wLetra_Button.FlatAppearance.BorderSize = 0;
            this.wLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.wLetra_Button.Location = new System.Drawing.Point(248, 195);
            this.wLetra_Button.Name = "wLetra_Button";
            this.wLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.wLetra_Button.TabIndex = 23;
            this.wLetra_Button.Text = "W";
            this.wLetra_Button.UseVisualStyleBackColor = false;
            this.wLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // vLetra_Button
            // 
            this.vLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.vLetra_Button.FlatAppearance.BorderSize = 0;
            this.vLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.vLetra_Button.Location = new System.Drawing.Point(202, 195);
            this.vLetra_Button.Name = "vLetra_Button";
            this.vLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.vLetra_Button.TabIndex = 22;
            this.vLetra_Button.Text = "V";
            this.vLetra_Button.UseVisualStyleBackColor = false;
            this.vLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // uLetra_Button
            // 
            this.uLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.uLetra_Button.FlatAppearance.BorderSize = 0;
            this.uLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.uLetra_Button.Location = new System.Drawing.Point(156, 195);
            this.uLetra_Button.Name = "uLetra_Button";
            this.uLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.uLetra_Button.TabIndex = 21;
            this.uLetra_Button.Text = "U";
            this.uLetra_Button.UseVisualStyleBackColor = false;
            this.uLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // ñLetra_Button
            // 
            this.ñLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.ñLetra_Button.FlatAppearance.BorderSize = 0;
            this.ñLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ñLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.ñLetra_Button.Location = new System.Drawing.Point(248, 149);
            this.ñLetra_Button.Name = "ñLetra_Button";
            this.ñLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.ñLetra_Button.TabIndex = 20;
            this.ñLetra_Button.Text = "Ñ";
            this.ñLetra_Button.UseVisualStyleBackColor = false;
            this.ñLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // tLetra_Button
            // 
            this.tLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.tLetra_Button.FlatAppearance.BorderSize = 0;
            this.tLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.tLetra_Button.Location = new System.Drawing.Point(110, 195);
            this.tLetra_Button.Name = "tLetra_Button";
            this.tLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.tLetra_Button.TabIndex = 19;
            this.tLetra_Button.Text = "T";
            this.tLetra_Button.UseVisualStyleBackColor = false;
            this.tLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // sLetra_Button
            // 
            this.sLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.sLetra_Button.FlatAppearance.BorderSize = 0;
            this.sLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.sLetra_Button.Location = new System.Drawing.Point(64, 195);
            this.sLetra_Button.Name = "sLetra_Button";
            this.sLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.sLetra_Button.TabIndex = 18;
            this.sLetra_Button.Text = "S";
            this.sLetra_Button.UseVisualStyleBackColor = false;
            this.sLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // rLetra_Button
            // 
            this.rLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.rLetra_Button.FlatAppearance.BorderSize = 0;
            this.rLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.rLetra_Button.Location = new System.Drawing.Point(18, 195);
            this.rLetra_Button.Name = "rLetra_Button";
            this.rLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.rLetra_Button.TabIndex = 17;
            this.rLetra_Button.Text = "R";
            this.rLetra_Button.UseVisualStyleBackColor = false;
            this.rLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // qLetra_Button
            // 
            this.qLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.qLetra_Button.FlatAppearance.BorderSize = 0;
            this.qLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.qLetra_Button.Location = new System.Drawing.Point(386, 149);
            this.qLetra_Button.Name = "qLetra_Button";
            this.qLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.qLetra_Button.TabIndex = 16;
            this.qLetra_Button.Text = "Q";
            this.qLetra_Button.UseVisualStyleBackColor = false;
            this.qLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // zLetra_Button
            // 
            this.zLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.zLetra_Button.FlatAppearance.BorderSize = 0;
            this.zLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.zLetra_Button.Location = new System.Drawing.Point(386, 195);
            this.zLetra_Button.Name = "zLetra_Button";
            this.zLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.zLetra_Button.TabIndex = 26;
            this.zLetra_Button.Text = "Z";
            this.zLetra_Button.UseVisualStyleBackColor = false;
            this.zLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // yLetra_Button
            // 
            this.yLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.yLetra_Button.FlatAppearance.BorderSize = 0;
            this.yLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.yLetra_Button.Location = new System.Drawing.Point(340, 195);
            this.yLetra_Button.Name = "yLetra_Button";
            this.yLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.yLetra_Button.TabIndex = 25;
            this.yLetra_Button.Text = "Y";
            this.yLetra_Button.UseVisualStyleBackColor = false;
            this.yLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // xLetra_Button
            // 
            this.xLetra_Button.BackColor = System.Drawing.Color.Transparent;
            this.xLetra_Button.FlatAppearance.BorderSize = 0;
            this.xLetra_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xLetra_Button.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.xLetra_Button.Location = new System.Drawing.Point(294, 195);
            this.xLetra_Button.Name = "xLetra_Button";
            this.xLetra_Button.Size = new System.Drawing.Size(40, 40);
            this.xLetra_Button.TabIndex = 24;
            this.xLetra_Button.Text = "X";
            this.xLetra_Button.UseVisualStyleBackColor = false;
            this.xLetra_Button.Click += new System.EventHandler(this.letra_button_Click);
            // 
            // puntuacion_label
            // 
            this.puntuacion_label.AutoSize = true;
            this.puntuacion_label.BackColor = System.Drawing.Color.Transparent;
            this.puntuacion_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.puntuacion_label.ForeColor = VentanaPartida.miColorCompSecundario;
            this.puntuacion_label.Location = new System.Drawing.Point(660, 49);
            this.puntuacion_label.Name = "puntuacion_label";
            this.puntuacion_label.Size = new System.Drawing.Size(138, 29);
            this.puntuacion_label.TabIndex = 27;
            this.puntuacion_label.Text = "Puntuación  >";
            // 
            // valorPuntuacion_label
            // 
            this.valorPuntuacion_label.AutoSize = true;
            this.valorPuntuacion_label.BackColor = System.Drawing.Color.Transparent;
            this.valorPuntuacion_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.valorPuntuacion_label.ForeColor = VentanaPartida.miColorCompSecundario;
            this.valorPuntuacion_label.Location = new System.Drawing.Point(804, 49);
            this.valorPuntuacion_label.Name = "valorPuntuacion_label";
            this.valorPuntuacion_label.Size = new System.Drawing.Size(25, 29);
            this.valorPuntuacion_label.TabIndex = 28;
            this.valorPuntuacion_label.Text = "0";
            this.valorPuntuacion_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valorIntentos_label
            // 
            this.valorIntentos_label.AutoSize = true;
            this.valorIntentos_label.BackColor = System.Drawing.Color.Transparent;
            this.valorIntentos_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.valorIntentos_label.ForeColor = VentanaPartida.miColorCompSecundario;
            this.valorIntentos_label.Location = new System.Drawing.Point(804, 74);
            this.valorIntentos_label.Name = "valorIntentos_label";
            this.valorIntentos_label.Size = new System.Drawing.Size(25, 29);
            this.valorIntentos_label.TabIndex = 30;
            this.valorIntentos_label.Text = "0";
            this.valorIntentos_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intentos_label
            // 
            this.intentos_label.AutoSize = true;
            this.intentos_label.BackColor = System.Drawing.Color.Transparent;
            this.intentos_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.intentos_label.ForeColor = VentanaPartida.miColorCompSecundario;
            this.intentos_label.Location = new System.Drawing.Point(688, 74);
            this.intentos_label.Name = "intentos_label";
            this.intentos_label.Size = new System.Drawing.Size(110, 29);
            this.intentos_label.TabIndex = 29;
            this.intentos_label.Text = "Intentos  >";
            // 
            // adivinar_button
            // 
            this.adivinar_button.BackColor = System.Drawing.Color.Transparent;
            this.adivinar_button.Enabled = false;
            this.adivinar_button.FlatAppearance.BorderSize = 0;
            this.adivinar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adivinar_button.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.adivinar_button.Location = new System.Drawing.Point(301, 47);
            this.adivinar_button.Name = "adivinar_button";
            this.adivinar_button.Size = new System.Drawing.Size(138, 46);
            this.adivinar_button.TabIndex = 31;
            this.adivinar_button.Text = "Adivinar";
            this.adivinar_button.UseVisualStyleBackColor = false;
            this.adivinar_button.Click += new System.EventHandler(this.adivinar_button_Click);
            // 
            // sugerida_textBox
            // 
            this.sugerida_textBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.sugerida_textBox.Location = new System.Drawing.Point(6, 51);
            this.sugerida_textBox.Name = "sugerida_textBox";
            this.sugerida_textBox.Size = new System.Drawing.Size(289, 40);
            this.sugerida_textBox.TabIndex = 32;
            this.sugerida_textBox.TextChanged += new System.EventHandler(this.sugerida_textBox_TextChanged);
            // 
            // misteriosa_label
            // 
            this.misteriosa_label.BackColor = System.Drawing.Color.Transparent;
            this.misteriosa_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 28F, System.Drawing.FontStyle.Bold);
            this.misteriosa_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
            this.misteriosa_label.Location = new System.Drawing.Point(389, 241);
            this.misteriosa_label.Name = "misteriosa_label";
            this.misteriosa_label.Size = new System.Drawing.Size(433, 65);
            this.misteriosa_label.TabIndex = 34;
            this.misteriosa_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volver_button
            // 
            this.volver_button.BackColor = System.Drawing.Color.Bisque;
            this.volver_button.FlatAppearance.BorderSize = 0;
            this.volver_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volver_button.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.volver_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(83)))), ((int)(((byte)(0)))));
            this.volver_button.Location = new System.Drawing.Point(4, 164);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(254, 45);
            this.volver_button.TabIndex = 38;
            this.volver_button.Text = "Volver a inicio";
            this.volver_button.UseVisualStyleBackColor = false;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // categorias_comboBox
            // 
            this.categorias_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.categorias_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorias_comboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.categorias_comboBox.FormattingEnabled = true;
            this.categorias_comboBox.Location = new System.Drawing.Point(3, 41);
            this.categorias_comboBox.Name = "categorias_comboBox";
            this.categorias_comboBox.Size = new System.Drawing.Size(256, 37);
            this.categorias_comboBox.TabIndex = 41;
            this.categorias_comboBox.SelectedIndexChanged += new System.EventHandler(this.categorias_comboBox_SelectedIndexChanged);
            // 
            // categoria_label
            // 
            this.categoria_label.AutoSize = true;
            this.categoria_label.BackColor = System.Drawing.Color.Transparent;
            this.categoria_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.categoria_label.ForeColor = VentanaPartida.miColorCompSecundario;
            this.categoria_label.Location = new System.Drawing.Point(73, 5);
            this.categoria_label.Name = "categoria_label";
            this.categoria_label.Size = new System.Drawing.Size(117, 33);
            this.categoria_label.TabIndex = 42;
            this.categoria_label.Text = "Categoría";
            // 
            // controlesPartida_panel
            // 
            this.controlesPartida_panel.BackColor = System.Drawing.Color.Transparent;
            this.controlesPartida_panel.Controls.Add(this.sugeridas_FlowPane);
            this.controlesPartida_panel.Controls.Add(this.gLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.aLetra_button);
            this.controlesPartida_panel.Controls.Add(this.bLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.cLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.dLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.eLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.sugerida_textBox);
            this.controlesPartida_panel.Controls.Add(this.fLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.hLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.adivinar_button);
            this.controlesPartida_panel.Controls.Add(this.iLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.ñLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.jLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.kLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.lLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.zLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.mLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.yLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.nLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.xLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.oLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.wLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.pLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.vLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.qLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.uLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.rLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.sLetra_Button);
            this.controlesPartida_panel.Controls.Add(this.tLetra_Button);
            this.controlesPartida_panel.Enabled = false;
            this.controlesPartida_panel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlesPartida_panel.Location = new System.Drawing.Point(390, 358);
            this.controlesPartida_panel.Name = "controlesPartida_panel";
            this.controlesPartida_panel.Size = new System.Drawing.Size(439, 247);
            this.controlesPartida_panel.TabIndex = 43;
            // 
            // sugeridas_FlowPane
            // 
            this.sugeridas_FlowPane.BackColor = System.Drawing.Color.Transparent;
            this.sugeridas_FlowPane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sugeridas_FlowPane.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugeridas_FlowPane.Location = new System.Drawing.Point(6, 6);
            this.sugeridas_FlowPane.Name = "sugeridas_FlowPane";
            this.sugeridas_FlowPane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sugeridas_FlowPane.Size = new System.Drawing.Size(433, 39);
            this.sugeridas_FlowPane.TabIndex = 45;
            // 
            // jugar_button
            // 
            this.jugar_button.BackColor = System.Drawing.Color.Transparent;
            this.jugar_button.Enabled = false;
            this.jugar_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.jugar_button.FlatAppearance.BorderSize = 3;
            this.jugar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar_button.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.jugar_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.jugar_button.Location = new System.Drawing.Point(3, 107);
            this.jugar_button.Name = "jugar_button";
            this.jugar_button.Size = new System.Drawing.Size(256, 51);
            this.jugar_button.TabIndex = 44;
            this.jugar_button.Text = "Jugar";
            this.jugar_button.UseVisualStyleBackColor = false;
            this.jugar_button.Click += new System.EventHandler(this.jugar_button_Click);
            // 
            // resultado_label
            // 
            this.resultado_label.BackColor = System.Drawing.Color.Transparent;
            this.resultado_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold);
            this.resultado_label.ForeColor = System.Drawing.Color.Black;
            this.resultado_label.Location = new System.Drawing.Point(20, 36);
            this.resultado_label.Name = "resultado_label";
            this.resultado_label.Size = new System.Drawing.Size(320, 144);
            this.resultado_label.TabIndex = 45;
            this.resultado_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultado_button
            // 
            this.resultado_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(128)))));
            this.resultado_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.resultado_button.FlatAppearance.BorderSize = 3;
            this.resultado_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultado_button.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Bold);
            this.resultado_button.Location = new System.Drawing.Point(110, 211);
            this.resultado_button.Name = "resultado_button";
            this.resultado_button.Size = new System.Drawing.Size(141, 49);
            this.resultado_button.TabIndex = 46;
            this.resultado_button.Text = "Vale";
            this.resultado_button.UseVisualStyleBackColor = false;
            this.resultado_button.Click += new System.EventHandler(this.resultado_button_Click);
            // 
            // controlesConfiguracion_panel
            // 
            this.controlesConfiguracion_panel.BackColor = System.Drawing.Color.Transparent;
            this.controlesConfiguracion_panel.Controls.Add(this.categoria_label);
            this.controlesConfiguracion_panel.Controls.Add(this.categorias_comboBox);
            this.controlesConfiguracion_panel.Controls.Add(this.jugar_button);
            this.controlesConfiguracion_panel.Controls.Add(this.volver_button);
            this.controlesConfiguracion_panel.Location = new System.Drawing.Point(69, 393);
            this.controlesConfiguracion_panel.Name = "controlesConfiguracion_panel";
            this.controlesConfiguracion_panel.Size = new System.Drawing.Size(262, 212);
            this.controlesConfiguracion_panel.TabIndex = 49;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(69, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(186, 319);
            this.pictureBox.TabIndex = 50;
            this.pictureBox.TabStop = false;
            // 
            // resultado_panel
            // 
            this.resultado_panel.BackColor = System.Drawing.Color.Transparent;
            this.resultado_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultado_panel.BackgroundImage")));
            this.resultado_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultado_panel.Controls.Add(this.resultado_button);
            this.resultado_panel.Controls.Add(this.resultado_label);
            this.resultado_panel.Location = new System.Drawing.Point(270, 108);
            this.resultado_panel.Name = "resultado_panel";
            this.resultado_panel.Size = new System.Drawing.Size(361, 295);
            this.resultado_panel.TabIndex = 51;
            this.resultado_panel.Visible = false;
            // 
            // VentanaPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.resultado_panel);
            this.Controls.Add(this.misteriosa_label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.controlesPartida_panel);
            this.Controls.Add(this.controlesConfiguracion_panel);
            this.Controls.Add(this.valorIntentos_label);
            this.Controls.Add(this.intentos_label);
            this.Controls.Add(this.valorPuntuacion_label);
            this.Controls.Add(this.puntuacion_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "VentanaPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.controlesPartida_panel.ResumeLayout(false);
            this.controlesPartida_panel.PerformLayout();
            this.controlesConfiguracion_panel.ResumeLayout(false);
            this.controlesConfiguracion_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.resultado_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aLetra_button;
        private System.Windows.Forms.Button bLetra_Button;
        private System.Windows.Forms.Button dLetra_Button;
        private System.Windows.Forms.Button cLetra_Button;
        private System.Windows.Forms.Button hLetra_Button;
        private System.Windows.Forms.Button gLetra_Button;
        private System.Windows.Forms.Button fLetra_Button;
        private System.Windows.Forms.Button eLetra_Button;
        private System.Windows.Forms.Button pLetra_Button;
        private System.Windows.Forms.Button oLetra_Button;
        private System.Windows.Forms.Button nLetra_Button;
        private System.Windows.Forms.Button mLetra_Button;
        private System.Windows.Forms.Button lLetra_Button;
        private System.Windows.Forms.Button kLetra_Button;
        private System.Windows.Forms.Button jLetra_Button;
        private System.Windows.Forms.Button iLetra_Button;
        private System.Windows.Forms.Button wLetra_Button;
        private System.Windows.Forms.Button vLetra_Button;
        private System.Windows.Forms.Button uLetra_Button;
        private System.Windows.Forms.Button ñLetra_Button;
        private System.Windows.Forms.Button tLetra_Button;
        private System.Windows.Forms.Button sLetra_Button;
        private System.Windows.Forms.Button rLetra_Button;
        private System.Windows.Forms.Button qLetra_Button;
        private System.Windows.Forms.Button zLetra_Button;
        private System.Windows.Forms.Button yLetra_Button;
        private System.Windows.Forms.Button xLetra_Button;
        private System.Windows.Forms.Label puntuacion_label;
        private System.Windows.Forms.Label valorPuntuacion_label;
        private System.Windows.Forms.Label valorIntentos_label;
        private System.Windows.Forms.Label intentos_label;
        private System.Windows.Forms.Button adivinar_button;
        private System.Windows.Forms.TextBox sugerida_textBox;
        private System.Windows.Forms.Label misteriosa_label;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.ComboBox categorias_comboBox;
        private System.Windows.Forms.Label categoria_label;
        private System.Windows.Forms.Panel controlesPartida_panel;
        private System.Windows.Forms.Button jugar_button;
        private System.Windows.Forms.FlowLayoutPanel sugeridas_FlowPane;
        private System.Windows.Forms.Label resultado_label;
        private System.Windows.Forms.Button resultado_button;
        private System.Windows.Forms.Panel controlesConfiguracion_panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel resultado_panel;
    }
}