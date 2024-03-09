using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkControls
{
    public class IOSStyleCheck : Control
    {
        bool _checked = false;

        public bool Checked { get
            {
                return _checked;
            }
            set
            {
                _checked = value;

                Invalidate();
            }    
        
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
           
            e.Graphics.FillEllipse(new SolidBrush(Color.Tomato), 
                        new Rectangle(0,0,Height-1, Height-1));

            e.Graphics.FillEllipse(new SolidBrush(Color.Tomato),
                        new Rectangle(Width - Height-1, 0,  Height-1, Height-1));

            e.Graphics.FillRectangle(new SolidBrush(Color.Tomato),
                new Rectangle(Height/2, 0, Width - 1 - Height, Height-1));


            if (_checked)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.White),
                            new Rectangle(1, 1, Height - 2, Height - 2));
            }
            else
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.White),
                            new Rectangle(Width - Height-2, 1, Height - 2, Height - 2));
            }

        }
    }
}
