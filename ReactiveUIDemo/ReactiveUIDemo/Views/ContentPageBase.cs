using ReactiveUI.XamForms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIDemo.Views
{
    public class ContentPageBase<TViewModel> : ReactiveContentPage<TViewModel> where TViewModel : class
    {
    }
}
