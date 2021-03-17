
namespace OrderSystem
{
    partial class MealOption
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
            this.label_mealName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_singlePrice = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.button_addCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_mealName
            // 
            this.label_mealName.AutoSize = true;
            this.label_mealName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_mealName.Location = new System.Drawing.Point(30, 57);
            this.label_mealName.Name = "label_mealName";
            this.label_mealName.Size = new System.Drawing.Size(52, 16);
            this.label_mealName.TabIndex = 0;
            this.label_mealName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(272, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "價格: ";
            // 
            // label_singlePrice
            // 
            this.label_singlePrice.AutoSize = true;
            this.label_singlePrice.Font = new System.Drawing.Font("新細明體", 10F);
            this.label_singlePrice.Location = new System.Drawing.Point(331, 57);
            this.label_singlePrice.Name = "label_singlePrice";
            this.label_singlePrice.Size = new System.Drawing.Size(14, 14);
            this.label_singlePrice.TabIndex = 2;
            this.label_singlePrice.Text = "0";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(180, 55);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(58, 22);
            this.quantity.TabIndex = 3;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // button_addCart
            // 
            this.button_addCart.Location = new System.Drawing.Point(119, 119);
            this.button_addCart.Name = "button_addCart";
            this.button_addCart.Size = new System.Drawing.Size(157, 23);
            this.button_addCart.TabIndex = 4;
            this.button_addCart.Text = "加入購物車";
            this.button_addCart.UseVisualStyleBackColor = true;
            this.button_addCart.Click += new System.EventHandler(this.button_addCart_Click);
            // 
            // MealOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 170);
            this.Controls.Add(this.button_addCart);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label_singlePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mealName);
            this.Name = "MealOption";
            this.Text = "MealOption";
            this.Load += new System.EventHandler(this.MealOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mealName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_singlePrice;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button button_addCart;
    }
}