using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Keyboard
{
    public partial class Keyboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ICollection<Button> buttonsLayout = new List<Button>();
            for (char current = 'a'; current <= 'z'; current++)
            {
                Button currentBtn = new Button();
                currentBtn.Text = current.ToString();
                currentBtn.Click += addToText;
                currentBtn.Width = 100;
                currentBtn.Height = 100;
                currentBtn.ID = current.ToString();
                Btns.Controls.Add(currentBtn);
                currentBtn.Visible = true;
                currentBtn.BackColor = Color.AliceBlue;
                buttonsLayout.Add(currentBtn);
            }

        }

        private void addToText(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            Text.Text += btn.Text;
        }

        protected void Text_Load(object sender, EventArgs e)
        {

        }
    }
}