﻿namespace WindowsFormsApp2
{
    partial class FrmProgressBarSample
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
            this.components = new System.ComponentModel.Container();
            this.ProgressBarProcess = new System.Windows.Forms.ProgressBar();
            this.LabelPercentComplete = new System.Windows.Forms.Label();
            this.LabelPercentCompleteText = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelStatusText = new System.Windows.Forms.Label();
            this.LabelProgressStep = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.TimerForProgressBar = new System.Windows.Forms.Timer(this.components);
            this.ComboBoxProgressStep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProgressBarProcess
            // 
            this.ProgressBarProcess.Location = new System.Drawing.Point(12, 21);
            this.ProgressBarProcess.Name = "ProgressBarProcess";
            this.ProgressBarProcess.Size = new System.Drawing.Size(616, 23);
            this.ProgressBarProcess.TabIndex = 0;
            this.ProgressBarProcess.Click += new System.EventHandler(this.ProgressBarProcess_Click);
            // 
            // LabelPercentComplete
            // 
            this.LabelPercentComplete.AutoSize = true;
            this.LabelPercentComplete.Location = new System.Drawing.Point(9, 47);
            this.LabelPercentComplete.Name = "LabelPercentComplete";
            this.LabelPercentComplete.Size = new System.Drawing.Size(67, 13);
            this.LabelPercentComplete.TabIndex = 1;
            this.LabelPercentComplete.Text = "Выполнено:";
            this.LabelPercentComplete.Click += new System.EventHandler(this.LabelPercentComplete_Click);
            // 
            // LabelPercentCompleteText
            // 
            this.LabelPercentCompleteText.AutoSize = true;
            this.LabelPercentCompleteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPercentCompleteText.Location = new System.Drawing.Point(82, 47);
            this.LabelPercentCompleteText.Name = "LabelPercentCompleteText";
            this.LabelPercentCompleteText.Size = new System.Drawing.Size(16, 13);
            this.LabelPercentCompleteText.TabIndex = 2;
            this.LabelPercentCompleteText.Text = "%";
            this.LabelPercentCompleteText.Click += new System.EventHandler(this.LabelPercentCompleteText_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(9, 69);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(44, 13);
            this.LabelStatus.TabIndex = 3;
            this.LabelStatus.Text = "Статус:";
            this.LabelStatus.Click += new System.EventHandler(this.LabelStatus_Click);
            // 
            // LabelStatusText
            // 
            this.LabelStatusText.AutoSize = true;
            this.LabelStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStatusText.Location = new System.Drawing.Point(82, 69);
            this.LabelStatusText.Name = "LabelStatusText";
            this.LabelStatusText.Size = new System.Drawing.Size(14, 13);
            this.LabelStatusText.TabIndex = 4;
            this.LabelStatusText.Text = "?";
            this.LabelStatusText.Click += new System.EventHandler(this.LabelStatusText_Click);
            // 
            // LabelProgressStep
            // 
            this.LabelProgressStep.AutoSize = true;
            this.LabelProgressStep.Location = new System.Drawing.Point(328, 111);
            this.LabelProgressStep.Name = "LabelProgressStep";
            this.LabelProgressStep.Size = new System.Drawing.Size(107, 13);
            this.LabelProgressStep.TabIndex = 5;
            this.LabelProgressStep.Text = "Шаг прогресс бара:";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(13, 106);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(130, 23);
            this.ButtonReset.TabIndex = 6;
            this.ButtonReset.Text = "&Сброс";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(149, 106);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(130, 23);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.Text = "&Остановить";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // TimerForProgressBar
            // 
            this.TimerForProgressBar.Interval = 1000;
            this.TimerForProgressBar.Tick += new System.EventHandler(this.TimerForProgressBar_Tick);
            // 
            // ComboBoxProgressStep
            // 
            this.ComboBoxProgressStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProgressStep.FormattingEnabled = true;
            this.ComboBoxProgressStep.Location = new System.Drawing.Point(441, 108);
            this.ComboBoxProgressStep.Name = "ComboBoxProgressStep";
            this.ComboBoxProgressStep.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxProgressStep.TabIndex = 8;
            this.ComboBoxProgressStep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmProgressBarSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 141);
            this.Controls.Add(this.ComboBoxProgressStep);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.LabelProgressStep);
            this.Controls.Add(this.LabelStatusText);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelPercentCompleteText);
            this.Controls.Add(this.LabelPercentComplete);
            this.Controls.Add(this.ProgressBarProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProgressBarSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[Allineed.Ru] Пример работы с элементом ProgressBar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarProcess;
        private System.Windows.Forms.Label LabelPercentComplete;
        private System.Windows.Forms.Label LabelPercentCompleteText;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelStatusText;
        private System.Windows.Forms.Label LabelProgressStep;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Timer TimerForProgressBar;
        private System.Windows.Forms.ComboBox ComboBoxProgressStep;
    }
}

