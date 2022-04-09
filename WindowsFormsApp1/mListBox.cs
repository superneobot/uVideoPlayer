using System.Drawing;
using System.Windows.Forms;

namespace uPlayer
{
    public partial class mListBox : ListBox
    {
        Font font = new Font("Motiva Sans", 10f, FontStyle.Regular, GraphicsUnit.Point);
        public mListBox()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.Selectable, true);
            this.BackColor = Color.FromArgb(70, 77, 95);
            this.ForeColor = Color.AliceBlue;
            this.BorderStyle = BorderStyle.None;
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.ScrollAlwaysVisible = false;
            HorizontalScrollbar = false;
            this.ItemHeight = 30;

        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            e.ItemHeight = 30;
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // Перерисовываем фон всех элементов ListBox.
            e.DrawBackground();

            if (e.Index >= Items.Count || e.Index <= -1)
                return;

            object item = Items[e.Index];
            if (item == null)
                return;

            string text = item.ToString();
            SizeF stringSize = e.Graphics.MeasureString(text, Font);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.DrawRectangle(new Pen(SystemColors.ActiveCaption), e.Bounds);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ActiveCaption), e.Bounds);
                e.Graphics.DrawString(text, font, new SolidBrush(Color.Black),
                    new PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2));
            }
            else
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(70, 77, 95)), e.Bounds);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(70, 77, 95)), e.Bounds);
                e.Graphics.DrawString(text, font, Brushes.Black,
                    new PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2));
            }
            e.DrawFocusRectangle();

            //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(70, 77, 95)), e.Bounds);
            e.Graphics.DrawString(text, font, new SolidBrush(Color.Black),
                new PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2));
        }
    }
}
