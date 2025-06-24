namespace MidiToMotor
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.rbStop = new Telerik.WinControls.UI.RadButton();
            this.checkedListBoxChannels = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radButtonMHSTW = new Telerik.WinControls.UI.RadButton();
            this.radButtonHurt = new Telerik.WinControls.UI.RadButton();
            this.kCubeInertialMotorCtrl1 = new CommonLibrary.Devices.MotionController.ThorLabs.KCube.ChuckRotatorCtrl();
            this.radButtonFunkyTown = new Telerik.WinControls.UI.RadButton();
            this.radButtonMultiToneTest = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonMHSTW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonHurt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonFunkyTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonMultiToneTest)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(36, 30);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Charge";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(178, 30);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Imperial Theme";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(36, 162);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(176, 24);
            this.radButton3.TabIndex = 4;
            this.radButton3.Text = "Imperial Theme Midi";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // rbStop
            // 
            this.rbStop.Location = new System.Drawing.Point(286, 116);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(68, 24);
            this.rbStop.TabIndex = 5;
            this.rbStop.Text = "Stop";
            this.rbStop.Click += new System.EventHandler(this.rbStop_Click);
            // 
            // checkedListBoxChannels
            // 
            this.checkedListBoxChannels.CheckOnClick = true;
            this.checkedListBoxChannels.FormattingEnabled = true;
            this.checkedListBoxChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.checkedListBoxChannels.Location = new System.Drawing.Point(283, 162);
            this.checkedListBoxChannels.Name = "checkedListBoxChannels";
            this.checkedListBoxChannels.Size = new System.Drawing.Size(120, 229);
            this.checkedListBoxChannels.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Channels";
            // 
            // radButtonMHSTW
            // 
            this.radButtonMHSTW.Location = new System.Drawing.Point(36, 205);
            this.radButtonMHSTW.Name = "radButtonMHSTW";
            this.radButtonMHSTW.Size = new System.Drawing.Size(176, 24);
            this.radButtonMHSTW.TabIndex = 5;
            this.radButtonMHSTW.Text = "Man Who Sold The World";
            this.radButtonMHSTW.Click += new System.EventHandler(this.radButtonMHSTW_Click);
            // 
            // radButtonHurt
            // 
            this.radButtonHurt.Location = new System.Drawing.Point(36, 248);
            this.radButtonHurt.Name = "radButtonHurt";
            this.radButtonHurt.Size = new System.Drawing.Size(176, 24);
            this.radButtonHurt.TabIndex = 8;
            this.radButtonHurt.Text = "Stairway To Heaven";
            this.radButtonHurt.Click += new System.EventHandler(this.radButtonHurt_Click);
            // 
            // kCubeInertialMotorCtrl1
            // 
            this.kCubeInertialMotorCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kCubeInertialMotorCtrl1.BackgroundImage")));
            this.kCubeInertialMotorCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kCubeInertialMotorCtrl1.Location = new System.Drawing.Point(449, 394);
            this.kCubeInertialMotorCtrl1.Name = "kCubeInertialMotorCtrl1";
            this.kCubeInertialMotorCtrl1.Size = new System.Drawing.Size(339, 44);
            this.kCubeInertialMotorCtrl1.TabIndex = 1;
            // 
            // radButtonFunkyTown
            // 
            this.radButtonFunkyTown.Location = new System.Drawing.Point(36, 291);
            this.radButtonFunkyTown.Name = "radButtonFunkyTown";
            this.radButtonFunkyTown.Size = new System.Drawing.Size(176, 24);
            this.radButtonFunkyTown.TabIndex = 9;
            this.radButtonFunkyTown.Text = "Funky Town";
            this.radButtonFunkyTown.Click += new System.EventHandler(this.radButtonFunkyTown_Click);
            // 
            // radButtonMultiToneTest
            // 
            this.radButtonMultiToneTest.Location = new System.Drawing.Point(312, 30);
            this.radButtonMultiToneTest.Name = "radButtonMultiToneTest";
            this.radButtonMultiToneTest.Size = new System.Drawing.Size(110, 24);
            this.radButtonMultiToneTest.TabIndex = 3;
            this.radButtonMultiToneTest.Text = "Tone Test";
            this.radButtonMultiToneTest.Click += new System.EventHandler(this.radButtonMultiToneTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radButtonMultiToneTest);
            this.Controls.Add(this.radButtonFunkyTown);
            this.Controls.Add(this.radButtonHurt);
            this.Controls.Add(this.radButtonMHSTW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxChannels);
            this.Controls.Add(this.rbStop);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.kCubeInertialMotorCtrl1);
            this.Controls.Add(this.radButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonMHSTW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonHurt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonFunkyTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonMultiToneTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private CommonLibrary.Devices.MotionController.ThorLabs.KCube.ChuckRotatorCtrl kCubeInertialMotorCtrl1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton rbStop;
        private System.Windows.Forms.CheckedListBox checkedListBoxChannels;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton radButtonMHSTW;
        private Telerik.WinControls.UI.RadButton radButtonHurt;
        private Telerik.WinControls.UI.RadButton radButtonFunkyTown;
        private Telerik.WinControls.UI.RadButton radButtonMultiToneTest;
    }
}

