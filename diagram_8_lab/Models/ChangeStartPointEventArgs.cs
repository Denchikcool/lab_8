using Avalonia;
using System;

namespace diagram_8_lab.Models
{
    public class ChangeStartPointEventArgs : EventArgs
    {
        public Point NewStartPoint { get; set; }
        public Point OldStartPoint { get; set; }
    }
}
