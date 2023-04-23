using Avalonia;
using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagram_8_lab.Models.Grids
{
    public abstract class AbstractGrid : AbstractElement
    {
        private double width;
        private Point startPoint;
        private GridStrings gridText;
        private double height;
        
        

        public AbstractGrid()
        {
            GridText = new GridStrings();
            GridText.Attributes = "";
            GridText.Operations = "";
        }

        public Point StartPoint
        {
            get => startPoint;
            set{
                Point oldPoint = StartPoint;
                SetAndRaise(ref startPoint, value);
                if (ChangeStartPoint != null){
                    ChangeStartPointEventArgs args = new ChangeStartPointEventArgs
                    {
                        OldStartPoint = oldPoint,
                        NewStartPoint = StartPoint
                    };
                    ChangeStartPoint(this, args);
                }
            }
        }
        public double Width
        {
            get => width;
            set{
                double oldWidth = Width;
                SetAndRaise(ref width, value);
                if (ChangeHeight != null){
                    ChangeSizeEventArgs args = new ChangeSizeEventArgs
                    {
                        OldSize = oldWidth,
                        NewSize = Width
                    };
                    ChangeWidth(this, args);
                }
            }
        }
        public double Height
        {
            get => height;
            set
            {
                double oldHeight = Height;
                SetAndRaise(ref height, value);
                if (ChangeHeight != null)
                {
                    ChangeSizeEventArgs args = new ChangeSizeEventArgs
                    {
                        OldSize = oldHeight,
                        NewSize = Height
                    };
                    ChangeHeight(this, args);
                }
            }
        }

        public GridStrings GridText
        {
            get => gridText;
            set => SetAndRaise(ref gridText, value);
        }

        public event EventHandler<ChangeStartPointEventArgs> ChangeStartPoint;
        public event EventHandler<ChangeSizeEventArgs> ChangeWidth;
        public event EventHandler<ChangeSizeEventArgs> ChangeHeight;
        
    }
}
