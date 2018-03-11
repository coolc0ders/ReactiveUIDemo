using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIDemo.Model
{
    public class Todo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public bool IsEnabled => !IsDone;
    }
}
