using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class WinForm : IPage
    {
        public void BuildPage()
        {
            Console.WriteLine("WinForm Oluşturuldu");
        }
    }
    
    public class WinFormComponent : IComponent
    {
        public void BuildComponent() { 
        Console.WriteLine("WinForm textbox oluşturuldu");
        Console.WriteLine("WinForm label oluşturuldu");
        }
    }
}
