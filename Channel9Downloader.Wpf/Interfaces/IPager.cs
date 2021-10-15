using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Wpf.Interfaces
{
    public interface IPager
    {
        event Action<string> PageChanged;

        void ChangePage(string pageName, params object[] args);

        void OpenFlyoutPage(string pageName, params object[] args);

        void CloseFlyout();

        void GoBack();
    }
}