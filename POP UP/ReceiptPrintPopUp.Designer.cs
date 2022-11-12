namespace Smart_POS_X.POP_UP
{
    partial class ReceiptPrintPopUp
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.lbl_SellingCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)});
            this.tablePanel1.Controls.Add(this.gridControl2);
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.tablePanel4);
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(432, 663);
            this.tablePanel1.TabIndex = 12;
            // 
            // gridControl2
            // 
            this.tablePanel1.SetColumn(this.gridControl2, 1);
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(12, 386);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.tablePanel1.SetRow(this.gridControl2, 3);
            this.gridControl2.Size = new System.Drawing.Size(408, 194);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "총 결제 금액";
            this.gridColumn4.FieldName = "TotalPay";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "현금 결제";
            this.gridColumn5.FieldName = "CashPay";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "포인트 결제";
            this.gridColumn6.FieldName = "PointPay";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "날짜";
            this.gridColumn7.FieldName = "CreateTime";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "책임자";
            this.gridColumn8.FieldName = "CreateUser";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 1);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(12, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 2);
            this.gridControl1.Size = new System.Drawing.Size(408, 327);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "주문 목록";
            this.gridColumn1.FieldName = "MenuName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "금액";
            this.gridColumn2.FieldName = "SellingPrice";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "개수";
            this.gridColumn3.FieldName = "SellingCount";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // tablePanel4
            // 
            this.tablePanel1.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70F)});
            this.tablePanel4.Controls.Add(this.lbl_SellingCode);
            this.tablePanel4.Controls.Add(this.labelControl2);
            this.tablePanel4.Location = new System.Drawing.Point(12, 23);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel1.SetRow(this.tablePanel4, 1);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel4.Size = new System.Drawing.Size(408, 24);
            this.tablePanel4.TabIndex = 12;
            // 
            // lbl_SellingCode
            // 
            this.lbl_SellingCode.Appearance.BackColor = System.Drawing.Color.White;
            this.lbl_SellingCode.Appearance.Options.UseBackColor = true;
            this.tablePanel4.SetColumn(this.lbl_SellingCode, 1);
            this.lbl_SellingCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SellingCode.Location = new System.Drawing.Point(122, 0);
            this.lbl_SellingCode.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_SellingCode.Name = "lbl_SellingCode";
            this.tablePanel4.SetRow(this.lbl_SellingCode, 0);
            this.lbl_SellingCode.Size = new System.Drawing.Size(286, 24);
            this.lbl_SellingCode.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.tablePanel4.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel4.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(122, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "영수증 번호";
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 1);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel3.Controls.Add(this.simpleButton1);
            this.tablePanel3.Controls.Add(this.btn_Print);
            this.tablePanel3.Location = new System.Drawing.Point(12, 606);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel1.SetRow(this.tablePanel3, 5);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel3.Size = new System.Drawing.Size(408, 34);
            this.tablePanel3.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.tablePanel3.SetColumn(this.simpleButton1, 0);
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel3.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(137, 28);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "나가기";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Print.Location = new System.Drawing.Point(309, 3);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(96, 28);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "출력";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // ReceiptPrintPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 663);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ReceiptPrintPopUp";
            this.Text = "영수증 출력";
            this.Load += new System.EventHandler(this.ReceiptPrintPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lbl_SellingCode;
    }
}