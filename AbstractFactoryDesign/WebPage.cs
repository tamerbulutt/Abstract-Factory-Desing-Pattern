using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
   public class WebPage : IPage
    {
        public void BuildPage()
        {
            Console.WriteLine("Web Sayfası Oluşturuldu.");
        }
    }
    public class WebComponent : IComponent
    {
        public void BuildComponent()
        {
            Console.WriteLine("Web text box oluşturuldu");
            Console.WriteLine("Web label oluşturuldu");
        }
    }
}
