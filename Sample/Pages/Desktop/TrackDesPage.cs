using System;


namespace Sample.Pages.Desktop
{
    class TrackDesPage : BaseTrackPage
    {
        public TrackDesPage EnterNumber(String text)
        {
            Enter(EmailEntry, text);
            TakeScreenshot("EnterEmail");

            return this;
        }

        public TrackDesPage TapSubmit()
        {
            Tap(SubmitBtn);
            TakeScreenshot("TapSubmit");

            return this;
        }

        public TrackDesPage CheckAlert()
        {
            CheckElement(Alert);
            TakeScreenshot("Complite");
            return this;
        }
    }
}
