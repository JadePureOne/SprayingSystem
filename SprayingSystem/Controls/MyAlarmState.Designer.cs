namespace SprayingSystem.Controls
{
    partial class MyAlarmState
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
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_stateName = new Sunny.UI.UILabel();
            lbl_AlarmState = new Sunny.UI.UISymbolLabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(lbl_stateName, 0, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_AlarmState, 1, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_stateName
            // 
            lbl_stateName.Dock = DockStyle.Fill;
            lbl_stateName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_stateName.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_stateName.Location = new Point(3, 0);
            lbl_stateName.Name = "lbl_stateName";
            lbl_stateName.Size = new Size(184, 60);
            lbl_stateName.TabIndex = 0;
            lbl_stateName.Text = "名称报警";
            lbl_stateName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_AlarmState
            // 
            lbl_AlarmState.Dock = DockStyle.Fill;
            lbl_AlarmState.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_AlarmState.Location = new Point(193, 3);
            lbl_AlarmState.MinimumSize = new Size(1, 1);
            lbl_AlarmState.Name = "lbl_AlarmState";
            lbl_AlarmState.Size = new Size(54, 54);
            lbl_AlarmState.Style = Sunny.UI.UIStyle.Custom;
            lbl_AlarmState.Symbol = 61683;
            lbl_AlarmState.SymbolColor = Color.Red;
            lbl_AlarmState.SymbolSize = 54;
            lbl_AlarmState.TabIndex = 1;
            // 
            // MyAlarmState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "MyAlarmState";
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel lbl_stateName;
        private Sunny.UI.UISymbolLabel lbl_AlarmState;
    }
}
