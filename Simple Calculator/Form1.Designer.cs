namespace Simple_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            num1 = new MaskedTextBox();
            num2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            operation = new ComboBox();
            result = new Button();
            history = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(12, 38);
            num1.Mask = "00000000";
            num1.Name = "num1";
            num1.Size = new Size(394, 23);
            num1.TabIndex = 0;
            num1.ValidatingType = typeof(int);
            num1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // num2
            // 
            num2.Location = new Point(12, 112);
            num2.Mask = "00000000";
            num2.Name = "num2";
            num2.Size = new Size(394, 23);
            num2.TabIndex = 1;
            num2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Number one";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Number two";
            // 
            // operation
            // 
            operation.FormattingEnabled = true;
            operation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operation.Location = new Point(12, 166);
            operation.Name = "operation";
            operation.Size = new Size(394, 23);
            operation.TabIndex = 4;
            operation.Text = "Operations";
            // 
            // result
            // 
            result.Cursor = Cursors.Hand;
            result.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(12, 213);
            result.Name = "result";
            result.Size = new Size(394, 34);
            result.TabIndex = 5;
            result.Text = "Result";
            result.UseVisualStyleBackColor = true;
            result.Click += result_Click;
            // 
            // history
            // 
            history.FormattingEnabled = true;
            history.ItemHeight = 15;
            history.Location = new Point(12, 292);
            history.Name = "history";
            history.Size = new Size(394, 79);
            history.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(164, 269);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 7;
            label3.Text = "Results history";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(418, 387);
            Controls.Add(label3);
            Controls.Add(history);
            Controls.Add(result);
            Controls.Add(operation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(num2);
            Controls.Add(num1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox num1;
        private MaskedTextBox num2;
        private Label label1;
        private Label label2;
        private ComboBox operation;
        private Button result;
        private ListBox history;
        private Label label3;
    }
}
