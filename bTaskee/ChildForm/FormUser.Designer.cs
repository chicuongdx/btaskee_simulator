
namespace bTaskee.ChildForm
{
    partial class FormUser
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
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.pctAvatar = new System.Windows.Forms.PictureBox();
            this.pctAvatar_Inf = new System.Windows.Forms.PictureBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar_Inf)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUser.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUser.Controls.Add(this.lbMail);
            this.pnlUser.Controls.Add(this.lbPhone);
            this.pnlUser.Controls.Add(this.lbAdress);
            this.pnlUser.Controls.Add(this.lbName);
            this.pnlUser.Controls.Add(this.pctAvatar_Inf);
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(300, 431);
            this.pnlUser.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(584, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(585, 168);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(210, 23);
            this.txtAdress.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(585, 249);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(210, 23);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(586, 333);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 23);
            this.txtMail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 17);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "No Name";
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackgroundImage = global::bTaskee.Properties.Resources.photo_camera;
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvatar.Location = new System.Drawing.Point(474, 119);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(30, 30);
            this.btnAvatar.TabIndex = 3;
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // pctAvatar
            // 
            this.pctAvatar.BackgroundImage = global::bTaskee.Properties.Resources.No_sign;
            this.pctAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctAvatar.Location = new System.Drawing.Point(368, 49);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.Size = new System.Drawing.Size(100, 100);
            this.pctAvatar.TabIndex = 1;
            this.pctAvatar.TabStop = false;
            // 
            // pctAvatar_Inf
            // 
            this.pctAvatar_Inf.BackgroundImage = global::bTaskee.Properties.Resources.No_sign;
            this.pctAvatar_Inf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctAvatar_Inf.Location = new System.Drawing.Point(100, 12);
            this.pctAvatar_Inf.Name = "pctAvatar_Inf";
            this.pctAvatar_Inf.Size = new System.Drawing.Size(100, 100);
            this.pctAvatar_Inf.TabIndex = 1;
            this.pctAvatar_Inf.TabStop = false;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(12, 172);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(58, 17);
            this.lbAdress.TabIndex = 2;
            this.lbAdress.Text = "Adress";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(12, 220);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(54, 17);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(12, 268);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(37, 17);
            this.lbMail.TabIndex = 2;
            this.lbMail.Text = "Mail";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(682, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 434);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctAvatar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlUser);
            this.Name = "FormUser";
            this.Text = "USER";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar_Inf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pctAvatar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.PictureBox pctAvatar_Inf;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Button btnUpdate;
    }
}