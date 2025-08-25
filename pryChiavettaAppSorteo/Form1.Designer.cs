namespace pryChiavettaAppSorteo
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
            label1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(235, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario--------------";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(33, 100);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(205, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Fecha de sorteo-------------";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(33, 139);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(224, 21);
            lbl3.TabIndex = 2;
            lbl3.Text = "Cantidad de Participantes---- ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = Color.White;
            button1.Location = new Point(306, 190);
            button1.Name = "button1";
            button1.Size = new Size(198, 36);
            button1.TabIndex = 3;
            button1.Text = "!!REGISTRAR!!";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(229, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 5;
            label2.Text = "!SORTEO 0KM!";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl2;
        private Label lbl3;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
