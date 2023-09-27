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
    public partial class SerialPortTest : Form
    {
        public SerialPortTest()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //关闭组件多线程安全设置。
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化端口列表源。
            RefreshSerialPorts();

            //设置校验位列表数据。
            foreach (Parity p in Enum.GetValues(typeof(Parity)))
            {
                comboBox_parity.Items.Add(p);
            }

            //设置停止位列表数据。
            foreach (StopBits s in Enum.GetValues(typeof(StopBits)))
            {
                comboBox_stopBits.Items.Add(s);
            }

            //设置界面串口参数数值。
            comboBox_baudRate.Text = "9600";    //默认波特率     9600。
            comboBox_dataBits.Text = "8";       //默认数据位     8。
            comboBox_parity.SelectedIndex = 0;  //默认奇偶校验位 Parity.None。
            comboBox_stopBits.SelectedIndex = 1;//默认停止位     StopBits.one。

            //初始化串口默认数据
            if (comboBox_serialName.Items.Count > 0)
            {
                defaultSerialPort.PortName = (String)comboBox_serialName.Items[0];
            }
            defaultSerialPort.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);   //波特率。
            defaultSerialPort.DataBits = Convert.ToInt32(comboBox_dataBits.Text);   //数据位。
            defaultSerialPort.Parity = (Parity)comboBox_parity.SelectedItem;        //奇偶校验位。
            defaultSerialPort.StopBits = (StopBits)comboBox_stopBits.SelectedItem;  //停止位。
            defaultSerialPort.ReadTimeout = 5000;                              //读取超时时长。
            defaultSerialPort.WriteTimeout = 5000;                             //写入超时时长。

            //工具描述
            text_toolTips.Text = "1.结束符：\r\n" +
                "  设置了结束符后，写入命令时会自动将结束符添加到命令末尾。\r\n" +
                "  结束符必须以ASCII形式输入，可以输入多个结束符，以逗号区分。例如：13,10 \r\n\r\n" +
                "2. 读取方式：\r\n" +
                "  设置读取到指定字符时，也是以ASCII形式输入，可以输入多个结束符，例如：13,10 \r\n\r\n" +
                "3.常用ASCII: \r\n" +
                "  换行\\r 对应ASCII: 13\r\n" +
                "  回车\\n 对应ASCII: 10\r\n\r\n" +
                "4. 程序地址: " +
                "https://github.com/Jlln1998/SerialPortDebugTool";

            //给串口对象注册接收事件。
            defaultSerialPort.DataReceived += new SerialDataReceivedEventHandler(PortDataReceive);

            //开启定时器
            serialPortCheckTimer.Start();
        }
        //按钮点击事件：扫描端口
        private void Btn_searchSerialPorts_Click(object sender, EventArgs e)
        {
            if (!defaultSerialPort.IsOpen)
            {
                RefreshSerialPorts();
            }
            else
            {
                MessageBox.Show("目前端口处于打开状态，请关闭后再操作！", "错误");
            }
            
        }

        /// <summary>
        /// 检测电脑所有可用端口，并且添加到端口列表中
        /// </summary>
        private void RefreshSerialPorts()
        {
            comboBox_serialName.Items.Clear();
            comboBox_serialName.Items.AddRange(SerialPort.GetPortNames());

            //如果存在可用端口，则默认选中列表中的第一个端口
            if (comboBox_serialName.Items.Count > 0)
            {
                comboBox_serialName.SelectedIndex = 0;
            }
        }

        // 按钮点击事件：开启端口
        private void Btn_openPort_Click(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口已是开启状态，无需重复开启！", "错误");
                return;
            }
            try
            {
                defaultSerialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("端口开启失败，异常原因：" + ex.Message, "错误");
                return;
            }
            label_serialPortStatus.Text = "开启中";
            label_serialPortStatus.ForeColor = Color.Green;
            EnableChangeSerialPortSet(false);
        }

        //按钮点击事件：关闭端口
        private void Btn_closePort_Click(object sender, EventArgs e)
        {
            if (!defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口已是关闭状态，无需重复关闭！", "错误");
                return;
            }
            try
            {
                defaultSerialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("端口关闭失败，异常原因：" + ex.Message, "错误");
                return;
            }
            label_serialPortStatus.Text = "已关闭";
            label_serialPortStatus.ForeColor = Color.Red;
            EnableChangeSerialPortSet(true);
        }

        //按钮点击事件：写入命令。
        private void Btn_send_Click(object sender, EventArgs e)
        {
            StartWriteCommand();
        }

        //命令框回车事件
        private void Text_sendData_KeyDown(object sender, KeyEventArgs e) { 
            if (e.KeyValue == 13) {
                StartWriteCommand(); 
            }
        }

        //写入命令
        private void StartWriteCommand()
        {
            //判断端口开启情况
            if (!defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口处于关闭状态，请打开端口！", "错误");
                return;
            }

            //获取要发送的命令数据
            string sendData = text_sendData.Text;
            if (String.IsNullOrEmpty(sendData.Trim()))
            {
                MessageBox.Show("发送数据为空，请输入要发送的数据！", "错误");
                return;
            }

            //给命令加上指定的结束符
            if (radio_endCharYes.Checked)
            {
                string endChar;
                try
                {
                    endChar = ParseAsciiString(text_endChar.Text);
                }
                catch
                {
                    MessageBox.Show("'发送数据 - 结束符'位置设置的指定字符格式不正确，请按指定规则输入 ！！！", "错误");
                    return;
                }
                sendData += endChar;
            }
            try
            {
                defaultSerialPort.Write(sendData);

            }
            catch (Exception ex)
            {
                AddMessageToTextBox(text_receiveData, ex.Message);
                MessageBox.Show("数据获取失败，异常原因：" + ex.Message);
            }

            AddMessageToTextBox(text_sendHistory, sendData.Replace("\r", "\\r").Replace("\n", "\\n"));
        }

        /// <summary>
        /// 串口自动接收事件。
        /// </summary>
        public void PortDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (radio_autoResYes.Checked)
                {
                    string res;
                    if (radio_receiveLine.Checked) //读取缓存区一行数据
                    {
                        res = defaultSerialPort.ReadLine();

                    }
                    else if (radio_receiveToChar.Checked) //读取缓存区到指定行的数据
                    {
                        string endChar;
                        try
                        {
                            endChar = ParseAsciiString(text_receiveTo.Text);
                        }
                        catch
                        {
                            MessageBox.Show("【读取方式】位置设置的指定字符格式不正确，请按指定规则输入 ！！！", "错误");
                            return;
                        }
                        try
                        {
                            res = defaultSerialPort.ReadTo(endChar);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "错误");
                            return;
                        }

                    }
                    else //读取缓存区全部数据
                    {
                        res = defaultSerialPort.ReadExisting();
                    }
                    //显示\r\n 这些不可见字符
                    if (radio_showHideYes.Checked)
                    {
                        AddMessageToTextBox(text_receiveData, res.Replace("\r", "\\r").Replace("\n", "\\n"));
                    }
                    else
                    {
                        AddMessageToTextBox(text_receiveData, res);
                    }
                }
            }
            catch(Exception ex) {
                AddMessageToTextBox(text_receiveData, ex.Message);
            }
        }

        //按钮点击事件：手动读取命令。
        private void Btn_receive_Click(object sender, EventArgs e)
        {
            if (!defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口处于关闭状态，请打开端口！", "错误");
                return;
            }
            try
            {
                string res = "";
                if (radio_receiveAll.Checked) //读取缓存区全部数据
                {
                    res = defaultSerialPort.ReadExisting();

                }
                else if (radio_receiveLine.Checked) //读取缓存区一行数据
                {
                    res = defaultSerialPort.ReadLine();

                }
                else if (radio_receiveToChar.Checked) //读取缓存区到指定行的数据
                {
                    string endChar = "";
                    try
                    {
                        endChar = ParseAsciiString(text_receiveTo.Text);
                    }
                    catch
                    {
                        MessageBox.Show("'读取方式'位置设置的指定字符格式不正确，请按指定规则输入 ！！！", "错误");
                        return;
                    }
                    res = defaultSerialPort.ReadTo(endChar);
                }

                //显示\r \n 这些不可见字符
                if (radio_showHideYes.Checked)
                {
                    AddMessageToTextBox(text_receiveData, res.Replace("\r", "\\r").Replace("\n", "\\n"));
                }
                else
                {
                    AddMessageToTextBox(text_receiveData, res);
                }  
            }
            catch (Exception ex)
            {
                AddMessageToTextBox(text_receiveData, ex.Message);
                MessageBox.Show("数据获取失败，异常原因：" + ex.Message);
            }
        }

        /// <summary>
        /// 解析以逗号分割的数字ASCII形式的字符串，将其转换成对应ASCII字符串。例如 13,10 ===> \r\n
        /// </summary>
        /// <param name="str">要解析的字符串</param>
        /// <returns>转换后的字符串</returns>
        private string ParseAsciiString(string str)
        {
            string[] arrStr = str.Split(',');
            string result = "";
            foreach (string s in arrStr)
            {
                result += Convert.ToChar(Convert.ToInt32(s)).ToString();
            }
            return result;
        }

        /// <summary>
        /// 向指定文本框新增输出信息。
        /// </summary>
        /// <param name="textBox">要操作的文本框对象</param>
        /// <param name="text">要添加的文本</param>
        private void AddMessageToTextBox(TextBox textBox,string text)
        {
            if(textBox.Name == "text_sendHistory")
            {
                if (radio_sendTimeYes.Checked)
                {
                    DateTime currentTime = DateTime.Now;
                    string format = "yyyy/MM/dd HH:mm:ss";
                    string dateStr = currentTime.ToString(format);
                    textBox.AppendText(dateStr + "：\r\n" + text + "\r\n");
                }
                else
                {
                    textBox.AppendText(text + "\r\n");
                }
            }else if(textBox.Name == "text_receiveData")
            {
                if (radio_receiveTimeYes.Checked)
                {
                    DateTime currentTime = DateTime.Now;
                    string format = "yyyy/MM/dd HH:mm:ss";
                    string dateStr = currentTime.ToString(format);
                    textBox.AppendText(dateStr + "：\r\n" + text + "\r\n");
                }
                else
                {
                    textBox.AppendText(text + "\r\n");
                }
            }
            
        }

        //清空发送数据
        private void Btn_clearSendHis_Click(object sender, EventArgs e)
        {
            text_sendHistory.Clear();
        }

        //清空接收历史数据
        private void Btn_clearReceiveHistory_Click(object sender, EventArgs e)
        {
            text_receiveData.Clear();
        }

        /// <summary>
        /// 修改端口属性设置控件是否可操作
        /// </summary>
        /// <param name="canControl">布尔值，true 代表允许操作控件</param>
        private void EnableChangeSerialPortSet(bool canControl)
        {
            if (canControl)
            {
                comboBox_serialName.Enabled = true;
                comboBox_baudRate.Enabled = true;
                comboBox_dataBits.Enabled = true;
                comboBox_parity.Enabled = true;
                comboBox_stopBits.Enabled = true;
                btn_advancedSet.Enabled = true;
                btn_searchSerialPorts.Enabled = true;
            }
            else
            {
                comboBox_serialName.Enabled = false;
                comboBox_baudRate.Enabled = false;
                comboBox_dataBits.Enabled = false;
                comboBox_parity.Enabled = false;
                comboBox_stopBits.Enabled = false;
                btn_advancedSet.Enabled = false;
                btn_searchSerialPorts.Enabled = false;
            }
        }

        //更换操作端口
        private void Comb_serialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置","警告") ;
                return;
            }
            defaultSerialPort.PortName = comboBox_serialName.Text;
        }
        //更新波特率
        private void Comb_baudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置", "警告");
                return;
            }
            defaultSerialPort.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
        }
        //更新数据位
        private void Comb_dataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置", "警告");
                return;
            }
            defaultSerialPort.DataBits = Convert.ToInt32(comboBox_dataBits.Text);
        }
        //更新校验位
        private void Comb_parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置", "警告");
                return;
            }
            defaultSerialPort.Parity = (Parity)comboBox_parity.SelectedItem;
        }
        //更新停止位
        private void Comb_stopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置", "警告");
                return;
            }
            defaultSerialPort.StopBits = (StopBits)comboBox_stopBits.SelectedItem;
        }
        //进阶设置
        private void Btn_advancedSet_Click(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen)
            {
                MessageBox.Show("端口目前处于开启状态，请关闭后再进行设置", "警告");
                return;
            }
            Form adSetFrm = new Frm_AdcancedSet(defaultSerialPort)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            adSetFrm.ShowDialog();
        }
        //发送数据—是否有结束符切换事件。
        private void Radio_endCharNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_endCharYes.Checked)
            {
                text_endChar.Enabled = true;
                text_endChar.BackColor = Color.White;
                text_endChar.Focus();
            }else
            {
                text_endChar.Clear();
                text_endChar.Enabled = false;
                text_endChar.BackColor = Color.WhiteSmoke;
            }
        }
        //接收数据—接收方式切换事件。
        private void Radio_receiveToChar_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_receiveToChar.Checked)
            {
                text_receiveTo.Enabled = true;
                text_receiveTo.BackColor = Color.White;
                text_receiveTo.Focus();
            }
            else
            {
                text_receiveTo.Clear();
                text_receiveTo.Enabled = false;
                text_receiveTo.BackColor = Color.WhiteSmoke;
            }
        }
        //定时器任务，每过1秒，检测端口状态
        private void SerialPortCheckTimer_Tick(object sender, EventArgs e)
        {
            if (defaultSerialPort.IsOpen && label_serialPortStatus.Text != "开启中")
            {
                label_serialPortStatus.Text = "开启中";
                label_serialPortStatus.ForeColor = Color.Green;
                EnableChangeSerialPortSet(false);
            }
            else if( !defaultSerialPort.IsOpen && label_serialPortStatus.Text != "已关闭")
            {
                label_serialPortStatus.Text = "已关闭";
                label_serialPortStatus.ForeColor = Color.Red;
                EnableChangeSerialPortSet(true);
            }
        }

        private void text_sendData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
