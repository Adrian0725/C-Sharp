
namespace OrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuListDataGrid = new System.Windows.Forms.DataGridView();
            this.Button_CheckCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TableNum = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuListDataGrid
            // 
            this.MenuListDataGrid.AllowUserToAddRows = false;
            this.MenuListDataGrid.AllowUserToDeleteRows = false;
            this.MenuListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MenuListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuListDataGrid.Enabled = false;
            this.MenuListDataGrid.Location = new System.Drawing.Point(12, 69);
            this.MenuListDataGrid.MultiSelect = false;
            this.MenuListDataGrid.Name = "MenuListDataGrid";
            this.MenuListDataGrid.ReadOnly = true;
            this.MenuListDataGrid.RowTemplate.Height = 24;
            this.MenuListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MenuListDataGrid.Size = new System.Drawing.Size(286, 276);
            this.MenuListDataGrid.TabIndex = 0;
            this.MenuListDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MenuListDataGrid_CellMouseClick);
            // 
            // Button_CheckCart
            // 
            this.Button_CheckCart.Enabled = false;
            this.Button_CheckCart.Font = new System.Drawing.Font("新細明體", 12F);
            this.Button_CheckCart.Location = new System.Drawing.Point(364, 156);
            this.Button_CheckCart.Name = "Button_CheckCart";
            this.Button_CheckCart.Size = new System.Drawing.Size(114, 39);
            this.Button_CheckCart.TabIndex = 1;
            this.Button_CheckCart.Text = "查看購物車";
            this.Button_CheckCart.UseVisualStyleBackColor = true;
            this.Button_CheckCart.Click += new System.EventHandler(this.Button_CheckCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "桌號:  ";
            // 
            // textBox_TableNum
            // 
            this.textBox_TableNum.Location = new System.Drawing.Point(130, 26);
            this.textBox_TableNum.Name = "textBox_TableNum";
            this.textBox_TableNum.Size = new System.Drawing.Size(61, 22);
            this.textBox_TableNum.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(223, 26);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "確定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 357);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_TableNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_CheckCart);
            this.Controls.Add(this.MenuListDataGrid);
            this.Name = "Form1";
            this.Text = "鼎泰豐小吃";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MenuListDataGrid;
        private System.Windows.Forms.Button Button_CheckCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TableNum;
        private System.Windows.Forms.Button button_OK;
    }
}

