using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_HW01_3A713153
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var cryptoMD5 = System.Security.Cryptography.MD5.Create();
            byte[] source = Encoding.Default.GetBytes(tbinput.Text);//將字串轉為Byte[]
            byte[] crypto = cryptoMD5.ComputeHash(source);//進行MD5加密
            //string result = Convert.ToBase64String(source);
            var result = BitConverter.ToString(crypto).Replace("-", String.Empty).ToUpper();

            /*string result = Convert.ToBase64String(crypto);//把加密後的字串從Byte[]轉為字串
            rtboutput.Text("MD5加密:  " + result);//輸出結果*/



            //var str = tbinput.Text;
            //var md5 = str.ToMD5();
            rtboutput.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("改變命運吧!", "想讓生活過得輕鬆嘛?",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("上吧!孩子!", "相信號碼吧!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
