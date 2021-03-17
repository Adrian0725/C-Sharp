using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OrderSystem
{
    public partial class Form1 : Form
    {
        private Sql sql = new Sql();
        
        public Form1()
        {      
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            MenuListDataGrid.DataSource = sql.GetMenuList();
        }

        

        private void MenuListDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MealOption mealOption = new MealOption();
            mealOption.MealName = MenuListDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            mealOption.MealPrice = MenuListDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            mealOption.TableNum = textBox_TableNum.Text;
            mealOption.ShowDialog();

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_TableNum.Text == String.Empty)
                MessageBox.Show("請輸入桌號");
            else
            {
                MenuListDataGrid.Enabled = true;
                Button_CheckCart.Enabled = true;
            }
        }

        private void Button_CheckCart_Click(object sender, EventArgs e)
        {
            CartList cartList = new CartList();
            cartList.TableNum = textBox_TableNum.Text;
            cartList.ShowDialog();
        }
    }
}
