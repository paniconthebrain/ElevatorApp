namespace ElevatorApp
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
            btnPanelFloor1 = new Button();
            btnPanelFloor0 = new Button();
            btnRequestFloor0 = new Button();
            btnRequestFloor1 = new Button();
            lblPanelDisplay = new Label();
            lblFloor0Status = new Label();
            lblFloor1Status = new Label();
            groupBox1 = new GroupBox();
            btnLog = new Button();
            pnlShaft = new Panel();
            pnlCar = new Panel();
            tmrMove = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            pnlShaft.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanelFloor1
            // 
            btnPanelFloor1.Location = new Point(6, 22);
            btnPanelFloor1.Name = "btnPanelFloor1";
            btnPanelFloor1.Size = new Size(97, 23);
            btnPanelFloor1.TabIndex = 0;
            btnPanelFloor1.Text = "Go to Floor 1";
            btnPanelFloor1.UseVisualStyleBackColor = true;
            btnPanelFloor1.Click += btnFloor1_Click;
            // 
            // btnPanelFloor0
            // 
            btnPanelFloor0.Location = new Point(6, 51);
            btnPanelFloor0.Name = "btnPanelFloor0";
            btnPanelFloor0.Size = new Size(97, 23);
            btnPanelFloor0.TabIndex = 2;
            btnPanelFloor0.Text = "Go to floor 0";
            btnPanelFloor0.UseVisualStyleBackColor = true;
            btnPanelFloor0.Click += btnFloor0_Click;
            // 
            // btnRequestFloor0
            // 
            btnRequestFloor0.Location = new Point(553, 376);
            btnRequestFloor0.Name = "btnRequestFloor0";
            btnRequestFloor0.Size = new Size(75, 23);
            btnRequestFloor0.TabIndex = 3;
            btnRequestFloor0.Text = "Call Floor 0";
            btnRequestFloor0.UseVisualStyleBackColor = true;
            btnRequestFloor0.Click += btnRequestFloor0_Click;
            // 
            // btnRequestFloor1
            // 
            btnRequestFloor1.Location = new Point(553, 144);
            btnRequestFloor1.Name = "btnRequestFloor1";
            btnRequestFloor1.Size = new Size(75, 23);
            btnRequestFloor1.TabIndex = 4;
            btnRequestFloor1.Text = "Call Floor 1";
            btnRequestFloor1.UseVisualStyleBackColor = true;
            btnRequestFloor1.Click += btnRequestFloor1_Click;
            // 
            // lblPanelDisplay
            // 
            lblPanelDisplay.AutoSize = true;
            lblPanelDisplay.Font = new Font("Segoe UI", 18F);
            lblPanelDisplay.Location = new Point(144, 22);
            lblPanelDisplay.Name = "lblPanelDisplay";
            lblPanelDisplay.Size = new Size(24, 32);
            lblPanelDisplay.TabIndex = 5;
            lblPanelDisplay.Text = "-";
            // 
            // lblFloor0Status
            // 
            lblFloor0Status.AutoSize = true;
            lblFloor0Status.Location = new Point(634, 380);
            lblFloor0Status.Name = "lblFloor0Status";
            lblFloor0Status.Size = new Size(12, 15);
            lblFloor0Status.TabIndex = 6;
            lblFloor0Status.Text = "-";
            // 
            // lblFloor1Status
            // 
            lblFloor1Status.AutoSize = true;
            lblFloor1Status.Location = new Point(634, 148);
            lblFloor1Status.Name = "lblFloor1Status";
            lblFloor1Status.Size = new Size(12, 15);
            lblFloor1Status.TabIndex = 0;
            lblFloor1Status.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPanelFloor1);
            groupBox1.Controls.Add(btnPanelFloor0);
            groupBox1.Controls.Add(lblPanelDisplay);
            groupBox1.Location = new Point(837, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 240);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control Panel";
            // 
            // btnLog
            // 
            btnLog.Location = new Point(839, 346);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 23);
            btnLog.TabIndex = 8;
            btnLog.Text = "Show Log";
            btnLog.TextAlign = ContentAlignment.BottomCenter;
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // pnlShaft
            // 
            pnlShaft.BackColor = Color.FromArgb(0, 192, 192);
            pnlShaft.Controls.Add(pnlCar);
            pnlShaft.Location = new Point(26, 310);
            pnlShaft.Name = "pnlShaft";
            pnlShaft.Size = new Size(173, 471);
            pnlShaft.TabIndex = 9;
            // 
            // pnlCar
            // 
            pnlCar.BackColor = Color.FromArgb(192, 0, 0);
            pnlCar.Location = new Point(26, 307);
            pnlCar.Name = "pnlCar";
            pnlCar.Size = new Size(115, 161);
            pnlCar.TabIndex = 0;
            // 
            // tmrMove
            // 
            tmrMove.Interval = 20;
            tmrMove.Tick += tmrMove_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 861);
            Controls.Add(pnlShaft);
            Controls.Add(btnLog);
            Controls.Add(groupBox1);
            Controls.Add(lblFloor1Status);
            Controls.Add(lblFloor0Status);
            Controls.Add(btnRequestFloor1);
            Controls.Add(btnRequestFloor0);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlShaft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPanelFloor1;
        private Button btnPanelFloor0;
        private Button btnRequestFloor0;
        private Button btnRequestFloor1;
        private Label lblPanelDisplay;
        private Label lblFloor0Status;
        private Label lblFloor1Status;
        private GroupBox groupBox1;
        private Button btnLog;
        private Panel pnlShaft;
        private Panel pnlCar;
        private System.Windows.Forms.Timer tmrMove;
    }
}
