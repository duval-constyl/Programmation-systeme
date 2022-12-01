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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maximum = new System.Windows.Forms.Button();
            this.minimal = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.reserver = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reception = new System.Windows.Forms.Button();
            this.cuisine = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.cuisine1 = new RestaurantGroupe9.Cuisine();
            this.reservation1 = new RestaurantGroupe9.View.Reservation();
            this.reception1 = new RestaurantGroupe9.Reception();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.maximum);
            this.panel1.Controls.Add(this.minimal);
            this.panel1.Controls.Add(this.timer);
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
            // maximum
            // 
            this.maximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximum.Location = new System.Drawing.Point(99, 96);
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(30, 32);
            this.maximum.TabIndex = 7;
            this.maximum.Text = ">";
            this.maximum.UseVisualStyleBackColor = true;
            this.maximum.Click += new System.EventHandler(this.maximum_Click);
            // 
            // minimal
            // 
            this.minimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimal.Location = new System.Drawing.Point(24, 96);
            this.minimal.Name = "minimal";
            this.minimal.Size = new System.Drawing.Size(30, 32);
            this.minimal.TabIndex = 6;
            this.minimal.Text = "<";
            this.minimal.UseVisualStyleBackColor = true;
            this.minimal.Click += new System.EventHandler(this.minimal_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(61, 100);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(32, 24);
            this.timer.TabIndex = 5;
            this.timer.Text = "x1";
            // 
            // reserver
            // 
            this.reserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserver.Location = new System.Drawing.Point(24, 408);
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
            this.stop.Location = new System.Drawing.Point(24, 57);
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
            this.reception.Location = new System.Drawing.Point(24, 336);
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
            this.cuisine.Location = new System.Drawing.Point(24, 372);
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
            this.cuisine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuisine1.BackgroundImage")));
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
            this.reception1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reception1.BackgroundImage")));
            this.reception1.Location = new System.Drawing.Point(3, 0);
            this.reception1.Name = "reception1";
            this.reception1.Size = new System.Drawing.Size(666, 450);
            this.reception1.TabIndex = 3;
            this.reception1.Load += new System.EventHandler(this.reception1_Load_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reception1);
            this.Controls.Add(this.reservation1);
            this.Controls.Add(this.cuisine1);
            this.Controls.Add(this.panel1);
            this.Name = "Restaurant";
            this.Text = "GESTION RESTAURANT GROUPE 9";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button maximum;
        private System.Windows.Forms.Button minimal;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label label1;
    }
}