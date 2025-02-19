using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprayingSystem.Controls
{
    public partial class MyCounterButton : UIUserControl
    {
        private UIStyle _style;

        //默认填充颜色，可用于恢复本色
        private Color _defaultFillColor;
        private Color _defaultRectColor;
        public MyCounterButton()
        {
            InitializeComponent();
            this.Load += MyCounterButton_Load;      
        }

        private void MyCounterButton_Load(object? sender, EventArgs e)
        {
            UIExtension.SetStyleManager = (UIStyleManager manager) => { 
                this.btn_Counter.Style = manager.Style;
                _style = manager.Style;
                _defaultFillColor = this.btn_Counter.FillColor;
                _defaultRectColor = this.btn_Counter.RectColor;
            };
        }

        private string buttonName="空运行";
        [Browsable(true)] //向外暴露属性，可以在设计器中设置
        [Category("自定义属性")]
        [Description("按钮名称")]
        public string ButtonName
        {
            get { return buttonName; }
            set { 
                buttonName = value;
                this.btn_Counter.Text = buttonName; 
            }
        }

        private int buttonSymbol;
        [Browsable(true)] //向外暴露属性，可以在设计器中设置
        [Category("自定义属性")]
        [Description("按钮图标")]
        public int ButtonSymbol
        {
            get { return buttonSymbol; }
            set
            {
                buttonSymbol = value;
                this.btn_Counter.Symbol = buttonSymbol;
            }
        }

        private bool buttonState;
        [Browsable(true)] //向外暴露属性，可以在设计器中设置
        [Category("自定义属性")]
        [Description("按钮状态")]
        public bool ButtonState
        {
            get { return buttonState; }
            set
            {
                buttonState = value;
                if (buttonState == true)
                {
                    this.btn_Counter.FillColor = this.btn_Counter.FillPressColor;
                    this.btn_Counter.FillColor2 = this.btn_Counter.FillPressColor;
                    this.RectColor = this.btn_Counter.RectPressColor;
                }
                else
                {
                    //两种情况，切换了主题和未切换主题
                    if (this.btn_Counter.Style != _style)
                    {
                        this.btn_Counter.Style = _style;
                    }
                    else
                    {
                        this.btn_Counter.FillColor = _defaultFillColor;
                        this.btn_Counter.FillColor2 = _defaultFillColor;
                        
                    }
                }
            }
        }

        private string variableName = "";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("获取变量名称")]
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }

    }
}
