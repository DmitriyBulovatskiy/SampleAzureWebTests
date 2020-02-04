using System;


namespace Sample.Pages.Mobile
{
    public class TrackMobPage : BaseTrackPage
    {
        public TrackMobPage EnterNumber(String text)
        {
            Enter(EmailEntry, text);
            TakeScreenshot("EnterEmail");

            return this;
        }

        public TrackMobPage TapSubmit()
        {
            Tap(SubmitBtn);
            TakeScreenshot("TapSubmit");

            return this;
        }

        public TrackMobPage CheckAlert()
        {
            CheckElement(Alert);
            TakeScreenshot("Complite");
            return this;
        }
    }
}
