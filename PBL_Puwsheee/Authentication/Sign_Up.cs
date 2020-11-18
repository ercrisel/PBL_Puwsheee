using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.SqlClient;

namespace PBL_Puwsheee
{
    public partial class Sign_Up : Form
    {
        string imageLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Sign_Up()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Log_In login = new Log_In();
            login.Show();
            this.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            PositiveAffirmations pa = new PositiveAffirmations();
            pa.Show();
            this.Close();
        }

        private void confirmpasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Resources");
            string location = filePath + "\\SamplePhoto.png";
            imageLocation = location;
        }
        public static bool isAllLetters(string text)
        {
            bool allLetters = false;
            char[] textCharArray = text.ToCharArray();
            for (int i = 0; i <textCharArray.Length; i++)
            {
                int letter = (int)textCharArray[i];
                //checks if letter lang laman 65-90 caps 97-122 small
                if (letter >= 65 && letter <= 90 || letter>=97 && letter<=122 || letter== 32)
                {
                    allLetters = true;
                }
                else
                {
                    allLetters = false;
                    break;
                }

            }
            return allLetters; 
        }
        private void firstnameTextbox_TextChanged(object sender, EventArgs e)
        {
           // checks if all is letters
           
            if (isAllLetters(firstnameTextbox.Text))
            {
                firstNameCondition.Visible = false;
            }
            if (!isAllLetters(firstnameTextbox.Text) && firstnameTextbox.TextLength != 0)
            {
                firstNameCondition.Visible = true;
            }

        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {
            // if all is letters
            
            if (isAllLetters(lastnameTextbox.Text))
            {
                lastNameCondition.Visible = false;
            }
            if (!isAllLetters(lastnameTextbox.Text) && lastnameTextbox.Text.Length !=0)
            {
                lastNameCondition.Visible = true;
            }
        }

       

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            //checks if it is unique 
            bool uniqueEmail = true;
            string connectionString = "Data Source=DESKTOP-8NV2VQJ;Initial Catalog=Puwshee;Integrated Security=True;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spCheckUniqueEmail", connect);
            SqlParameter parameter = new SqlParameter("@EmailAddress", emailTextbox.Text);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(parameter);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string emailAddress = read["EmailAddress"].ToString();
                if (emailAddress == emailTextbox.Text)
                {
                    uniqueEmail = false;
                    break;
                }

            }
            read.Close();
            connect.Close();
            if (uniqueEmail)
            {
                emailCondition.Visible = false;
            }
            if (!uniqueEmail)
            {
                emailCondition.Visible = true;
            }
            

           
          
            
          
        }

        private void usernameTexbox_TextChanged(object sender, EventArgs e)
        {
            bool uniqueUsername = true;
            string connectionString = "Data Source=DESKTOP-8NV2VQJ;Initial Catalog=Puwshee;Integrated Security=True;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = new SqlCommand("spCheckUniqueUsername", connect);
            SqlParameter parameter = new SqlParameter("@Username", usernameTexbox.Text);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(parameter);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string userName = read["Username"].ToString();
                if (userName == usernameTexbox.Text)
                {
                    uniqueUsername = false;
                    break;
                }

            }
            read.Close();
            connect.Close();
            if (uniqueUsername)
            {
                usernameCondition.Visible = false;
            }
            if (!uniqueUsername)
            {
                usernameCondition.Visible = true;
            }

        }
    }
}
