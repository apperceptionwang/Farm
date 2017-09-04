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
    public partial class S_Shop : Form
    {
        
        public S_Shop()
        {
            InitializeComponent();
        }

        #region 购买种子
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if(Money.money>int.Parse(tbx_All.Text))
            {
                Money.money -= int.Parse(tbx_All.Text);
            }
            else
            {
                MessageBox.Show("余额不足!");
                return;
            }
            Bag bag1 = new Bag();
            bag.Count_zll += int.Parse(tbx_zll.Text);
            bag.Count_Grape += int.Parse(tbx_Grape.Text);
            bag.Count_Lichi += int.Parse(tbx_Lichi.Text);
            bag.Count_Jingling += int.Parse(tbx_Jingling.Text);
            bag.Count_emo += int.Parse(tbx_emo.Text);
            bag1.lbl_zll.Text = bag.Count_zll.ToString();
            bag1.lbl_Grape.Text = bag.Count_Grape.ToString();
            bag1.lbl_Lichi.Text = bag.Count_Lichi.ToString();
            bag1.lbl_Jingling.Text = bag.Count_Jingling.ToString();
            bag1.lbl_emo.Text = bag.Count_emo.ToString();
            bag1.Show();
            MessageBox.Show("购买成功,请到背包查看物品!");
        }
        #endregion

        #region 植物滚动条
        private void tkb_zll_Scroll(object sender, EventArgs e)
        {
            tbx_zll.Text = (tkb_zll.Value).ToString();
        }

        private void tkb_Grape_Scroll(object sender, EventArgs e)
        {
            tbx_Grape.Text = (tkb_Grape.Value).ToString();
        }

        private void tkb_Lichi_Scroll(object sender, EventArgs e)
        {
            tbx_Lichi.Text = (tkb_Lichi.Value).ToString();
        }

        private void tkb_Jingling_Scroll(object sender, EventArgs e)
        {
            tbx_Jingling.Text = (tkb_Jingling.Value).ToString();
        }

        private void tkb_emo_Scroll(object sender, EventArgs e)
        {
            tbx_emo.Text = (tkb_emo.Value).ToString();
        }
        #endregion

        #region 取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 选取种子数量
        private void tbx_zll_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_zll.TextLength > 0)
                    tkb_zll.Value = Convert.ToInt32(tbx_zll.Text);

            }
            catch (FormatException e1)
            {
                MessageBox.Show("请输入你要买的种子数~");
                tbx_zll.Text = "0";
            }
            catch (ArgumentException e2)
            {
                tbx_zll.Text = "99";
            }
            try
            {
                if (tbx_zll.Text == "")
                {
                    throw new tbxnullException("文本不能为空!");
                }
                lbl_zll_2.Text = (int.Parse(tbx_zll.Text) * 18).ToString();
            }
            catch (tbxnullException ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbx_All.Text = (Convert.ToInt32(lbl_zll_2.Text)+Convert.ToInt32(lbl_Grape_2.Text) + Convert.ToInt32(lbl_Lichi_2.Text) + Convert.ToInt32(lbl_Jingling_2.Text) + Convert.ToInt32(lbl_emo_2.Text)).ToString();
        }

        private void tbx_Lichi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_Lichi.TextLength > 0)
                    tkb_Lichi.Value = Convert.ToInt32(tbx_Lichi.Text);

            }
            catch (FormatException e1)
            {
                MessageBox.Show("请输入你要买的种子数~");
                tbx_Lichi.Text = "0";
            }

            catch (ArgumentException e2)
            {
                tbx_Lichi.Text = "99";
            }
            try
            {
                if (tbx_Lichi.Text == "")
                {
                    throw new tbxnullException("文本不能为空!");
                }
                lbl_Lichi_2.Text = (int.Parse(tbx_Lichi.Text) * 30).ToString();
            }
            catch (tbxnullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbx_All.Text = (Convert.ToInt32(lbl_zll_2.Text) + Convert.ToInt32(lbl_Grape_2.Text) + Convert.ToInt32(lbl_Lichi_2.Text) + Convert.ToInt32(lbl_Jingling_2.Text) + Convert.ToInt32(lbl_emo_2.Text)).ToString();
        }

        private void tbx_Jingling_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_Jingling.TextLength > 0)
                    tkb_Jingling.Value = Convert.ToInt32(tbx_Jingling.Text);

            }
            catch (FormatException e1)
            {
                MessageBox.Show("请输入你要买的种子数~");
                tbx_Jingling.Text = "0";
            }

            catch (ArgumentException e2)
            {
                tbx_Jingling.Text = "99";
            }
            try
            {
                if (tbx_Jingling.Text == "")
                {
                    throw new tbxnullException("文本不能为空!");
                }
                lbl_Jingling_2.Text = (int.Parse(tbx_Jingling.Text) * 200).ToString();
            }
            catch (tbxnullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbx_All.Text = (Convert.ToInt32(lbl_zll_2.Text) + Convert.ToInt32(lbl_Grape_2.Text) + Convert.ToInt32(lbl_Lichi_2.Text) + Convert.ToInt32(lbl_Jingling_2.Text) + Convert.ToInt32(lbl_emo_2.Text)).ToString();
        }

        private void tbx_emo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_emo.TextLength > 0)
                    tkb_emo.Value = Convert.ToInt32(tbx_emo.Text);

            }
            catch (FormatException e1)
            {
                MessageBox.Show("请输入你要买的种子数~");
                tbx_emo.Text = "0";
            }

            catch (ArgumentException e2)
            {
                tbx_emo.Text = "99";
            }
            try
            {
                if (tbx_emo.Text == "")
                {
                    throw new tbxnullException("文本不能为空!");
                }
                lbl_emo_2.Text = (int.Parse(tbx_emo.Text) * 500).ToString();
            }
            catch (tbxnullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbx_All.Text = (Convert.ToInt32(lbl_zll_2.Text) + Convert.ToInt32(lbl_Grape_2.Text) + Convert.ToInt32(lbl_Lichi_2.Text) + Convert.ToInt32(lbl_Jingling_2.Text) + Convert.ToInt32(lbl_emo_2.Text)).ToString();
        }
        private void tbx_Grape_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_Grape.TextLength > 0)
                    tkb_Grape.Value = Convert.ToInt32(tbx_Grape.Text);

            }
            catch (FormatException e1)
            {
                MessageBox.Show("请输入你要买的种子数~");
                tbx_Grape.Text = "0";
            }
            catch (ArgumentException e2)
            {
                tbx_Grape.Text = "99";
            }
            try
            {
                if (tbx_Grape.Text == "")
                {
                    throw new tbxnullException("文本不能为空!");
                }
                lbl_Grape_2.Text = (int.Parse(tbx_Grape.Text) * 25).ToString();
            }
            catch(tbxnullException ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbx_All.Text = (Convert.ToInt32(lbl_zll_2.Text) + Convert.ToInt32(lbl_Grape_2.Text) + Convert.ToInt32(lbl_Lichi_2.Text) + Convert.ToInt32(lbl_Jingling_2.Text) + Convert.ToInt32(lbl_emo_2.Text)).ToString();
        }
        #endregion

        

        

    }


     //自定义异常类
    class tbxnullException : ApplicationException
    {
        #region 自定义异常类
        public tbxnullException(string message):base(message)
        {

        }
        #endregion
    }
}
