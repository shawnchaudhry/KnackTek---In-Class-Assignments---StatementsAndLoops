using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatementsAndLoops
{
    public partial class StatementsAndLoops : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void addAState(object sender, EventArgs e)
        {
            while(ddlStates.Items.Count < 6 && tbStateName.Text.CompareTo("") != 0)
            {
                ddlStates.Items.Add(tbStateName.Text);
                tbStateName.Text = "";
            }

            if(ddlStates.Items.Count == 5)
            {
                Label fullList = new Label();
                fullList.Text = "You can only have 5 items in the list!";
                Page.Controls.Add(fullList);
            }
        }
    }
}