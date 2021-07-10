using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
   public class PanelGenerator
    {
        private AbstractGenerateScreen _abstractGenerateScreen;
        private IPage _page;
        private IComponent _component;
        
        public PanelGenerator(AbstractGenerateScreen abstractGenerateScreen)
        {
            _abstractGenerateScreen = abstractGenerateScreen;
            _page = _abstractGenerateScreen.CreatePage();
            _component = _abstractGenerateScreen.CreateComponent();
        }

        public void BuildPanel()
        {
            _page.BuildPage();
            _component.BuildComponent();
        }
    }
}
