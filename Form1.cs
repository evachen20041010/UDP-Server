using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;   //匯入網路通訊協定相關參數
using System.Net.Sockets;   //匯入網路插座功能函數
using System.Threading; //匯入多執行緒功能函數

namespace UDP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread Th;  //網路監聽執行緒

        private void Form1_Load(object sender, EventArgs e)
        {
            Th = new Thread(Listen);    //建立監聽執行緒
            Th.IsBackground = true; //設定為背景執行緒
            Th.Start(); //開始監聽
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Th.Abort(); //關閉執行緒
        }
    }
}
