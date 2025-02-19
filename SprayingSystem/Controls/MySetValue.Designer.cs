namespace SprayingSystem.Controls
{
    partial class MySetValue
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Name = new Sunny.UI.UILabel();
            txt_Value = new Sunny.UI.UITextBox();
            lbl_Unit = new Sunny.UI.UILabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Controls.Add(lbl_Unit, 2, 0);
            tableLayoutPanel1.Controls.Add(txt_Value, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_Name, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(337, 46);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            lbl_Name.Dock = DockStyle.Fill;
            lbl_Name.Font = new Font("宋体", 12F);
            lbl_Name.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Name.Location = new Point(3, 0);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(136, 60);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "参数名称";
            lbl_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Value
            // 
            txt_Value.Dock = DockStyle.Fill;
            txt_Value.Font = new Font("宋体", 12F);
            txt_Value.Location = new Point(146, 5);
            txt_Value.Margin = new Padding(4, 5, 4, 5);
            txt_Value.MinimumSize = new Size(1, 16);
            txt_Value.Name = "txt_Value";
            txt_Value.Padding = new Padding(5);
            txt_Value.ShowText = false;
            txt_Value.Size = new Size(117, 50);
            txt_Value.TabIndex = 2;
            txt_Value.TextAlignment = ContentAlignment.MiddleCenter;
            txt_Value.Watermark = "";
            // 
            // lbl_Unit
            // 
            lbl_Unit.Dock = DockStyle.Fill;
            lbl_Unit.Font = new Font("宋体", 12F);
            lbl_Unit.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Unit.Location = new Point(270, 0);
            lbl_Unit.Name = "lbl_Unit";
            lbl_Unit.Size = new Size(64, 60);
            lbl_Unit.TabIndex = 3;
            lbl_Unit.Text = "单位";
            lbl_Unit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MySetValue
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "MySetValue";
            Size = new Size(337, 46);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UITextBox txt_Value;
        private Sunny.UI.UILabel lbl_Name;
        private Sunny.UI.UILabel lbl_Unit;
    }
}
