namespace ITU.RefereeAssistant.WinApp
{
    partial class FormReferee
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
            this.cbTourType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.playerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTourType
            // 
            this.cbTourType.FormattingEnabled = true;
            this.cbTourType.Location = new System.Drawing.Point(29, 47);
            this.cbTourType.Name = "cbTourType";
            this.cbTourType.Size = new System.Drawing.Size(121, 21);
            this.cbTourType.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 21);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(474, 333);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Очистить список";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // gbPlayers
            // 
            this.gbPlayers.Location = new System.Drawing.Point(349, 12);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(241, 297);
            this.gbPlayers.TabIndex = 7;
            this.gbPlayers.TabStop = false;
            this.gbPlayers.Text = "Список участников";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(29, 103);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(201, 20);
            this.tbPlayerName.TabIndex = 0;
            this.tbPlayerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gbPlayerName_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // playerText
            // 
            this.playerText.AutoSize = true;
            this.playerText.Location = new System.Drawing.Point(26, 87);
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(294, 13);
            this.playerText.TabIndex = 8;
            this.playerText.Text = "Введите название команды и нажмите кнопку добавить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите тип системы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // FormReferee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbPlayers);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbTourType);
            this.Name = "FormReferee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощник судьи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTourType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label playerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

