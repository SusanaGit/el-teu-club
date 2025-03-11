namespace ElTeuClub
{
    partial class Inici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inici));
            picBox_esquerre = new PictureBox();
            picBox_dreta = new PictureBox();
            lbl_nomSoci = new Label();
            lbl_cognomsSoci = new Label();
            lbl_direccio = new Label();
            lbl_telefon = new Label();
            lbl_mail = new Label();
            btn_afegirNouSoci = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            txtbox_nomSoci = new TextBox();
            txtbox_cognomsSoci = new TextBox();
            txtbox_direccio = new TextBox();
            txtbox_telefon = new TextBox();
            txtbox_mail = new TextBox();
            picbox_foto = new PictureBox();
            lbl_titolSoci = new Label();
            lbl_titol = new Label();
            lbl_data_registre = new Label();
            picBox_primer = new PictureBox();
            picBox_ultim = new PictureBox();
            dateTimePicker_registre = new DateTimePicker();
            lbl_activitats = new Label();
            btn_tancar = new Button();
            picbox_floppy = new PictureBox();
            picbox_addSoci = new PictureBox();
            chcklist_activitats = new CheckedListBox();
            picbox_borrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox_esquerre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_dreta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_foto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_primer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_ultim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_floppy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_addSoci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox_borrar).BeginInit();
            SuspendLayout();
            // 
            // picBox_esquerre
            // 
            picBox_esquerre.Image = (Image)resources.GetObject("picBox_esquerre.Image");
            picBox_esquerre.Location = new Point(294, 497);
            picBox_esquerre.Name = "picBox_esquerre";
            picBox_esquerre.Size = new Size(50, 50);
            picBox_esquerre.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_esquerre.TabIndex = 1;
            picBox_esquerre.TabStop = false;
            picBox_esquerre.Click += picBox_esquerre_Click;
            // 
            // picBox_dreta
            // 
            picBox_dreta.Image = (Image)resources.GetObject("picBox_dreta.Image");
            picBox_dreta.Location = new Point(350, 497);
            picBox_dreta.Name = "picBox_dreta";
            picBox_dreta.Size = new Size(50, 50);
            picBox_dreta.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_dreta.TabIndex = 3;
            picBox_dreta.TabStop = false;
            picBox_dreta.Click += picBox_dreta_Click;
            // 
            // lbl_nomSoci
            // 
            lbl_nomSoci.AutoSize = true;
            lbl_nomSoci.BackColor = Color.Transparent;
            lbl_nomSoci.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_nomSoci.ForeColor = Color.Sienna;
            lbl_nomSoci.Location = new Point(129, 209);
            lbl_nomSoci.Name = "lbl_nomSoci";
            lbl_nomSoci.Size = new Size(48, 21);
            lbl_nomSoci.TabIndex = 5;
            lbl_nomSoci.Text = "Nom";
            // 
            // lbl_cognomsSoci
            // 
            lbl_cognomsSoci.AutoSize = true;
            lbl_cognomsSoci.BackColor = Color.Transparent;
            lbl_cognomsSoci.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_cognomsSoci.ForeColor = Color.Sienna;
            lbl_cognomsSoci.Location = new Point(129, 256);
            lbl_cognomsSoci.Name = "lbl_cognomsSoci";
            lbl_cognomsSoci.Size = new Size(82, 21);
            lbl_cognomsSoci.TabIndex = 6;
            lbl_cognomsSoci.Text = "Cognoms";
            // 
            // lbl_direccio
            // 
            lbl_direccio.AutoSize = true;
            lbl_direccio.BackColor = Color.Transparent;
            lbl_direccio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_direccio.ForeColor = Color.Sienna;
            lbl_direccio.Location = new Point(129, 301);
            lbl_direccio.Name = "lbl_direccio";
            lbl_direccio.Size = new Size(73, 21);
            lbl_direccio.TabIndex = 7;
            lbl_direccio.Text = "Direcció";
            // 
            // lbl_telefon
            // 
            lbl_telefon.AutoSize = true;
            lbl_telefon.BackColor = Color.Transparent;
            lbl_telefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_telefon.ForeColor = Color.Sienna;
            lbl_telefon.Location = new Point(129, 348);
            lbl_telefon.Name = "lbl_telefon";
            lbl_telefon.Size = new Size(67, 21);
            lbl_telefon.TabIndex = 8;
            lbl_telefon.Text = "Telèfon";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.BackColor = Color.Transparent;
            lbl_mail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_mail.ForeColor = Color.Sienna;
            lbl_mail.Location = new Point(129, 398);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(44, 21);
            lbl_mail.TabIndex = 9;
            lbl_mail.Text = "Mail";
            // 
            // btn_afegirNouSoci
            // 
            btn_afegirNouSoci.Font = new Font("Segoe UI", 12F);
            btn_afegirNouSoci.Location = new Point(94, 574);
            btn_afegirNouSoci.Name = "btn_afegirNouSoci";
            btn_afegirNouSoci.Size = new Size(150, 50);
            btn_afegirNouSoci.TabIndex = 12;
            btn_afegirNouSoci.Text = "Nou Soci";
            btn_afegirNouSoci.UseVisualStyleBackColor = true;
            btn_afegirNouSoci.Click += btn_afegirNouSoci_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 12F);
            btn_modificar.Location = new Point(275, 574);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(150, 50);
            btn_modificar.TabIndex = 13;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 12F);
            btn_eliminar.Location = new Point(456, 574);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(150, 50);
            btn_eliminar.TabIndex = 14;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txtbox_nomSoci
            // 
            txtbox_nomSoci.Font = new Font("Segoe UI", 9F);
            txtbox_nomSoci.Location = new Point(214, 206);
            txtbox_nomSoci.Name = "txtbox_nomSoci";
            txtbox_nomSoci.Size = new Size(200, 23);
            txtbox_nomSoci.TabIndex = 15;
            // 
            // txtbox_cognomsSoci
            // 
            txtbox_cognomsSoci.Font = new Font("Segoe UI", 9F);
            txtbox_cognomsSoci.Location = new Point(214, 254);
            txtbox_cognomsSoci.Name = "txtbox_cognomsSoci";
            txtbox_cognomsSoci.Size = new Size(200, 23);
            txtbox_cognomsSoci.TabIndex = 16;
            // 
            // txtbox_direccio
            // 
            txtbox_direccio.Font = new Font("Segoe UI", 9F);
            txtbox_direccio.Location = new Point(214, 301);
            txtbox_direccio.Name = "txtbox_direccio";
            txtbox_direccio.Size = new Size(200, 23);
            txtbox_direccio.TabIndex = 17;
            // 
            // txtbox_telefon
            // 
            txtbox_telefon.Font = new Font("Segoe UI", 9F);
            txtbox_telefon.Location = new Point(214, 349);
            txtbox_telefon.Name = "txtbox_telefon";
            txtbox_telefon.Size = new Size(200, 23);
            txtbox_telefon.TabIndex = 18;
            // 
            // txtbox_mail
            // 
            txtbox_mail.Font = new Font("Segoe UI", 9F);
            txtbox_mail.Location = new Point(214, 397);
            txtbox_mail.Name = "txtbox_mail";
            txtbox_mail.Size = new Size(200, 23);
            txtbox_mail.TabIndex = 19;
            // 
            // picbox_foto
            // 
            picbox_foto.BorderStyle = BorderStyle.FixedSingle;
            picbox_foto.Image = (Image)resources.GetObject("picbox_foto.Image");
            picbox_foto.Location = new Point(437, 138);
            picbox_foto.Name = "picbox_foto";
            picbox_foto.Size = new Size(110, 130);
            picbox_foto.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_foto.TabIndex = 20;
            picbox_foto.TabStop = false;
            // 
            // lbl_titolSoci
            // 
            lbl_titolSoci.AutoSize = true;
            lbl_titolSoci.BackColor = Color.Transparent;
            lbl_titolSoci.Cursor = Cursors.No;
            lbl_titolSoci.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_titolSoci.ForeColor = Color.Sienna;
            lbl_titolSoci.Location = new Point(292, 152);
            lbl_titolSoci.Name = "lbl_titolSoci";
            lbl_titolSoci.Size = new Size(97, 37);
            lbl_titolSoci.TabIndex = 21;
            lbl_titolSoci.Text = "Soci/a";
            // 
            // lbl_titol
            // 
            lbl_titol.AutoSize = true;
            lbl_titol.BackColor = Color.Transparent;
            lbl_titol.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titol.ForeColor = Color.Sienna;
            lbl_titol.Location = new Point(196, 76);
            lbl_titol.Name = "lbl_titol";
            lbl_titol.Size = new Size(308, 47);
            lbl_titol.TabIndex = 22;
            lbl_titol.Text = "La Força ᕙ(•̀‸•́‶)ᕗ";
            // 
            // lbl_data_registre
            // 
            lbl_data_registre.AutoSize = true;
            lbl_data_registre.BackColor = Color.Transparent;
            lbl_data_registre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_registre.ForeColor = Color.Sienna;
            lbl_data_registre.Location = new Point(128, 441);
            lbl_data_registre.Name = "lbl_data_registre";
            lbl_data_registre.Size = new Size(72, 21);
            lbl_data_registre.TabIndex = 23;
            lbl_data_registre.Text = "Registre";
            // 
            // picBox_primer
            // 
            picBox_primer.Image = (Image)resources.GetObject("picBox_primer.Image");
            picBox_primer.Location = new Point(238, 497);
            picBox_primer.Name = "picBox_primer";
            picBox_primer.Size = new Size(50, 50);
            picBox_primer.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_primer.TabIndex = 2;
            picBox_primer.TabStop = false;
            picBox_primer.Click += picBox_primer_Click;
            // 
            // picBox_ultim
            // 
            picBox_ultim.Image = (Image)resources.GetObject("picBox_ultim.Image");
            picBox_ultim.Location = new Point(406, 497);
            picBox_ultim.Name = "picBox_ultim";
            picBox_ultim.Size = new Size(50, 50);
            picBox_ultim.SizeMode = PictureBoxSizeMode.Zoom;
            picBox_ultim.TabIndex = 4;
            picBox_ultim.TabStop = false;
            picBox_ultim.Click += picBox_ultim_Click;
            // 
            // dateTimePicker_registre
            // 
            dateTimePicker_registre.CalendarFont = new Font("Segoe UI", 9F);
            dateTimePicker_registre.Font = new Font("Segoe UI", 9F);
            dateTimePicker_registre.Location = new Point(214, 445);
            dateTimePicker_registre.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePicker_registre.Name = "dateTimePicker_registre";
            dateTimePicker_registre.Size = new Size(200, 23);
            dateTimePicker_registre.TabIndex = 24;
            // 
            // lbl_activitats
            // 
            lbl_activitats.AutoSize = true;
            lbl_activitats.BackColor = Color.Transparent;
            lbl_activitats.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_activitats.ForeColor = Color.Sienna;
            lbl_activitats.Location = new Point(450, 279);
            lbl_activitats.Name = "lbl_activitats";
            lbl_activitats.Size = new Size(82, 21);
            lbl_activitats.TabIndex = 25;
            lbl_activitats.Text = "Activitats";
            // 
            // btn_tancar
            // 
            btn_tancar.BackColor = Color.Transparent;
            btn_tancar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tancar.ForeColor = Color.Sienna;
            btn_tancar.Location = new Point(672, 5);
            btn_tancar.Name = "btn_tancar";
            btn_tancar.Size = new Size(23, 23);
            btn_tancar.TabIndex = 26;
            btn_tancar.Text = "X";
            btn_tancar.UseVisualStyleBackColor = false;
            btn_tancar.Click += btn_tancar_Click;
            // 
            // picbox_floppy
            // 
            picbox_floppy.Image = (Image)resources.GetObject("picbox_floppy.Image");
            picbox_floppy.Location = new Point(467, 478);
            picbox_floppy.Name = "picbox_floppy";
            picbox_floppy.Size = new Size(80, 83);
            picbox_floppy.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_floppy.TabIndex = 27;
            picbox_floppy.TabStop = false;
            picbox_floppy.Visible = false;
            picbox_floppy.Click += picbox_floppy_Click;
            // 
            // picbox_addSoci
            // 
            picbox_addSoci.BackColor = Color.DarkOrange;
            picbox_addSoci.BorderStyle = BorderStyle.FixedSingle;
            picbox_addSoci.Image = (Image)resources.GetObject("picbox_addSoci.Image");
            picbox_addSoci.Location = new Point(468, 478);
            picbox_addSoci.Name = "picbox_addSoci";
            picbox_addSoci.Size = new Size(79, 83);
            picbox_addSoci.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_addSoci.TabIndex = 28;
            picbox_addSoci.TabStop = false;
            picbox_addSoci.Visible = false;
            picbox_addSoci.Click += picbox_addSoci_Click;
            // 
            // chcklist_activitats
            // 
            chcklist_activitats.FormattingEnabled = true;
            chcklist_activitats.Items.AddRange(new object[] { "Zumba", "Natació", "Pilates", "Ioga", "Futbol", "Basquetbol", "Tennis", "Golf", "Hípica" });
            chcklist_activitats.Location = new Point(431, 303);
            chcklist_activitats.Name = "chcklist_activitats";
            chcklist_activitats.Size = new Size(124, 166);
            chcklist_activitats.TabIndex = 31;
            // 
            // picbox_borrar
            // 
            picbox_borrar.BorderStyle = BorderStyle.FixedSingle;
            picbox_borrar.Image = (Image)resources.GetObject("picbox_borrar.Image");
            picbox_borrar.Location = new Point(468, 478);
            picbox_borrar.Name = "picbox_borrar";
            picbox_borrar.Size = new Size(79, 86);
            picbox_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_borrar.TabIndex = 32;
            picbox_borrar.TabStop = false;
            picbox_borrar.Visible = false;
            picbox_borrar.Click += picbox_borrar_Click;
            // 
            // Inici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 681);
            Controls.Add(picbox_borrar);
            Controls.Add(chcklist_activitats);
            Controls.Add(picbox_addSoci);
            Controls.Add(picbox_floppy);
            Controls.Add(btn_tancar);
            Controls.Add(lbl_activitats);
            Controls.Add(dateTimePicker_registre);
            Controls.Add(lbl_data_registre);
            Controls.Add(lbl_titol);
            Controls.Add(lbl_titolSoci);
            Controls.Add(picbox_foto);
            Controls.Add(txtbox_mail);
            Controls.Add(txtbox_telefon);
            Controls.Add(txtbox_direccio);
            Controls.Add(txtbox_cognomsSoci);
            Controls.Add(txtbox_nomSoci);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_afegirNouSoci);
            Controls.Add(lbl_mail);
            Controls.Add(lbl_telefon);
            Controls.Add(lbl_direccio);
            Controls.Add(lbl_cognomsSoci);
            Controls.Add(lbl_nomSoci);
            Controls.Add(picBox_ultim);
            Controls.Add(picBox_dreta);
            Controls.Add(picBox_primer);
            Controls.Add(picBox_esquerre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inici";
            ((System.ComponentModel.ISupportInitialize)picBox_esquerre).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_dreta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_foto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_primer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_ultim).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_floppy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_addSoci).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox_borrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBox_esquerre;
        private PictureBox picBox_dreta;
        private Label lbl_nomSoci;
        private Label lbl_cognomsSoci;
        private Label lbl_direccio;
        private Label lbl_telefon;
        private Label lbl_mail;
        private Button btn_afegirNouSoci;
        private Button btn_modificar;
        private Button btn_eliminar;
        private TextBox txtbox_nomSoci;
        private TextBox txtbox_cognomsSoci;
        private TextBox txtbox_direccio;
        private TextBox txtbox_telefon;
        private TextBox txtbox_mail;
        private PictureBox picbox_foto;
        private Label lbl_titolSoci;
        private Label lbl_titol;
        private Label lbl_data_registre;
        private PictureBox picBox_primer;
        private PictureBox picBox_ultim;
        private DateTimePicker dateTimePicker_registre;
        private Label lbl_activitats;
        private Button btn_tancar;
        private PictureBox picbox_floppy;
        private PictureBox picbox_addSoci;
        private CheckedListBox chcklist_activitats;
        private PictureBox picbox_borrar;
    }
}
