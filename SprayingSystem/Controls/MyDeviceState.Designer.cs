namespace SprayingSystem.Controls
{
    partial class MyDeviceState
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
            lbl_StateName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            light_State = new Sunny.UI.UILight();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(light_State, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_StateName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(250, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_StateName
            // 
            lbl_StateName.AutoSize = true;
            lbl_StateName.Dock = DockStyle.Fill;
            lbl_StateName.Location = new Point(3, 0);
            lbl_StateName.Name = "lbl_StateName";
            lbl_StateName.Size = new Size(184, 60);
            lbl_StateName.TabIndex = 0;
            lbl_StateName.Text = "状态名称";
            lbl_StateName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // light_State
            // 
            light_State.Dock = DockStyle.Fill;
            light_State.Font = new Font("宋体", 12F);
            light_State.Location = new Point(193, 3);
            light_State.MinimumSize = new Size(1, 1);
            light_State.Name = "light_State";
            light_State.OffColor = Color.Red;
            light_State.Radius = 54;
            light_State.Size = new Size(54, 54);
            light_State.TabIndex = 2;
            // 
            // MyDeviceState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Name = "MyDeviceState";
            Size = new Size(250, 60);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILight light_State;
        private Label lbl_StateName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
