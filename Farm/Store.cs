using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Farm.Class;
using System.IO;

namespace Farm
{
    public partial class Store : Form
    {
        
        public Store()
        {
            InitializeComponent();
        }

        #region 确认播种种子
        private void btn_OK_Click(object sender, EventArgs e)
        {
           
            if (cbx1.Checked)
            {
                Seed.S_image = pb1.Image;
                Seed.S_ID = "1";
                bag.Count_zll--;
                cbx1.Checked = false;
                //MyFarm myfarm = new MyFarm();
                //myfarm.SowSeed(myfarm.pb1);
            }
            if (cbx2.Checked)
            {
                Seed.S_ID = "2";
                Seed.S_image = pb2.Image;
                bag.Count_Grape--;
                cbx2.Checked = false;
            }
            if (cbx3.Checked)
            {
                Seed.S_ID = "3";
                Seed.S_image = pb3.Image;
                bag.Count_Lichi--;
                cbx3.Checked = false;
            }
            if (cbx4.Checked)
            {
                Seed.S_ID = "4";
                Seed.S_image = pb4.Image;
                bag.Count_Jingling--;
                cbx4.Checked = false;
            }
            if (cbx5.Checked)
            {
                Seed.S_ID = "5";
                Seed.S_image = pb5.Image;
                bag.Count_emo--;
                cbx5.Checked = false;
            }
            if (cbx6.Checked)
            {
                Seed.S_ID = "6";
                Seed.S_image = pb6.Image;
            }
            if (cbx7.Checked)
            {
                Seed.S_ID = "7";
                Seed.S_image = pb7.Image;
            }
            if (cbx8.Checked)
            {
                Seed.S_ID = "8";
                Seed.S_image = pb8.Image;
            }
            this.Visible = false;
        }
        #endregion

        public void setImage(Image image)
        {
            
        }

        #region 得到种子图片
        public Image getImage()
        {
            return Seed.S_image;
        }
        #endregion

        #region 单选框规范
        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx1.Checked)
            {
                cbx2.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx2.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx3.Checked)
            {
                cbx1.Checked = false;
                cbx2.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx4.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx2.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx5.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx2.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx6.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx2.Checked = false;
                cbx7.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx7.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx2.Checked = false;
                cbx8.Checked = false;
            }
        }

        private void cbx8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx8.Checked)
            {
                cbx1.Checked = false;
                cbx3.Checked = false;
                cbx4.Checked = false;
                cbx5.Checked = false;
                cbx6.Checked = false;
                cbx7.Checked = false;
                cbx2.Checked = false;
            }
        }
        #endregion

        #region 界面加载
        private void Store_Load(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources.tzy1;
            pb2.Image = Properties.Resources.tzy2;
            pb3.Image = Properties.Resources.tzy3;
            pb4.Image = Properties.Resources.tzy4;
            pb5.Image = Properties.Resources.tzy5;
            pb6.Image = Properties.Resources.tzy6;
            pb7.Image = Properties.Resources.tzy7;
            pb8.Image = Properties.Resources.tzy8;
            
        }
        #endregion

        #region Timer事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_zll.Text = bag.Count_zll.ToString();
            lbl_Grape.Text = bag.Count_Grape.ToString();
            lbl_Lichi.Text = bag.Count_Lichi.ToString();
            lbl_Jingling.Text = bag.Count_Jingling.ToString();
            lbl_emo.Text = bag.Count_emo.ToString();
            if (int.Parse(lbl_zll.Text) == 0)
            {
                cbx1.Enabled = false;
            }
            else
            {
                cbx1.Enabled = true; ;
            }
            if (int.Parse(lbl_Grape.Text) == 0)
            {
                cbx2.Enabled = false;
            }
            else
            {
                cbx2.Enabled = true; ;
            }
            if (int.Parse(lbl_Lichi.Text) == 0)
            {
                cbx3.Enabled = false;
            }
            else
            {
                cbx3.Enabled = true; ;
            }
            if (int.Parse(lbl_Jingling.Text) == 0)
            {
                cbx4.Enabled = false;
            }
            else
            {
                cbx4.Enabled = true; ;
            }
            if (int.Parse(lbl_emo.Text) == 0)
            {
                cbx5.Enabled = false;
            }
            else
            {
                cbx5.Enabled = true; ;
            }
        }
        #endregion

        #region 取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #endregion

        #region 关闭窗口
        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
        #endregion


    }
}
