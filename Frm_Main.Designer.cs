
namespace SerialTestTools
{
    partial class SerialPortTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.group_serialDataSet = new System.Windows.Forms.GroupBox();
            this.btn_advancedSet = new System.Windows.Forms.Button();
            this.btn_searchSerialPorts = new System.Windows.Forms.Button();
            this.comboBox_stopBits = new System.Windows.Forms.ComboBox();
            this.label_stopBits = new System.Windows.Forms.Label();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.label_parity = new System.Windows.Forms.Label();
            this.comboBox_dataBits = new System.Windows.Forms.ComboBox();
            this.label_dataBits = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label_baudRate = new System.Windows.Forms.Label();
            this.comboBox_serialName = new System.Windows.Forms.ComboBox();
            this.label_serialName = new System.Windows.Forms.Label();
            this.text_receiveData = new System.Windows.Forms.TextBox();
            this.group_receiveSet = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radio_receiveTimeNo = new System.Windows.Forms.RadioButton();
            this.radio_receiveTimeYes = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radio_showHideNo = new System.Windows.Forms.RadioButton();
            this.radio_showHideYes = new System.Windows.Forms.RadioButton();
            this.lbl_receiveTimeTips = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_receiveTo = new System.Windows.Forms.TextBox();
            this.radio_receiveToChar = new System.Windows.Forms.RadioButton();
            this.radio_receiveLine = new System.Windows.Forms.RadioButton();
            this.radio_receiveAll = new System.Windows.Forms.RadioButton();
            this.label_receiveStyle = new System.Windows.Forms.Label();
            this.btn_clearReceiveHistory = new System.Windows.Forms.Button();
            this.btn_receive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panl_autoRecive = new System.Windows.Forms.Panel();
            this.radio_autoResNo = new System.Windows.Forms.RadioButton();
            this.radio_autoResYes = new System.Windows.Forms.RadioButton();
            this.label_autoReciveTips = new System.Windows.Forms.Label();
            this.group_portControl = new System.Windows.Forms.GroupBox();
            this.label_serialPortStatus = new System.Windows.Forms.Label();
            this.btn_closePort = new System.Windows.Forms.Button();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.label_serialStatusTips = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.text_sendData = new System.Windows.Forms.TextBox();
            this.group_sendSet = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radio_sendTimeNo = new System.Windows.Forms.RadioButton();
            this.radio_sendTimeYes = new System.Windows.Forms.RadioButton();
            this.label_recordTimeTips = new System.Windows.Forms.Label();
            this.btn_clearSendHis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_endCharYes = new System.Windows.Forms.RadioButton();
            this.radio_endCharNo = new System.Windows.Forms.RadioButton();
            this.text_endChar = new System.Windows.Forms.TextBox();
            this.label_endCharTips = new System.Windows.Forms.Label();
            this.label_sendDataTips = new System.Windows.Forms.Label();
            this.defaultSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.text_sendHistory = new System.Windows.Forms.TextBox();
            this.group_sendHistory = new System.Windows.Forms.GroupBox();
            this.group_toolTips = new System.Windows.Forms.GroupBox();
            this.text_toolTips = new System.Windows.Forms.TextBox();
            this.serialPortCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.group_serialDataSet.SuspendLayout();
            this.group_receiveSet.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panl_autoRecive.SuspendLayout();
            this.group_portControl.SuspendLayout();
            this.group_sendSet.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.group_sendHistory.SuspendLayout();
            this.group_toolTips.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_serialDataSet
            // 
            this.group_serialDataSet.Controls.Add(this.btn_advancedSet);
            this.group_serialDataSet.Controls.Add(this.btn_searchSerialPorts);
            this.group_serialDataSet.Controls.Add(this.comboBox_stopBits);
            this.group_serialDataSet.Controls.Add(this.label_stopBits);
            this.group_serialDataSet.Controls.Add(this.comboBox_parity);
            this.group_serialDataSet.Controls.Add(this.label_parity);
            this.group_serialDataSet.Controls.Add(this.comboBox_dataBits);
            this.group_serialDataSet.Controls.Add(this.label_dataBits);
            this.group_serialDataSet.Controls.Add(this.comboBox_baudRate);
            this.group_serialDataSet.Controls.Add(this.label_baudRate);
            this.group_serialDataSet.Controls.Add(this.comboBox_serialName);
            this.group_serialDataSet.Controls.Add(this.label_serialName);
            this.group_serialDataSet.Location = new System.Drawing.Point(29, 32);
            this.group_serialDataSet.Margin = new System.Windows.Forms.Padding(5);
            this.group_serialDataSet.Name = "group_serialDataSet";
            this.group_serialDataSet.Padding = new System.Windows.Forms.Padding(5);
            this.group_serialDataSet.Size = new System.Drawing.Size(332, 391);
            this.group_serialDataSet.TabIndex = 0;
            this.group_serialDataSet.TabStop = false;
            this.group_serialDataSet.Text = "端口设置";
            // 
            // btn_advancedSet
            // 
            this.btn_advancedSet.Location = new System.Drawing.Point(29, 326);
            this.btn_advancedSet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_advancedSet.Name = "btn_advancedSet";
            this.btn_advancedSet.Size = new System.Drawing.Size(131, 43);
            this.btn_advancedSet.TabIndex = 0;
            this.btn_advancedSet.TabStop = false;
            this.btn_advancedSet.Text = "更多设置";
            this.btn_advancedSet.UseVisualStyleBackColor = true;
            this.btn_advancedSet.Click += new System.EventHandler(this.Btn_advancedSet_Click);
            // 
            // btn_searchSerialPorts
            // 
            this.btn_searchSerialPorts.Location = new System.Drawing.Point(183, 326);
            this.btn_searchSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchSerialPorts.Name = "btn_searchSerialPorts";
            this.btn_searchSerialPorts.Size = new System.Drawing.Size(131, 43);
            this.btn_searchSerialPorts.TabIndex = 0;
            this.btn_searchSerialPorts.TabStop = false;
            this.btn_searchSerialPorts.Text = "扫描端口";
            this.btn_searchSerialPorts.UseVisualStyleBackColor = true;
            this.btn_searchSerialPorts.Click += new System.EventHandler(this.Btn_searchSerialPorts_Click);
            // 
            // comboBox_stopBits
            // 
            this.comboBox_stopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stopBits.FormattingEnabled = true;
            this.comboBox_stopBits.Location = new System.Drawing.Point(139, 263);
            this.comboBox_stopBits.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_stopBits.Name = "comboBox_stopBits";
            this.comboBox_stopBits.Size = new System.Drawing.Size(155, 32);
            this.comboBox_stopBits.TabIndex = 0;
            this.comboBox_stopBits.TabStop = false;
            this.comboBox_stopBits.SelectedIndexChanged += new System.EventHandler(this.Comb_stopBits_SelectedIndexChanged);
            // 
            // label_stopBits
            // 
            this.label_stopBits.AutoSize = true;
            this.label_stopBits.Location = new System.Drawing.Point(34, 268);
            this.label_stopBits.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_stopBits.Name = "label_stopBits";
            this.label_stopBits.Size = new System.Drawing.Size(82, 24);
            this.label_stopBits.TabIndex = 8;
            this.label_stopBits.Text = "停止位";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Location = new System.Drawing.Point(139, 211);
            this.comboBox_parity.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(155, 32);
            this.comboBox_parity.TabIndex = 0;
            this.comboBox_parity.TabStop = false;
            this.comboBox_parity.SelectedIndexChanged += new System.EventHandler(this.Comb_parity_SelectedIndexChanged);
            // 
            // label_parity
            // 
            this.label_parity.AutoSize = true;
            this.label_parity.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_parity.Location = new System.Drawing.Point(34, 216);
            this.label_parity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_parity.Name = "label_parity";
            this.label_parity.Size = new System.Drawing.Size(82, 24);
            this.label_parity.TabIndex = 6;
            this.label_parity.Text = "校验位";
            // 
            // comboBox_dataBits
            // 
            this.comboBox_dataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataBits.FormattingEnabled = true;
            this.comboBox_dataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_dataBits.Location = new System.Drawing.Point(139, 159);
            this.comboBox_dataBits.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_dataBits.Name = "comboBox_dataBits";
            this.comboBox_dataBits.Size = new System.Drawing.Size(155, 32);
            this.comboBox_dataBits.TabIndex = 0;
            this.comboBox_dataBits.TabStop = false;
            this.comboBox_dataBits.SelectedIndexChanged += new System.EventHandler(this.Comb_dataBits_SelectedIndexChanged);
            // 
            // label_dataBits
            // 
            this.label_dataBits.AutoSize = true;
            this.label_dataBits.Location = new System.Drawing.Point(34, 164);
            this.label_dataBits.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_dataBits.Name = "label_dataBits";
            this.label_dataBits.Size = new System.Drawing.Size(82, 24);
            this.label_dataBits.TabIndex = 4;
            this.label_dataBits.Text = "数据位";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(139, 107);
            this.comboBox_baudRate.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(155, 32);
            this.comboBox_baudRate.TabIndex = 0;
            this.comboBox_baudRate.TabStop = false;
            this.comboBox_baudRate.SelectedIndexChanged += new System.EventHandler(this.Comb_baudRate_SelectedIndexChanged);
            // 
            // label_baudRate
            // 
            this.label_baudRate.AutoSize = true;
            this.label_baudRate.Location = new System.Drawing.Point(34, 112);
            this.label_baudRate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_baudRate.Name = "label_baudRate";
            this.label_baudRate.Size = new System.Drawing.Size(82, 24);
            this.label_baudRate.TabIndex = 2;
            this.label_baudRate.Text = "波特率";
            // 
            // comboBox_serialName
            // 
            this.comboBox_serialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_serialName.FormattingEnabled = true;
            this.comboBox_serialName.Location = new System.Drawing.Point(139, 55);
            this.comboBox_serialName.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_serialName.Name = "comboBox_serialName";
            this.comboBox_serialName.Size = new System.Drawing.Size(155, 32);
            this.comboBox_serialName.TabIndex = 0;
            this.comboBox_serialName.TabStop = false;
            this.comboBox_serialName.SelectedIndexChanged += new System.EventHandler(this.Comb_serialName_SelectedIndexChanged);
            // 
            // label_serialName
            // 
            this.label_serialName.AutoSize = true;
            this.label_serialName.Location = new System.Drawing.Point(34, 60);
            this.label_serialName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_serialName.Name = "label_serialName";
            this.label_serialName.Size = new System.Drawing.Size(82, 24);
            this.label_serialName.TabIndex = 0;
            this.label_serialName.Text = "端口号";
            // 
            // text_receiveData
            // 
            this.text_receiveData.Location = new System.Drawing.Point(22, 176);
            this.text_receiveData.Margin = new System.Windows.Forms.Padding(4);
            this.text_receiveData.Multiline = true;
            this.text_receiveData.Name = "text_receiveData";
            this.text_receiveData.ReadOnly = true;
            this.text_receiveData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_receiveData.Size = new System.Drawing.Size(971, 400);
            this.text_receiveData.TabIndex = 0;
            this.text_receiveData.TabStop = false;
            this.text_receiveData.WordWrap = false;
            // 
            // group_receiveSet
            // 
            this.group_receiveSet.Controls.Add(this.panel4);
            this.group_receiveSet.Controls.Add(this.panel5);
            this.group_receiveSet.Controls.Add(this.lbl_receiveTimeTips);
            this.group_receiveSet.Controls.Add(this.panel2);
            this.group_receiveSet.Controls.Add(this.label_receiveStyle);
            this.group_receiveSet.Controls.Add(this.btn_clearReceiveHistory);
            this.group_receiveSet.Controls.Add(this.btn_receive);
            this.group_receiveSet.Controls.Add(this.text_receiveData);
            this.group_receiveSet.Controls.Add(this.label1);
            this.group_receiveSet.Location = new System.Drawing.Point(29, 432);
            this.group_receiveSet.Margin = new System.Windows.Forms.Padding(4);
            this.group_receiveSet.Name = "group_receiveSet";
            this.group_receiveSet.Padding = new System.Windows.Forms.Padding(4);
            this.group_receiveSet.Size = new System.Drawing.Size(1204, 584);
            this.group_receiveSet.TabIndex = 0;
            this.group_receiveSet.TabStop = false;
            this.group_receiveSet.Text = "接收数据";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radio_receiveTimeNo);
            this.panel4.Controls.Add(this.radio_receiveTimeYes);
            this.panel4.Location = new System.Drawing.Point(493, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 40);
            this.panel4.TabIndex = 28;
            // 
            // radio_receiveTimeNo
            // 
            this.radio_receiveTimeNo.AutoSize = true;
            this.radio_receiveTimeNo.Location = new System.Drawing.Point(85, 5);
            this.radio_receiveTimeNo.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receiveTimeNo.Name = "radio_receiveTimeNo";
            this.radio_receiveTimeNo.Size = new System.Drawing.Size(65, 28);
            this.radio_receiveTimeNo.TabIndex = 0;
            this.radio_receiveTimeNo.Text = "否";
            this.radio_receiveTimeNo.UseVisualStyleBackColor = true;
            // 
            // radio_receiveTimeYes
            // 
            this.radio_receiveTimeYes.AutoSize = true;
            this.radio_receiveTimeYes.Checked = true;
            this.radio_receiveTimeYes.Location = new System.Drawing.Point(15, 5);
            this.radio_receiveTimeYes.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receiveTimeYes.Name = "radio_receiveTimeYes";
            this.radio_receiveTimeYes.Size = new System.Drawing.Size(65, 28);
            this.radio_receiveTimeYes.TabIndex = 0;
            this.radio_receiveTimeYes.TabStop = true;
            this.radio_receiveTimeYes.Text = "是";
            this.radio_receiveTimeYes.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radio_showHideNo);
            this.panel5.Controls.Add(this.radio_showHideYes);
            this.panel5.Location = new System.Drawing.Point(140, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 45);
            this.panel5.TabIndex = 30;
            // 
            // radio_showHideNo
            // 
            this.radio_showHideNo.AutoSize = true;
            this.radio_showHideNo.Location = new System.Drawing.Point(99, 10);
            this.radio_showHideNo.Margin = new System.Windows.Forms.Padding(4);
            this.radio_showHideNo.Name = "radio_showHideNo";
            this.radio_showHideNo.Size = new System.Drawing.Size(65, 28);
            this.radio_showHideNo.TabIndex = 0;
            this.radio_showHideNo.Text = "否";
            this.radio_showHideNo.UseVisualStyleBackColor = true;
            // 
            // radio_showHideYes
            // 
            this.radio_showHideYes.AutoSize = true;
            this.radio_showHideYes.Checked = true;
            this.radio_showHideYes.Location = new System.Drawing.Point(13, 10);
            this.radio_showHideYes.Margin = new System.Windows.Forms.Padding(4);
            this.radio_showHideYes.Name = "radio_showHideYes";
            this.radio_showHideYes.Size = new System.Drawing.Size(65, 28);
            this.radio_showHideYes.TabIndex = 0;
            this.radio_showHideYes.TabStop = true;
            this.radio_showHideYes.Text = "是";
            this.radio_showHideYes.UseVisualStyleBackColor = true;
            // 
            // lbl_receiveTimeTips
            // 
            this.lbl_receiveTimeTips.AutoSize = true;
            this.lbl_receiveTimeTips.Location = new System.Drawing.Point(373, 125);
            this.lbl_receiveTimeTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_receiveTimeTips.Name = "lbl_receiveTimeTips";
            this.lbl_receiveTimeTips.Size = new System.Drawing.Size(130, 24);
            this.lbl_receiveTimeTips.TabIndex = 27;
            this.lbl_receiveTimeTips.Text = "记录时间：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_receiveTo);
            this.panel2.Controls.Add(this.radio_receiveToChar);
            this.panel2.Controls.Add(this.radio_receiveLine);
            this.panel2.Controls.Add(this.radio_receiveAll);
            this.panel2.Location = new System.Drawing.Point(140, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 60);
            this.panel2.TabIndex = 28;
            // 
            // text_receiveTo
            // 
            this.text_receiveTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_receiveTo.Enabled = false;
            this.text_receiveTo.Location = new System.Drawing.Point(618, 9);
            this.text_receiveTo.Margin = new System.Windows.Forms.Padding(4);
            this.text_receiveTo.Multiline = true;
            this.text_receiveTo.Name = "text_receiveTo";
            this.text_receiveTo.Size = new System.Drawing.Size(235, 40);
            this.text_receiveTo.TabIndex = 3;
            this.text_receiveTo.WordWrap = false;
            // 
            // radio_receiveToChar
            // 
            this.radio_receiveToChar.AutoSize = true;
            this.radio_receiveToChar.Location = new System.Drawing.Point(317, 15);
            this.radio_receiveToChar.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receiveToChar.Name = "radio_receiveToChar";
            this.radio_receiveToChar.Size = new System.Drawing.Size(293, 28);
            this.radio_receiveToChar.TabIndex = 0;
            this.radio_receiveToChar.Text = "读取到指定字符(ASCII)";
            this.radio_receiveToChar.UseVisualStyleBackColor = true;
            this.radio_receiveToChar.CheckedChanged += new System.EventHandler(this.Radio_receiveToChar_CheckedChanged);
            // 
            // radio_receiveLine
            // 
            this.radio_receiveLine.AutoSize = true;
            this.radio_receiveLine.Location = new System.Drawing.Point(172, 15);
            this.radio_receiveLine.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receiveLine.Name = "radio_receiveLine";
            this.radio_receiveLine.Size = new System.Drawing.Size(137, 28);
            this.radio_receiveLine.TabIndex = 0;
            this.radio_receiveLine.Text = "读取一行";
            this.radio_receiveLine.UseVisualStyleBackColor = true;
            // 
            // radio_receiveAll
            // 
            this.radio_receiveAll.AutoSize = true;
            this.radio_receiveAll.Checked = true;
            this.radio_receiveAll.Location = new System.Drawing.Point(17, 15);
            this.radio_receiveAll.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receiveAll.Name = "radio_receiveAll";
            this.radio_receiveAll.Size = new System.Drawing.Size(137, 28);
            this.radio_receiveAll.TabIndex = 0;
            this.radio_receiveAll.TabStop = true;
            this.radio_receiveAll.Text = "读取全部";
            this.radio_receiveAll.UseVisualStyleBackColor = true;
            // 
            // label_receiveStyle
            // 
            this.label_receiveStyle.AutoSize = true;
            this.label_receiveStyle.Location = new System.Drawing.Point(25, 55);
            this.label_receiveStyle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_receiveStyle.Name = "label_receiveStyle";
            this.label_receiveStyle.Size = new System.Drawing.Size(130, 24);
            this.label_receiveStyle.TabIndex = 0;
            this.label_receiveStyle.Text = "读取方式：";
            // 
            // btn_clearReceiveHistory
            // 
            this.btn_clearReceiveHistory.Location = new System.Drawing.Point(1025, 375);
            this.btn_clearReceiveHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearReceiveHistory.Name = "btn_clearReceiveHistory";
            this.btn_clearReceiveHistory.Size = new System.Drawing.Size(158, 65);
            this.btn_clearReceiveHistory.TabIndex = 0;
            this.btn_clearReceiveHistory.TabStop = false;
            this.btn_clearReceiveHistory.Text = "清空记录";
            this.btn_clearReceiveHistory.UseVisualStyleBackColor = true;
            this.btn_clearReceiveHistory.Click += new System.EventHandler(this.Btn_clearReceiveHistory_Click);
            // 
            // btn_receive
            // 
            this.btn_receive.Location = new System.Drawing.Point(1025, 247);
            this.btn_receive.Margin = new System.Windows.Forms.Padding(4);
            this.btn_receive.Name = "btn_receive";
            this.btn_receive.Size = new System.Drawing.Size(158, 65);
            this.btn_receive.TabIndex = 0;
            this.btn_receive.TabStop = false;
            this.btn_receive.Text = "手动读取";
            this.btn_receive.UseVisualStyleBackColor = true;
            this.btn_receive.Click += new System.EventHandler(this.Btn_receive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "显示\\r\\n：";
            // 
            // panl_autoRecive
            // 
            this.panl_autoRecive.Controls.Add(this.radio_autoResNo);
            this.panl_autoRecive.Controls.Add(this.radio_autoResYes);
            this.panl_autoRecive.Location = new System.Drawing.Point(130, 100);
            this.panl_autoRecive.Margin = new System.Windows.Forms.Padding(4);
            this.panl_autoRecive.Name = "panl_autoRecive";
            this.panl_autoRecive.Size = new System.Drawing.Size(248, 40);
            this.panl_autoRecive.TabIndex = 21;
            // 
            // radio_autoResNo
            // 
            this.radio_autoResNo.AutoSize = true;
            this.radio_autoResNo.Location = new System.Drawing.Point(85, 5);
            this.radio_autoResNo.Margin = new System.Windows.Forms.Padding(4);
            this.radio_autoResNo.Name = "radio_autoResNo";
            this.radio_autoResNo.Size = new System.Drawing.Size(65, 28);
            this.radio_autoResNo.TabIndex = 0;
            this.radio_autoResNo.Text = "否";
            this.radio_autoResNo.UseVisualStyleBackColor = true;
            // 
            // radio_autoResYes
            // 
            this.radio_autoResYes.AutoSize = true;
            this.radio_autoResYes.Checked = true;
            this.radio_autoResYes.Location = new System.Drawing.Point(15, 5);
            this.radio_autoResYes.Margin = new System.Windows.Forms.Padding(4);
            this.radio_autoResYes.Name = "radio_autoResYes";
            this.radio_autoResYes.Size = new System.Drawing.Size(65, 28);
            this.radio_autoResYes.TabIndex = 0;
            this.radio_autoResYes.TabStop = true;
            this.radio_autoResYes.Text = "是";
            this.radio_autoResYes.UseVisualStyleBackColor = true;
            // 
            // label_autoReciveTips
            // 
            this.label_autoReciveTips.AutoSize = true;
            this.label_autoReciveTips.Location = new System.Drawing.Point(9, 108);
            this.label_autoReciveTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_autoReciveTips.Name = "label_autoReciveTips";
            this.label_autoReciveTips.Size = new System.Drawing.Size(130, 24);
            this.label_autoReciveTips.TabIndex = 0;
            this.label_autoReciveTips.Text = "自动接收：";
            // 
            // group_portControl
            // 
            this.group_portControl.Controls.Add(this.label_serialPortStatus);
            this.group_portControl.Controls.Add(this.btn_closePort);
            this.group_portControl.Controls.Add(this.btn_openPort);
            this.group_portControl.Controls.Add(this.label_serialStatusTips);
            this.group_portControl.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group_portControl.Location = new System.Drawing.Point(377, 32);
            this.group_portControl.Margin = new System.Windows.Forms.Padding(4);
            this.group_portControl.Name = "group_portControl";
            this.group_portControl.Padding = new System.Windows.Forms.Padding(4);
            this.group_portControl.Size = new System.Drawing.Size(684, 136);
            this.group_portControl.TabIndex = 4;
            this.group_portControl.TabStop = false;
            this.group_portControl.Text = "端口控制";
            // 
            // label_serialPortStatus
            // 
            this.label_serialPortStatus.AutoSize = true;
            this.label_serialPortStatus.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_serialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.label_serialPortStatus.Location = new System.Drawing.Point(445, 74);
            this.label_serialPortStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_serialPortStatus.Name = "label_serialPortStatus";
            this.label_serialPortStatus.Size = new System.Drawing.Size(148, 43);
            this.label_serialPortStatus.TabIndex = 0;
            this.label_serialPortStatus.Text = "已关闭";
            // 
            // btn_closePort
            // 
            this.btn_closePort.Location = new System.Drawing.Point(237, 55);
            this.btn_closePort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_closePort.Name = "btn_closePort";
            this.btn_closePort.Size = new System.Drawing.Size(156, 51);
            this.btn_closePort.TabIndex = 0;
            this.btn_closePort.TabStop = false;
            this.btn_closePort.Text = "关闭端口";
            this.btn_closePort.UseVisualStyleBackColor = true;
            this.btn_closePort.Click += new System.EventHandler(this.Btn_closePort_Click);
            // 
            // btn_openPort
            // 
            this.btn_openPort.Location = new System.Drawing.Point(39, 55);
            this.btn_openPort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(148, 51);
            this.btn_openPort.TabIndex = 0;
            this.btn_openPort.TabStop = false;
            this.btn_openPort.Text = "打开端口";
            this.btn_openPort.UseVisualStyleBackColor = true;
            this.btn_openPort.Click += new System.EventHandler(this.Btn_openPort_Click);
            // 
            // label_serialStatusTips
            // 
            this.label_serialStatusTips.AutoSize = true;
            this.label_serialStatusTips.Location = new System.Drawing.Point(459, 35);
            this.label_serialStatusTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_serialStatusTips.Name = "label_serialStatusTips";
            this.label_serialStatusTips.Size = new System.Drawing.Size(120, 27);
            this.label_serialStatusTips.TabIndex = 0;
            this.label_serialStatusTips.Text = "端口状态";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(479, 159);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(91, 48);
            this.btn_send.TabIndex = 0;
            this.btn_send.TabStop = false;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // text_sendData
            // 
            this.text_sendData.Location = new System.Drawing.Point(130, 163);
            this.text_sendData.Margin = new System.Windows.Forms.Padding(4);
            this.text_sendData.Multiline = true;
            this.text_sendData.Name = "text_sendData";
            this.text_sendData.Size = new System.Drawing.Size(336, 40);
            this.text_sendData.TabIndex = 2;
            this.text_sendData.WordWrap = false;
            // 
            // group_sendSet
            // 
            this.group_sendSet.Controls.Add(this.panel3);
            this.group_sendSet.Controls.Add(this.label_recordTimeTips);
            this.group_sendSet.Controls.Add(this.btn_clearSendHis);
            this.group_sendSet.Controls.Add(this.panel1);
            this.group_sendSet.Controls.Add(this.text_sendData);
            this.group_sendSet.Controls.Add(this.panl_autoRecive);
            this.group_sendSet.Controls.Add(this.text_endChar);
            this.group_sendSet.Controls.Add(this.label_endCharTips);
            this.group_sendSet.Controls.Add(this.label_autoReciveTips);
            this.group_sendSet.Controls.Add(this.label_sendDataTips);
            this.group_sendSet.Controls.Add(this.btn_send);
            this.group_sendSet.Location = new System.Drawing.Point(377, 187);
            this.group_sendSet.Margin = new System.Windows.Forms.Padding(4);
            this.group_sendSet.Name = "group_sendSet";
            this.group_sendSet.Padding = new System.Windows.Forms.Padding(4);
            this.group_sendSet.Size = new System.Drawing.Size(684, 236);
            this.group_sendSet.TabIndex = 0;
            this.group_sendSet.TabStop = false;
            this.group_sendSet.Text = "发送数据";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radio_sendTimeNo);
            this.panel3.Controls.Add(this.radio_sendTimeYes);
            this.panel3.Location = new System.Drawing.Point(495, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 40);
            this.panel3.TabIndex = 26;
            // 
            // radio_sendTimeNo
            // 
            this.radio_sendTimeNo.AutoSize = true;
            this.radio_sendTimeNo.Location = new System.Drawing.Point(85, 5);
            this.radio_sendTimeNo.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sendTimeNo.Name = "radio_sendTimeNo";
            this.radio_sendTimeNo.Size = new System.Drawing.Size(65, 28);
            this.radio_sendTimeNo.TabIndex = 0;
            this.radio_sendTimeNo.Text = "否";
            this.radio_sendTimeNo.UseVisualStyleBackColor = true;
            // 
            // radio_sendTimeYes
            // 
            this.radio_sendTimeYes.AutoSize = true;
            this.radio_sendTimeYes.Checked = true;
            this.radio_sendTimeYes.Location = new System.Drawing.Point(15, 5);
            this.radio_sendTimeYes.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sendTimeYes.Name = "radio_sendTimeYes";
            this.radio_sendTimeYes.Size = new System.Drawing.Size(65, 28);
            this.radio_sendTimeYes.TabIndex = 0;
            this.radio_sendTimeYes.TabStop = true;
            this.radio_sendTimeYes.Text = "是";
            this.radio_sendTimeYes.UseVisualStyleBackColor = true;
            // 
            // label_recordTimeTips
            // 
            this.label_recordTimeTips.AutoSize = true;
            this.label_recordTimeTips.Location = new System.Drawing.Point(381, 108);
            this.label_recordTimeTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_recordTimeTips.Name = "label_recordTimeTips";
            this.label_recordTimeTips.Size = new System.Drawing.Size(130, 24);
            this.label_recordTimeTips.TabIndex = 0;
            this.label_recordTimeTips.Text = "记录时间：";
            // 
            // btn_clearSendHis
            // 
            this.btn_clearSendHis.Location = new System.Drawing.Point(578, 159);
            this.btn_clearSendHis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearSendHis.Name = "btn_clearSendHis";
            this.btn_clearSendHis.Size = new System.Drawing.Size(91, 48);
            this.btn_clearSendHis.TabIndex = 0;
            this.btn_clearSendHis.TabStop = false;
            this.btn_clearSendHis.Text = "清空";
            this.btn_clearSendHis.UseVisualStyleBackColor = true;
            this.btn_clearSendHis.Click += new System.EventHandler(this.Btn_clearSendHis_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_endCharYes);
            this.panel1.Controls.Add(this.radio_endCharNo);
            this.panel1.Location = new System.Drawing.Point(130, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 45);
            this.panel1.TabIndex = 24;
            // 
            // radio_endCharYes
            // 
            this.radio_endCharYes.AutoSize = true;
            this.radio_endCharYes.Location = new System.Drawing.Point(85, 9);
            this.radio_endCharYes.Name = "radio_endCharYes";
            this.radio_endCharYes.Size = new System.Drawing.Size(149, 28);
            this.radio_endCharYes.TabIndex = 0;
            this.radio_endCharYes.Text = "有(ASCII)";
            this.radio_endCharYes.UseVisualStyleBackColor = true;
            // 
            // radio_endCharNo
            // 
            this.radio_endCharNo.AutoSize = true;
            this.radio_endCharNo.Checked = true;
            this.radio_endCharNo.Location = new System.Drawing.Point(15, 9);
            this.radio_endCharNo.Name = "radio_endCharNo";
            this.radio_endCharNo.Size = new System.Drawing.Size(65, 28);
            this.radio_endCharNo.TabIndex = 0;
            this.radio_endCharNo.TabStop = true;
            this.radio_endCharNo.Text = "无";
            this.radio_endCharNo.UseVisualStyleBackColor = true;
            this.radio_endCharNo.CheckedChanged += new System.EventHandler(this.Radio_endCharNo_CheckedChanged);
            // 
            // text_endChar
            // 
            this.text_endChar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_endChar.Enabled = false;
            this.text_endChar.Location = new System.Drawing.Point(385, 36);
            this.text_endChar.Margin = new System.Windows.Forms.Padding(4);
            this.text_endChar.Multiline = true;
            this.text_endChar.Name = "text_endChar";
            this.text_endChar.Size = new System.Drawing.Size(284, 40);
            this.text_endChar.TabIndex = 1;
            this.text_endChar.WordWrap = false;
            // 
            // label_endCharTips
            // 
            this.label_endCharTips.AutoSize = true;
            this.label_endCharTips.Location = new System.Drawing.Point(9, 44);
            this.label_endCharTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_endCharTips.Name = "label_endCharTips";
            this.label_endCharTips.Size = new System.Drawing.Size(130, 24);
            this.label_endCharTips.TabIndex = 0;
            this.label_endCharTips.Text = "结束符号：";
            // 
            // label_sendDataTips
            // 
            this.label_sendDataTips.AutoSize = true;
            this.label_sendDataTips.Location = new System.Drawing.Point(9, 171);
            this.label_sendDataTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_sendDataTips.Name = "label_sendDataTips";
            this.label_sendDataTips.Size = new System.Drawing.Size(130, 24);
            this.label_sendDataTips.TabIndex = 0;
            this.label_sendDataTips.Text = "命令数据：";
            // 
            // text_sendHistory
            // 
            this.text_sendHistory.Location = new System.Drawing.Point(8, 36);
            this.text_sendHistory.Margin = new System.Windows.Forms.Padding(4);
            this.text_sendHistory.Multiline = true;
            this.text_sendHistory.Name = "text_sendHistory";
            this.text_sendHistory.ReadOnly = true;
            this.text_sendHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_sendHistory.Size = new System.Drawing.Size(515, 347);
            this.text_sendHistory.TabIndex = 0;
            this.text_sendHistory.TabStop = false;
            this.text_sendHistory.WordWrap = false;
            // 
            // group_sendHistory
            // 
            this.group_sendHistory.Controls.Add(this.text_sendHistory);
            this.group_sendHistory.Location = new System.Drawing.Point(1079, 32);
            this.group_sendHistory.Margin = new System.Windows.Forms.Padding(4);
            this.group_sendHistory.Name = "group_sendHistory";
            this.group_sendHistory.Padding = new System.Windows.Forms.Padding(4);
            this.group_sendHistory.Size = new System.Drawing.Size(534, 391);
            this.group_sendHistory.TabIndex = 0;
            this.group_sendHistory.TabStop = false;
            this.group_sendHistory.Text = "发送历史";
            // 
            // group_toolTips
            // 
            this.group_toolTips.Controls.Add(this.text_toolTips);
            this.group_toolTips.Location = new System.Drawing.Point(1253, 432);
            this.group_toolTips.Name = "group_toolTips";
            this.group_toolTips.Size = new System.Drawing.Size(359, 584);
            this.group_toolTips.TabIndex = 17;
            this.group_toolTips.TabStop = false;
            this.group_toolTips.Text = "工具说明";
            // 
            // text_toolTips
            // 
            this.text_toolTips.BackColor = System.Drawing.SystemColors.Menu;
            this.text_toolTips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_toolTips.CausesValidation = false;
            this.text_toolTips.Location = new System.Drawing.Point(15, 34);
            this.text_toolTips.Multiline = true;
            this.text_toolTips.Name = "text_toolTips";
            this.text_toolTips.ReadOnly = true;
            this.text_toolTips.Size = new System.Drawing.Size(334, 542);
            this.text_toolTips.TabIndex = 0;
            this.text_toolTips.TabStop = false;
            // 
            // serialPortCheckTimer
            // 
            this.serialPortCheckTimer.Tick += new System.EventHandler(this.SerialPortCheckTimer_Tick);
            // 
            // SerialPortTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1624, 1049);
            this.Controls.Add(this.group_toolTips);
            this.Controls.Add(this.group_sendHistory);
            this.Controls.Add(this.group_sendSet);
            this.Controls.Add(this.group_portControl);
            this.Controls.Add(this.group_receiveSet);
            this.Controls.Add(this.group_serialDataSet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SerialPortTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易端口调试工具—By极乐流年";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_serialDataSet.ResumeLayout(false);
            this.group_serialDataSet.PerformLayout();
            this.group_receiveSet.ResumeLayout(false);
            this.group_receiveSet.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panl_autoRecive.ResumeLayout(false);
            this.panl_autoRecive.PerformLayout();
            this.group_portControl.ResumeLayout(false);
            this.group_portControl.PerformLayout();
            this.group_sendSet.ResumeLayout(false);
            this.group_sendSet.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.group_sendHistory.ResumeLayout(false);
            this.group_sendHistory.PerformLayout();
            this.group_toolTips.ResumeLayout(false);
            this.group_toolTips.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_serialDataSet;
        public System.Windows.Forms.ComboBox comboBox_serialName;
        private System.Windows.Forms.Label label_serialName;
        public System.Windows.Forms.ComboBox comboBox_stopBits;
        private System.Windows.Forms.Label label_stopBits;
        public System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.Label label_parity;
        public System.Windows.Forms.ComboBox comboBox_dataBits;
        private System.Windows.Forms.Label label_dataBits;
        public System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label_baudRate;
        private System.Windows.Forms.TextBox text_receiveData;
        private System.Windows.Forms.GroupBox group_receiveSet;
        private System.Windows.Forms.Button btn_searchSerialPorts;
        private System.Windows.Forms.Button btn_clearReceiveHistory;
        private System.Windows.Forms.Button btn_receive;
        private System.Windows.Forms.GroupBox group_portControl;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox text_sendData;
        private System.Windows.Forms.Label label_serialPortStatus;
        private System.Windows.Forms.Button btn_closePort;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Label label_serialStatusTips;
        private System.Windows.Forms.GroupBox group_sendSet;
        private System.Windows.Forms.Button btn_advancedSet;
        private System.IO.Ports.SerialPort defaultSerialPort;
        private System.Windows.Forms.Label label_sendDataTips;
        private System.Windows.Forms.TextBox text_sendHistory;
        private System.Windows.Forms.Button btn_clearSendHis;
        private System.Windows.Forms.GroupBox group_sendHistory;
        private System.Windows.Forms.Panel panl_autoRecive;
        private System.Windows.Forms.RadioButton radio_autoResNo;
        private System.Windows.Forms.RadioButton radio_autoResYes;
        private System.Windows.Forms.Label label_autoReciveTips;
        private System.Windows.Forms.Label label_endCharTips;
        private System.Windows.Forms.TextBox text_endChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_endCharYes;
        private System.Windows.Forms.RadioButton radio_endCharNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_receiveTo;
        private System.Windows.Forms.RadioButton radio_receiveToChar;
        private System.Windows.Forms.RadioButton radio_receiveLine;
        private System.Windows.Forms.RadioButton radio_receiveAll;
        private System.Windows.Forms.Label label_receiveStyle;
        private System.Windows.Forms.GroupBox group_toolTips;
        private System.Windows.Forms.TextBox text_toolTips;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radio_sendTimeNo;
        private System.Windows.Forms.RadioButton radio_sendTimeYes;
        private System.Windows.Forms.Label label_recordTimeTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_showHideNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radio_showHideYes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radio_receiveTimeNo;
        private System.Windows.Forms.RadioButton radio_receiveTimeYes;
        private System.Windows.Forms.Label lbl_receiveTimeTips;
        private System.Windows.Forms.Timer serialPortCheckTimer;
    }
}

