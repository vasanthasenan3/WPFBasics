using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDesigning
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<String> skills = new List<String>();
            if (chkcpp.IsChecked == true)
                skills.Add("C++");
            if (chkhtml.IsChecked == true)
                skills.Add("HTML");
            if (chkpython.IsChecked == true)
                skills.Add("Python");
            if (chkjava.IsChecked == true)
                skills.Add("Java");

            string gender = " ";
            if (rbmale.IsChecked == true)
                gender = "Male";
            if (rbfemale.IsChecked == true)
                gender = "Female";


            ComboBoxItem course = (ComboBoxItem)cmbcourse.SelectedItem;
            string selectedcourse = "";
            if (course != null)
            {
                selectedcourse = course.Content.ToString();
            }

            string intrests = "";
            foreach (ListBoxItem item in lstintrests.SelectedItems)
            {
                intrests += item.Content.ToString() + ",";
            }
            ArrayList studentdetails = new ArrayList();
            studentdetails.Add(txtname.Text);
            studentdetails.Add(gender);
            studentdetails.Add(selectedcourse);

            Hashtable studentrecord = new Hashtable();
            studentrecord.Add(101, txtname.Text);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Student Details---");
            sb.AppendLine();
            sb.AppendLine("Name:" + txtname.Text);
            sb.AppendLine("Course:" + selectedcourse);
            sb.AppendLine("Intrests:" + intrests);
            sb.AppendLine("Gender:" + gender);
            sb.AppendLine();
            sb.AppendLine("Skills:");
            foreach (string skill in skills)
            {
                sb.AppendLine(skill);
            }
            sb.AppendLine();

            sb.AppendLine("Student ID:101");
            sb.AppendLine("Student Name:" + studentrecord[101]);
            MessageBox.Show(sb.ToString());

        }
    }
}
