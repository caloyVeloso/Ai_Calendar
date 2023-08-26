namespace Ai_Calendar
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
            panel1 = new Panel();
            calendar_Mainform1 = new Calendar.Calendar_Mainform();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(calendar_Mainform1);
            panel1.Location = new Point(12, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 653);
            panel1.TabIndex = 0;
            // 
            // calendar_Mainform1
            // 
            calendar_Mainform1.BackColor = SystemColors.ActiveBorder;
            calendar_Mainform1.Dock = DockStyle.Fill;
            calendar_Mainform1.Location = new Point(0, 0);
            calendar_Mainform1.Name = "calendar_Mainform1";
            calendar_Mainform1.Size = new Size(633, 653);
            calendar_Mainform1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(633, 79);
            label1.TabIndex = 1;
            label1.Text = "Month";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 2;
            label2.Text = "Sunday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(102, 119);
            label3.Name = "label3";
            label3.Size = new Size(89, 33);
            label3.TabIndex = 3;
            label3.Text = "Monday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(192, 119);
            label4.Name = "label4";
            label4.Size = new Size(89, 33);
            label4.TabIndex = 4;
            label4.Text = "Tuesday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(282, 119);
            label5.Name = "label5";
            label5.Size = new Size(89, 33);
            label5.TabIndex = 5;
            label5.Text = "Wednesday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(372, 119);
            label6.Name = "label6";
            label6.Size = new Size(89, 33);
            label6.TabIndex = 6;
            label6.Text = "Thurday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(462, 119);
            label7.Name = "label7";
            label7.Size = new Size(89, 33);
            label7.TabIndex = 7;
            label7.Text = "Friday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(552, 119);
            label8.Name = "label8";
            label8.Size = new Size(89, 33);
            label8.TabIndex = 8;
            label8.Text = "Saturday";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(570, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 79);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 79);
            button2.TabIndex = 10;
            button2.Text = "Prev";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 820);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Calendar.Calendar_Mainform calendar_Mainform1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}