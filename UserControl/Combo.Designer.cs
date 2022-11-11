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
            this.cbo_Job = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Job.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Job
            // 
            this.cbo_Job.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Job.EditValue = "NAME";
            this.cbo_Job.Location = new System.Drawing.Point(0, 0);
            this.cbo_Job.Margin = new System.Windows.Forms.Padding(0);
            this.cbo_Job.Name = "cbo_Job";
            this.cbo_Job.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_Job.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_Job.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Job.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbo_Job.Properties.AutoHeight = false;
            this.cbo_Job.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbo_Job.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_Job.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "NAME", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODE", "CODE", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbo_Job.Properties.DisplayMember = "NAME";
            this.cbo_Job.Properties.NullText = "";
            this.cbo_Job.Size = new System.Drawing.Size(576, 417);
            this.cbo_Job.TabIndex = 5;
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo_Job);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(576, 417);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_Job.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbo_Job;
    }
}
