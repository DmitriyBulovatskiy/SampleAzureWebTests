using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Pages.Mobile
{
    public class MainMobPage : BaseMainPage
    {
        public MainMobPage GoToNumber()
        {
            Tap(base.GoToTrack);
            TakeScreenshot("GoToTrack");
            return this;
        }

     
    }
}
