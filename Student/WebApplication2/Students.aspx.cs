using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{   
    public partial class Students : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {   
            List<Student> studentList = CreateStudentList();
            // checks whether the page is being loaded in response to a client postback, or if it is being loaded and accessed for the first time.
            if (!this.IsPostBack)
            {
                //Binding data on the drop list
                this.DropDownList1.DataSource = studentList;
                this.DropDownList1.DataTextField = "FirstName";
                this.DropDownList1.DataValueField = "Id";
                this.DropDownList1.DataBind();
            }
            

            
        }
        // A method having a list of students
        public static List<Student> CreateStudentList()
        {   // Adding data to the student list
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student("Ayesha", "Hamid", "Lahore", 1));
            studentList.Add(new Student("Ahmed", "Ayesha", "Sahiwal", 2));
            studentList.Add(new Student("Ali", "Ahmed", "Multan", 3));
            studentList.Add(new Student("Ayesha", "Ali", "Sahiwal", 4));
            studentList.Add(new Student("Hamza", "Hassan", "Lahore", 5));
            studentList.Add(new Student("waqas", "Hamza", "Multan", 6));
            studentList.Add(new Student("Bilal", "waqas", "Sahiwal", 7));
            studentList.Add(new Student("Umair", "Bilal", "Lahore", 8));
            studentList.Add(new Student("babar", "Umair", "Multan", 9));
            studentList.Add(new Student("Misbah", "babar", "Sahiwal", 10));
            studentList.Add(new Student("Younis", "Misbah", "Lahore", 11));
            studentList.Add(new Student("Shaheen", "Younis", "Multan", 12));
            studentList.Add(new Student("Abdullah", "Shaheen", "Lahore", 13));
            studentList.Add(new Student("Suits", "Abdullah", "Sahiwal", 14));
            studentList.Add(new Student("Harvey", "Spector", "Lahore", 15));
            studentList.Add(new Student("Jessica", "Pearson", "Sahiwal", 16));
            studentList.Add(new Student("Mike", "Ross", "Multan", 17));
            studentList.Add(new Student("Donna", "Paulson", "Lahore", 18));

            return studentList;
        }

        [System.Web.Services.WebMethod]
        // Function calling through the ajax on client side
        public static List<string> InformationofStudent (int Id)
        {   
            List<Student> studentList = CreateStudentList();
            List<string> result = new List<string>();
            var studentListLength = studentList.Count;
            for (int i=0;i< studentListLength;i++)
            {   // checking and sending data into a list to access on the client side through ajax
                if (studentList[i].Id == Id)
                {
                    result.Add(studentList[i].Id.ToString());
                    result.Add(studentList[i].FirstName);
                    result.Add(studentList[i].LastName);
                    result.Add(studentList[i].City);
                }
            }
            return result;
        }


    }
}