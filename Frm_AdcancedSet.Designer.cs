
namespace SerialTestTools
{
    partial class Frm_AdcancedSet
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
            this.comb_readBuffer = new System.Windows.Forms.ComboBox();
            this.lbl_readBuffer = new System.Windows.Forms.Label();
            this.comb_writeBuffer = new System.Windows.Forms.ComboBox();
            this.lbl_writeBuffer = new System.Windows.Forms.Label();
            this.comb_readTimeOut = new System.Windows.Forms.ComboBox();
            this.lbl_readTimeOut = new System.Windows.Forms.Label();
            this.comb_writeTimeOut = new System.Windows.Forms.ComboBox();
            this.lbl_writeTimeOut = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comb_readBuffer
            // 
            this.comb_readBuffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_readBuffer.FormattingEnabled = true;
            this.comb_readBuffer.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.comb_readBuffer.Location = new System.Drawing.Point(244, 224);
            this.comb_readBuffer.Margin = new System.Windows.Forms.Padding(5);
            this.comb_readBuffer.Name = "comb_readBuffer";
            this.comb_readBuffer.Size = new System.Drawing.Size(155, 32);
            this.comb_readBuffer.TabIndex = 17;
            // 
            // lbl_readBuffer
            // 
            this.lbl_readBuffer.AutoSize = true;
            this.lbl_readBuffer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_readBuffer.Location = new System.Drawing.Point(80, 227);
            this.lbl_readBuffer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_readBuffer.Name = "lbl_readBuffer";
            this.lbl_readBuffer.Size = new System.Drawing.Size(154, 24);
            this.lbl_readBuffer.TabIndex = 16;
            this.lbl_readBuffer.Text = "读取缓存大小";
            // 
            // comb_writeBuffer
            // 
            this.comb_writeBuffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_writeBuffer.FormattingEnabled = true;
            this.comb_writeBuffer.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.comb_writeBuffer.Location = new System.Drawing.Point(244, 165);
            this.comb_writeBuffer.Margin = new System.Windows.Forms.Padding(5);
            this.comb_writeBuffer.Name = "comb_writeBuffer";
            this.comb_writeBuffer.Size = new System.Drawing.Size(155, 32);
            this.comb_writeBuffer.TabIndex = 15;
            // 
            // lbl_writeBuffer
            // 
            this.lbl_writeBuffer.AutoSize = true;
            this.lbl_writeBuffer.Location = new System.Drawing.Point(80, 168);
            this.lbl_writeBuffer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_writeBuffer.Name = "lbl_writeBuffer";
            this.lbl_writeBuffer.Size = new System.Drawing.Size(154, 24);
            this.lbl_writeBuffer.TabIndex = 14;
            this.lbl_writeBuffer.Text = "写入缓存大小";
            // 
            // comb_readTimeOut
            // 
            this.comb_readTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_readTimeOut.FormattingEnabled = true;
            this.comb_readTimeOut.Items.AddRange(new object[] {
            "5 s",
            "8 s",
            "10 s",
            "13 s",
            "15 s",
            "20 s"});
            this.comb_readTimeOut.Location = new System.Drawing.Point(244, 106);
            this.comb_readTimeOut.Margin = new System.Windows.Forms.Padding(5);
            this.comb_readTimeOut.Name = "comb_readTimeOut";
            this.comb_readTimeOut.Size = new System.Drawing.Size(155, 32);
            this.comb_readTimeOut.TabIndex = 13;
            // 
            // lbl_readTimeOut
            // 
            this.lbl_readTimeOut.AutoSize = true;
            this.lbl_readTimeOut.Location = new System.Drawing.Point(80, 109);
            this.lbl_readTimeOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_readTimeOut.Name = "lbl_readTimeOut";
            this.lbl_readTimeOut.Size = new System.Drawing.Size(154, 24);
            this.lbl_readTimeOut.TabIndex = 12;
            this.lbl_readTimeOut.Text = "读取超时时长";
            // 
            // comb_writeTimeOut
            // 
            this.comb_writeTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_writeTimeOut.FormattingEnabled = true;
            this.comb_writeTimeOut.Items.AddRange(new object[] {
            "5 s",
            "8 s",
            "10 s",
            "13 s",
            "15 s",
            "20 s"});
            this.comb_writeTimeOut.Location = new System.Drawing.Point(244, 47);
            this.comb_writeTimeOut.Margin = new System.Windows.Forms.Padding(5);
            this.comb_writeTimeOut.Name = "comb_writeTimeOut";
            this.comb_writeTimeOut.Size = new System.Drawing.Size(155, 32);
            this.comb_writeTimeOut.TabIndex = 11;
            // 
            // lbl_writeTimeOut
            // 
            this.lbl_writeTimeOut.AutoSize = true;
            this.lbl_writeTimeOut.Location = new System.Drawing.Point(80, 50);
            this.lbl_writeTimeOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_writeTimeOut.Name = "lbl_writeTimeOut";
            this.lbl_writeTimeOut.Size = new System.Drawing.Size(154, 24);
            this.lbl_writeTimeOut.TabIndex = 10;
            this.lbl_writeTimeOut.Text = "写入超时时长";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(171, 295);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(146, 55);
            this.btn_confirm.TabIndex = 18;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Frm_AdcancedSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 398);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.comb_readBuffer);
            this.Controls.Add(this.lbl_readBuffer);
            this.Controls.Add(this.comb_writeBuffer);
            this.Controls.Add(this.lbl_writeBuffer);
            this.Controls.Add(this.comb_readTimeOut);
            this.Controls.Add(this.lbl_readTimeOut);
            this.Controls.Add(this.comb_writeTimeOut);
            this.Controls.Add(this.lbl_writeTimeOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_AdcancedSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口进阶设置";
            this.Load += new System.EventHandler(this.Frm_AdcancedSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comb_readBuffer;
        private System.Windows.Forms.Label lbl_readBuffer;
        public System.Windows.Forms.ComboBox comb_writeBuffer;
        private System.Windows.Forms.Label lbl_writeBuffer;
        public System.Windows.Forms.ComboBox comb_readTimeOut;
        private System.Windows.Forms.Label lbl_readTimeOut;
        public System.Windows.Forms.ComboBox comb_writeTimeOut;
        private System.Windows.Forms.Label lbl_writeTimeOut;
        private System.Windows.Forms.Button btn_confirm;
    }
}