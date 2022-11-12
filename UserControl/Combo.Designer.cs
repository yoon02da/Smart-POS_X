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
            this.cbo.Location = new System.Drawing.Point(0, 0);
            this.cbo.Name = "cbo";
            this.cbo.Properties.AutoHeight = false;
            this.cbo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo.Properties.DisplayMember = "NAME";
            this.cbo.Properties.ValueMember = "CODE";
            this.cbo.Properties.DataSourceChanged += new System.EventHandler(this.lookUpEdit1_Properties_DataSourceChanged);
            this.cbo.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpEdit1_Properties_EditValueChanging);
            this.cbo.Size = new System.Drawing.Size(1070, 890);
            this.cbo.TabIndex = 0;
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(1070, 890);
            this.Load += new System.EventHandler(this.Combo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit cbo;
    }
}
