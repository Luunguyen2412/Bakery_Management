namespace GUI
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pnControl = new System.Windows.Forms.Panel();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnInvoices = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.productUsrCtrl1 = new GUI.UsrCtrlManage.ProductUsrCtrl();
            this.pnControl.SuspendLayout();
            this.pnList.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.pnControl.Controls.Add(this.minimize);
            this.pnControl.Controls.Add(this.close);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1262, 36);
            this.pnControl.TabIndex = 0;
            // 
            // pnList
            // 
            this.pnList.BackColor = System.Drawing.SystemColors.Control;
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.btnInvoices);
            this.pnList.Controls.Add(this.btnCategory);
            this.pnList.Controls.Add(this.btnReport);
            this.pnList.Controls.Add(this.btnEmployee);
            this.pnList.Controls.Add(this.btnTable);
            this.pnList.Controls.Add(this.btnProduct);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 36);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(1262, 52);
            this.pnList.TabIndex = 1;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 50);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1262, 2);
            this.pnLine.TabIndex = 15;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.productUsrCtrl1);
            this.pnMain.Location = new System.Drawing.Point(0, 87);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1262, 562);
            this.pnMain.TabIndex = 2;
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnInvoices.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnInvoices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoices.IconSize = 18;
            this.btnInvoices.Location = new System.Drawing.Point(818, -2);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(205, 54);
            this.btnInvoices.TabIndex = 16;
            this.btnInvoices.Text = "INVOICES";
            this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.IconSize = 18;
            this.btnCategory.Location = new System.Drawing.Point(410, -2);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(205, 54);
            this.btnCategory.TabIndex = 14;
            this.btnCategory.Text = "CATEGORY";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 18;
            this.btnReport.Location = new System.Drawing.Point(1023, -2);
            this.btnReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(205, 54);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployee.IconSize = 18;
            this.btnEmployee.Location = new System.Drawing.Point(613, -2);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(205, 54);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTable.IconSize = 18;
            this.btnTable.Location = new System.Drawing.Point(205, -2);
            this.btnTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(205, 54);
            this.btnTable.TabIndex = 10;
            this.btnTable.Text = "TABLE";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.IconSize = 18;
            this.btnProduct.Location = new System.Drawing.Point(0, -2);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(205, 54);
            this.btnProduct.TabIndex = 9;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // minimize
            // 
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1170, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(38, 24);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 12;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1212, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 11;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // productUsrCtrl1
            // 
            this.productUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.productUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productUsrCtrl1.Location = new System.Drawing.Point(0, 0);
            this.productUsrCtrl1.Name = "productUsrCtrl1";
            this.productUsrCtrl1.Size = new System.Drawing.Size(1262, 562);
            this.productUsrCtrl1.TabIndex = 0;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 650);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.pnControl.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnList;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnTable;
        private FontAwesome.Sharp.IconButton btnProduct;
        private System.Windows.Forms.Panel pnLine;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton btnInvoices;
        private UsrCtrlManage.ProductUsrCtrl productUsrCtrl1;
    }
}