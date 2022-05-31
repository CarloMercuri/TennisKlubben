using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TennisKlubben.Data;

namespace TennisKlubben.Klub
{
    public partial class Register : System.Web.UI.Page
    {
        InputControl inputControl = new InputControl();

        private int birthDay
        {
            get { return Int32.Parse(input_Day.SelectedItem.Value); }
        }
        private int birthMonth
        {
            get { return Int32.Parse(input_Month.SelectedItem.Value); }
        }

        private int birthYear
        {
            get { return Int32.Parse(input_Year.SelectedItem.Value); }
        }

        public DateTime SelectedBirthDate
        {
            get
            {
                try
                {
                    return new DateTime(this.birthYear, this.birthMonth, this.birthDay);
                }
                catch
                {
                    return DateTime.MinValue;
                }
            }          
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PopulateYear();
                this.PopulateMonth();
                this.PopulateDay();
                div_CC.Visible = false;
            }
            else
            {
                PopulateDay();

                int age = CalculateAge();

                if(age >= 18)
                {
                    div_CC.Visible = true;
                }
                else
                {
                    div_CC.Visible = false;
                }

            }

      
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            bool ok = CheckInputs();
        }

        private bool CheckInputs()
        {
            bool allValid = true;

            //
            // First Name
            //

            if (input_FirstName.Text.Length < 1)
            {
                warning_FirstName.Visible = true;
                allValid = false;
            }

            if (input_LastName.Text.Length < 1)
            {
                warning_LastName.Visible = true;
                allValid = false;
            }

            if (input_Address.Text.Length < 3)
            {
                warning_Address.Visible = true;
                allValid = false;
            }

            if (input_PhoneNumber.Text.Length < 5)
            {
                warning_PhoneNumber.Visible = true;
                allValid = false;
            }

            if (input_CC_Owner.Text.Length < 3)
            {
                warning_CC_Owner.Visible = true;
                allValid = false;
            }

            if (CalculateAge() < 18)
            {
                return allValid;
            }

            if (!inputControl.IsCreditCardNumberValid(input_CC_Number.Text))
            {
                warning_CardNumber.Visible = true;
                allValid = false;
            }

            if(input_CC_Owner.Text.Length < 4)
            {
                warning_CC_Owner.Visible = true;
                allValid = false;
            }

            if(!inputControl.IsOnlyNumbers(input_CC_ExpDay.Text) || Int32.Parse(input_CC_ExpDay.Text) > 31)
            {
                allValid = false;   
            }

            if(!inputControl.IsOnlyNumbers(input_CC_ExpMonth.Text) || Int32.Parse(input_CC_ExpMonth.Text) > 12)
            {
                allValid = false;
            }

            return allValid;
        }


        private int CalculateAge()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(SelectedBirthDate.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            return age;
        }

        protected void input_Change(object sender, EventArgs e)
        {

        }

        protected void UpdateDatetime(object sender, EventArgs e)
        {
            PopulateDay();
        }

        private void PopulateDay()
        {
            int selected = input_Day.SelectedItem == null ? 1 : Int32.Parse(input_Day.SelectedItem.Value);
            //Int32.Parse(input_Day.SelectedItem.Value);
            input_Day.Items.Clear();

            int days = DateTime.DaysInMonth(this.birthYear, this.birthMonth);

            for (int i = 1; i <= days; i++)
            {
                ListItem lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                input_Day.Items.Add(lt);
            }

            // Select the last selected day, unless it's higher than the selected month's max days, in which case
            // set it to that value
            input_Day.Items.FindByValue(selected > days? days.ToString() : selected.ToString()).Selected = true;
        }

        private void PopulateMonth()
        {
            input_Month.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                ListItem lt = new ListItem();
                string monthText = new DateTime(2010, i, 1).ToString("MMMM");
                monthText = char.ToUpper(monthText[0]) + monthText.Substring(1);
                lt.Text = monthText;
                lt.Value = i.ToString();
                input_Month.Items.Add(lt);
            }

            input_Month.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }

        private void PopulateYear()
        {
            input_Year.Items.Clear();

            for (int i = DateTime.Now.Year; i >= 1930; i--)
            {
                ListItem lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                input_Year.Items.Add(lt);
            }

            input_Year.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }
    }   
}