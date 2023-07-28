using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetPlayerOne();
        string GetPlayerTwo();
        string GetWebsite();
    }
}
