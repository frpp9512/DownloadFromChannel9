using Channel9Downloader.Wpf.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel9Downloader.Wpf.Pages
{
    public class Pager : IPager
    {
        public event Action<string> PageChanged;

        public void ChangePage(string pageName, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void CloseFlyout()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void OpenFlyoutPage(string pageName, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
