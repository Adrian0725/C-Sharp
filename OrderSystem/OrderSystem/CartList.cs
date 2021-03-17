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
    public partial class CartList : Form
    {
        private Sql sql = new Sql();
        private string tableNum;
        public string TableNum { get { return tableNum; } set { tableNum = value; } }

        private string deleteSequence;

        public CartList()
        {
            InitializeComponent();
        }

        private void CartList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dataGridView_Orderlist.DataSource = sql.GetOrderlist(tableNum);
            label_TotalPrice.Text = sql.CountingTotalPrice(tableNum);
            deleteSequence = dataGridView_Orderlist.Rows[0].Cells[1].Value.ToString();
        }


        private void button_DeleteAll_Click(object sender, EventArgs e)
        {
            sql.DeleteAll(tableNum);

            loadData();
        }

        private void button_DeleteOne_Click(object sender, EventArgs e)
        {
            sql.DeleteOne(deleteSequence);

            loadData();
        }

        private void dataGridView_Orderlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteSequence = dataGridView_Orderlist.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
