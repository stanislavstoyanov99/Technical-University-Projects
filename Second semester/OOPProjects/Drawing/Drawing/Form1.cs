using ClassLibraryFigures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class FormMain : Form, IGraphics
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private List<Rectangle> rectangles = new List<Rectangle>();

        private List<Rectangle> selectedRectangles = new List<Rectangle>();

        public void DrawRectangle(Color color, int x, int y, int width, int height)
        {
            using (var graphics = CreateGraphics())
            using (var pen = new Pen(color, 2))
            {
                graphics.DrawRectangle(pen, x, y, width, height);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var rectangle in rectangles)
            {
                rectangle.Paint(this);
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Mouse down at x: {e.X} y: {e.Y}");

            // при натиснат десен бутон
            if (e.Button == MouseButtons.Right)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Position = e.Location;
                rectangle.Width = 100;
                rectangle.Height = 100;
                rectangle.Color = Color.Blue;

                // добавяне в списъка с форми
                rectangles.Add(rectangle);

                // получава graphics обект, за да изрисува новата фигура
                // използваме using конструкция, тъй като graphics обекта имплементира IDisposable
                using (var graphics = CreateGraphics())
                {
                    rectangle.Paint(this);
                }
            }
            else if (e.Button == MouseButtons.Left) // при натиснат ляв бутон
            {
                using (var graphics = CreateGraphics())
                {
                    selectedRectangles = RectangleExtension.WhereContains(rectangles, e.Location);

                    // how does it work? - .NET 2.0
                    selectedRectangles = RectangleExtension.Where(rectangles,
                        delegate (Rectangle rectangle)
                        {
                            return rectangle.Contains(e.Location);
                        });

                    // .NET 3.0
                    selectedRectangles = RectangleExtension.Where(rectangles, r => r.Contains(e.Location));

                    // using as extension method
                    selectedRectangles = rectangles.Where(r => r.Contains(e.Location));
                    selectedRectangles = rectangles.WhereContains(e.Location);

                    // LINQ
                    selectedRectangles = rectangles
                        .Where(r => r.Contains(e.Location))
                        .ToList();

                    selectedRectangles = rectangles
                        .Where(r => r.Position.X > e.Location.X)
                        .ToList();

                    foreach (var selectedRectangle in selectedRectangles)
                    {
                        selectedRectangle.Color = Color.Red;
                        selectedRectangle.Paint(this);
                    }
                }
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedRectangles == null)
            {
                return;
            }

            using (var graphics = CreateGraphics())
            {
                foreach (var selectedRectangle in selectedRectangles)
                {
                    selectedRectangle.Color = Color.Blue;
                    selectedRectangle.Paint(this);
                }
            }

            selectedRectangles = null;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            foreach (var rectangle in rectangles)
            {
                rectangles.Remove(rectangle);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (Stream stream = new FileStream("data.db", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, rectangles);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data.db"))
            {
                return;
            }

            IFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream("data.db", FileMode.Open, FileAccess.Read))
            {
                rectangles = (List<Rectangle>)formatter.Deserialize(stream);
            }

            selectedRectangles = rectangles
                .Where(c => c.Color == Color.Red)
                .ToList();
        }
    }
}
