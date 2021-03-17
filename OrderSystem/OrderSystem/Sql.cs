using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace OrderSystem
{
    class Sql
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-MGA6RF7;Initial Catalog=Menu;Integrated Security=True");
        public DataTable GetMenuList()
        {
            DataTable dtMenu = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from MenuList", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dtMenu.Load(reader);

            con.Close();

            return dtMenu;
        }

        public void addCart(string tableNum, int ramdonNum, string mealName, decimal quantity, int totalPrice)
        {
            SqlCommand cmd = new SqlCommand("insert into OrderTable values(@TableNum, @SequenceNum, @MealName, @Quantity, @SinglePrice)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@TableNum", tableNum);
            cmd.Parameters.AddWithValue("@SequenceNum", ramdonNum); 
            cmd.Parameters.AddWithValue("@MealName", mealName);
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantity));
            cmd.Parameters.AddWithValue("@SinglePrice", totalPrice);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string CountingTotalPrice(string tableNum)
        {
            string totalPrice = "";
            SqlCommand cmd = new SqlCommand("select sum(SinglePrice) as '總價' from OrderTable where TableNum = @TableNum", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@TableNum", tableNum);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["總價"].ToString() == "")
                    totalPrice = "0";
                else
                    totalPrice = reader["總價"].ToString();
            }

            con.Close();

            return totalPrice;
        }

        public DataTable GetOrderlist(string tableNum)
        {
            DataTable dtOrder = new DataTable();

            SqlCommand cmd = new SqlCommand("select * from OrderTable where TableNum = @TableNum", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@TableNum", tableNum);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtOrder.Load(reader);
            con.Close();

            return dtOrder;
        }

        public void DeleteAll(string tableNum)
        {
            SqlCommand cmd = new SqlCommand("delete from OrderTable where TableNum = @TableNum", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@TableNum", tableNum);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteOne(string deleteSequence)
        {
            SqlCommand cmd = new SqlCommand("delete from OrderTable where SequenceNum = @SequenceNum", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SequenceNum", deleteSequence);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
