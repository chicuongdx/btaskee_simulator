
namespace bTaskee
{
    partial class bTaskee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bTaskee));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.imgLstIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnActivty = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pctIcon = new System.Windows.Forms.PictureBox();
            this.pnlTileBar = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnZoomIO = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTile = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).BeginInit();
            this.pnlTileBar.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnActivty);
            this.pnlMenu.Controls.Add(this.btnService);
            this.pnlMenu.Controls.Add(this.pnlIcon);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 494);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.CausesValidation = false;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageKey = "profile.png";
            this.btnUser.ImageList = this.imgLstIcon;
            this.btnUser.Location = new System.Drawing.Point(0, 190);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(200, 60);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Người dùng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // imgLstIcon
            // 
            this.imgLstIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcon.ImageStream")));
            this.imgLstIcon.TransparentColor = System.Drawing.Color.Firebrick;
            this.imgLstIcon.Images.SetKeyName(0, "broom.png");
            this.imgLstIcon.Images.SetKeyName(1, "carts.png");
            this.imgLstIcon.Images.SetKeyName(2, "profile.png");
            // 
            // btnActivty
            // 
            this.btnActivty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnActivty.CausesValidation = false;
            this.btnActivty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivty.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActivty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivty.ImageKey = "carts.png";
            this.btnActivty.ImageList = this.imgLstIcon;
            this.btnActivty.Location = new System.Drawing.Point(0, 130);
            this.btnActivty.Margin = new System.Windows.Forms.Padding(0);
            this.btnActivty.Name = "btnActivty";
            this.btnActivty.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActivty.Size = new System.Drawing.Size(200, 60);
            this.btnActivty.TabIndex = 1;
            this.btnActivty.Text = "Hoạt động";
            this.btnActivty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivty.UseVisualStyleBackColor = false;
            this.btnActivty.Click += new System.EventHandler(this.btnActivty_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnService.CausesValidation = false;
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.ImageKey = "broom.png";
            this.btnService.ImageList = this.imgLstIcon;
            this.btnService.Location = new System.Drawing.Point(0, 70);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(200, 60);
            this.btnService.TabIndex = 0;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlIcon.Controls.Add(this.pctIcon);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(200, 70);
            this.pnlIcon.TabIndex = 0;
            // 
            // pctIcon
            // 
            this.pctIcon.BackgroundImage = global::bTaskee.Properties.Resources.apitherapy;
            this.pctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctIcon.Location = new System.Drawing.Point(0, 0);
            this.pctIcon.Name = "pctIcon";
            this.pctIcon.Size = new System.Drawing.Size(200, 68);
            this.pctIcon.TabIndex = 0;
            this.pctIcon.TabStop = false;
            this.pctIcon.Click += new System.EventHandler(this.pctIcon_Click);
            // 
            // pnlTileBar
            // 
            this.pnlTileBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTileBar.Controls.Add(this.btnHide);
            this.pnlTileBar.Controls.Add(this.btnZoomIO);
            this.pnlTileBar.Controls.Add(this.btnClose);
            this.pnlTileBar.Controls.Add(this.lbTile);
            this.pnlTileBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTileBar.Name = "pnlTileBar";
            this.pnlTileBar.Size = new System.Drawing.Size(849, 70);
            this.pnlTileBar.TabIndex = 1;
            this.pnlTileBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTileBar_MouseMove);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackgroundImage = global::bTaskee.Properties.Resources.hide;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(744, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 30);
            this.btnHide.TabIndex = 3;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnZoomIO
            // 
            this.btnZoomIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIO.BackgroundImage = global::bTaskee.Properties.Resources.monitor;
            this.btnZoomIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIO.FlatAppearance.BorderSize = 0;
            this.btnZoomIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIO.Location = new System.Drawing.Point(780, 0);
            this.btnZoomIO.Name = "btnZoomIO";
            this.btnZoomIO.Size = new System.Drawing.Size(30, 30);
            this.btnZoomIO.TabIndex = 3;
            this.btnZoomIO.UseVisualStyleBackColor = true;
            this.btnZoomIO.Click += new System.EventHandler(this.btnZoomIO_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::bTaskee.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(816, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTile
            // 
            this.lbTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTile.AutoSize = true;
            this.lbTile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTile.ForeColor = System.Drawing.Color.White;
            this.lbTile.Location = new System.Drawing.Point(382, 21);
            this.lbTile.Name = "lbTile";
            this.lbTile.Size = new System.Drawing.Size(71, 23);
            this.lbTile.TabIndex = 0;
            this.lbTile.Text = "HOME";
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlChildForm.Controls.Add(this.lbDay);
            this.pnlChildForm.Controls.Add(this.lbDate);
            this.pnlChildForm.Controls.Add(this.lbSecond);
            this.pnlChildForm.Controls.Add(this.lbTime);
            this.pnlChildForm.Location = new System.Drawing.Point(200, 70);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(850, 424);
            this.pnlChildForm.TabIndex = 2;
            // 
            // lbDay
            // 
            this.lbDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDay.AutoSize = true;
            this.lbDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDay.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(86)))));
            this.lbDay.Location = new System.Drawing.Point(538, 240);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(242, 66);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "SUNDAY";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate.AutoSize = true;
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDate.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(86)))));
            this.lbDate.Location = new System.Drawing.Point(54, 240);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(404, 66);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "October 3 2016";
            // 
            // lbSecond
            // 
            this.lbSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSecond.AutoSize = true;
            this.lbSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSecond.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(86)))));
            this.lbSecond.Location = new System.Drawing.Point(450, 130);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(66, 50);
            this.lbSecond.TabIndex = 1;
            this.lbSecond.Text = "22";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTime.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(86)))));
            this.lbTime.Location = new System.Drawing.Point(164, 60);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(320, 130);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "22:22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bTaskee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1050, 495);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTileBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "bTaskee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "bTaskee";
            this.Load += new System.EventHandler(this.bTaskee_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIcon)).EndInit();
            this.pnlTileBar.ResumeLayout(false);
            this.pnlTileBar.PerformLayout();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ImageList imgLstIcon;
        private System.Windows.Forms.Button btnActivty;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Panel pnlTileBar;
        private System.Windows.Forms.Label lbTile;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnZoomIO;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctIcon;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Timer timer;
    }
}