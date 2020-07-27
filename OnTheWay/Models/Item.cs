 using System;
using System.Diagnostics;

namespace OnTheWay.Models
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}