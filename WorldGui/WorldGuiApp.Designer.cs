namespace WorldGui
{
    partial class FormWorldGui
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTallA = new TextBox();
            txtTallB = new TextBox();
            txtSum = new TextBox();
            btnSum = new Button();
            SuspendLayout();
            // 
            // txtTallA
            // 
            txtTallA.Location = new Point(9, 14);
            txtTallA.Margin = new Padding(3, 2, 3, 2);
            txtTallA.Name = "txtTallA";
            txtTallA.Size = new Size(110, 23);
            txtTallA.TabIndex = 0;
            // 
            // txtTallB
            // 
            txtTallB.Location = new Point(12, 57);
            txtTallB.Margin = new Padding(3, 2, 3, 2);
            txtTallB.Name = "txtTallB";
            txtTallB.Size = new Size(110, 23);
            txtTallB.TabIndex = 1;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(9, 117);
            txtSum.Margin = new Padding(3, 2, 3, 2);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(110, 23);
            txtSum.TabIndex = 2;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(11, 82);
            btnSum.Margin = new Padding(3, 2, 3, 2);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(108, 22);
            btnSum.TabIndex = 3;
            btnSum.Text = "Sum";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // FormWorldGui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 189);
            Controls.Add(btnSum);
            Controls.Add(txtSum);
            Controls.Add(txtTallB);
            Controls.Add(txtTallA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormWorldGui";
            Text = "World GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTallA;
        private TextBox txtTallB;
        private TextBox txtSum;
        private Button btnSum;
    }
}