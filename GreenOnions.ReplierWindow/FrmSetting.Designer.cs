namespace GreenOnions.ReplierWindow
{
    partial class FrmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvReplies = new System.Windows.Forms.DataGridView();
            this.colMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchMode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTriggerMode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colReplyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReplyMode = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvImages = new System.Windows.Forms.ListView();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvReplies
            // 
            this.dgvReplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReplies.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessage,
            this.colMatchMode,
            this.colTriggerMode,
            this.colReplyValue,
            this.colPriority,
            this.colReplyMode,
            this.colRemove});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReplies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReplies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReplies.GridColor = System.Drawing.Color.Silver;
            this.dgvReplies.Location = new System.Drawing.Point(0, 21);
            this.dgvReplies.Name = "dgvReplies";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReplies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReplies.RowHeadersVisible = false;
            this.dgvReplies.RowTemplate.Height = 25;
            this.dgvReplies.Size = new System.Drawing.Size(944, 510);
            this.dgvReplies.TabIndex = 2;
            this.dgvReplies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReplies_CellContentClick);
            // 
            // colMessage
            // 
            this.colMessage.DataPropertyName = "Message";
            this.colMessage.HeaderText = "触发消息";
            this.colMessage.Name = "colMessage";
            // 
            // colMatchMode
            // 
            this.colMatchMode.DataPropertyName = "MatchMode";
            this.colMatchMode.FillWeight = 80F;
            this.colMatchMode.HeaderText = "匹配模式";
            this.colMatchMode.Items.AddRange(new object[] {
            "完全",
            "包含",
            "前缀",
            "后缀",
            "正则表达式"});
            this.colMatchMode.Name = "colMatchMode";
            // 
            // colTriggerMode
            // 
            this.colTriggerMode.DataPropertyName = "TriggerMode";
            this.colTriggerMode.FillWeight = 80F;
            this.colTriggerMode.HeaderText = "触发模式";
            this.colTriggerMode.Items.AddRange(new object[] {
            "私聊消息",
            "群组消息",
            "私聊/群组消息"});
            this.colTriggerMode.Name = "colTriggerMode";
            // 
            // colReplyValue
            // 
            this.colReplyValue.DataPropertyName = "ReplyValue";
            this.colReplyValue.HeaderText = "回复内容";
            this.colReplyValue.Name = "colReplyValue";
            // 
            // colPriority
            // 
            this.colPriority.DataPropertyName = "Priority";
            this.colPriority.FillWeight = 40F;
            this.colPriority.HeaderText = "优先级";
            this.colPriority.Name = "colPriority";
            // 
            // colReplyMode
            // 
            this.colReplyMode.DataPropertyName = "ReplyMode";
            this.colReplyMode.FillWeight = 60F;
            this.colReplyMode.HeaderText = "以回复方式发送";
            this.colReplyMode.Name = "colReplyMode";
            // 
            // colRemove
            // 
            this.colRemove.FillWeight = 30F;
            this.colRemove.HeaderText = "删除";
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "删除";
            this.colRemove.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 21);
            this.panel1.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(19, 2);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(907, 17);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "提示：插入图片格式：<图片名称.后缀>，例如\"回复测试<测试图片.jpg>\"。优先级：数字越小优先度越高。随机回复：触发消息和优先级均相等时会随机发送一条回复。";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvImages);
            this.panel3.Controls.Add(this.btnAddImage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 150);
            this.panel3.TabIndex = 3;
            // 
            // lvImages
            // 
            this.lvImages.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImages.LargeImageList = this.imageList;
            this.lvImages.Location = new System.Drawing.Point(0, 0);
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(904, 150);
            this.lvImages.TabIndex = 3;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvImages_MouseUp);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddImage.Location = new System.Drawing.Point(904, 0);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(40, 150);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "添加图片";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRemove});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // menuItemRemove
            // 
            this.menuItemRemove.Name = "menuItemRemove";
            this.menuItemRemove.Size = new System.Drawing.Size(100, 22);
            this.menuItemRemove.Text = "删除";
            this.menuItemRemove.Click += new System.EventHandler(this.MenuItemRemove_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.dgvReplies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "自定义回复设置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList;
        private DataGridView dgvReplies;
        private Panel panel1;
        private Panel panel3;
        private Button btnAddImage;
        private Label lblInfo;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem menuItemRemove;
        private ListView lvImages;
        private DataGridViewTextBoxColumn colMessage;
        private DataGridViewComboBoxColumn colMatchMode;
        private DataGridViewComboBoxColumn colTriggerMode;
        private DataGridViewTextBoxColumn colReplyValue;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewCheckBoxColumn colReplyMode;
        private DataGridViewButtonColumn colRemove;
    }
}