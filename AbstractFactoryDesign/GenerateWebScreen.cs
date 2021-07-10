using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class GenerateWebScreen : AbstractGenerateScreen
    {
        public override IPage CreatePage()
        {
            return new WebPage();
        }
        public override IComponent CreateComponent()
        {
            return new WebComponent();
        }
    }
}
