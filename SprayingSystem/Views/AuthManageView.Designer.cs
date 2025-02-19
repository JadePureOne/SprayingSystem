namespace SprayingSystem
{
    partial class AuthManageView
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
            myCounterButton1 = new Controls.MyCounterButton();
            SuspendLayout();
            // 
            // myCounterButton1
            // 
            myCounterButton1.BackColor = Color.Transparent;
            myCounterButton1.ButtonName = null;
            myCounterButton1.FillColor = Color.Transparent;
            myCounterButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            myCounterButton1.Location = new Point(187, 148);
            myCounterButton1.MinimumSize = new Size(1, 1);
            myCounterButton1.Name = "myCounterButton1";
            myCounterButton1.RectColor = Color.Transparent;
            myCounterButton1.Size = new Size(190, 90);
            myCounterButton1.TabIndex = 0;
            myCounterButton1.Text = "myCounterButton1";
            myCounterButton1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // AuthManageView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(myCounterButton1);
            Name = "AuthManageView";
            Symbol = 362722;
            Text = "权限管理";
            ResumeLayout(false);
        }

        #endregion

        private Controls.MyCounterButton myCounterButton1;
    }
}
