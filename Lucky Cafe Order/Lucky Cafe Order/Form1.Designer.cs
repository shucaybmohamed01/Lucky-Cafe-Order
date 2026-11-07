namespace Lucky_Cafe_Order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentMemberCheckbox = new System.Windows.Forms.CheckBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.DrinkPrice = new System.Windows.Forms.GroupBox();
            this.CoffeRadioBtn = new System.Windows.Forms.RadioButton();
            this.JuiceRadioBtn = new System.Windows.Forms.RadioButton();
            this.TeaRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustomerNameTxt = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.object_bace02e1_8a12_4338_b234_5af6461b787d = new System.Windows.Forms.GroupBox();
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d = new System.Windows.Forms.GroupBox();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LuckyMessageLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DrinkPrice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentMemberCheckbox);
            this.groupBox1.Controls.Add(this.QuantityTxt);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.DrinkPrice);
            this.groupBox1.Controls.Add(this.CustomerNameTxt);
            this.groupBox1.Controls.Add(this.Customer_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(614, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // StudentMemberCheckbox
            // 
            this.StudentMemberCheckbox.AutoSize = true;
            this.StudentMemberCheckbox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentMemberCheckbox.Location = new System.Drawing.Point(280, 386);
            this.StudentMemberCheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StudentMemberCheckbox.Name = "StudentMemberCheckbox";
            this.StudentMemberCheckbox.Size = new System.Drawing.Size(296, 29);
            this.StudentMemberCheckbox.TabIndex = 5;
            this.StudentMemberCheckbox.Text = "Student Member (10% Off)";
            this.StudentMemberCheckbox.UseVisualStyleBackColor = true;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(166, 374);
            this.QuantityTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuantityTxt.Multiline = true;
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(98, 41);
            this.QuantityTxt.TabIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(35, 390);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(98, 25);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity:";
            // 
            // DrinkPrice
            // 
            this.DrinkPrice.Controls.Add(this.CoffeRadioBtn);
            this.DrinkPrice.Controls.Add(this.JuiceRadioBtn);
            this.DrinkPrice.Controls.Add(this.TeaRadioBtn);
            this.DrinkPrice.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkPrice.Location = new System.Drawing.Point(39, 197);
            this.DrinkPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrinkPrice.Name = "DrinkPrice";
            this.DrinkPrice.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrinkPrice.Size = new System.Drawing.Size(537, 161);
            this.DrinkPrice.TabIndex = 2;
            this.DrinkPrice.TabStop = false;
            this.DrinkPrice.Text = "Drink Type";
            // 
            // CoffeRadioBtn
            // 
            this.CoffeRadioBtn.AutoSize = true;
            this.CoffeRadioBtn.Location = new System.Drawing.Point(26, 83);
            this.CoffeRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CoffeRadioBtn.Name = "CoffeRadioBtn";
            this.CoffeRadioBtn.Size = new System.Drawing.Size(138, 29);
            this.CoffeRadioBtn.TabIndex = 0;
            this.CoffeRadioBtn.TabStop = true;
            this.CoffeRadioBtn.Text = "Coffe  ($2)";
            this.CoffeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // JuiceRadioBtn
            // 
            this.JuiceRadioBtn.AutoSize = true;
            this.JuiceRadioBtn.Location = new System.Drawing.Point(26, 123);
            this.JuiceRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JuiceRadioBtn.Name = "JuiceRadioBtn";
            this.JuiceRadioBtn.Size = new System.Drawing.Size(136, 29);
            this.JuiceRadioBtn.TabIndex = 0;
            this.JuiceRadioBtn.TabStop = true;
            this.JuiceRadioBtn.Text = "Juice  ($3)";
            this.JuiceRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TeaRadioBtn
            // 
            this.TeaRadioBtn.AutoSize = true;
            this.TeaRadioBtn.Location = new System.Drawing.Point(26, 42);
            this.TeaRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeaRadioBtn.Name = "TeaRadioBtn";
            this.TeaRadioBtn.Size = new System.Drawing.Size(123, 29);
            this.TeaRadioBtn.TabIndex = 0;
            this.TeaRadioBtn.TabStop = true;
            this.TeaRadioBtn.Text = "Tea  ($1)";
            this.TeaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Location = new System.Drawing.Point(39, 132);
            this.CustomerNameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerNameTxt.Multiline = true;
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(537, 47);
            this.CustomerNameTxt.TabIndex = 1;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Name.Location = new System.Drawing.Point(35, 93);
            this.Customer_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(169, 25);
            this.Customer_Name.TabIndex = 0;
            this.Customer_Name.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // object_bace02e1_8a12_4338_b234_5af6461b787d
            // 
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Location = new System.Drawing.Point(30, 188);
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Name = "object_bace02e1_8a12_4338_b234_5af6461b787d";
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.Size = new System.Drawing.Size(499, 178);
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.TabIndex = 2;
            this.object_bace02e1_8a12_4338_b234_5af6461b787d.TabStop = false;
            // 
            // object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d
            // 
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Location = new System.Drawing.Point(30, 188);
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Name = "object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d";
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.Size = new System.Drawing.Size(499, 178);
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.TabIndex = 2;
            this.object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d.TabStop = false;
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.SystemColors.Menu;
            this.OrderList.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList.ForeColor = System.Drawing.Color.Black;
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 19;
            this.OrderList.Location = new System.Drawing.Point(666, 78);
            this.OrderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(499, 346);
            this.OrderList.TabIndex = 1;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(25, 483);
            this.CalculateBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(224, 62);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "Calculate Order";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(305, 483);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(224, 62);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save to File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(625, 483);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(225, 62);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load from File";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(941, 483);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(224, 62);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // LuckyMessageLbl
            // 
            this.LuckyMessageLbl.AutoSize = true;
            this.LuckyMessageLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyMessageLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.LuckyMessageLbl.Location = new System.Drawing.Point(19, 73);
            this.LuckyMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LuckyMessageLbl.Name = "LuckyMessageLbl";
            this.LuckyMessageLbl.Size = new System.Drawing.Size(182, 29);
            this.LuckyMessageLbl.TabIndex = 5;
            this.LuckyMessageLbl.Text = "Lucky Message:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.ForeColor = System.Drawing.Color.Navy;
            this.TotalPriceLbl.Location = new System.Drawing.Point(20, 32);
            this.TotalPriceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(133, 29);
            this.TotalPriceLbl.TabIndex = 6;
            this.TotalPriceLbl.Text = "Total Price:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.LuckyMessageLbl);
            this.groupBox2.Controls.Add(this.TotalPriceLbl);
            this.groupBox2.Location = new System.Drawing.Point(25, 551);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1140, 114);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label.Location = new System.Drawing.Point(21, 5);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(184, 24);
            this.Label.TabIndex = 8;
            this.Label.Text = "Lucky Cafe Order";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(666, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DrinkPrice.ResumeLayout(false);
            this.DrinkPrice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DrinkPrice;
        private System.Windows.Forms.RadioButton CoffeRadioBtn;
        private System.Windows.Forms.RadioButton JuiceRadioBtn;
        private System.Windows.Forms.RadioButton TeaRadioBtn;
        private System.Windows.Forms.TextBox CustomerNameTxt;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.CheckBox StudentMemberCheckbox;
        private System.Windows.Forms.GroupBox object_bace02e1_8a12_4338_b234_5af6461b787d;
        private System.Windows.Forms.GroupBox object_792fa44f_a8c3_484c_a4ef_e02936a2cf5d;
        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label LuckyMessageLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
    }
}

