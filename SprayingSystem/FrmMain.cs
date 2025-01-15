using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sunny.UI;

namespace SprayingSystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        


        public FrmMain()
        {
            InitializeComponent();

        }


        
    }
}