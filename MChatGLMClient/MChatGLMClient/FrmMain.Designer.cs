namespace ChatGLMClient
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ucTextBoxExAPI = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBtnImgSend = new HZH_Controls.Controls.UCBtnImg();
            this.ucBtnImgMaxTokens = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarMaxTokens = new HZH_Controls.Controls.UCTrackBar();
            this.labelMaxTokens = new System.Windows.Forms.Label();
            this.ucBtnImgTemp = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarTemp = new HZH_Controls.Controls.UCTrackBar();
            this.labelTemp = new System.Windows.Forms.Label();
            this.ucBtnImgTopp = new HZH_Controls.Controls.UCBtnImg();
            this.labelTopp = new System.Windows.Forms.Label();
            this.ucTrackBarTopp = new HZH_Controls.Controls.UCTrackBar();
            this.ucBtnImgClear = new HZH_Controls.Controls.UCBtnImg();
            this.label2 = new System.Windows.Forms.Label();
            this.ucSwitchStream = new HZH_Controls.Controls.UCSwitch();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucb_connectstatus = new HZH_Controls.Controls.UCBtnExt();
            this.ucb_status = new HZH_Controls.Controls.UCBtnExt();
            this.ucAutoConnect = new HZH_Controls.Controls.UCSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_startmonitorStatus = new System.Windows.Forms.Button();
            this.ucBtnImgStop = new HZH_Controls.Controls.UCBtnImg();
            this.ucb_Connect = new HZH_Controls.Controls.UCDropDownBtn();
            this.ucb_mode = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // ucTextBoxExAPI
            // 
            this.ucTextBoxExAPI.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxExAPI.ConerRadius = 20;
            this.ucTextBoxExAPI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxExAPI.DecLength = 2;
            this.ucTextBoxExAPI.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxExAPI.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPI.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.ucTextBoxExAPI.InputText = "";
            this.ucTextBoxExAPI.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxExAPI.IsFocusColor = true;
            this.ucTextBoxExAPI.IsRadius = true;
            this.ucTextBoxExAPI.IsShowClearBtn = true;
            this.ucTextBoxExAPI.IsShowKeyboard = false;
            this.ucTextBoxExAPI.IsShowRect = true;
            this.ucTextBoxExAPI.IsShowSearchBtn = false;
            this.ucTextBoxExAPI.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxExAPI.Location = new System.Drawing.Point(121, 82);
            this.ucTextBoxExAPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxExAPI.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxExAPI.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxExAPI.Name = "ucTextBoxExAPI";
            this.ucTextBoxExAPI.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxExAPI.PasswordChar = '\0';
            this.ucTextBoxExAPI.PromptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucTextBoxExAPI.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxExAPI.PromptText = "";
            this.ucTextBoxExAPI.RectColor = System.Drawing.SystemColors.Control;
            this.ucTextBoxExAPI.RectWidth = 1;
            this.ucTextBoxExAPI.RegexPattern = "";
            this.ucTextBoxExAPI.Size = new System.Drawing.Size(351, 30);
            this.ucTextBoxExAPI.TabIndex = 56;
            this.ucTextBoxExAPI.Leave += new System.EventHandler(this.ucTextBoxExAPI_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "地址";
            // 
            // ucBtnImgSend
            // 
            this.ucBtnImgSend.BackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgSend.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.BtnText = "   发送";
            this.ucBtnImgSend.ConerRadius = 20;
            this.ucBtnImgSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgSend.EnabledMouseEffect = false;
            this.ucBtnImgSend.FillColor = System.Drawing.Color.White;
            this.ucBtnImgSend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgSend.ForeColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgSend.Image")));
            this.ucBtnImgSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgSend.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgSend.ImageFontIcons")));
            this.ucBtnImgSend.IsRadius = true;
            this.ucBtnImgSend.IsShowRect = true;
            this.ucBtnImgSend.IsShowTips = false;
            this.ucBtnImgSend.Location = new System.Drawing.Point(658, 601);
            this.ucBtnImgSend.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgSend.Name = "ucBtnImgSend";
            this.ucBtnImgSend.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgSend.RectWidth = 1;
            this.ucBtnImgSend.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgSend.TabIndex = 58;
            this.ucBtnImgSend.TabStop = false;
            this.ucBtnImgSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgSend.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgSend.TipsText = "";
            this.ucBtnImgSend.BtnClick += new System.EventHandler(this.ucBtnImgSend_BtnClick);
            // 
            // ucBtnImgMaxTokens
            // 
            this.ucBtnImgMaxTokens.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgMaxTokens.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.BtnText = "Maximum length";
            this.ucBtnImgMaxTokens.ConerRadius = 5;
            this.ucBtnImgMaxTokens.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgMaxTokens.EnabledMouseEffect = false;
            this.ucBtnImgMaxTokens.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgMaxTokens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgMaxTokens.Image")));
            this.ucBtnImgMaxTokens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgMaxTokens.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgMaxTokens.ImageFontIcons")));
            this.ucBtnImgMaxTokens.IsRadius = true;
            this.ucBtnImgMaxTokens.IsShowRect = true;
            this.ucBtnImgMaxTokens.IsShowTips = false;
            this.ucBtnImgMaxTokens.Location = new System.Drawing.Point(645, 152);
            this.ucBtnImgMaxTokens.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgMaxTokens.Name = "ucBtnImgMaxTokens";
            this.ucBtnImgMaxTokens.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.RectWidth = 1;
            this.ucBtnImgMaxTokens.Size = new System.Drawing.Size(186, 31);
            this.ucBtnImgMaxTokens.TabIndex = 63;
            this.ucBtnImgMaxTokens.TabStop = false;
            this.ucBtnImgMaxTokens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgMaxTokens.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgMaxTokens.TipsText = "";
            // 
            // ucTrackBarMaxTokens
            // 
            this.ucTrackBarMaxTokens.DcimalDigits = 0;
            this.ucTrackBarMaxTokens.IsShowTips = true;
            this.ucTrackBarMaxTokens.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarMaxTokens.LineWidth = 8F;
            this.ucTrackBarMaxTokens.Location = new System.Drawing.Point(645, 186);
            this.ucTrackBarMaxTokens.MaxValue = 4096F;
            this.ucTrackBarMaxTokens.MinValue = 0F;
            this.ucTrackBarMaxTokens.Name = "ucTrackBarMaxTokens";
            this.ucTrackBarMaxTokens.Size = new System.Drawing.Size(186, 30);
            this.ucTrackBarMaxTokens.TabIndex = 64;
            this.ucTrackBarMaxTokens.TipsFormat = null;
            this.ucTrackBarMaxTokens.Value = 2048F;
            this.ucTrackBarMaxTokens.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarMaxTokens.ValueChanged += new System.EventHandler(this.ucTrackBarMaxTokens_ValueChanged);
            // 
            // labelMaxTokens
            // 
            this.labelMaxTokens.AutoSize = true;
            this.labelMaxTokens.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMaxTokens.Location = new System.Drawing.Point(843, 193);
            this.labelMaxTokens.Name = "labelMaxTokens";
            this.labelMaxTokens.Size = new System.Drawing.Size(45, 19);
            this.labelMaxTokens.TabIndex = 65;
            this.labelMaxTokens.Text = "2048";
            // 
            // ucBtnImgTemp
            // 
            this.ucBtnImgTemp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTemp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.BtnText = "Temperature";
            this.ucBtnImgTemp.ConerRadius = 5;
            this.ucBtnImgTemp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTemp.EnabledMouseEffect = false;
            this.ucBtnImgTemp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTemp.Image")));
            this.ucBtnImgTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTemp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTemp.ImageFontIcons")));
            this.ucBtnImgTemp.IsRadius = true;
            this.ucBtnImgTemp.IsShowRect = true;
            this.ucBtnImgTemp.IsShowTips = false;
            this.ucBtnImgTemp.Location = new System.Drawing.Point(645, 234);
            this.ucBtnImgTemp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTemp.Name = "ucBtnImgTemp";
            this.ucBtnImgTemp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.RectWidth = 1;
            this.ucBtnImgTemp.Size = new System.Drawing.Size(152, 30);
            this.ucBtnImgTemp.TabIndex = 66;
            this.ucBtnImgTemp.TabStop = false;
            this.ucBtnImgTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTemp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTemp.TipsText = "";
            // 
            // ucTrackBarTemp
            // 
            this.ucTrackBarTemp.DcimalDigits = 1;
            this.ucTrackBarTemp.IsShowTips = true;
            this.ucTrackBarTemp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTemp.LineWidth = 8F;
            this.ucTrackBarTemp.Location = new System.Drawing.Point(645, 267);
            this.ucTrackBarTemp.MaxValue = 1F;
            this.ucTrackBarTemp.MinValue = 0F;
            this.ucTrackBarTemp.Name = "ucTrackBarTemp";
            this.ucTrackBarTemp.Size = new System.Drawing.Size(185, 30);
            this.ucTrackBarTemp.TabIndex = 67;
            this.ucTrackBarTemp.TipsFormat = null;
            this.ucTrackBarTemp.Value = 0.9F;
            this.ucTrackBarTemp.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarTemp.ValueChanged += new System.EventHandler(this.ucTrackBarTemp_ValueChanged);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemp.Location = new System.Drawing.Point(843, 273);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(40, 19);
            this.labelTemp.TabIndex = 68;
            this.labelTemp.Text = "0.95";
            // 
            // ucBtnImgTopp
            // 
            this.ucBtnImgTopp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTopp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.BtnText = "Top p";
            this.ucBtnImgTopp.ConerRadius = 5;
            this.ucBtnImgTopp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTopp.EnabledMouseEffect = false;
            this.ucBtnImgTopp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTopp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTopp.Image")));
            this.ucBtnImgTopp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTopp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTopp.ImageFontIcons")));
            this.ucBtnImgTopp.IsRadius = true;
            this.ucBtnImgTopp.IsShowRect = true;
            this.ucBtnImgTopp.IsShowTips = false;
            this.ucBtnImgTopp.Location = new System.Drawing.Point(659, 315);
            this.ucBtnImgTopp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTopp.Name = "ucBtnImgTopp";
            this.ucBtnImgTopp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.RectWidth = 1;
            this.ucBtnImgTopp.Size = new System.Drawing.Size(98, 30);
            this.ucBtnImgTopp.TabIndex = 69;
            this.ucBtnImgTopp.TabStop = false;
            this.ucBtnImgTopp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTopp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTopp.TipsText = "";
            // 
            // labelTopp
            // 
            this.labelTopp.AutoSize = true;
            this.labelTopp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTopp.Location = new System.Drawing.Point(845, 355);
            this.labelTopp.Name = "labelTopp";
            this.labelTopp.Size = new System.Drawing.Size(31, 19);
            this.labelTopp.TabIndex = 71;
            this.labelTopp.Text = "0.7";
            // 
            // ucTrackBarTopp
            // 
            this.ucTrackBarTopp.DcimalDigits = 1;
            this.ucTrackBarTopp.IsShowTips = true;
            this.ucTrackBarTopp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTopp.LineWidth = 8F;
            this.ucTrackBarTopp.Location = new System.Drawing.Point(645, 348);
            this.ucTrackBarTopp.MaxValue = 1F;
            this.ucTrackBarTopp.MinValue = 0F;
            this.ucTrackBarTopp.Name = "ucTrackBarTopp";
            this.ucTrackBarTopp.Size = new System.Drawing.Size(185, 30);
            this.ucTrackBarTopp.TabIndex = 70;
            this.ucTrackBarTopp.TipsFormat = null;
            this.ucTrackBarTopp.Value = 0.7F;
            this.ucTrackBarTopp.ValueColor = System.Drawing.Color.Green;
            this.ucTrackBarTopp.ValueChanged += new System.EventHandler(this.ucTrackBarTopp_ValueChanged);
            // 
            // ucBtnImgClear
            // 
            this.ucBtnImgClear.BackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucBtnImgClear.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgClear.BtnText = "  清空";
            this.ucBtnImgClear.ConerRadius = 20;
            this.ucBtnImgClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgClear.EnabledMouseEffect = false;
            this.ucBtnImgClear.FillColor = System.Drawing.Color.White;
            this.ucBtnImgClear.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgClear.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgClear.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgClear.Image")));
            this.ucBtnImgClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgClear.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgClear.ImageFontIcons")));
            this.ucBtnImgClear.IsRadius = true;
            this.ucBtnImgClear.IsShowRect = true;
            this.ucBtnImgClear.IsShowTips = false;
            this.ucBtnImgClear.Location = new System.Drawing.Point(658, 470);
            this.ucBtnImgClear.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgClear.Name = "ucBtnImgClear";
            this.ucBtnImgClear.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgClear.RectWidth = 1;
            this.ucBtnImgClear.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgClear.TabIndex = 59;
            this.ucBtnImgClear.TabStop = false;
            this.ucBtnImgClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgClear.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgClear.TipsText = "";
            this.ucBtnImgClear.BtnClick += new System.EventHandler(this.ucBtnImgClear_BtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(655, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 87;
            this.label2.Text = "流模式";
            // 
            // ucSwitchStream
            // 
            this.ucSwitchStream.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchStream.Checked = true;
            this.ucSwitchStream.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchStream.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchStream.Location = new System.Drawing.Point(719, 409);
            this.ucSwitchStream.Name = "ucSwitchStream";
            this.ucSwitchStream.Size = new System.Drawing.Size(69, 31);
            this.ucSwitchStream.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchStream.TabIndex = 88;
            this.ucSwitchStream.Texts = new string[] {
        "I",
        "O"};
            this.ucSwitchStream.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucSwitchStream.TrueTextColr = System.Drawing.Color.White;
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(36, 133);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(584, 389);
            this.richTextBoxAnswer.TabIndex = 60;
            this.richTextBoxAnswer.TabStop = false;
            this.richTextBoxAnswer.Text = "";
            this.richTextBoxAnswer.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(37, 546);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(583, 97);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = null;
            this.ucBtnExt2.ConerRadius = 20;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(33, 543);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.Green;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(590, 103);
            this.ucBtnExt2.TabIndex = 86;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.ConerRadius = 20;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(33, 130);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Green;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(590, 395);
            this.ucBtnExt1.TabIndex = 61;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            // 
            // ucb_connectstatus
            // 
            this.ucb_connectstatus.BackColor = System.Drawing.Color.White;
            this.ucb_connectstatus.BtnBackColor = System.Drawing.Color.White;
            this.ucb_connectstatus.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_connectstatus.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucb_connectstatus.BtnText = "连接";
            this.ucb_connectstatus.ConerRadius = 100;
            this.ucb_connectstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_connectstatus.EnabledMouseEffect = false;
            this.ucb_connectstatus.FillColor = System.Drawing.Color.Transparent;
            this.ucb_connectstatus.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_connectstatus.IsRadius = true;
            this.ucb_connectstatus.IsShowRect = true;
            this.ucb_connectstatus.IsShowTips = false;
            this.ucb_connectstatus.Location = new System.Drawing.Point(806, 422);
            this.ucb_connectstatus.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_connectstatus.Name = "ucb_connectstatus";
            this.ucb_connectstatus.RectColor = System.Drawing.Color.Green;
            this.ucb_connectstatus.RectWidth = 1;
            this.ucb_connectstatus.Size = new System.Drawing.Size(100, 100);
            this.ucb_connectstatus.TabIndex = 87;
            this.ucb_connectstatus.TabStop = false;
            this.ucb_connectstatus.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_connectstatus.TipsText = "";
            // 
            // ucb_status
            // 
            this.ucb_status.BackColor = System.Drawing.Color.White;
            this.ucb_status.BtnBackColor = System.Drawing.Color.White;
            this.ucb_status.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_status.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucb_status.BtnText = "状态";
            this.ucb_status.ConerRadius = 100;
            this.ucb_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_status.EnabledMouseEffect = false;
            this.ucb_status.FillColor = System.Drawing.Color.Transparent;
            this.ucb_status.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_status.IsRadius = true;
            this.ucb_status.IsShowRect = true;
            this.ucb_status.IsShowTips = false;
            this.ucb_status.Location = new System.Drawing.Point(806, 546);
            this.ucb_status.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_status.Name = "ucb_status";
            this.ucb_status.RectColor = System.Drawing.Color.Green;
            this.ucb_status.RectWidth = 1;
            this.ucb_status.Size = new System.Drawing.Size(100, 100);
            this.ucb_status.TabIndex = 90;
            this.ucb_status.TabStop = false;
            this.ucb_status.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_status.TipsText = "";
            // 
            // ucAutoConnect
            // 
            this.ucAutoConnect.BackColor = System.Drawing.Color.Transparent;
            this.ucAutoConnect.Checked = true;
            this.ucAutoConnect.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucAutoConnect.FalseTextColr = System.Drawing.Color.White;
            this.ucAutoConnect.Location = new System.Drawing.Point(801, 83);
            this.ucAutoConnect.Name = "ucAutoConnect";
            this.ucAutoConnect.Size = new System.Drawing.Size(69, 31);
            this.ucAutoConnect.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucAutoConnect.TabIndex = 92;
            this.ucAutoConnect.Texts = new string[] {
        "I",
        "O"};
            this.ucAutoConnect.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAutoConnect.TrueTextColr = System.Drawing.Color.White;
            this.ucAutoConnect.CheckedChanged += new System.EventHandler(this.ucAutoConnect_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(721, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "自动连接";
            // 
            // bnt_startmonitorStatus
            // 
            this.bnt_startmonitorStatus.Location = new System.Drawing.Point(53, 649);
            this.bnt_startmonitorStatus.Name = "bnt_startmonitorStatus";
            this.bnt_startmonitorStatus.Size = new System.Drawing.Size(82, 25);
            this.bnt_startmonitorStatus.TabIndex = 93;
            this.bnt_startmonitorStatus.Text = "监控网络";
            this.bnt_startmonitorStatus.UseVisualStyleBackColor = true;
            this.bnt_startmonitorStatus.Visible = false;
            this.bnt_startmonitorStatus.Click += new System.EventHandler(this.Bnt_startmonitorStatus_Click);
            // 
            // ucBtnImgStop
            // 
            this.ucBtnImgStop.BackColor = System.Drawing.Color.White;
            this.ucBtnImgStop.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgStop.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucBtnImgStop.BtnForeColor = System.Drawing.Color.Green;
            this.ucBtnImgStop.BtnText = "  停止";
            this.ucBtnImgStop.ConerRadius = 20;
            this.ucBtnImgStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgStop.EnabledMouseEffect = false;
            this.ucBtnImgStop.FillColor = System.Drawing.Color.White;
            this.ucBtnImgStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgStop.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgStop.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgStop.Image")));
            this.ucBtnImgStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgStop.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgStop.ImageFontIcons")));
            this.ucBtnImgStop.IsRadius = true;
            this.ucBtnImgStop.IsShowRect = true;
            this.ucBtnImgStop.IsShowTips = false;
            this.ucBtnImgStop.Location = new System.Drawing.Point(658, 546);
            this.ucBtnImgStop.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgStop.Name = "ucBtnImgStop";
            this.ucBtnImgStop.RectColor = System.Drawing.Color.Green;
            this.ucBtnImgStop.RectWidth = 1;
            this.ucBtnImgStop.Size = new System.Drawing.Size(125, 42);
            this.ucBtnImgStop.TabIndex = 94;
            this.ucBtnImgStop.TabStop = false;
            this.ucBtnImgStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImgStop.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgStop.TipsText = "";
            this.ucBtnImgStop.BtnClick += new System.EventHandler(this.ucBtnImgStop_BtnClick);
            // 
            // ucb_Connect
            // 
            this.ucb_Connect.BackColor = System.Drawing.Color.White;
            this.ucb_Connect.BtnBackColor = System.Drawing.Color.White;
            this.ucb_Connect.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.ucb_Connect.BtnForeColor = System.Drawing.Color.Green;
            this.ucb_Connect.Btns = new string[] {
        "cpu",
        "fp16",
        "int8",
        "int4",
        "fp16-双卡"};
            this.ucb_Connect.BtnText = "启动";
            this.ucb_Connect.ConerRadius = 20;
            this.ucb_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_Connect.DropPanelHeight = -1;
            this.ucb_Connect.EnabledMouseEffect = false;
            this.ucb_Connect.FillColor = System.Drawing.Color.White;
            this.ucb_Connect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_Connect.ForeColor = System.Drawing.Color.Green;
            this.ucb_Connect.Image = ((System.Drawing.Image)(resources.GetObject("ucb_Connect.Image")));
            this.ucb_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucb_Connect.ImageFontIcons = null;
            this.ucb_Connect.IsRadius = true;
            this.ucb_Connect.IsShowRect = true;
            this.ucb_Connect.IsShowTips = false;
            this.ucb_Connect.Location = new System.Drawing.Point(500, 82);
            this.ucb_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.ucb_Connect.Name = "ucb_Connect";
            this.ucb_Connect.RectColor = System.Drawing.Color.Green;
            this.ucb_Connect.RectWidth = 1;
            this.ucb_Connect.Size = new System.Drawing.Size(106, 31);
            this.ucb_Connect.TabIndex = 96;
            this.ucb_Connect.TabStop = false;
            this.ucb_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucb_Connect.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_Connect.TipsText = "";
            this.ucb_Connect.BtnClick += new System.EventHandler(this.ucb_Connect_BtnClick);
            // 
            // ucb_mode
            // 
            this.ucb_mode.BackColor = System.Drawing.Color.White;
            this.ucb_mode.BtnBackColor = System.Drawing.Color.White;
            this.ucb_mode.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.ucb_mode.BtnForeColor = System.Drawing.Color.Green;
            this.ucb_mode.BtnText = "模式";
            this.ucb_mode.ConerRadius = 50;
            this.ucb_mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucb_mode.EnabledMouseEffect = false;
            this.ucb_mode.FillColor = System.Drawing.Color.Transparent;
            this.ucb_mode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucb_mode.IsRadius = true;
            this.ucb_mode.IsShowRect = true;
            this.ucb_mode.IsShowTips = false;
            this.ucb_mode.Location = new System.Drawing.Point(658, 73);
            this.ucb_mode.Margin = new System.Windows.Forms.Padding(0);
            this.ucb_mode.Name = "ucb_mode";
            this.ucb_mode.RectColor = System.Drawing.Color.Green;
            this.ucb_mode.RectWidth = 1;
            this.ucb_mode.Size = new System.Drawing.Size(50, 50);
            this.ucb_mode.TabIndex = 97;
            this.ucb_mode.TabStop = false;
            this.ucb_mode.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucb_mode.TipsText = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.ucb_mode);
            this.Controls.Add(this.ucb_Connect);
            this.Controls.Add(this.ucBtnImgStop);
            this.Controls.Add(this.bnt_startmonitorStatus);
            this.Controls.Add(this.ucAutoConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucb_status);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.ucSwitchStream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucTextBoxExAPI);
            this.Controls.Add(this.ucBtnImgClear);
            this.Controls.Add(this.labelTopp);
            this.Controls.Add(this.ucTrackBarTopp);
            this.Controls.Add(this.ucBtnImgTopp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.ucTrackBarTemp);
            this.Controls.Add(this.ucBtnImgTemp);
            this.Controls.Add(this.labelMaxTokens);
            this.Controls.Add(this.ucTrackBarMaxTokens);
            this.Controls.Add(this.ucBtnImgMaxTokens);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.ucBtnImgSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.ucb_connectstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FrmMain";
            this.RegionRadius = 40;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "FrmMain";
            this.Title = "ChatGLM-6B 环境";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.ucb_connectstatus, 0);
            this.Controls.SetChildIndex(this.ucBtnExt1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ucBtnImgSend, 0);
            this.Controls.SetChildIndex(this.richTextBoxAnswer, 0);
            this.Controls.SetChildIndex(this.ucBtnImgMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucTrackBarMaxTokens, 0);
            this.Controls.SetChildIndex(this.labelMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTemp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTemp, 0);
            this.Controls.SetChildIndex(this.labelTemp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTopp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTopp, 0);
            this.Controls.SetChildIndex(this.labelTopp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgClear, 0);
            this.Controls.SetChildIndex(this.ucTextBoxExAPI, 0);
            this.Controls.SetChildIndex(this.ucBtnExt2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ucSwitchStream, 0);
            this.Controls.SetChildIndex(this.richTextBoxQuestion, 0);
            this.Controls.SetChildIndex(this.ucb_status, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ucAutoConnect, 0);
            this.Controls.SetChildIndex(this.bnt_startmonitorStatus, 0);
            this.Controls.SetChildIndex(this.ucBtnImgStop, 0);
            this.Controls.SetChildIndex(this.ucb_Connect, 0);
            this.Controls.SetChildIndex(this.ucb_mode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxExAPI;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgSend;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgMaxTokens;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarMaxTokens;
        private System.Windows.Forms.Label labelMaxTokens;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTemp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTemp;
        private System.Windows.Forms.Label labelTemp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTopp;
        private System.Windows.Forms.Label labelTopp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTopp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgClear;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCSwitch ucSwitchStream;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucb_connectstatus;
        private HZH_Controls.Controls.UCBtnExt ucb_status;
        private HZH_Controls.Controls.UCSwitch ucAutoConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_startmonitorStatus;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgStop;
        private HZH_Controls.Controls.UCDropDownBtn ucb_Connect;
        private HZH_Controls.Controls.UCBtnExt ucb_mode;
    }
}

