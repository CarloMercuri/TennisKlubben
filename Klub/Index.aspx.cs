using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TennisKlubben.Data;

namespace TennisKlubben.Klub
{
    public partial class Index : System.Web.UI.Page
    {
        InputControl inputcontrol = new InputControl();

        protected void Page_Load(object sender, EventArgs e)
        {
            label_Membercode_Warning.Visible = false;
        }

        protected void btn_NewUserClick(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx?Type=");
        }

        protected void btn_ExistingUser_Click(object sender, EventArgs e)
        {

        }

        private void SetErrorBorder()
        {
            MemberCodeInputBox.BorderStyle = BorderStyle.Dashed;
            MemberCodeInputBox.BorderWidth = 2;
            MemberCodeInputBox.BorderColor = Color.Red;
        }

        protected void input_Membercode_TextChange(object sender, EventArgs e)
        {
            if (!inputcontrol.IsOnlyNumbers(MemberCodeInputBox.Text))
            {
                SetErrorBorder();
                label_Membercode_Warning.Visible = true;
                label_Membercode_Warning.Text = "Member code must only contain numbers.";

                return;
            }

            if (MemberCodeInputBox.Text.Length != 8)
            {
                SetErrorBorder();
                label_Membercode_Warning.Visible = true;
                label_Membercode_Warning.Text = "Code needs to be 8 numbers long.";
                return;
            }

            // Else, it's all good

            MemberCodeInputBox.BorderStyle = BorderStyle.Dashed;
            MemberCodeInputBox.BorderWidth = 0;
            MemberCodeInputBox.BorderColor = Color.Transparent;
            label_Membercode_Warning.Visible = false;                
     

            Response.Redirect("User.aspx?Id=" + MemberCodeInputBox.Text);
        }
    }
}