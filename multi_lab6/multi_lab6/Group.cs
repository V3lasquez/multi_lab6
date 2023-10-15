using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Group : List<Item>
    {
        public string Title { get; set; }

        public Group(string title)
        {
            Title = title;
        }
    }
}
