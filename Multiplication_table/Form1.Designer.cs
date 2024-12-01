namespace Multiplication_table
{
    partial class Form1
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
            label1 = new Label();
            txtNumber = new TextBox();
            txtMultiplicationTable = new TextBox();
            btnMultiplication = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(112, 48);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // txtMultiplicationTable
            // 
            txtMultiplicationTable.Location = new Point(112, 80);
            txtMultiplicationTable.Multiline = true;
            txtMultiplicationTable.Name = "txtMultiplicationTable";
            txtMultiplicationTable.Size = new Size(183, 173);
            txtMultiplicationTable.TabIndex = 2;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(233, 51);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(110, 23);
            btnMultiplication.TabIndex = 3;
            btnMultiplication.Text = "Multiplication ";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 287);
            Controls.Add(btnMultiplication);
            Controls.Add(txtMultiplicationTable);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private TextBox txtMultiplicationTable;
        private Button btnMultiplication;
    }
}
