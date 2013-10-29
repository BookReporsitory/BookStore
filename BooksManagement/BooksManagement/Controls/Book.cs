using System.Drawing;
using System.Windows.Forms;

namespace BooksManagement.Controls
{
    public partial class Book : UserControl
    {
        public Book()
        {
            InitializeComponent();
        }


        private void Book_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Book_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
