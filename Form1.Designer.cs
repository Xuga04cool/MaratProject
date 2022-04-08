
namespace MaratProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.howWorkPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.howLabelFirst = new System.Windows.Forms.Label();
            this.howWorkLabel = new System.Windows.Forms.Label();
            this.boldLabel = new System.Windows.Forms.Label();
            this.littleLabel = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.getDataPanel = new System.Windows.Forms.Panel();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.multiplicandTextBox = new System.Windows.Forms.TextBox();
            this.multiplicandLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerTextLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.howWorkPanel.SuspendLayout();
            this.getDataPanel.SuspendLayout();
            this.answerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.howWorkPanel);
            this.mainPanel.Location = new System.Drawing.Point(-6, 68);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(753, 311);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // howWorkPanel
            // 
            this.howWorkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.howWorkPanel.Controls.Add(this.label1);
            this.howWorkPanel.Controls.Add(this.howLabelFirst);
            this.howWorkPanel.Controls.Add(this.howWorkLabel);
            this.howWorkPanel.Location = new System.Drawing.Point(32, 81);
            this.howWorkPanel.Name = "howWorkPanel";
            this.howWorkPanel.Size = new System.Drawing.Size(686, 163);
            this.howWorkPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // howLabelFirst
            // 
            this.howLabelFirst.Location = new System.Drawing.Point(4, 35);
            this.howLabelFirst.Name = "howLabelFirst";
            this.howLabelFirst.Size = new System.Drawing.Size(664, 16);
            this.howLabelFirst.TabIndex = 1;
            this.howLabelFirst.Text = "Множитель заносится в регистр множителя, множимое в реистр множимого, исходное зн" +
    "ачение регистра СПЧ обнуляетя.";
            // 
            // howWorkLabel
            // 
            this.howWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.howWorkLabel.Location = new System.Drawing.Point(176, 9);
            this.howWorkLabel.Name = "howWorkLabel";
            this.howWorkLabel.Size = new System.Drawing.Size(260, 16);
            this.howWorkLabel.TabIndex = 0;
            this.howWorkLabel.Text = "Как работает умножение cдвигом влево?";
            // 
            // boldLabel
            // 
            this.boldLabel.AutoSize = true;
            this.boldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldLabel.Location = new System.Drawing.Point(131, 9);
            this.boldLabel.Name = "boldLabel";
            this.boldLabel.Size = new System.Drawing.Size(476, 13);
            this.boldLabel.TabIndex = 1;
            this.boldLabel.Text = "Виртуализация аппаратной реализации операций умножения и деления чисел";
            this.boldLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // littleLabel
            // 
            this.littleLabel.Location = new System.Drawing.Point(131, 35);
            this.littleLabel.Name = "littleLabel";
            this.littleLabel.Size = new System.Drawing.Size(473, 30);
            this.littleLabel.TabIndex = 2;
            this.littleLabel.Text = "           программа предназначена для демонстрации пошагового выполнения работы " +
    "\r\nалгоритма сложения на положительных числах, представимых в четырехразрядной се" +
    "тке";
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Location = new System.Drawing.Point(605, 395);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(82, 28);
            this.btn.TabIndex = 4;
            this.btn.Text = "Далее";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // getDataPanel
            // 
            this.getDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getDataPanel.Controls.Add(this.multiplierTextBox);
            this.getDataPanel.Controls.Add(this.multiplierLabel);
            this.getDataPanel.Controls.Add(this.multiplicandTextBox);
            this.getDataPanel.Controls.Add(this.multiplicandLabel);
            this.getDataPanel.Controls.Add(this.label4);
            this.getDataPanel.Location = new System.Drawing.Point(773, 68);
            this.getDataPanel.Name = "getDataPanel";
            this.getDataPanel.Size = new System.Drawing.Size(686, 163);
            this.getDataPanel.TabIndex = 3;
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.Location = new System.Drawing.Point(26, 110);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.Size = new System.Drawing.Size(59, 20);
            this.multiplierTextBox.TabIndex = 4;
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.multiplierLabel.Location = new System.Drawing.Point(8, 91);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(76, 16);
            this.multiplierLabel.TabIndex = 3;
            this.multiplierLabel.Text = "Множитель";
            // 
            // multiplicandTextBox
            // 
            this.multiplicandTextBox.Location = new System.Drawing.Point(25, 59);
            this.multiplicandTextBox.Name = "multiplicandTextBox";
            this.multiplicandTextBox.Size = new System.Drawing.Size(59, 20);
            this.multiplicandTextBox.TabIndex = 2;
            // 
            // multiplicandLabel
            // 
            this.multiplicandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.multiplicandLabel.Location = new System.Drawing.Point(7, 40);
            this.multiplicandLabel.Name = "multiplicandLabel";
            this.multiplicandLabel.Size = new System.Drawing.Size(78, 16);
            this.multiplicandLabel.TabIndex = 1;
            this.multiplicandLabel.Text = "Множимое ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите множимое и множитель";
            // 
            // answerPanel
            // 
            this.answerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerPanel.Controls.Add(this.answerLabel);
            this.answerPanel.Controls.Add(this.answerTextLabel);
            this.answerPanel.Location = new System.Drawing.Point(773, 237);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(686, 163);
            this.answerPanel.TabIndex = 5;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.answerLabel.Location = new System.Drawing.Point(25, 30);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(46, 17);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "label2";
            // 
            // answerTextLabel
            // 
            this.answerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextLabel.Location = new System.Drawing.Point(7, 10);
            this.answerTextLabel.Name = "answerTextLabel";
            this.answerTextLabel.Size = new System.Drawing.Size(260, 16);
            this.answerTextLabel.TabIndex = 0;
            this.answerTextLabel.Text = "Ответ\r\n:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1471, 721);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.getDataPanel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.littleLabel);
            this.Controls.Add(this.boldLabel);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Аппаратная реализация арифметических операций";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.howWorkPanel.ResumeLayout(false);
            this.getDataPanel.ResumeLayout(false);
            this.getDataPanel.PerformLayout();
            this.answerPanel.ResumeLayout(false);
            this.answerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label boldLabel;
        private System.Windows.Forms.Label littleLabel;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel howWorkPanel;
        private System.Windows.Forms.Label howWorkLabel;
        private System.Windows.Forms.Label howLabelFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel getDataPanel;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.TextBox multiplicandTextBox;
        private System.Windows.Forms.Label multiplicandLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label answerTextLabel;
    }
}

