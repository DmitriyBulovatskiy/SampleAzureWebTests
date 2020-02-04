using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Pages.Desktop
{
    public class MainDesPage : BaseMainPage
    {
        public MainDesPage GoToNumber()
        {
            Tap(base.GoToTrack);
            TakeScreenshot("GoToTrack");
            return this;
        }

        
    }
}
