namespace Smart_POS_X.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Admin = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(40, 48);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(87, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(40, 93);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(87, 39);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // txt_ID
            // 
            this.tablePanel1.SetColumn(this.txt_ID, 2);
            this.txt_ID.Location = new System.Drawing.Point(133, 56);
            this.txt_ID.Name = "txt_ID";
            this.tablePanel1.SetRow(this.txt_ID, 1);
            this.txt_ID.Size = new System.Drawing.Size(179, 22);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.tablePanel1.SetColumn(this.txt_Password, 2);
            this.txt_Password.Location = new System.Drawing.Point(133, 101);
            this.txt_Password.Name = "txt_Password";
            this.tablePanel1.SetRow(this.txt_Password, 2);
            this.txt_Password.Size = new System.Drawing.Size(179, 22);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.tablePanel1.SetColumn(this.btn_Cancel, 3);
            this.btn_Cancel.Location = new System.Drawing.Point(318, 100);
            this.btn_Cancel.Name = "btn_Cancel";
            this.tablePanel1.SetRow(this.btn_Cancel, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(96, 25);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Admin
            // 
            this.tablePanel1.SetColumn(this.btn_Admin, 3);
            this.btn_Admin.Location = new System.Drawing.Point(318, 145);
            this.btn_Admin.Name = "btn_Admin";
            this.tablePanel1.SetRow(this.btn_Admin, 3);
            this.btn_Admin.Size = new System.Drawing.Size(96, 25);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "관리자";
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.btn_Login);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.txt_ID);
            this.tablePanel1.Controls.Add(this.txt_Password);
            this.tablePanel1.Controls.Add(this.btn_Cancel);
            this.tablePanel1.Controls.Add(this.btn_Admin);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(463, 224);
            this.tablePanel1.TabIndex = 7;
            // 
            // btn_Login
            // 
            this.tablePanel1.SetColumn(this.btn_Login, 3);
            this.btn_Login.Location = new System.Drawing.Point(318, 55);
            this.btn_Login.Name = "btn_Login";
            this.tablePanel1.SetRow(this.btn_Login, 1);
            this.btn_Login.Size = new System.Drawing.Size(96, 25);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "로그인";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 224);
            this.Controls.Add(this.tablePanel1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.LargeImage")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Admin;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
    }
}