namespace WindowsFormsApp
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.BtnP2P = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPlay2Comp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnBunifExit = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnP2P
            // 
            this.BtnP2P.Activecolor = System.Drawing.Color.Cyan;
            this.BtnP2P.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnP2P.BackColor = System.Drawing.Color.Cyan;
            this.BtnP2P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnP2P.BorderRadius = 5;
            this.BtnP2P.ButtonText = "        Player vs Player";
            this.BtnP2P.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnP2P.DisabledColor = System.Drawing.Color.Gray;
            this.BtnP2P.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnP2P.Iconimage = null;
            this.BtnP2P.Iconimage_right = null;
            this.BtnP2P.Iconimage_right_Selected = null;
            this.BtnP2P.Iconimage_Selected = null;
            this.BtnP2P.IconMarginLeft = 0;
            this.BtnP2P.IconMarginRight = 0;
            this.BtnP2P.IconRightVisible = true;
            this.BtnP2P.IconRightZoom = 0D;
            this.BtnP2P.IconVisible = true;
            this.BtnP2P.IconZoom = 90D;
            this.BtnP2P.IsTab = false;
            this.BtnP2P.Location = new System.Drawing.Point(168, 137);
            this.BtnP2P.Name = "BtnP2P";
            this.BtnP2P.Normalcolor = System.Drawing.Color.Cyan;
            this.BtnP2P.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(188)))));
            this.BtnP2P.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnP2P.selected = true;
            this.BtnP2P.Size = new System.Drawing.Size(168, 36);
            this.BtnP2P.TabIndex = 0;
            this.BtnP2P.Text = "        Player vs Player";
            this.BtnP2P.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnP2P.Textcolor = System.Drawing.Color.Black;
            this.BtnP2P.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP2P.Click += new System.EventHandler(this.BtnP2P_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.TicTac;
            this.pictureBox1.Location = new System.Drawing.Point(420, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPlay2Comp
            // 
            this.BtnPlay2Comp.Activecolor = System.Drawing.Color.Cyan;
            this.BtnPlay2Comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPlay2Comp.BackColor = System.Drawing.Color.Cyan;
            this.BtnPlay2Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPlay2Comp.BorderRadius = 5;
            this.BtnPlay2Comp.ButtonText = "    Player vs Computer";
            this.BtnPlay2Comp.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPlay2Comp.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPlay2Comp.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPlay2Comp.Iconimage = null;
            this.BtnPlay2Comp.Iconimage_right = null;
            this.BtnPlay2Comp.Iconimage_right_Selected = null;
            this.BtnPlay2Comp.Iconimage_Selected = null;
            this.BtnPlay2Comp.IconMarginLeft = 0;
            this.BtnPlay2Comp.IconMarginRight = 0;
            this.BtnPlay2Comp.IconRightVisible = true;
            this.BtnPlay2Comp.IconRightZoom = 0D;
            this.BtnPlay2Comp.IconVisible = true;
            this.BtnPlay2Comp.IconZoom = 90D;
            this.BtnPlay2Comp.IsTab = false;
            this.BtnPlay2Comp.Location = new System.Drawing.Point(168, 202);
            this.BtnPlay2Comp.Name = "BtnPlay2Comp";
            this.BtnPlay2Comp.Normalcolor = System.Drawing.Color.Cyan;
            this.BtnPlay2Comp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(188)))));
            this.BtnPlay2Comp.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPlay2Comp.selected = true;
            this.BtnPlay2Comp.Size = new System.Drawing.Size(168, 36);
            this.BtnPlay2Comp.TabIndex = 4;
            this.BtnPlay2Comp.Text = "    Player vs Computer";
            this.BtnPlay2Comp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPlay2Comp.Textcolor = System.Drawing.Color.Black;
            this.BtnPlay2Comp.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay2Comp.Click += new System.EventHandler(this.BtnPlay2Comp_Click);
            // 
            // BtnBunifExit
            // 
            this.BtnBunifExit.Activecolor = System.Drawing.Color.Cyan;
            this.BtnBunifExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBunifExit.BackColor = System.Drawing.Color.Red;
            this.BtnBunifExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBunifExit.BorderRadius = 5;
            this.BtnBunifExit.ButtonText = "          Exit";
            this.BtnBunifExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBunifExit.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBunifExit.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBunifExit.Iconimage = null;
            this.BtnBunifExit.Iconimage_right = null;
            this.BtnBunifExit.Iconimage_right_Selected = null;
            this.BtnBunifExit.Iconimage_Selected = null;
            this.BtnBunifExit.IconMarginLeft = 0;
            this.BtnBunifExit.IconMarginRight = 0;
            this.BtnBunifExit.IconRightVisible = true;
            this.BtnBunifExit.IconRightZoom = 0D;
            this.BtnBunifExit.IconVisible = true;
            this.BtnBunifExit.IconZoom = 90D;
            this.BtnBunifExit.IsTab = false;
            this.BtnBunifExit.Location = new System.Drawing.Point(192, 297);
            this.BtnBunifExit.Name = "BtnBunifExit";
            this.BtnBunifExit.Normalcolor = System.Drawing.Color.Red;
            this.BtnBunifExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(80)))), ((int)(((byte)(68)))));
            this.BtnBunifExit.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBunifExit.selected = true;
            this.BtnBunifExit.Size = new System.Drawing.Size(103, 36);
            this.BtnBunifExit.TabIndex = 5;
            this.BtnBunifExit.Text = "          Exit";
            this.BtnBunifExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBunifExit.Textcolor = System.Drawing.Color.White;
            this.BtnBunifExit.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBunifExit.Click += new System.EventHandler(this.BtnBunifExit_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(499, 356);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBunifExit);
            this.Controls.Add(this.BtnPlay2Comp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnP2P);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayForm";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "TIC - TAC - TOE";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton BtnP2P;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPlay2Comp;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBunifExit;
    }
}