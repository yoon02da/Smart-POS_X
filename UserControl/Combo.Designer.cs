namespace Smart_POS_X.UserControl
{
    partial class Combo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo.EditValue = "NAME";
            this.cbo.Location = new System.Drawing.Point(0, 0);
            this.cbo.Margin = new System.Windows.Forms.Padding(0);
            this.cbo.Name = "cbo";
            this.cbo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo.Properties.Appearance.Options.UseForeColor = true;
            this.cbo.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.Transparent;
            this.cbo.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbo.Properties.AutoHeight = false;
            this.cbo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cbo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "NAME", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "CODE")});
            this.cbo.Properties.DisplayMember = "NAME";
            this.cbo.Properties.NullText = "";
            this.cbo.Size = new System.Drawing.Size(576, 417);
            this.cbo.TabIndex = 5;
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(576, 417);
            ((System.ComponentModel.ISupportInitialize)(this.cbo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit cbo;
    }
}
