using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace AkzeptanzTests
{
    public class TrackerDriver
    {
        private Process _tracker;
        private string _antwort;

        public void Starte()
        {
            _tracker = Process.Start(new ProcessStartInfo
                                         {
                                             FileName = "NerdGolfTracker.exe",
                                             UseShellExecute = false,
                                             RedirectStandardOutput = true,
                                             RedirectStandardInput = true,
                                             CreateNoWindow = true,
                                         });
            SpeichereAntwort();
        }

        public void Beende()
        {
            if (!_tracker.HasExited)
                _tracker.Kill();
        }

        public void EmpfangeAnweisung(string anweisung)
        {
            _tracker.StandardInput.WriteLine(anweisung);
            SpeichereAntwort();
        }

        private void SpeichereAntwort()
        {
            _antwort = _tracker.StandardOutput.ReadLine();
            while (_tracker.StandardOutput.Peek() >= 0)
                _antwort += System.Environment.NewLine + _tracker.StandardOutput.ReadLine();
        }

        public void AssertThatAntwortContains(string format, params object[] objects)
        {
            StringAssert.Contains(_antwort, string.Format(format, objects));
        }

        public void AssertThatBulletPointsAreProperlyFormated()
        {
            var splittedString = _antwort.Split('*');
            for (int i = 0; i < splittedString.Length - 1; i++)
            {
                Assert.IsTrue(splittedString[i].EndsWith(System.Environment.NewLine+ " "));
            }
        }
    }
}