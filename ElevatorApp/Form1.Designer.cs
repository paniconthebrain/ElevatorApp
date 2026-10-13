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
            btnFloor1 = new Button();
            lblFloor = new Label();
            btnFloor0 = new Button();
            SuspendLayout();
            // 
            // btnFloor1
            // 
            btnFloor1.Location = new Point(477, 205);
            btnFloor1.Name = "btnFloor1";
            btnFloor1.Size = new Size(97, 23);
            btnFloor1.TabIndex = 0;
            btnFloor1.Text = "Go to Floor 1";
            btnFloor1.UseVisualStyleBackColor = true;
            btnFloor1.Click += btnFloor1_Click;
            // 
            // lblFloor
            // 
            lblFloor.AutoSize = true;
            lblFloor.Location = new Point(477, 187);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(46, 15);
            lblFloor.TabIndex = 1;
            lblFloor.Text = "Floor: 0";
            // 
            // btnFloor0
            // 
            btnFloor0.Location = new Point(477, 234);
            btnFloor0.Name = "btnFloor0";
            btnFloor0.Size = new Size(97, 23);
            btnFloor0.TabIndex = 2;
            btnFloor0.Text = "Go to floor 0";
            btnFloor0.UseVisualStyleBackColor = true;
            btnFloor0.Click += btnFloor0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFloor0);
            Controls.Add(lblFloor);
            Controls.Add(btnFloor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFloor1;
        private Label lblFloor;
        private Button btnFloor0;
    }
}
