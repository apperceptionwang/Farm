using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Farm
{
    public partial class Select_Player : Form
    {
        
        int P_no=0;
        bool pbx1_selectd=false;
        bool pbx2_selectd = false;
        bool pbx3_selectd = false;
        public Select_Player()
        {
            InitializeComponent();
        }

        #region timer事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            P_no = P_no % 3 + 1;
            if(P_no==1)
            {
                pictureBox1.Image = Properties.Resources.Player1;
            }
            if (P_no == 2)
            {
                pictureBox1.Image = Properties.Resources.Player2;
            }
            if (P_no == 3)
            {
                pictureBox1.Image = Properties.Resources.Player3;
            }
            
        }
        #endregion

        #region 人物选择
        private void btn_Choose_Click(object sender, EventArgs e)
        {
            PictureBox[] pbx_P = new PictureBox[3];
            pbx_P[0]=Pbx_P1;
            pbx_P[1]=Pbx_P2;
            pbx_P[2]=Pbx_P3;
            if(cbx_1.Checked)
            {
                Player.P_Image = Properties.Resources.Player1;
                this.timer1.Enabled = false;
                this.Visible = false;
                MyFarm mf_1 = new MyFarm();
                mf_1.Show();
            }
            if (cbx_2.Checked)
            {
                Player.P_Image = Properties.Resources.Player2;
                this.timer1.Enabled = false;
                this.Visible = false;
                MyFarm mf_2 = new MyFarm();
                mf_2.Show();
            }
            if (cbx_3.Checked)
            {
                Player.P_Image = Properties.Resources.Player3;
                this.timer1.Enabled = false;
                this.Visible = false;
                MyFarm mf_3 = new MyFarm();
                mf_3.Show();
            }
            
        }
        #endregion

        #region 单选框规范
        private void cbx_1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbx_1.Checked)
            {
                pbx1_selectd = true;
                cbx_2.Checked = false;
                cbx_3.Checked = false;

            }
            
            
            
        }

        private void cbx_2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbx_2.Checked)
            {
                pbx2_selectd = true;
                cbx_1.Checked = false;
                cbx_3.Checked = false;
            }
            
            
        }

        private void cbx_3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbx_3.Checked)
            {
                pbx3_selectd = true;
                cbx_1.Checked = false;
                cbx_2.Checked = false;
            }

        }
        #endregion

        #region 关闭程序
        private void Select_Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
