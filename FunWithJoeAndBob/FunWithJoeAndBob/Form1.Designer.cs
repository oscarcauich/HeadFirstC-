namespace FunWithJoeAndBob
{
    partial class Form1
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
            this.JoesCashLabel = new System.Windows.Forms.Label();
            this.BobsCashLabel = new System.Windows.Forms.Label();
            this.BanksCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoesCashLabel
            // 
            this.JoesCashLabel.AutoSize = true;
            this.JoesCashLabel.Location = new System.Drawing.Point(49, 42);
            this.JoesCashLabel.Name = "JoesCashLabel";
            this.JoesCashLabel.Size = new System.Drawing.Size(53, 13);
            this.JoesCashLabel.TabIndex = 0;
            this.JoesCashLabel.Text = "Joe has $";
            // 
            // BobsCashLabel
            // 
            this.BobsCashLabel.AutoSize = true;
            this.BobsCashLabel.Location = new System.Drawing.Point(52, 79);
            this.BobsCashLabel.Name = "BobsCashLabel";
            this.BobsCashLabel.Size = new System.Drawing.Size(55, 13);
            this.BobsCashLabel.TabIndex = 1;
            this.BobsCashLabel.Text = "Bob has $";
            // 
            // BanksCashLabel
            // 
            this.BanksCashLabel.AutoSize = true;
            this.BanksCashLabel.Location = new System.Drawing.Point(55, 124);
            this.BanksCashLabel.Name = "BanksCashLabel";
            this.BanksCashLabel.Size = new System.Drawing.Size(55, 13);
            this.BanksCashLabel.TabIndex = 2;
            this.BanksCashLabel.Text = "The has $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(52, 253);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(96, 51);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(182, 253);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(89, 51);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BanksCashLabel);
            this.Controls.Add(this.BobsCashLabel);
            this.Controls.Add(this.JoesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoesCashLabel;
        private System.Windows.Forms.Label BobsCashLabel;
        private System.Windows.Forms.Label BanksCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

