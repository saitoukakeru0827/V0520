
namespace V0520
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
            this.RIGHT = new System.Windows.Forms.Button();
            this.LEFT = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.UP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RIGHT
            // 
            this.RIGHT.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RIGHT.Location = new System.Drawing.Point(713, 352);
            this.RIGHT.Name = "RIGHT";
            this.RIGHT.Size = new System.Drawing.Size(75, 23);
            this.RIGHT.TabIndex = 0;
            this.RIGHT.Text = "→";
            this.RIGHT.UseVisualStyleBackColor = true;
            this.RIGHT.Click += new System.EventHandler(this.button1_Click);
            // 
            // LEFT
            // 
            this.LEFT.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LEFT.Location = new System.Drawing.Point(579, 352);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(75, 23);
            this.LEFT.TabIndex = 1;
            this.LEFT.Text = "←";
            this.LEFT.UseVisualStyleBackColor = true;
            this.LEFT.Click += new System.EventHandler(this.button2_Click);
            // 
            // DOWN
            // 
            this.DOWN.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOWN.Location = new System.Drawing.Point(649, 415);
            this.DOWN.Name = "DOWN";
            this.DOWN.Size = new System.Drawing.Size(75, 23);
            this.DOWN.TabIndex = 2;
            this.DOWN.Text = "↓";
            this.DOWN.UseVisualStyleBackColor = true;
            this.DOWN.Click += new System.EventHandler(this.button3_Click);
            // 
            // UP
            // 
            this.UP.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UP.Location = new System.Drawing.Point(649, 303);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(75, 23);
            this.UP.TabIndex = 3;
            this.UP.Text = "↑";
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "（・ω・）";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UP);
            this.Controls.Add(this.DOWN);
            this.Controls.Add(this.LEFT);
            this.Controls.Add(this.RIGHT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RIGHT;
        private System.Windows.Forms.Button LEFT;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Label label1;
    }
}

