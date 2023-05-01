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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            ACPlugControl = new System.Windows.Forms.Timer(components);
            NotifyIcon = new NotifyIcon(components);
            Notify = new System.Windows.Forms.Timer(components);
            hideButton = new Button();
            resetButton = new Button();
            label2 = new Label();
            pauseButton = new Button();
            Pause = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 0;
            label1.Text = "Screen on time calculator";
            // 
            // ACPlugControl
            // 
            ACPlugControl.Interval = 1000;
            ACPlugControl.Tick += ACPlugControl_Tick;
            // 
            // NotifyIcon
            // 
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
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
            hideButton.Location = new Point(113, 80);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(94, 29);
            hideButton.TabIndex = 1;
            hideButton.Text = "Hide";
            hideButton.UseVisualStyleBackColor = true;
            hideButton.Click += hideButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(213, 80);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Info Label";
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(13, 80);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(94, 29);
            pauseButton.TabIndex = 5;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // Pause
            // 
            Pause.Tick += Pause_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 121);
            Controls.Add(pauseButton);
            Controls.Add(label2);
            Controls.Add(resetButton);
            Controls.Add(hideButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
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
        private Label label2;
        private Button pauseButton;
        private System.Windows.Forms.Timer Pause;
    }
}