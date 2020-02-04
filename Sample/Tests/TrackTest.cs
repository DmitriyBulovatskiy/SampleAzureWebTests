using Sample.Tests.Desktop;
using Sample.Tests.Mobile;
using Sample.Tests.Tablet;
using Sample.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.Tests
{
    [TestClass]
    public class TrackTest
    {
        
        
        [TestMethod]
        public void Track()
        {
            new TrackDesTest().TrackTest();
            new TrackMobTest().TrackTest();
            new TrackTabTest().TrackTest();

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            new AppManager().SendMail();
        }
    }
}
