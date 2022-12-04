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
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.IP = new DevExpress.XtraEditors.TextEdit();
            this.IPset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(40, 91);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(182, 91);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(40, 200);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(182, 91);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // txt_ID
            // 
            this.tablePanel1.SetColumn(this.txt_ID, 2);
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(242, 91);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Properties.Appearance.Options.UseFont = true;
            this.txt_ID.Properties.AutoHeight = false;
            this.txt_ID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetRow(this.txt_ID, 1);
            this.txt_ID.Size = new System.Drawing.Size(384, 91);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.tablePanel1.SetColumn(this.txt_Password, 2);
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Password.Location = new System.Drawing.Point(242, 200);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Properties.AutoHeight = false;
            this.txt_Password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetRow(this.txt_Password, 2);
            this.txt_Password.Size = new System.Drawing.Size(384, 91);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_Cancel, 4);
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Location = new System.Drawing.Point(666, 200);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.tablePanel1.SetRow(this.btn_Cancel, 2);
            this.btn_Cancel.Size = new System.Drawing.Size(182, 91);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_Admin, 4);
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Admin.Location = new System.Drawing.Point(666, 309);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_Admin.Name = "btn_Admin";
            this.tablePanel1.SetRow(this.btn_Admin, 3);
            this.btn_Admin.Size = new System.Drawing.Size(182, 64);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "관리자";
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)});
            this.tablePanel1.Controls.Add(this.toggleSwitch1);
            this.tablePanel1.Controls.Add(this.btn_Admin);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.IP);
            this.tablePanel1.Controls.Add(this.IPset);
            this.tablePanel1.Controls.Add(this.btn_Login);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.txt_ID);
            this.tablePanel1.Controls.Add(this.txt_Password);
            this.tablePanel1.Controls.Add(this.btn_Cancel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(888, 465);
            this.tablePanel1.TabIndex = 7;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // toggleSwitch1
            // 
            this.tablePanel1.SetColumn(this.toggleSwitch1, 1);
            this.toggleSwitch1.Location = new System.Drawing.Point(36, 28);
            this.toggleSwitch1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "";
            this.toggleSwitch1.Properties.OnText = "";
            this.tablePanel1.SetRow(this.toggleSwitch1, 0);
            this.toggleSwitch1.Size = new System.Drawing.Size(190, 26);
            this.toggleSwitch1.TabIndex = 12;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.simpleButton1, 4);
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(666, 391);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 4);
            this.simpleButton1.Size = new System.Drawing.Size(182, 65);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "IP Reset";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // IP
            // 
            this.tablePanel1.SetColumn(this.IP, 1);
            this.tablePanel1.SetColumnSpan(this.IP, 2);
            this.IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IP.Location = new System.Drawing.Point(40, 391);
            this.IP.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.IP.Name = "IP";
            this.IP.Properties.AutoHeight = false;
            this.IP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetRow(this.IP, 4);
            this.IP.Size = new System.Drawing.Size(586, 65);
            this.IP.TabIndex = 9;
            // 
            // IPset
            // 
            this.IPset.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPset.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.IPset, 1);
            this.IPset.Location = new System.Drawing.Point(40, 321);
            this.IPset.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.IPset.Name = "IPset";
            this.tablePanel1.SetRow(this.IPset, 3);
            this.IPset.Size = new System.Drawing.Size(182, 40);
            this.IPset.TabIndex = 8;
            this.IPset.Text = "IP";
            this.IPset.Click += new System.EventHandler(this.IPset_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Appearance.Font = new System.Drawing.Font("나눔스퀘어라운드OTF ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btn_Login, 4);
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Login.Location = new System.Drawing.Point(666, 91);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_Login.Name = "btn_Login";
            this.tablePanel1.SetRow(this.btn_Login, 1);
            this.btn_Login.Size = new System.Drawing.Size(182, 91);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "로그인";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 465);
            this.Controls.Add(this.tablePanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton IPset;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit IP;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}