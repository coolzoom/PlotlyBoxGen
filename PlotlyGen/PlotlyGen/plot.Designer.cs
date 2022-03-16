
namespace PlotlyGen
{
    partial class plot
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTextBoxPlotName = new MaterialSkin.Controls.MaterialTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxDIVID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxPlotWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxPlotHeight = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxYstep = new MaterialSkin.Controls.MaterialTextBox();
            this.ckbCL = new MaterialSkin.Controls.MaterialCheckbox();
            this.ckbUSL = new MaterialSkin.Controls.MaterialCheckbox();
            this.ckbLSL = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtLSL = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUSL = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCL = new MaterialSkin.Controls.MaterialTextBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTextBoxPlotName
            // 
            this.materialTextBoxPlotName.AnimateReadOnly = false;
            this.materialTextBoxPlotName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPlotName.Depth = 0;
            this.materialTextBoxPlotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxPlotName.Hint = "Please enter Plot Name";
            this.materialTextBoxPlotName.LeadingIcon = null;
            this.materialTextBoxPlotName.Location = new System.Drawing.Point(148, 39);
            this.materialTextBoxPlotName.MaxLength = 50;
            this.materialTextBoxPlotName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPlotName.Multiline = false;
            this.materialTextBoxPlotName.Name = "materialTextBoxPlotName";
            this.materialTextBoxPlotName.Size = new System.Drawing.Size(238, 50);
            this.materialTextBoxPlotName.TabIndex = 0;
            this.materialTextBoxPlotName.Text = "Plot Name";
            this.materialTextBoxPlotName.TrailingIcon = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 408);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(815, 523);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(95, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Generate";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTextBoxDIVID
            // 
            this.materialTextBoxDIVID.AnimateReadOnly = false;
            this.materialTextBoxDIVID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDIVID.Depth = 0;
            this.materialTextBoxDIVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxDIVID.Hint = "Please enter div id";
            this.materialTextBoxDIVID.LeadingIcon = null;
            this.materialTextBoxDIVID.Location = new System.Drawing.Point(3, 39);
            this.materialTextBoxDIVID.MaxLength = 50;
            this.materialTextBoxDIVID.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDIVID.Multiline = false;
            this.materialTextBoxDIVID.Name = "materialTextBoxDIVID";
            this.materialTextBoxDIVID.Size = new System.Drawing.Size(139, 50);
            this.materialTextBoxDIVID.TabIndex = 3;
            this.materialTextBoxDIVID.Text = "plot1";
            this.materialTextBoxDIVID.TrailingIcon = null;
            // 
            // materialTextBoxPlotWidth
            // 
            this.materialTextBoxPlotWidth.AnimateReadOnly = false;
            this.materialTextBoxPlotWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPlotWidth.Depth = 0;
            this.materialTextBoxPlotWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxPlotWidth.Hint = "Please enter Plot Width";
            this.materialTextBoxPlotWidth.LeadingIcon = null;
            this.materialTextBoxPlotWidth.Location = new System.Drawing.Point(531, 39);
            this.materialTextBoxPlotWidth.MaxLength = 50;
            this.materialTextBoxPlotWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPlotWidth.Multiline = false;
            this.materialTextBoxPlotWidth.Name = "materialTextBoxPlotWidth";
            this.materialTextBoxPlotWidth.Size = new System.Drawing.Size(189, 50);
            this.materialTextBoxPlotWidth.TabIndex = 4;
            this.materialTextBoxPlotWidth.Text = "500";
            this.materialTextBoxPlotWidth.TrailingIcon = null;
            // 
            // materialTextBoxPlotHeight
            // 
            this.materialTextBoxPlotHeight.AnimateReadOnly = false;
            this.materialTextBoxPlotHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPlotHeight.Depth = 0;
            this.materialTextBoxPlotHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxPlotHeight.Hint = "Please enter Plot Height";
            this.materialTextBoxPlotHeight.LeadingIcon = null;
            this.materialTextBoxPlotHeight.Location = new System.Drawing.Point(726, 39);
            this.materialTextBoxPlotHeight.MaxLength = 50;
            this.materialTextBoxPlotHeight.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPlotHeight.Multiline = false;
            this.materialTextBoxPlotHeight.Name = "materialTextBoxPlotHeight";
            this.materialTextBoxPlotHeight.Size = new System.Drawing.Size(189, 50);
            this.materialTextBoxPlotHeight.TabIndex = 5;
            this.materialTextBoxPlotHeight.Text = "400";
            this.materialTextBoxPlotHeight.TrailingIcon = null;
            // 
            // materialTextBoxYstep
            // 
            this.materialTextBoxYstep.AnimateReadOnly = false;
            this.materialTextBoxYstep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxYstep.Depth = 0;
            this.materialTextBoxYstep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxYstep.Hint = "Please enter Ystep";
            this.materialTextBoxYstep.LeadingIcon = null;
            this.materialTextBoxYstep.Location = new System.Drawing.Point(392, 39);
            this.materialTextBoxYstep.MaxLength = 50;
            this.materialTextBoxYstep.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxYstep.Multiline = false;
            this.materialTextBoxYstep.Name = "materialTextBoxYstep";
            this.materialTextBoxYstep.Size = new System.Drawing.Size(133, 50);
            this.materialTextBoxYstep.TabIndex = 6;
            this.materialTextBoxYstep.Text = "0.01";
            this.materialTextBoxYstep.TrailingIcon = null;
            // 
            // ckbCL
            // 
            this.ckbCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbCL.AutoSize = true;
            this.ckbCL.Depth = 0;
            this.ckbCL.Location = new System.Drawing.Point(0, 538);
            this.ckbCL.Margin = new System.Windows.Forms.Padding(0);
            this.ckbCL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbCL.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbCL.Name = "ckbCL";
            this.ckbCL.ReadOnly = false;
            this.ckbCL.Ripple = true;
            this.ckbCL.Size = new System.Drawing.Size(54, 37);
            this.ckbCL.TabIndex = 7;
            this.ckbCL.Text = "CL";
            this.ckbCL.UseVisualStyleBackColor = true;
            // 
            // ckbUSL
            // 
            this.ckbUSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbUSL.AutoSize = true;
            this.ckbUSL.Depth = 0;
            this.ckbUSL.Location = new System.Drawing.Point(148, 538);
            this.ckbUSL.Margin = new System.Windows.Forms.Padding(0);
            this.ckbUSL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbUSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbUSL.Name = "ckbUSL";
            this.ckbUSL.ReadOnly = false;
            this.ckbUSL.Ripple = true;
            this.ckbUSL.Size = new System.Drawing.Size(64, 37);
            this.ckbUSL.TabIndex = 8;
            this.ckbUSL.Text = "USL";
            this.ckbUSL.UseVisualStyleBackColor = true;
            // 
            // ckbLSL
            // 
            this.ckbLSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbLSL.AutoSize = true;
            this.ckbLSL.Depth = 0;
            this.ckbLSL.Location = new System.Drawing.Point(313, 538);
            this.ckbLSL.Margin = new System.Windows.Forms.Padding(0);
            this.ckbLSL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbLSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbLSL.Name = "ckbLSL";
            this.ckbLSL.ReadOnly = false;
            this.ckbLSL.Ripple = true;
            this.ckbLSL.Size = new System.Drawing.Size(63, 37);
            this.ckbLSL.TabIndex = 9;
            this.ckbLSL.Text = "LSL";
            this.ckbLSL.UseVisualStyleBackColor = true;
            // 
            // txtLSL
            // 
            this.txtLSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLSL.AnimateReadOnly = false;
            this.txtLSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLSL.Depth = 0;
            this.txtLSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLSL.LeadingIcon = null;
            this.txtLSL.Location = new System.Drawing.Point(379, 518);
            this.txtLSL.MaxLength = 50;
            this.txtLSL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLSL.Multiline = false;
            this.txtLSL.Name = "txtLSL";
            this.txtLSL.Size = new System.Drawing.Size(95, 50);
            this.txtLSL.TabIndex = 10;
            this.txtLSL.Text = "0";
            this.txtLSL.TrailingIcon = null;
            // 
            // txtUSL
            // 
            this.txtUSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUSL.AnimateReadOnly = false;
            this.txtUSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUSL.Depth = 0;
            this.txtUSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUSL.LeadingIcon = null;
            this.txtUSL.Location = new System.Drawing.Point(215, 518);
            this.txtUSL.MaxLength = 50;
            this.txtUSL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUSL.Multiline = false;
            this.txtUSL.Name = "txtUSL";
            this.txtUSL.Size = new System.Drawing.Size(95, 50);
            this.txtUSL.TabIndex = 11;
            this.txtUSL.Text = "0";
            this.txtUSL.TrailingIcon = null;
            // 
            // txtCL
            // 
            this.txtCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCL.AnimateReadOnly = false;
            this.txtCL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCL.Depth = 0;
            this.txtCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCL.LeadingIcon = null;
            this.txtCL.Location = new System.Drawing.Point(57, 518);
            this.txtCL.MaxLength = 50;
            this.txtCL.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCL.Multiline = false;
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(95, 50);
            this.txtCL.TabIndex = 12;
            this.txtCL.Text = "0";
            this.txtCL.TrailingIcon = null;
            // 
            // webView21
            // 
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(496, 106);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(437, 407);
            this.webView21.Source = new System.Uri("files://index.html", System.UriKind.Absolute);
            this.webView21.TabIndex = 13;
            this.webView21.ZoomFactor = 1D;
            // 
            // plot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.txtCL);
            this.Controls.Add(this.txtUSL);
            this.Controls.Add(this.txtLSL);
            this.Controls.Add(this.ckbLSL);
            this.Controls.Add(this.ckbUSL);
            this.Controls.Add(this.ckbCL);
            this.Controls.Add(this.materialTextBoxYstep);
            this.Controls.Add(this.materialTextBoxPlotHeight);
            this.Controls.Add(this.materialTextBoxPlotWidth);
            this.Controls.Add(this.materialTextBoxDIVID);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialTextBoxPlotName);
            this.Name = "plot";
            this.Size = new System.Drawing.Size(936, 575);
            this.Load += new System.EventHandler(this.plot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPlotName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDIVID;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPlotWidth;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPlotHeight;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxYstep;
        private MaterialSkin.Controls.MaterialCheckbox ckbCL;
        private MaterialSkin.Controls.MaterialCheckbox ckbUSL;
        private MaterialSkin.Controls.MaterialCheckbox ckbLSL;
        private MaterialSkin.Controls.MaterialTextBox txtLSL;
        private MaterialSkin.Controls.MaterialTextBox txtUSL;
        private MaterialSkin.Controls.MaterialTextBox txtCL;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
