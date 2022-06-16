
namespace Partner_app
{
    partial class products
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
            this.listProduct = new System.Windows.Forms.GroupBox();
            this.pdgv = new System.Windows.Forms.DataGridView();
            this.meuu = new System.Windows.Forms.GroupBox();
            this.help = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.GroupBox();
            this.logout = new System.Windows.Forms.Button();
            this.proflie = new System.Windows.Forms.Button();
            this.detailProduct = new System.Windows.Forms.GroupBox();
            this.noticeContent = new System.Windows.Forms.TextBox();
            this.notice = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SL_ConLai = new System.Windows.Forms.TextBox();
            this.pquantityLabel = new System.Windows.Forms.Label();
            this.TenSP = new System.Windows.Forms.TextBox();
            this.pnameLabel = new System.Windows.Forms.Label();
            this.DonGia = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.partner = new System.Windows.Forms.Label();
            this.listProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdgv)).BeginInit();
            this.meuu.SuspendLayout();
            this.account.SuspendLayout();
            this.detailProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProduct
            // 
            this.listProduct.Controls.Add(this.pdgv);
            this.listProduct.Location = new System.Drawing.Point(12, 192);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(783, 399);
            this.listProduct.TabIndex = 0;
            this.listProduct.TabStop = false;
            this.listProduct.Text = "Danh sách sản phẩm";
            // 
            // pdgv
            // 
            this.pdgv.ColumnHeadersHeight = 29;
            this.pdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pdgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pdgv.Location = new System.Drawing.Point(6, 37);
            this.pdgv.Name = "pdgv";
            this.pdgv.ReadOnly = true;
            this.pdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.pdgv.RowTemplate.Height = 29;
            this.pdgv.Size = new System.Drawing.Size(770, 349);
            this.pdgv.TabIndex = 0;
            this.pdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pdgv_CellClick);
            // 
            // meuu
            // 
            this.meuu.Controls.Add(this.help);
            this.meuu.Controls.Add(this.dashboard);
            this.meuu.Controls.Add(this.order);
            this.meuu.Controls.Add(this.product);
            this.meuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meuu.Location = new System.Drawing.Point(12, 31);
            this.meuu.Name = "meuu";
            this.meuu.Size = new System.Drawing.Size(475, 70);
            this.meuu.TabIndex = 1;
            this.meuu.TabStop = false;
            this.meuu.Text = "Menu";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(343, 25);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(117, 36);
            this.help.TabIndex = 5;
            this.help.Text = "Hỗ trợ";
            this.help.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.Location = new System.Drawing.Point(235, 25);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(117, 36);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "Thống kê";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(120, 25);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(117, 36);
            this.order.TabIndex = 4;
            this.order.Text = "Đơn hàng";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product.Location = new System.Drawing.Point(6, 25);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(117, 36);
            this.product.TabIndex = 3;
            this.product.Text = "Sản phẩm";
            this.product.UseVisualStyleBackColor = false;
            // 
            // account
            // 
            this.account.Controls.Add(this.logout);
            this.account.Controls.Add(this.proflie);
            this.account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account.Location = new System.Drawing.Point(1007, 31);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(239, 70);
            this.account.TabIndex = 6;
            this.account.TabStop = false;
            this.account.Text = "Tài khoản";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(116, 25);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(117, 36);
            this.logout.TabIndex = 3;
            this.logout.Text = "Đăng xuất";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // proflie
            // 
            this.proflie.Location = new System.Drawing.Point(0, 25);
            this.proflie.Name = "proflie";
            this.proflie.Size = new System.Drawing.Size(117, 36);
            this.proflie.TabIndex = 2;
            this.proflie.Text = "Thông tin";
            this.proflie.UseVisualStyleBackColor = true;
            // 
            // detailProduct
            // 
            this.detailProduct.Controls.Add(this.noticeContent);
            this.detailProduct.Controls.Add(this.notice);
            this.detailProduct.Controls.Add(this.delete);
            this.detailProduct.Controls.Add(this.edit);
            this.detailProduct.Controls.Add(this.reset);
            this.detailProduct.Controls.Add(this.add);
            this.detailProduct.Controls.Add(this.SL_ConLai);
            this.detailProduct.Controls.Add(this.pquantityLabel);
            this.detailProduct.Controls.Add(this.TenSP);
            this.detailProduct.Controls.Add(this.pnameLabel);
            this.detailProduct.Controls.Add(this.DonGia);
            this.detailProduct.Controls.Add(this.priceLabel);
            this.detailProduct.Controls.Add(this.MaSP);
            this.detailProduct.Controls.Add(this.idLabel);
            this.detailProduct.Location = new System.Drawing.Point(810, 192);
            this.detailProduct.Name = "detailProduct";
            this.detailProduct.Size = new System.Drawing.Size(442, 399);
            this.detailProduct.TabIndex = 7;
            this.detailProduct.TabStop = false;
            this.detailProduct.Text = "Chi tiết sản phẩm";
            this.detailProduct.Enter += new System.EventHandler(this.detailProduct_Enter);
            // 
            // noticeContent
            // 
            this.noticeContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noticeContent.Location = new System.Drawing.Point(125, 259);
            this.noticeContent.Name = "noticeContent";
            this.noticeContent.ReadOnly = true;
            this.noticeContent.Size = new System.Drawing.Size(296, 20);
            this.noticeContent.TabIndex = 15;
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Location = new System.Drawing.Point(6, 259);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(81, 20);
            this.notice.TabIndex = 14;
            this.notice.Text = "Thông báo";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(290, 300);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 38);
            this.delete.TabIndex = 13;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(163, 300);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(106, 38);
            this.edit.TabIndex = 12;
            this.edit.Text = "Chỉnh sửa";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(290, 355);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(106, 38);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(163, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 38);
            this.add.TabIndex = 8;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // SL_ConLai
            // 
            this.SL_ConLai.Location = new System.Drawing.Point(125, 204);
            this.SL_ConLai.Name = "SL_ConLai";
            this.SL_ConLai.Size = new System.Drawing.Size(296, 27);
            this.SL_ConLai.TabIndex = 7;
            // 
            // pquantityLabel
            // 
            this.pquantityLabel.AutoSize = true;
            this.pquantityLabel.Location = new System.Drawing.Point(6, 204);
            this.pquantityLabel.Name = "pquantityLabel";
            this.pquantityLabel.Size = new System.Drawing.Size(69, 20);
            this.pquantityLabel.TabIndex = 6;
            this.pquantityLabel.Text = "Số lượng";
            // 
            // TenSP
            // 
            this.TenSP.Location = new System.Drawing.Point(125, 100);
            this.TenSP.Name = "TenSP";
            this.TenSP.Size = new System.Drawing.Size(296, 27);
            this.TenSP.TabIndex = 5;
            // 
            // pnameLabel
            // 
            this.pnameLabel.AutoSize = true;
            this.pnameLabel.Location = new System.Drawing.Point(6, 107);
            this.pnameLabel.Name = "pnameLabel";
            this.pnameLabel.Size = new System.Drawing.Size(100, 20);
            this.pnameLabel.TabIndex = 4;
            this.pnameLabel.Text = "Tên sản phẩm";
            // 
            // DonGia
            // 
            this.DonGia.Location = new System.Drawing.Point(125, 153);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(296, 27);
            this.DonGia.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 153);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Đơn giá";
            // 
            // MaSP
            // 
            this.MaSP.Location = new System.Drawing.Point(125, 46);
            this.MaSP.Name = "MaSP";
            this.MaSP.Size = new System.Drawing.Size(296, 27);
            this.MaSP.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Mã";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(619, 142);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(94, 29);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Tìm kiếm";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(56, 143);
            this.search.Name = "search";
            this.search.PlaceholderText = "Sản phẩm bạn tìm kiếm là ?";
            this.search.Size = new System.Drawing.Size(568, 27);
            this.search.TabIndex = 16;
            // 
            // partner
            // 
            this.partner.AutoSize = true;
            this.partner.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.partner.Location = new System.Drawing.Point(1007, 8);
            this.partner.Name = "partner";
            this.partner.Size = new System.Drawing.Size(72, 25);
            this.partner.TabIndex = 17;
            this.partner.Text = "Đối tác";
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 673);
            this.Controls.Add(this.partner);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.detailProduct);
            this.Controls.Add(this.account);
            this.Controls.Add(this.meuu);
            this.Controls.Add(this.listProduct);
            this.Name = "products";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.products_Load);
            this.listProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdgv)).EndInit();
            this.meuu.ResumeLayout(false);
            this.account.ResumeLayout(false);
            this.detailProduct.ResumeLayout(false);
            this.detailProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listProduct;
        private System.Windows.Forms.DataGridView pdgv;
        private System.Windows.Forms.GroupBox meuu;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.GroupBox account;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button proflie;
        private System.Windows.Forms.GroupBox detailProduct;
        private System.Windows.Forms.TextBox SL_ConLai;
        private System.Windows.Forms.Label pquantityLabel;
        private System.Windows.Forms.TextBox TenSP;
        private System.Windows.Forms.Label pnameLabel;
        private System.Windows.Forms.TextBox DonGia;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox MaSP;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox noticeContent;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label partner;
    }
}

