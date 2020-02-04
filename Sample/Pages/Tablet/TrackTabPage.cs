using System;


namespace Sample.Pages.Tablet
{
    public class TrackTabPage : BaseTrackPage
    {
        public TrackTabPage EnterNumber(String text)
        {
            Enter(EmailEntry, text);
            TakeScreenshot("EnterEmail");

            return this;
        }

        public TrackTabPage TapSubmit()
        {
            Tap(SubmitBtn);
            TakeScreenshot("TapSubmit");

            return this;
        }

        public TrackTabPage CheckAlert()
        {
            CheckElement(Alert);
            TakeScreenshot("Complite");
            return this;
        }
    }
}
