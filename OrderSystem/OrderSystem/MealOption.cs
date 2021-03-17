using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MealOption : Form
    {
        private Sql sql = new Sql();
        private int totalPrice;
        private string mealName;
        private string mealPrice;
        private string tableNum;
        public string MealName { set { mealName = value; } }
        public string MealPrice {  set { mealPrice = value; } }
        public string TableNum {  set { tableNum = value; } }

        public MealOption()
        {
            InitializeComponent();
        }

        private void MealOption_Load(object sender, EventArgs e)
        {
            label_mealName.Text = mealName;
            label_singlePrice.Text = mealPrice;
            totalPrice = int.Parse(mealPrice);
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            totalPrice = int.Parse(mealPrice) * Convert.ToInt32(quantity.Value);
            label_singlePrice.Text = totalPrice.ToString();
        }

        private void button_addCart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());//生成亂數
            int ramdonNum = rnd.Next(14537890, 94537890);

            sql.addCart(tableNum, ramdonNum, mealName, quantity.Value, totalPrice);

            this.Close();
        }
    }
}
