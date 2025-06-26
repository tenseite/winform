using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinButNum
{
    public class ClickButton : Button
    {
        
        public int mClicks;

        
        public int Clicks
        {
            get { return mClicks; }
        }

        
        public ClickButton()
        {
            
           
            
            this.FlatStyle = FlatStyle.Flat;
        }

        
        protected override void OnClick(EventArgs e)
        {
            mClicks++; 
            base.OnClick(e); 

          
            this.Invalidate();
        }

      
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent); 

           
            Graphics g = pevent.Graphics;

           
            SizeF stringSize = g.MeasureString(Clicks.ToString(), this.Font);

            
            g.DrawString(
                Clicks.ToString(),
                this.Font,
                SystemBrushes.ControlText,
                this.Width - stringSize.Width - 5,
                this.Height - stringSize.Height - 5
            );
        }
    }
}