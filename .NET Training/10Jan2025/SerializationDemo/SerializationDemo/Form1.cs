using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
// For XML
using System.Xml.Serialization;
// For SOAP
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ClearAllTextBoxes()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();

                }
            }
        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmpID.Text);
            emp1.Name = txtEmpName.Text;
            emp1.Salary = Convert.ToInt32(txtEmpSalary.Text);

            // Binary Serialization Below
            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\BinSerialize.bin",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);
            fs.Close();

            ClearAllTextBoxes();

            MessageBox.Show("Record Added...");

        }

        private void btnBinUnserialize_Click(object sender, EventArgs e)
        {
            // Deserialization here
            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);

            txtEmpID.Text = emp1.EmpID.ToString();
            txtEmpName.Text = emp1.Name;
            txtEmpSalary.Text = emp1.Salary.ToString();

            fs.Close();

        }

        private void btnXmlSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmpID.Text);
            emp1.Name = txtEmpName.Text;
            emp1.Salary = Convert.ToInt32(txtEmpSalary.Text);

            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);

            ClearAllTextBoxes();

            fs.Close();
        }

        private void btnXmlDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            Employee emp1 = (Employee)xs.Deserialize(fs);

            txtEmpID.Text = emp1.EmpID.ToString();
            txtEmpName.Text = emp1.Name;
            txtEmpSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }

        private void btnSoapSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = Convert.ToInt32(txtEmpID.Text);
            emp1.Name = txtEmpName.Text;
            emp1.Salary = Convert.ToInt32(txtEmpSalary.Text);

            // SOAP Serialization Below
            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\SOAPSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);
            fs.Close();

            ClearAllTextBoxes();

            MessageBox.Show("Record Added...");
        }

        private void btnSoapDeserialize_Click(object sender, EventArgs e)
        {
            // Deserialization here
            FileStream fs = new FileStream(@"D:\MyData\Capgemini\Training\.NET Training\10Jan2025\SerializationDemo\SOAPSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);

            txtEmpID.Text = emp1.EmpID.ToString();
            txtEmpName.Text = emp1.Name;
            txtEmpSalary.Text = emp1.Salary.ToString();

            fs.Close();
        }
    }
}
