using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
   public class GenerateWinFormScreen : AbstractGenerateScreen
    {
        public override IPage CreatePage()
        {
            return new WinForm();
        }
        public override IComponent CreateComponent()
        {
            return new WinFormComponent();
        }
    }
}
