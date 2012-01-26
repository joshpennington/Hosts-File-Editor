namespace OCaff.Framework
{
    partial class IPAddressInputBox
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
            this.IpAddressFirstNumber = new System.Windows.Forms.TextBox();
            this.IpAddressSecondNumber = new System.Windows.Forms.TextBox();
            this.IpAddressThirdNumber = new System.Windows.Forms.TextBox();
            this.IpAddressFourthNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpAddressFirstNumber
            // 
            this.IpAddressFirstNumber.Location = new System.Drawing.Point(3, 3);
            this.IpAddressFirstNumber.Name = "IpAddressFirstNumber";
            this.IpAddressFirstNumber.Size = new System.Drawing.Size(28, 20);
            this.IpAddressFirstNumber.TabIndex = 0;
            this.IpAddressFirstNumber.TextChanged += new System.EventHandler(this.IpAddressFirstNumber_TextChanged);
            this.IpAddressFirstNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IpAddressFirstNumber_KeyDown);
            this.IpAddressFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpAddressFirstNumber_KeyPress);
            // 
            // IpAddressSecondNumber
            // 
            this.IpAddressSecondNumber.Location = new System.Drawing.Point(53, 3);
            this.IpAddressSecondNumber.Name = "IpAddressSecondNumber";
            this.IpAddressSecondNumber.Size = new System.Drawing.Size(28, 20);
            this.IpAddressSecondNumber.TabIndex = 1;
            // 
            // IpAddressThirdNumber
            // 
            this.IpAddressThirdNumber.Location = new System.Drawing.Point(103, 3);
            this.IpAddressThirdNumber.Name = "IpAddressThirdNumber";
            this.IpAddressThirdNumber.Size = new System.Drawing.Size(28, 20);
            this.IpAddressThirdNumber.TabIndex = 2;
            // 
            // IpAddressFourthNumber
            // 
            this.IpAddressFourthNumber.Location = new System.Drawing.Point(153, 3);
            this.IpAddressFourthNumber.Name = "IpAddressFourthNumber";
            this.IpAddressFourthNumber.Size = new System.Drawing.Size(28, 20);
            this.IpAddressFourthNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // IPAddressInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpAddressFourthNumber);
            this.Controls.Add(this.IpAddressThirdNumber);
            this.Controls.Add(this.IpAddressSecondNumber);
            this.Controls.Add(this.IpAddressFirstNumber);
            this.Name = "IPAddressInputBox";
            this.Size = new System.Drawing.Size(186, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpAddressFirstNumber;
        private System.Windows.Forms.TextBox IpAddressSecondNumber;
        private System.Windows.Forms.TextBox IpAddressThirdNumber;
        private System.Windows.Forms.TextBox IpAddressFourthNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
