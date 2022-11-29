namespace RestaurantGroupe9
{
    partial class Restaurant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reserver = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reception = new System.Windows.Forms.Button();
            this.cuisine = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.cuisine1 = new RestaurantGroupe9.Cuisine();
            this.reservation1 = new RestaurantGroupe9.View.Reservation();
            this.reception1 = new RestaurantGroupe9.Reception();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.reserver);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.reception);
            this.panel1.Controls.Add(this.cuisine);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 450);
            this.panel1.TabIndex = 0;
            // 
            // reserver
            // 
            this.reserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.Location = new System.Drawing.Point(24, 361);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(105, 30);
            this.reserver.TabIndex = 4;
            this.reserver.Text = "RESERVER";
            this.reserver.UseVisualStyleBackColor = true;
            this.reserver.Click += new System.EventHandler(this.reserver_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(24, 408);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(105, 30);
            this.stop.TabIndex = 3;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // reception
            // 
            this.reception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reception.Location = new System.Drawing.Point(24, 73);
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(105, 30);
            this.reception.TabIndex = 2;
            this.reception.Text = "RECEPTION";
            this.reception.UseVisualStyleBackColor = true;
            this.reception.Click += new System.EventHandler(this.reception_Click);
            // 
            // cuisine
            // 
            this.cuisine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuisine.Location = new System.Drawing.Point(24, 122);
            this.cuisine.Name = "cuisine";
            this.cuisine.Size = new System.Drawing.Size(105, 30);
            this.cuisine.TabIndex = 1;
            this.cuisine.Text = "CUISINE";
            this.cuisine.UseVisualStyleBackColor = true;
            this.cuisine.Click += new System.EventHandler(this.cuisine_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(24, 21);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(105, 30);
            this.pause.TabIndex = 0;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // cuisine1
            // 
            this.cuisine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cuisine1.Location = new System.Drawing.Point(3, 0);
            this.cuisine1.Name = "cuisine1";
            this.cuisine1.Size = new System.Drawing.Size(666, 450);
            this.cuisine1.TabIndex = 1;
            // 
            // reservation1
            // 
            this.reservation1.Location = new System.Drawing.Point(3, 0);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(666, 450);
            this.reservation1.TabIndex = 2;
            // 
            // reception1
            // 
            this.reception1.Location = new System.Drawing.Point(3, 0);
            this.reception1.Name = "reception1";
            this.reception1.Size = new System.Drawing.Size(666, 450);
            this.reception1.TabIndex = 3;
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reception1);
            this.Controls.Add(this.reservation1);
            this.Controls.Add(this.cuisine1);
            this.Controls.Add(this.panel1);
            this.Name = "Restaurant";
            this.Text = "GESTION RESTAURANT GROUPE 9";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button reception;
        private System.Windows.Forms.Button cuisine;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button reserver;
        private Cuisine cuisine1;
        private View.Reservation reservation1;
        private Reception reception1;
    }
}