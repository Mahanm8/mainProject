using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using main.BLL;
using main.Entities;

namespace main.UIL
{
    public partial class safhe_khabar : System.Web.UI.Page
    {
        News h = new News();
        protected void Page_Load(object sender, EventArgs e)
        {
                var dataToShow = h.loadfirstnews();
                gridServiceAdmin.DataSource = dataToShow;
                gridServiceAdmin.DataBind();
            
        }
       /* protected void ButtonAdd_Click(object sender, EventArgs e)
        {


            var title = TextBoxtitle.Text.ToString();
            var text = TextBox.Text.ToString();

            var khabar = new khabar();

            khabar.title = title;
            khabar.textbox = text;

            News.AddToDatabase(khabar);

            var dataToShow = h.loadfirstnews();
            gridServiceAdmin.DataSource = dataToShow;
            gridServiceAdmin.DataBind();

        }
        protected void ButtonRemove_Click(object sender, EventArgs e)
        {

            var id = TextBoxidRemove.Text.ToString();

            h.RemoveFromDatabase(id);


            var dataToShow = h.loadfirstnews();
            gridServiceAdmin.DataSource = dataToShow;
            gridServiceAdmin.DataBind();


        }*/

    }
}