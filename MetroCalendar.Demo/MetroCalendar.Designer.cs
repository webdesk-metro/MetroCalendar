namespace MetroCalendar.Demo
{
    partial class MetroCalendar
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
            this.lbl_title = new System.Windows.Forms.Label();
            //this.calendar1 = new MetroCalendar.Controls.Calendar(); //Mudar para o debaixo...
            this.calendar1 = new Controls.Calendar();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_title.Location = new System.Drawing.Point(2, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(224, 32);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Metro Calendar 2017";
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.calendar1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar1.ForeColor = System.Drawing.Color.DarkGray;
            this.calendar1.Location = new System.Drawing.Point(4, 50);
            this.calendar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendar1.MaximumSize = new System.Drawing.Size(352, 392);
            this.calendar1.MinimumSize = new System.Drawing.Size(352, 392);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(352, 392);
            this.calendar1.TabIndex = 4;
            // 
            // MetroCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 450);
            this.MinimumSize = new System.Drawing.Size(360, 450);
            this.Name = "MetroCalendar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MetroCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        //private MetroCalendar.Controles.Calendar calendar1; //Mudar para o debaixo...
        private Controls.Calendar calendar1;
    }
}

