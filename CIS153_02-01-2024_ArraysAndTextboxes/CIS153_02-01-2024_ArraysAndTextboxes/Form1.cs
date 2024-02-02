using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_02_01_2024_ArraysAndTextboxes
{
    public partial class Form1 : Form
    {
        private String[] names = new string[5];
        private int namesCnt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addName_Click(object sender, EventArgs e)
        {
            String name;
            name = txt_name.Text;
            if (txt_name.Text != "")
            {

                lbl_error.Visible = false;
                

                if (namesCnt < names.Length)
                {
                    names[namesCnt] = name;
                }
                else
                {
                    String[] tempNames = names;
                    names = new string[names.Length + 1];
                    for (int i = 0; i < tempNames.Length; i++)
                    {
                        names[i] = tempNames[i];
                    }

                    names[namesCnt] = name;
                }
                

                //Clear the text box
                txt_name.Text = "";
                namesCnt++;

                //Tell the user their name was added
                lbl_success.Text = name + " added.";
            }
            else
            {
                //Make the error message visible
                lbl_error.Visible = true;

                //Clear the success label
                lbl_success.Text = "";
            }
            
            ////instead of if statements, we can use a try catch
            //try
            //{
            //    names[namesCnt] = name;
            //}
            //catch(Exception exp)
            //{
            //    //Resize array
            //    //Copy elements
            //}

            ////Add the new name to the array.
        }

        private void btn_displayNames_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Display");
            Console.WriteLine("=======");

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
