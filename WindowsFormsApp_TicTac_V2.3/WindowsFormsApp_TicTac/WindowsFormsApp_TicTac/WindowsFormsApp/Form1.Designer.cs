namespace WindowsFormsApp
{
    partial class UneForme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UneForme));
            this.BtnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BunifuPlayer1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BunifuPlayer2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MtrTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MtrBtnBackM = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.Activecolor = System.Drawing.Color.Cyan;
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.BackColor = System.Drawing.Color.Cyan;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReset.BorderRadius = 5;
            this.BtnReset.ButtonText = "        Reset";
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnReset.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReset.Iconimage = null;
            this.BtnReset.Iconimage_right = null;
            this.BtnReset.Iconimage_right_Selected = null;
            this.BtnReset.Iconimage_Selected = null;
            this.BtnReset.IconMarginLeft = 0;
            this.BtnReset.IconMarginRight = 0;
            this.BtnReset.IconRightVisible = true;
            this.BtnReset.IconRightZoom = 0D;
            this.BtnReset.IconVisible = true;
            this.BtnReset.IconZoom = 90D;
            this.BtnReset.IsTab = false;
            this.BtnReset.Location = new System.Drawing.Point(520, 26);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Normalcolor = System.Drawing.Color.Cyan;
            this.BtnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(188)))));
            this.BtnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnReset.selected = true;
            this.BtnReset.Size = new System.Drawing.Size(100, 34);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "        Reset";
            this.BtnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Textcolor = System.Drawing.Color.Black;
            this.BtnReset.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BunifuPlayer1
            // 
            this.BunifuPlayer1.BackColor = System.Drawing.Color.White;
            this.BunifuPlayer1.BorderColorFocused = System.Drawing.Color.LightCoral;
            this.BunifuPlayer1.BorderColorIdle = System.Drawing.Color.DarkRed;
            this.BunifuPlayer1.BorderColorMouseHover = System.Drawing.Color.Cyan;
            this.BunifuPlayer1.BorderThickness = 2;
            this.BunifuPlayer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunifuPlayer1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BunifuPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BunifuPlayer1.isPassword = false;
            this.BunifuPlayer1.Location = new System.Drawing.Point(546, 97);
            this.BunifuPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.BunifuPlayer1.Name = "BunifuPlayer1";
            this.BunifuPlayer1.Size = new System.Drawing.Size(229, 34);
            this.BunifuPlayer1.TabIndex = 6;
            this.BunifuPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BunifuPlayer1.OnValueChanged += new System.EventHandler(this.BunifuPlayer1_OnValueChanged);
            // 
            // BunifuPlayer2
            // 
            this.BunifuPlayer2.BackColor = System.Drawing.Color.White;
            this.BunifuPlayer2.BorderColorFocused = System.Drawing.Color.LightCoral;
            this.BunifuPlayer2.BorderColorIdle = System.Drawing.Color.DarkRed;
            this.BunifuPlayer2.BorderColorMouseHover = System.Drawing.Color.Cyan;
            this.BunifuPlayer2.BorderThickness = 2;
            this.BunifuPlayer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BunifuPlayer2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BunifuPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BunifuPlayer2.isPassword = false;
            this.BunifuPlayer2.Location = new System.Drawing.Point(546, 147);
            this.BunifuPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.BunifuPlayer2.Name = "BunifuPlayer2";
            this.BunifuPlayer2.Size = new System.Drawing.Size(229, 34);
            this.BunifuPlayer2.TabIndex = 7;
            this.BunifuPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(465, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 15);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(465, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 15);
            this.panel2.TabIndex = 10;
            // 
            // MtrTextBox
            // 
            this.MtrTextBox.Location = new System.Drawing.Point(464, 213);
            this.MtrTextBox.Multiline = true;
            this.MtrTextBox.Name = "MtrTextBox";
            this.MtrTextBox.ReadOnly = true;
            this.MtrTextBox.Size = new System.Drawing.Size(339, 205);
            this.MtrTextBox.TabIndex = 11;
            this.MtrTextBox.Text = "metroTextBox1";
            // 
            // MtrBtnBackM
            // 
            this.MtrBtnBackM.Location = new System.Drawing.Point(657, 26);
            this.MtrBtnBackM.Name = "MtrBtnBackM";
            this.MtrBtnBackM.Size = new System.Drawing.Size(90, 33);
            this.MtrBtnBackM.TabIndex = 20;
            this.MtrBtnBackM.Text = "Back Menu";
            this.MtrBtnBackM.Click += new System.EventHandler(this.MtrBtnBackM_Click);
            // 
            // UneForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MtrBtnBackM);
            this.Controls.Add(this.MtrTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BunifuPlayer2);
            this.Controls.Add(this.BunifuPlayer1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnReset);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UneForme";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Player vs Player";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton BtnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox BunifuPlayer1;
        private Bunifu.Framework.UI.BunifuMetroTextbox BunifuPlayer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox MtrTextBox;
        private MetroFramework.Controls.MetroButton MtrBtnBackM;
    }
}

