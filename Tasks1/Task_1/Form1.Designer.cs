namespace Task_1
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
            comboBoxEyeColor = new ComboBox();
            comboBoxPlace = new ComboBox();
            comboBoxHairColor = new ComboBox();
            comboBoxNames = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxEyeColor
            // 
            comboBoxEyeColor.FormattingEnabled = true;
            comboBoxEyeColor.Location = new Point(511, 79);
            comboBoxEyeColor.Name = "comboBoxEyeColor";
            comboBoxEyeColor.Size = new Size(121, 23);
            comboBoxEyeColor.TabIndex = 0;
            // 
            // comboBoxPlace
            // 
            comboBoxPlace.FormattingEnabled = true;
            comboBoxPlace.Location = new Point(372, 79);
            comboBoxPlace.Name = "comboBoxPlace";
            comboBoxPlace.Size = new Size(121, 23);
            comboBoxPlace.TabIndex = 1;
            // 
            // comboBoxHairColor
            // 
            comboBoxHairColor.FormattingEnabled = true;
            comboBoxHairColor.Location = new Point(233, 79);
            comboBoxHairColor.Name = "comboBoxHairColor";
            comboBoxHairColor.Size = new Size(121, 23);
            comboBoxHairColor.TabIndex = 2;
            comboBoxHairColor.SelectedIndexChanged += eyeColors_SelectedIndexChanged;
            // 
            // comboBoxNames
            // 
            comboBoxNames.FormattingEnabled = true;
            comboBoxNames.Location = new Point(233, 16);
            comboBoxNames.Name = "comboBoxNames";
            comboBoxNames.Size = new Size(121, 23);
            comboBoxNames.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxNames);
            Controls.Add(comboBoxHairColor);
            Controls.Add(comboBoxPlace);
            Controls.Add(comboBoxEyeColor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxEyeColor;
        private ComboBox comboBoxPlace;
        private ComboBox comboBoxHairColor;
        private ComboBox comboBoxNames;
    }
}
