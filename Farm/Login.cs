using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Farm.Class;

namespace Farm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region 打开背包
        private void btn_Bag_Click(object sender, EventArgs e)
        {
            Bag bag1 = new Bag();
            bag1.lbl_zll.Text = bag.Count_zll.ToString();
            bag1.lbl_Grape.Text = bag.Count_Grape.ToString();
            bag1.lbl_Lichi.Text = bag.Count_Lichi.ToString();
            bag1.lbl_Jingling.Text = bag.Count_Jingling.ToString();
            bag1.lbl_emo.Text = bag.Count_emo.ToString();
            bag1.Show();
        }
        #endregion

        #region 打开商店
        private void btn_Store_Click(object sender, EventArgs e)
        {
            S_Shop s_shop = new S_Shop();
            s_shop.Show();
        }
        #endregion

        #region 关闭窗口
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
