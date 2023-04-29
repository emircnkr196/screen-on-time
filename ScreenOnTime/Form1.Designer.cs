namespace ScreenOnTime
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ACPlugControl = new System.Windows.Forms.Timer(components);
            NotifyIcon = new NotifyIcon(components);
            Notify = new System.Windows.Forms.Timer(components);
            hideButton = new Button();
            resetButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 28);
            label1.TabIndex = 0;
            label1.Text = "Screen on time measurement is working.";
            // 
            // ACPlugControl
            // 
            ACPlugControl.Interval = 1000;
            ACPlugControl.Tick += ACPlugControl_Tick;
            // 
            // NotifyIcon
            // 
            NotifyIcon.Text = "NotifyIcon";
            NotifyIcon.Visible = true;
            NotifyIcon.Click += NotifyIcon_Click;
            // 
            // Notify
            // 
            Notify.Tick += Notify_Tick;
            // 
            // hideButton
            // 
            hideButton.Location = new Point(198, 113);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(94, 29);
            hideButton.TabIndex = 1;
            hideButton.Text = "Hide";
            hideButton.UseVisualStyleBackColor = true;
            hideButton.Click += hideButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(298, 113);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(98, 113);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 154);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(hideButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer ACPlugControl;
        private NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer Notify;
        private Button hideButton;
        private Button resetButton;
        private Button exitButton;
        private Label label2;
    }
}