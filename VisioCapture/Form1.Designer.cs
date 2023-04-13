namespace VisioCapture
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.videoView1 = new VisioForge.Core.UI.WinForms.VideoView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cbSourceMode = new System.Windows.Forms.ComboBox();
            this.videoView2 = new VisioForge.Core.UI.WinForms.VideoView();
            this.cbscreen = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 29);
            this.textBox1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(57, 374);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 54);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Start";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Gray;
            this.videoView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("videoView1.BackgroundImage")));
            this.videoView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoView1.Location = new System.Drawing.Point(57, 110);
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(460, 249);
            this.videoView1.StatusOverlay = null;
            this.videoView1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(188, 374);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 54);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Stop";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(853, 374);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(156, 54);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Snapshot";
            // 
            // cbSourceMode
            // 
            this.cbSourceMode.FormattingEnabled = true;
            this.cbSourceMode.Items.AddRange(new object[] {
            "File / Network stream (decode using LAV) ",
            "File / Network stream (decode using GPU) ",
            "File / Network stream (decode using FFMPEG)",
            "File (decode using DirectShow)",
            "File (decode using VLC)",
            "Blu-Ray",
            "File from memory (decode using DirectShow)",
            "MMS / WMV (network stream)",
            "HTTP / RTSP / RTMP (decoding using VLC)",
            "Encrypted file (decode using DirectShow)",
            "MIDI / KAR"});
            this.cbSourceMode.Location = new System.Drawing.Point(640, 31);
            this.cbSourceMode.Name = "cbSourceMode";
            this.cbSourceMode.Size = new System.Drawing.Size(364, 24);
            this.cbSourceMode.TabIndex = 5;
            this.cbSourceMode.Text = "Select";
            // 
            // videoView2
            // 
            this.videoView2.BackColor = System.Drawing.Color.Black;
            this.videoView2.Location = new System.Drawing.Point(545, 104);
            this.videoView2.Name = "videoView2";
            this.videoView2.Size = new System.Drawing.Size(464, 255);
            this.videoView2.StatusOverlay = null;
            this.videoView2.TabIndex = 6;
            // 
            // cbscreen
            // 
            this.cbscreen.FormattingEnabled = true;
            this.cbscreen.Items.AddRange(new object[] {
            "Pantalla 1",
            "Pantalla 2"});
            this.cbscreen.Location = new System.Drawing.Point(57, 65);
            this.cbscreen.Name = "cbscreen";
            this.cbscreen.Size = new System.Drawing.Size(205, 24);
            this.cbscreen.TabIndex = 7;
            this.cbscreen.Text = "Select";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(389, 374);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(104, 54);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "prueba";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 440);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.cbscreen);
            this.Controls.Add(this.videoView2);
            this.Controls.Add(this.cbSourceMode);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private VisioForge.Core.UI.WinForms.VideoView videoView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox cbSourceMode;
        private VisioForge.Core.UI.WinForms.VideoView videoView2;
        private System.Windows.Forms.ComboBox cbscreen;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}

