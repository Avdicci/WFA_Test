
namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Mouse_Enter = new System.Windows.Forms.Label();
            this.Change_Text = new System.Windows.Forms.Label();
            this.Mathclicker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(663, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(289, 76);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Click me to change my Cölörz";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.DoubleClick += new System.EventHandler(this.lbl2_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(133, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click Me";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl3.Location = new System.Drawing.Point(392, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(173, 51);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "purple";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl3_MouseClick);
            // 
            // Mouse_Enter
            // 
            this.Mouse_Enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Mouse_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mouse_Enter.Location = new System.Drawing.Point(350, 309);
            this.Mouse_Enter.Name = "Mouse_Enter";
            this.Mouse_Enter.Size = new System.Drawing.Size(141, 62);
            this.Mouse_Enter.TabIndex = 4;
            this.Mouse_Enter.Text = "Hover over me";
            this.Mouse_Enter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mouse_Enter.Click += new System.EventHandler(this.Mouse_Enter_Click);
            this.Mouse_Enter.MouseEnter += new System.EventHandler(this.Mouse_Enter_MouseEnter);
            this.Mouse_Enter.MouseLeave += new System.EventHandler(this.Mouse_Enter_MouseLeave);
            // 
            // Change_Text
            // 
            this.Change_Text.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Change_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Text.Location = new System.Drawing.Point(497, 309);
            this.Change_Text.Name = "Change_Text";
            this.Change_Text.Size = new System.Drawing.Size(153, 62);
            this.Change_Text.TabIndex = 5;
            this.Change_Text.Text = "Hover over blue";
            this.Change_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mathclicker
            // 
            this.Mathclicker.BackColor = System.Drawing.Color.IndianRed;
            this.Mathclicker.Location = new System.Drawing.Point(392, 39);
            this.Mathclicker.Name = "Mathclicker";
            this.Mathclicker.Size = new System.Drawing.Size(170, 49);
            this.Mathclicker.TabIndex = 6;
            this.Mathclicker.Text = "Click Me For Some MATHS";
            this.Mathclicker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mathclicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mathclicker_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Mathclicker);
            this.Controls.Add(this.Change_Text);
            this.Controls.Add(this.Mouse_Enter);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Zejd";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label Mouse_Enter;
        private System.Windows.Forms.Label Change_Text;
        private System.Windows.Forms.Label Mathclicker;
    }
}

