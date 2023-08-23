using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialTestTools
{
    public partial class Frm_AdcancedSet : Form
    {
        SerialPort serialPort = new SerialPort();
        public Frm_AdcancedSet(SerialPort sp)
        {
            InitializeComponent();
            this.serialPort = sp;
        }

        private void Frm_AdcancedSet_Load(object sender, EventArgs e)
        {
            //初始化数据
            comb_writeTimeOut.Text = (serialPort.WriteTimeout/1000).ToString() + " s";
            comb_readTimeOut.Text = (serialPort.ReadTimeout/1000).ToString() + " s";
            comb_writeBuffer.Text = serialPort.WriteBufferSize.ToString();
            comb_readBuffer.Text = serialPort.ReadBufferSize.ToString();
        }

        //按钮点击事件：设置端口 超时时间 和 缓存大小
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.serialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭端口后再进行设置", "警告");
                return;
            }
            try
            {
                var writeTimeout = comb_writeTimeOut.Text;
                var readTimeout = comb_readTimeOut.Text;

                this.serialPort.WriteTimeout = Convert.ToInt32(writeTimeout.Substring(0, writeTimeout.Length - 2)) * 1000;
                this.serialPort.ReadTimeout = Convert.ToInt32(readTimeout.Substring(0, readTimeout.Length - 2)) * 1000;

                this.serialPort.WriteBufferSize = Convert.ToInt32(comb_writeBuffer.Text);
                this.serialPort.ReadBufferSize = Convert.ToInt32(comb_readBuffer.Text);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }
    }
}
