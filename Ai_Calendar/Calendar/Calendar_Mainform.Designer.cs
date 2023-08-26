namespace Ai_Calendar.Calendar
{
    partial class Calendar_Mainform
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
            Calendar_Flowpanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Calendar_Flowpanel
            // 
            Calendar_Flowpanel.Dock = DockStyle.Fill;
            Calendar_Flowpanel.Location = new Point(0, 0);
            Calendar_Flowpanel.Name = "Calendar_Flowpanel";
            Calendar_Flowpanel.Size = new Size(633, 653);
            Calendar_Flowpanel.TabIndex = 0;
            // 
            // Calendar_Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(Calendar_Flowpanel);
            Name = "Calendar_Mainform";
            Size = new Size(633, 653);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Calendar_Flowpanel;
    }
}
