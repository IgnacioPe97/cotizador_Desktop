namespace ConversorTemperatura
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
            txt_Farenheit = new Label();
            txt_Celsius = new Label();
            txt_Kelvin = new Label();
            txb_Farenheit = new TextBox();
            txb_Celsius = new TextBox();
            txb_Kelvin = new TextBox();
            btn_Farenheit = new Button();
            btn_Celsius = new Button();
            btn_Kelvin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_FarToFar = new TextBox();
            txt_FarToCel = new TextBox();
            txt_FarToKel = new TextBox();
            SuspendLayout();
            // 
            // txt_Farenheit
            // 
            txt_Farenheit.AutoSize = true;
            txt_Farenheit.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Farenheit.Location = new Point(30, 118);
            txt_Farenheit.Name = "txt_Farenheit";
            txt_Farenheit.Size = new Size(84, 16);
            txt_Farenheit.TabIndex = 0;
            txt_Farenheit.Text = "Fahrenheit";
            // 
            // txt_Celsius
            // 
            txt_Celsius.AutoSize = true;
            txt_Celsius.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Celsius.Location = new Point(42, 157);
            txt_Celsius.Name = "txt_Celsius";
            txt_Celsius.Size = new Size(60, 16);
            txt_Celsius.TabIndex = 1;
            txt_Celsius.Text = "Celsius";
            // 
            // txt_Kelvin
            // 
            txt_Kelvin.AutoSize = true;
            txt_Kelvin.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Kelvin.Location = new Point(42, 198);
            txt_Kelvin.Name = "txt_Kelvin";
            txt_Kelvin.Size = new Size(56, 16);
            txt_Kelvin.TabIndex = 2;
            txt_Kelvin.Text = "Kelvin";
            // 
            // txb_Farenheit
            // 
            txb_Farenheit.Location = new Point(128, 111);
            txb_Farenheit.Name = "txb_Farenheit";
            txb_Farenheit.Size = new Size(100, 23);
            txb_Farenheit.TabIndex = 3;
            txb_Farenheit.TextChanged += txb_Farenheit_TextChanged;
            txb_Farenheit.Validating += txt_Farenheit_Validating;
            // 
            // txb_Celsius
            // 
            txb_Celsius.Location = new Point(128, 150);
            txb_Celsius.Name = "txb_Celsius";
            txb_Celsius.Size = new Size(100, 23);
            txb_Celsius.TabIndex = 4;
            txb_Celsius.Validating += txt_Celsius_Validating;
            // 
            // txb_Kelvin
            // 
            txb_Kelvin.Location = new Point(128, 191);
            txb_Kelvin.Name = "txb_Kelvin";
            txb_Kelvin.Size = new Size(100, 23);
            txb_Kelvin.TabIndex = 5;
            txb_Kelvin.Validating += txt_Kelvin_Validating;
            // 
            // btn_Farenheit
            // 
            btn_Farenheit.Location = new Point(269, 115);
            btn_Farenheit.Name = "btn_Farenheit";
            btn_Farenheit.Size = new Size(75, 23);
            btn_Farenheit.TabIndex = 6;
            btn_Farenheit.Text = "->";
            btn_Farenheit.UseVisualStyleBackColor = true;
            btn_Farenheit.Click += btn_Farenheit_Click;
            // 
            // btn_Celsius
            // 
            btn_Celsius.Location = new Point(269, 150);
            btn_Celsius.Name = "btn_Celsius";
            btn_Celsius.Size = new Size(75, 23);
            btn_Celsius.TabIndex = 7;
            btn_Celsius.Text = "->";
            btn_Celsius.UseVisualStyleBackColor = true;
            // 
            // btn_Kelvin
            // 
            btn_Kelvin.Location = new Point(269, 191);
            btn_Kelvin.Name = "btn_Kelvin";
            btn_Kelvin.Size = new Size(75, 23);
            btn_Kelvin.TabIndex = 8;
            btn_Kelvin.Text = "->";
            btn_Kelvin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(423, 83);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 9;
            label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(559, 83);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 10;
            label2.Text = "Celsius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(701, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 11;
            label3.Text = "Kelvin";
            // 
            // txt_FarToFar
            // 
            txt_FarToFar.Location = new Point(414, 116);
            txt_FarToFar.Name = "txt_FarToFar";
            txt_FarToFar.Size = new Size(100, 23);
            txt_FarToFar.TabIndex = 12;
            // 
            // txt_FarToCel
            // 
            txt_FarToCel.Location = new Point(538, 115);
            txt_FarToCel.Name = "txt_FarToCel";
            txt_FarToCel.Size = new Size(100, 23);
            txt_FarToCel.TabIndex = 13;
            // 
            // txt_FarToKel
            // 
            txt_FarToKel.Location = new Point(679, 115);
            txt_FarToKel.Name = "txt_FarToKel";
            txt_FarToKel.Size = new Size(100, 23);
            txt_FarToKel.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_FarToKel);
            Controls.Add(txt_FarToCel);
            Controls.Add(txt_FarToFar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Kelvin);
            Controls.Add(btn_Celsius);
            Controls.Add(btn_Farenheit);
            Controls.Add(txb_Kelvin);
            Controls.Add(txb_Celsius);
            Controls.Add(txb_Farenheit);
            Controls.Add(txt_Kelvin);
            Controls.Add(txt_Celsius);
            Controls.Add(txt_Farenheit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_Farenheit;
        private Label txt_Celsius;
        private Label txt_Kelvin;
        private TextBox txb_Farenheit;
        private TextBox txb_Celsius;
        private TextBox txb_Kelvin;
        private Button btn_Farenheit;
        private Button btn_Celsius;
        private Button btn_Kelvin;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_FarToFar;
        private TextBox txt_FarToCel;
        private TextBox txt_FarToKel;
    }
}