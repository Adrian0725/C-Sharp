
namespace OrderSystem
{
    partial class CartList
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
            this.dataGridView_Orderlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.button_PlacedOrder = new System.Windows.Forms.Button();
            this.button_DeleteAll = new System.Windows.Forms.Button();
            this.button_DeleteOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Orderlist
            // 
            this.dataGridView_Orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Orderlist.Location = new System.Drawing.Point(12, 32);
            this.dataGridView_Orderlist.Name = "dataGridView_Orderlist";
            this.dataGridView_Orderlist.RowTemplate.Height = 24;
            this.dataGridView_Orderlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Orderlist.Size = new System.Drawing.Size(501, 212);
            this.dataGridView_Orderlist.TabIndex = 0;
            this.dataGridView_Orderlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Orderlist_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(189, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "總價: ";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_TotalPrice.Location = new System.Drawing.Point(270, 276);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(32, 16);
            this.label_TotalPrice.TabIndex = 2;
            this.label_TotalPrice.Text = "000";
            // 
            // button_PlacedOrder
            // 
            this.button_PlacedOrder.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold);
            this.button_PlacedOrder.Location = new System.Drawing.Point(192, 427);
            this.button_PlacedOrder.Name = "button_PlacedOrder";
            this.button_PlacedOrder.Size = new System.Drawing.Size(126, 29);
            this.button_PlacedOrder.TabIndex = 3;
            this.button_PlacedOrder.Text = "確認訂單(X)";
            this.button_PlacedOrder.UseVisualStyleBackColor = true;
            // 
            // button_DeleteAll
            // 
            this.button_DeleteAll.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold);
            this.button_DeleteAll.Location = new System.Drawing.Point(192, 377);
            this.button_DeleteAll.Name = "button_DeleteAll";
            this.button_DeleteAll.Size = new System.Drawing.Size(126, 29);
            this.button_DeleteAll.TabIndex = 4;
            this.button_DeleteAll.Text = "清除全部";
            this.button_DeleteAll.UseVisualStyleBackColor = true;
            this.button_DeleteAll.Click += new System.EventHandler(this.button_DeleteAll_Click);
            // 
            // button_DeleteOne
            // 
            this.button_DeleteOne.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Bold);
            this.button_DeleteOne.Location = new System.Drawing.Point(192, 328);
            this.button_DeleteOne.Name = "button_DeleteOne";
            this.button_DeleteOne.Size = new System.Drawing.Size(126, 29);
            this.button_DeleteOne.TabIndex = 5;
            this.button_DeleteOne.Text = "清除單項";
            this.button_DeleteOne.UseVisualStyleBackColor = true;
            this.button_DeleteOne.Click += new System.EventHandler(this.button_DeleteOne_Click);
            // 
            // CartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 492);
            this.Controls.Add(this.button_DeleteOne);
            this.Controls.Add(this.button_DeleteAll);
            this.Controls.Add(this.button_PlacedOrder);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Orderlist);
            this.Name = "CartList";
            this.Text = "CartList";
            this.Load += new System.EventHandler(this.CartList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orderlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Orderlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Button button_PlacedOrder;
        private System.Windows.Forms.Button button_DeleteAll;
        private System.Windows.Forms.Button button_DeleteOne;
    }
}