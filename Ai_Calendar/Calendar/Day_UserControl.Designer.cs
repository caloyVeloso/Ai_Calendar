namespace Ai_Calendar.Calendar
{
    partial class Day_UserControl
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
            dayNo = new Label();
            SuspendLayout();
            // 
            // dayNo
            // 
            dayNo.Dock = DockStyle.Fill;
            dayNo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dayNo.Location = new Point(0, 0);
            dayNo.Name = "dayNo";
            dayNo.Size = new Size(84, 103);
            dayNo.TabIndex = 0;
            dayNo.Text = "00";
            dayNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Day_UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dayNo);
            Name = "Day_UserControl";
            Size = new Size(84, 103);
            ResumeLayout(false);
        }

        #endregion

        private Label dayNo;
    }
}
