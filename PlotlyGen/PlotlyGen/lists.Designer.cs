
namespace PlotlyGen
{
    partial class lists
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
            this.components = new System.ComponentModel.Container();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTextBoxDataName = new MaterialSkin.Controls.MaterialTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.BackColor = System.Drawing.Color.White;
            this.ListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Location = new System.Drawing.Point(0, 60);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(230, 284);
            this.ListBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 52);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItem1.Text = "Paste";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItem2.Text = "Clear";
            // 
            // materialTextBoxDataName
            // 
            this.materialTextBoxDataName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxDataName.AnimateReadOnly = false;
            this.materialTextBoxDataName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDataName.Depth = 0;
            this.materialTextBoxDataName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDataName.Hint = "data name";
            this.materialTextBoxDataName.LeadingIcon = null;
            this.materialTextBoxDataName.Location = new System.Drawing.Point(0, 0);
            this.materialTextBoxDataName.MaxLength = 50;
            this.materialTextBoxDataName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDataName.Multiline = false;
            this.materialTextBoxDataName.Name = "materialTextBoxDataName";
            this.materialTextBoxDataName.Size = new System.Drawing.Size(227, 50);
            this.materialTextBoxDataName.TabIndex = 1;
            this.materialTextBoxDataName.Text = "";
            this.materialTextBoxDataName.TrailingIcon = null;
            // 
            // lists
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialTextBoxDataName);
            this.Controls.Add(this.ListBox1);
            this.Name = "lists";
            this.Size = new System.Drawing.Size(230, 344);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public MaterialSkin.Controls.MaterialTextBox materialTextBoxDataName;
    }
}
