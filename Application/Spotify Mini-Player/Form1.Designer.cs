namespace Spotify_Mini_Player
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
            this.btn_options = new System.Windows.Forms.Button();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.coverImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.Transparent;
            this.btn_options.BackgroundImage = global::Spotify_Mini_Player.Properties.Resources.cog_solid1;
            this.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_options.FlatAppearance.BorderSize = 0;
            this.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.ForeColor = System.Drawing.Color.Transparent;
            this.btn_options.Location = new System.Drawing.Point(12, 10);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(21, 22);
            this.btn_options.TabIndex = 0;
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // btn_Queue
            // 
            this.btn_Queue.BackColor = System.Drawing.Color.Transparent;
            this.btn_Queue.BackgroundImage = global::Spotify_Mini_Player.Properties.Resources.outdent_solid;
            this.btn_Queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Queue.FlatAppearance.BorderSize = 0;
            this.btn_Queue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Queue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Queue.Location = new System.Drawing.Point(300, 10);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(22, 22);
            this.btn_Queue.TabIndex = 1;
            this.btn_Queue.UseVisualStyleBackColor = false;
            this.btn_Queue.Click += new System.EventHandler(this.Btn_Queue_Click);
            // 
            // coverImage
            // 
            this.coverImage.BackColor = System.Drawing.Color.Transparent;
            this.coverImage.Location = new System.Drawing.Point(55, 20);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(220, 220);
            this.coverImage.TabIndex = 2;
            this.coverImage.TabStop = false;
            this.coverImage.Click += new System.EventHandler(this.CoverImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(339, 371);
            this.Controls.Add(this.coverImage);
            this.Controls.Add(this.btn_Queue);
            this.Controls.Add(this.btn_options);
            this.MaximumSize = new System.Drawing.Size(355, 410);
            this.MinimumSize = new System.Drawing.Size(355, 410);
            this.Name = "Form1";
            this.Text = "Spotify Mini-Player";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_options;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.PictureBox coverImage;
    }
}

