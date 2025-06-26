namespace WinFormsApp_ImpUserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEvaluateVariant = new System.Windows.Forms.Button();
            this.button_EvaluaateAllDefault = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_InputValue = new System.Windows.Forms.Label();
            this.Label_Output = new System.Windows.Forms.Label();
            this.pictureBox_Formula = new System.Windows.Forms.PictureBox();
            this.comBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.LabelInputTaskNum = new System.Windows.Forms.Label();
            this.panel_Output = new System.Windows.Forms.Panel();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.vScrollBar_InputValue = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).BeginInit();
            this.panel_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEvaluateVariant
            // 
            this.buttonEvaluateVariant.Location = new System.Drawing.Point(5, 157);
            this.buttonEvaluateVariant.Name = "buttonEvaluateVariant";
            this.buttonEvaluateVariant.Size = new System.Drawing.Size(164, 46);
            this.buttonEvaluateVariant.TabIndex = 0;
            this.buttonEvaluateVariant.Text = "Выполнить расчет ";
            this.buttonEvaluateVariant.UseVisualStyleBackColor = true;
            this.buttonEvaluateVariant.Click += new System.EventHandler(this.buttonEvaluateVariant_Click);
            // 
            // button_EvaluaateAllDefault
            // 
            this.button_EvaluaateAllDefault.Location = new System.Drawing.Point(5, 209);
            this.button_EvaluaateAllDefault.Name = "button_EvaluaateAllDefault";
            this.button_EvaluaateAllDefault.Size = new System.Drawing.Size(164, 42);
            this.button_EvaluaateAllDefault.TabIndex = 1;
            this.button_EvaluaateAllDefault.Text = "Все расчеты со \r\nзначениями по умолчанию\r\n\r\n";
            this.button_EvaluaateAllDefault.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(5, 257);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(164, 48);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // label_InputValue
            // 
            this.label_InputValue.AutoSize = true;
            this.label_InputValue.Location = new System.Drawing.Point(12, 46);
            this.label_InputValue.Name = "label_InputValue";
            this.label_InputValue.Size = new System.Drawing.Size(140, 13);
            this.label_InputValue.TabIndex = 3;
            this.label_InputValue.Text = "Выберите номер задания ";
            // 
            // Label_Output
            // 
            this.Label_Output.Location = new System.Drawing.Point(23, 212);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(316, 81);
            this.Label_Output.TabIndex = 4;
            this.Label_Output.Text = "Расчет по формуле при n=...";
            // 
            // pictureBox_Formula
            // 
            this.pictureBox_Formula.Location = new System.Drawing.Point(14, 15);
            this.pictureBox_Formula.Name = "pictureBox_Formula";
            this.pictureBox_Formula.Size = new System.Drawing.Size(300, 100);
            this.pictureBox_Formula.TabIndex = 5;
            this.pictureBox_Formula.TabStop = false;
            // 
            // comBox_TaskNum
            // 
            this.comBox_TaskNum.FormattingEnabled = true;
            this.comBox_TaskNum.Items.AddRange(new object[] {
            "Задание 1",
            "Задание 2",
            "Задание 3"});
            this.comBox_TaskNum.Location = new System.Drawing.Point(15, 62);
            this.comBox_TaskNum.Name = "comBox_TaskNum";
            this.comBox_TaskNum.Size = new System.Drawing.Size(121, 21);
            this.comBox_TaskNum.TabIndex = 6;
            this.comBox_TaskNum.SelectedIndexChanged += new System.EventHandler(this.comBox_TaskNum_SelectedIndexChanged);
            // 
            // LabelInputTaskNum
            // 
            this.LabelInputTaskNum.AutoSize = true;
            this.LabelInputTaskNum.Location = new System.Drawing.Point(23, 169);
            this.LabelInputTaskNum.Name = "LabelInputTaskNum";
            this.LabelInputTaskNum.Size = new System.Drawing.Size(67, 13);
            this.LabelInputTaskNum.TabIndex = 7;
            this.LabelInputTaskNum.Text = "Значение n:";
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.vScrollBar_InputValue);
            this.panel_Output.Controls.Add(this.pictureBox_Formula);
            this.panel_Output.Controls.Add(this.Label_Output);
            this.panel_Output.Controls.Add(this.textBox_InputValue);
            this.panel_Output.Controls.Add(this.LabelInputTaskNum);
            this.panel_Output.Location = new System.Drawing.Point(175, 12);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(352, 310);
            this.panel_Output.TabIndex = 8;
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(96, 166);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputValue.TabIndex = 9;
            this.textBox_InputValue.TextChanged += new System.EventHandler(this.textBox_InputValue_TextChanged);
            // 
            // vScrollBar_InputValue
            // 
            this.vScrollBar_InputValue.Location = new System.Drawing.Point(199, 164);
            this.vScrollBar_InputValue.Name = "vScrollBar_InputValue";
            this.vScrollBar_InputValue.Size = new System.Drawing.Size(10, 22);
            this.vScrollBar_InputValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 331);
            this.Controls.Add(this.panel_Output);
            this.Controls.Add(this.comBox_TaskNum);
            this.Controls.Add(this.label_InputValue);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_EvaluaateAllDefault);
            this.Controls.Add(this.buttonEvaluateVariant);
            this.Name = "Form1";
            this.Text = "FormMain.cs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).EndInit();
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEvaluateVariant;
        private System.Windows.Forms.Button button_EvaluaateAllDefault;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_InputValue;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.PictureBox pictureBox_Formula;
        private System.Windows.Forms.ComboBox comBox_TaskNum;
        private System.Windows.Forms.Label LabelInputTaskNum;
        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.VScrollBar vScrollBar_InputValue;
        private System.Windows.Forms.TextBox textBox_InputValue;
    }
}

