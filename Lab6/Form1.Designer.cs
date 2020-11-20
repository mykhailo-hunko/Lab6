namespace Lab6
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
            this.drop_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sumText = new System.Windows.Forms.Label();
            this.add_to_bin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sum_in_bin = new System.Windows.Forms.Label();
            this.toXML = new System.Windows.Forms.Button();
            this.fromXML = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cash_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drop_list
            // 
            this.drop_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_list.FormattingEnabled = true;
            this.drop_list.Location = new System.Drawing.Point(33, 59);
            this.drop_list.Name = "drop_list";
            this.drop_list.Size = new System.Drawing.Size(189, 21);
            this.drop_list.TabIndex = 0;
            this.drop_list.SelectedIndexChanged += new System.EventHandler(this.drop_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Магазин";
            // 
            // amount_product
            // 
            this.amount_product.AutoSize = true;
            this.amount_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount_product.Location = new System.Drawing.Point(336, 60);
            this.amount_product.Name = "amount_product";
            this.amount_product.Size = new System.Drawing.Size(18, 20);
            this.amount_product.TabIndex = 2;
            this.amount_product.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(242, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "В наличии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сколько?";
            // 
            // text_amount
            // 
            this.text_amount.Location = new System.Drawing.Point(133, 110);
            this.text_amount.Name = "text_amount";
            this.text_amount.Size = new System.Drawing.Size(100, 20);
            this.text_amount.TabIndex = 5;
            this.text_amount.TextChanged += new System.EventHandler(this.text_amount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сумма";
            // 
            // sumText
            // 
            this.sumText.AutoSize = true;
            this.sumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumText.Location = new System.Drawing.Point(103, 170);
            this.sumText.Name = "sumText";
            this.sumText.Size = new System.Drawing.Size(18, 20);
            this.sumText.TabIndex = 7;
            this.sumText.Text = "0";
            // 
            // add_to_bin
            // 
            this.add_to_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_to_bin.Location = new System.Drawing.Point(185, 165);
            this.add_to_bin.Name = "add_to_bin";
            this.add_to_bin.Size = new System.Drawing.Size(169, 30);
            this.add_to_bin.TabIndex = 8;
            this.add_to_bin.Text = "Добавить в корзину";
            this.add_to_bin.UseVisualStyleBackColor = true;
            this.add_to_bin.Click += new System.EventHandler(this.add_to_bin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Итого:";
            // 
            // sum_in_bin
            // 
            this.sum_in_bin.AutoSize = true;
            this.sum_in_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_in_bin.Location = new System.Drawing.Point(103, 228);
            this.sum_in_bin.Name = "sum_in_bin";
            this.sum_in_bin.Size = new System.Drawing.Size(18, 20);
            this.sum_in_bin.TabIndex = 10;
            this.sum_in_bin.Text = "0";
            // 
            // toXML
            // 
            this.toXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toXML.Location = new System.Drawing.Point(542, 72);
            this.toXML.Name = "toXML";
            this.toXML.Size = new System.Drawing.Size(91, 42);
            this.toXML.TabIndex = 11;
            this.toXML.Text = "Переучет";
            this.toXML.UseVisualStyleBackColor = true;
            this.toXML.Click += new System.EventHandler(this.toXML_Click);
            // 
            // fromXML
            // 
            this.fromXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromXML.Location = new System.Drawing.Point(542, 170);
            this.fromXML.Name = "fromXML";
            this.fromXML.Size = new System.Drawing.Size(172, 38);
            this.fromXML.TabIndex = 12;
            this.fromXML.Text = "Отчет о продажах";
            this.fromXML.UseVisualStyleBackColor = true;
            this.fromXML.Click += new System.EventHandler(this.fromXML_Click);
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pay.Location = new System.Drawing.Point(82, 270);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(169, 30);
            this.pay.TabIndex = 13;
            this.pay.Text = "Оплата";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(312, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "В кассе:";
            // 
            // cash_text
            // 
            this.cash_text.AutoSize = true;
            this.cash_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cash_text.Location = new System.Drawing.Point(407, 280);
            this.cash_text.Name = "cash_text";
            this.cash_text.Size = new System.Drawing.Size(18, 20);
            this.cash_text.TabIndex = 15;
            this.cash_text.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.cash_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.fromXML);
            this.Controls.Add(this.toXML);
            this.Controls.Add(this.sum_in_bin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_to_bin);
            this.Controls.Add(this.sumText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drop_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drop_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amount_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sumText;
        private System.Windows.Forms.Button add_to_bin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sum_in_bin;
        private System.Windows.Forms.Button toXML;
        private System.Windows.Forms.Button fromXML;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cash_text;
    }
}

