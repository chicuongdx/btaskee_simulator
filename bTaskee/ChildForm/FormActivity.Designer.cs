
namespace bTaskee.ChildForm
{
    partial class FormActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivity));
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.pnlSerInf = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lbSer = new System.Windows.Forms.Label();
            this.lbNumSer = new System.Windows.Forms.Label();
            this.imgLstSer = new System.Windows.Forms.ImageList(this.components);
            this.lstViewData = new System.Windows.Forms.ListView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pnlInfor.SuspendLayout();
            this.pnlSerInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfor
            // 
            this.pnlInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfor.Controls.Add(this.pnlSerInf);
            this.pnlInfor.Controls.Add(this.lbNumSer);
            this.pnlInfor.Location = new System.Drawing.Point(1, 12);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(234, 410);
            this.pnlInfor.TabIndex = 0;
            // 
            // pnlSerInf
            // 
            this.pnlSerInf.Controls.Add(this.btnCheck);
            this.pnlSerInf.Controls.Add(this.btnHuy);
            this.pnlSerInf.Controls.Add(this.btnPay);
            this.pnlSerInf.Controls.Add(this.label3);
            this.pnlSerInf.Controls.Add(this.label4);
            this.pnlSerInf.Controls.Add(this.label2);
            this.pnlSerInf.Controls.Add(this.label5);
            this.pnlSerInf.Controls.Add(this.label1);
            this.pnlSerInf.Controls.Add(this.txtSale);
            this.pnlSerInf.Controls.Add(this.txtHour);
            this.pnlSerInf.Controls.Add(this.txtTime);
            this.pnlSerInf.Controls.Add(this.txtPay);
            this.pnlSerInf.Controls.Add(this.txtBill);
            this.pnlSerInf.Controls.Add(this.lbSer);
            this.pnlSerInf.Location = new System.Drawing.Point(3, 34);
            this.pnlSerInf.Name = "pnlSerInf";
            this.pnlSerInf.Size = new System.Drawing.Size(228, 311);
            this.pnlSerInf.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(49, 248);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 60);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(140, 248);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(85, 60);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giờ làm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thanh toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá:";
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.Location = new System.Drawing.Point(99, 162);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(100, 23);
            this.txtSale.TabIndex = 1;
            this.txtSale.TextChanged += new System.EventHandler(this.txtSale_TextChanged);
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(99, 79);
            this.txtHour.Name = "txtHour";
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(100, 23);
            this.txtHour.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(99, 40);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 23);
            this.txtTime.TabIndex = 1;
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(99, 205);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(100, 23);
            this.txtPay.TabIndex = 1;
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(99, 118);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(100, 23);
            this.txtBill.TabIndex = 1;
            // 
            // lbSer
            // 
            this.lbSer.AutoSize = true;
            this.lbSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSer.Location = new System.Drawing.Point(0, 17);
            this.lbSer.Name = "lbSer";
            this.lbSer.Size = new System.Drawing.Size(62, 17);
            this.lbSer.TabIndex = 0;
            this.lbSer.Text = "Dịch vụ";
            // 
            // lbNumSer
            // 
            this.lbNumSer.AutoSize = true;
            this.lbNumSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSer.Location = new System.Drawing.Point(3, 11);
            this.lbNumSer.Name = "lbNumSer";
            this.lbNumSer.Size = new System.Drawing.Size(142, 20);
            this.lbNumSer.TabIndex = 0;
            this.lbNumSer.Text = "Số lượng dịch vụ: 0";
            // 
            // imgLstSer
            // 
            this.imgLstSer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstSer.ImageStream")));
            this.imgLstSer.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstSer.Images.SetKeyName(0, "cleaning.png");
            this.imgLstSer.Images.SetKeyName(1, "deepcleaning.png");
            this.imgLstSer.Images.SetKeyName(2, "groceries.png");
            this.imgLstSer.Images.SetKeyName(3, "air-conditioner.png");
            this.imgLstSer.Images.SetKeyName(4, "bactericide.png");
            this.imgLstSer.Images.SetKeyName(5, "cooking.png");
            this.imgLstSer.Images.SetKeyName(6, "washing-machine.png");
            // 
            // lstViewData
            // 
            this.lstViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewData.GridLines = true;
            this.lstViewData.HideSelection = false;
            this.lstViewData.Location = new System.Drawing.Point(241, 12);
            this.lstViewData.Name = "lstViewData";
            this.lstViewData.Size = new System.Drawing.Size(581, 410);
            this.lstViewData.TabIndex = 1;
            this.lstViewData.UseCompatibleStateImageBehavior = false;
            this.lstViewData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewData_ItemSelectionChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(203, 164);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(20, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = ".";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 434);
            this.Controls.Add(this.lstViewData);
            this.Controls.Add(this.pnlInfor);
            this.Name = "FormActivity";
            this.Text = "ACTIVITY";
            this.Load += new System.EventHandler(this.FormActivity_Load);
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            this.pnlSerInf.ResumeLayout(false);
            this.pnlSerInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.ImageList imgLstSer;
        private System.Windows.Forms.ListView lstViewData;
        private System.Windows.Forms.Label lbNumSer;
        private System.Windows.Forms.Panel pnlSerInf;
        private System.Windows.Forms.Label lbSer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnCheck;
    }
}