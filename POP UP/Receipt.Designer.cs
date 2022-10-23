namespace Smart_POS_X.UI
{
    partial class Receipt
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
            this.txt_ReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.btn_ReInput = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Enter = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ReceiptCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ReceiptNo
            // 
            this.txt_ReceiptNo.Location = new System.Drawing.Point(99, 79);
            this.txt_ReceiptNo.Name = "txt_ReceiptNo";
            this.txt_ReceiptNo.Size = new System.Drawing.Size(327, 22);
            this.txt_ReceiptNo.TabIndex = 2;
            // 
            // btn_ReInput
            // 
            this.btn_ReInput.Location = new System.Drawing.Point(226, 126);
            this.btn_ReInput.Name = "btn_ReInput";
            this.btn_ReInput.Size = new System.Drawing.Size(91, 31);
            this.btn_ReInput.TabIndex = 3;
            this.btn_ReInput.Text = "재입력";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(335, 126);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(91, 31);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "확인";
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 187);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(414, 417);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(335, 621);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(91, 31);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "출력";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(226, 621);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 31);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "취소";
            // 
            // btn_ReceiptCancel
            // 
            this.btn_ReceiptCancel.Location = new System.Drawing.Point(12, 621);
            this.btn_ReceiptCancel.Name = "btn_ReceiptCancel";
            this.btn_ReceiptCancel.Size = new System.Drawing.Size(116, 31);
            this.btn_ReceiptCancel.TabIndex = 8;
            this.btn_ReceiptCancel.Text = "영수증 취소";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 35);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "영수증 조회 화면";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "영수증 번호";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 663);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_ReceiptCancel);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_ReInput);
            this.Controls.Add(this.txt_ReceiptNo);
            this.Name = "Receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_ReceiptNo;
        private DevExpress.XtraEditors.SimpleButton btn_ReInput;
        private DevExpress.XtraEditors.SimpleButton btn_Enter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_ReceiptCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}