namespace MacroConvert
{
    partial class MainForm
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
            this.memoEditInput = new DevExpress.XtraEditors.MemoEdit();
            this.memoEditOutput = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButtonComfirm = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditOutput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditInput
            // 
            this.memoEditInput.Location = new System.Drawing.Point(23, 24);
            this.memoEditInput.Name = "memoEditInput";
            this.memoEditInput.Size = new System.Drawing.Size(329, 321);
            this.memoEditInput.TabIndex = 0;
            // 
            // memoEditOutput
            // 
            this.memoEditOutput.Location = new System.Drawing.Point(358, 24);
            this.memoEditOutput.Name = "memoEditOutput";
            this.memoEditOutput.Size = new System.Drawing.Size(329, 321);
            this.memoEditOutput.TabIndex = 1;
            // 
            // simpleButtonComfirm
            // 
            this.simpleButtonComfirm.Location = new System.Drawing.Point(198, 368);
            this.simpleButtonComfirm.Name = "simpleButtonComfirm";
            this.simpleButtonComfirm.Size = new System.Drawing.Size(154, 54);
            this.simpleButtonComfirm.TabIndex = 2;
            this.simpleButtonComfirm.Text = "转换";
            this.simpleButtonComfirm.Click += new System.EventHandler(this.simpleButtonComfirm_Click);
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Location = new System.Drawing.Point(358, 368);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(154, 54);
            this.simpleButtonClear.TabIndex = 3;
            this.simpleButtonClear.Text = "清空";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 453);
            this.Controls.Add(this.simpleButtonClear);
            this.Controls.Add(this.simpleButtonComfirm);
            this.Controls.Add(this.memoEditOutput);
            this.Controls.Add(this.memoEditInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditOutput.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditInput;
        private DevExpress.XtraEditors.MemoEdit memoEditOutput;
        private DevExpress.XtraEditors.SimpleButton simpleButtonComfirm;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
    }
}

