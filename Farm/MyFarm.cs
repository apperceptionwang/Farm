using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Farm.Class;
using Farm.ToolClass;

namespace Farm
{

    public partial class MyFarm : Form
    {
        int x;
        int y;
        int count=0;
        
        bool zc = false;
        PictureBox pbx = null;
        Store MyStore = new Store();
        DBfun dbFun = new DBfun();
        public MyFarm()
        {
            InitializeComponent();
        }

        #region 玩家操作
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string direction = Convert.ToString(e.KeyCode);
            if (!zc)
            {
                timer1.Enabled = true;
                switch (direction)
                {
                    case "Up":
                        y = -1;
                        break;
                    case "Down":
                        y = 1;
                        break;
                    case "Left":
                        x = -1;
                        break;
                    case "Right":
                        x = 1;
                        break;
                    case "B":
                        timer1.Enabled = false;
                        Login lgn = new Login();
                        lgn.Show();
                        break;
                }
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Enabled = false;
            x = 0;
            y = 0;
        }
        #endregion

        #region Timer1事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pb_Player.Left += x;
            pb_Player.Top += y;
            SowSeed(pb1);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count==1)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb1.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb2);   
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 2)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb2.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb3);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 3)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb3.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb4);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 4)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb4.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb5);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 5)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb5.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb6);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 6)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb6.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb7);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 7)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb7.Image = Seed.S_image;
                Seed.S_image = null;
            }
            SowSeed(pb8);
            Seed.S_image = MyStore.getImage();
            if (Seed.S_image != null && count == 8)
            {
                this.pb_Player.Location = new Point(548, 187);
                timer2.Enabled = true;
                pb8.Image = Seed.S_image;
                Seed.S_image = null;
            }
        }
        #endregion

        #region 暂停代码区
        private void btn_Choose_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
        }
        #endregion

        #region 界面加载
        private void MyFarm_Load(object sender, EventArgs e)
        {
            pb_Player.Image = Player.P_Image;
            btn_Choose.Enabled = false;

            Money_grade.Text = "100";
            MessageBox.Show("100快都不给你！");
            MessageBox.Show("才怪!");
            MessageBox.Show("帅气的开发者打赏给你100块！");
            
        }
        #endregion

        #region 种植函数
        public void SowSeed(PictureBox pbx)
        {
            if (pb_Player.Left == pbx.Left && pb_Player.Top == pbx.Top)
            {
                count = int.Parse(pbx.Name.Substring(2));
                timer1.Enabled = false;

                Sow MySow = new Sow();
                MySow.Show();
                MySow.Visible = false;
                
                if (MySow.ShowDialog(this) == DialogResult.OK)
                {
                    MyStore.Visible = true;
                    MyStore.Show();
                }
            }
        }
        #endregion

        #region 植物生产金钱
        public void MakeMoney(PictureBox pbx)
        {
            int S_Money=0;
            string s_ID=pbx.Name.Substring(2);
            string str_sql = "select * from Seed where Seed_ID='" + s_ID + "'";
            if (dbFun.connect(str_sql))
            {
                S_Money=dbFun.getData(str_sql);
            }
            else
            {
                MessageBox.Show("连接数据库失败!");
            }
            Money_grade.Text = (int.Parse(Money_grade.Text) + S_Money).ToString();
            Money.money = int.Parse(Money_grade.Text);
        }
        #endregion

        #region Timer2事件
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Match(pb1);
            Match(pb2);
            Match(pb3);
            Match(pb4);
            Match(pb5);
            Match(pb6);
            Match(pb7);
            Match(pb8);
           
            
        }
        #endregion

        #region 匹配
        public void Match(PictureBox pbx)//匹配
        {

            Money_grade.Text = Money.money.ToString();
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy1))
            {
                MakeMoney(MyStore.pb1);

            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy2))
            {
                MakeMoney(MyStore.pb2);

            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy3))
            {
                MakeMoney(MyStore.pb3);
            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy4))
            {
                MakeMoney(MyStore.pb4);
            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy5))
            {
                MakeMoney(MyStore.pb5);
            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy6))
            {
                MakeMoney(MyStore.pb6);

            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy7))
            {
                MakeMoney(MyStore.pb7);

            }
            if (pbx.Image != null && ImageEquals(pbx.Image, Properties.Resources.tzy8))
            {
                MakeMoney(MyStore.pb8);

            }
        }
        #endregion

        #region 比较2个Image是否相等
        public bool ImageEquals(Image  Image_1,Image Image_2)
        {
            MemoryStream ms1 = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            Image_1.Save(ms1,System.Drawing.Imaging.ImageFormat.Jpeg);
            Image_2.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] im1 = ms1.GetBuffer();
            byte[] im2 = ms2.GetBuffer();
            if (im1.Length != im2.Length)
                return false;
            else
            {
                for (int i = 0; i < im1.Length; i++)
                    if (im1[i] != im2[i])
                        return false;
            }
            return true;
        }
        #endregion

        #region 关闭程序
        private void MyFarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
