using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Xaml.Media.Imaging;

namespace BackgroundTask
{
    public sealed class MyBackgroundTask: XamlRenderingBackgroundTask
    {
        protected override void OnRun(IBackgroundTaskInstance taskInstance)
        {
            base.OnRun(taskInstance);
        }
    }
}
