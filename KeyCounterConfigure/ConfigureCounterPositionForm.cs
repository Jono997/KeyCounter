using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCounter
{
    public partial class ConfigureCounterPositionForm : Form
    {
        public Point counter_position;
        private Rectangle monitor;

        public ConfigureCounterPositionForm(Point counter_position, string counter_name)
        {
            this.counter_position = counter_position;

            InitializeComponent();
            OKButton.Text = LocaleDialogue.Get("ok");
            cancelButton.Text = LocaleDialogue.Get("cancel");
            monitor = Screen.PrimaryScreen.Bounds;
            Location = new Point(0, 0);
            Size = new Size(monitor.Width, monitor.Height);
            mainPanel.Width += mainPanel.Width % 2;
            mainPanel.Height += mainPanel.Height % 2;
            mainPanel.Location = new Point((Width - mainPanel.Width) / 2, (Height - mainPanel.Height) / 2);
            exampleLabel.Text = counter_name + ": 000";

            xNumericUpDown.Value = counter_position.X;
            yNumericUpDown.Value = counter_position.Y;
            xNumericUpDown.ValueChanged += xyNumericUpDown_ValueChanged;
            yNumericUpDown.ValueChanged += xyNumericUpDown_ValueChanged;
        }

        private void xyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            coordinatePanel.Refresh();
            exampleLabel.Location = new Point(Convert.ToInt32(xNumericUpDown.Value), Convert.ToInt32(yNumericUpDown.Value));
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            counter_position = new Point(Convert.ToInt32(xNumericUpDown.Value), Convert.ToInt32(yNumericUpDown.Value));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void coordinatePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RectangleF bounds = g.VisibleClipBounds;
            decimal x_scale = Convert.ToDecimal(monitor.Width) / Convert.ToDecimal(bounds.Width);
            decimal y_scale = Convert.ToDecimal(monitor.Height) / Convert.ToDecimal(bounds.Height);
            int x = Convert.ToInt32(xNumericUpDown.Value / x_scale);
            int y = Convert.ToInt32(yNumericUpDown.Value / y_scale);
            Pen pen = new Pen(Brushes.Black);
            g.DrawLine(pen, x, 0, x, bounds.Height);
            g.DrawLine(pen, 0, y, bounds.Width, y);
        }

        private void coordinatePanel_MouseActivity()
        {
            Point p = Cursor.Position;
            Rectangle bounds = coordinatePanel.DisplayRectangle;
            Point location = coordinatePanel.Location;
            location.X += mainPanel.Location.X;
            location.Y += mainPanel.Location.Y;
            decimal x_scale = Convert.ToDecimal(monitor.Width) / Convert.ToDecimal(bounds.Width);
            decimal y_scale = Convert.ToDecimal(monitor.Height) / Convert.ToDecimal(bounds.Height);
            decimal x = Convert.ToDecimal((p.X - 1 - location.X) * x_scale);
            decimal y = Convert.ToDecimal((p.Y - 1 - location.Y) * y_scale);
            xNumericUpDown.Value = x;
            yNumericUpDown.Value = y;
        }

        private void coordinatePanel_Click(object sender, EventArgs e)
        {
            coordinatePanel_MouseActivity();
        }

        private void coordinatePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                coordinatePanel_MouseActivity();
        }
    }
}
