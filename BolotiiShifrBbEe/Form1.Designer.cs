namespace BolotiiShifr
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
            this.ishodniiText = new System.Windows.Forms.RichTextBox();
            this.stepSh = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.konechniiText = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.chooseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viborList = new System.Windows.Forms.ComboBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.shifrashBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.TextBox();
            this.qBox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.nBox = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.dClosed = new System.Windows.Forms.Label();
            this.nClosed = new System.Windows.Forms.Label();
            this.rsaText = new System.Windows.Forms.Label();
            this.morzeText = new System.Windows.Forms.Label();
            this.caesarText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stepSh)).BeginInit();
            this.SuspendLayout();
            // 
            // ishodniiText
            // 
            this.ishodniiText.Location = new System.Drawing.Point(90, 28);
            this.ishodniiText.Name = "ishodniiText";
            this.ishodniiText.Size = new System.Drawing.Size(776, 124);
            this.ishodniiText.TabIndex = 0;
            this.ishodniiText.Text = "";
            this.ishodniiText.Visible = false;
            this.ishodniiText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // stepSh
            // 
            this.stepSh.Location = new System.Drawing.Point(90, 158);
            this.stepSh.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stepSh.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.stepSh.Name = "stepSh";
            this.stepSh.Size = new System.Drawing.Size(67, 20);
            this.stepSh.TabIndex = 1;
            this.stepSh.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(90, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(67, 44);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Погнали";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // konechniiText
            // 
            this.konechniiText.Location = new System.Drawing.Point(90, 501);
            this.konechniiText.Name = "konechniiText";
            this.konechniiText.Size = new System.Drawing.Size(776, 134);
            this.konechniiText.TabIndex = 3;
            this.konechniiText.Text = "";
            this.konechniiText.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(12, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(38, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "<|=";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(393, 318);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(123, 47);
            this.chooseButton.TabIndex = 6;
            this.chooseButton.Text = "Далее";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(206, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите способ шифрования";
            // 
            // viborList
            // 
            this.viborList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viborList.FormattingEnabled = true;
            this.viborList.Items.AddRange(new object[] {
            "Код Морзе",
            "Шифр Цезаря",
            "RSA"});
            this.viborList.Location = new System.Drawing.Point(213, 291);
            this.viborList.Name = "viborList";
            this.viborList.Size = new System.Drawing.Size(490, 21);
            this.viborList.TabIndex = 8;
            // 
            // langBox
            // 
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.langBox.Location = new System.Drawing.Point(90, 157);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(100, 21);
            this.langBox.TabIndex = 9;
            this.langBox.Visible = false;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // shifrashBox
            // 
            this.shifrashBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shifrashBox.FormattingEnabled = true;
            this.shifrashBox.Items.AddRange(new object[] {
            "Шифрование",
            "Расшифрование"});
            this.shifrashBox.Location = new System.Drawing.Point(90, 191);
            this.shifrashBox.Name = "shifrashBox";
            this.shifrashBox.Size = new System.Drawing.Size(67, 21);
            this.shifrashBox.TabIndex = 10;
            this.shifrashBox.Visible = false;
            this.shifrashBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(279, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "p =";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(493, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "q =";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(279, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "d =";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(493, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "n =";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(307, 192);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(100, 20);
            this.pBox.TabIndex = 15;
            this.pBox.Visible = false;
            this.pBox.TextChanged += new System.EventHandler(this.pBox_TextChanged);
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(521, 192);
            this.qBox.Name = "qBox";
            this.qBox.Size = new System.Drawing.Size(100, 20);
            this.qBox.TabIndex = 16;
            this.qBox.Visible = false;
            this.qBox.TextChanged += new System.EventHandler(this.qBox_TextChanged);
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(307, 367);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(100, 20);
            this.dBox.TabIndex = 17;
            this.dBox.Visible = false;
            this.dBox.TextChanged += new System.EventHandler(this.dBox_TextChanged);
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(521, 367);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 18;
            this.nBox.Visible = false;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(361, 219);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(191, 40);
            this.buttonEncrypt.TabIndex = 19;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Visible = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecipher.Location = new System.Drawing.Point(361, 393);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(191, 40);
            this.buttonDecipher.TabIndex = 20;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Visible = false;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // dClosed
            // 
            this.dClosed.AutoSize = true;
            this.dClosed.Location = new System.Drawing.Point(688, 378);
            this.dClosed.Name = "dClosed";
            this.dClosed.Size = new System.Drawing.Size(0, 13);
            this.dClosed.TabIndex = 21;
            this.dClosed.Visible = false;
            // 
            // nClosed
            // 
            this.nClosed.AutoSize = true;
            this.nClosed.Location = new System.Drawing.Point(753, 378);
            this.nClosed.Name = "nClosed";
            this.nClosed.Size = new System.Drawing.Size(0, 13);
            this.nClosed.TabIndex = 22;
            this.nClosed.Visible = false;
            // 
            // rsaText
            // 
            this.rsaText.AutoSize = true;
            this.rsaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rsaText.Location = new System.Drawing.Point(72, 10);
            this.rsaText.Name = "rsaText";
            this.rsaText.Size = new System.Drawing.Size(48, 24);
            this.rsaText.TabIndex = 23;
            this.rsaText.Text = "RSA";
            this.rsaText.Visible = false;
            // 
            // morzeText
            // 
            this.morzeText.AutoSize = true;
            this.morzeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.morzeText.Location = new System.Drawing.Point(72, 10);
            this.morzeText.Name = "morzeText";
            this.morzeText.Size = new System.Drawing.Size(69, 24);
            this.morzeText.TabIndex = 24;
            this.morzeText.Text = "Морзе";
            this.morzeText.Visible = false;
            // 
            // caesarText
            // 
            this.caesarText.AutoSize = true;
            this.caesarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caesarText.Location = new System.Drawing.Point(72, 10);
            this.caesarText.Name = "caesarText";
            this.caesarText.Size = new System.Drawing.Size(75, 24);
            this.caesarText.TabIndex = 25;
            this.caesarText.Text = "Цезарь";
            this.caesarText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 678);
            this.Controls.Add(this.caesarText);
            this.Controls.Add(this.morzeText);
            this.Controls.Add(this.rsaText);
            this.Controls.Add(this.nClosed);
            this.Controls.Add(this.dClosed);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.dBox);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shifrashBox);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.viborList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.konechniiText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stepSh);
            this.Controls.Add(this.ishodniiText);
            this.Name = "Form1";
            this.Text = "Шифровальная машинка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stepSh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ishodniiText;
        private System.Windows.Forms.NumericUpDown stepSh;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox konechniiText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox viborList;
        public System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.ComboBox shifrashBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Label dClosed;
        private System.Windows.Forms.Label nClosed;
        private System.Windows.Forms.Label rsaText;
        private System.Windows.Forms.Label morzeText;
        private System.Windows.Forms.Label caesarText;
    }
}

