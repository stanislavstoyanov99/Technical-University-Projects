using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Assembly assembly = Assembly.LoadFile(openFileDialog.FileName);

                foreach (Type type in assembly.GetTypes())
                {
                    listBox.Items.Add(type);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secondListbox.Items.Clear();
            var selType = listBox.SelectedItem as Type;

            foreach (var m in selType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic 
                | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                secondListbox.Items.Add(m);
            }
        }

        private void secondListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thirdListbox.Items.Clear();
            var selMethod = secondListbox.SelectedItem as MethodInfo;

            foreach (var m in selMethod.GetParameters())
            {
                thirdListbox.Items.Add(m);
            }
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            var objType = listBox.SelectedItem as Type;

            var obj = Activator.CreateInstance(objType);

            var methodInfo = secondListbox.SelectedItem as MethodInfo;

            methodInfo.Invoke(obj, new object[] { 5, 6});
        }
    }
}
