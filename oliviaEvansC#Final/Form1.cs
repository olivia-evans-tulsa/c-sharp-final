using oliviaEvansC_Final.TCC2023DataSetTableAdapters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Olivia Evans
 * C# Final (Draft), 11/17/24
 * 
 * DESCRIPTION: this form serves as a UI for the underlying SQL framework, as basic as it is.
 * using various filters like campus, year, and offense type, this form will JOIN tables,
 * use WHERE statements (a lot of them), and overall do some heavy lifting to create
 * a new (temporary) table according to user input (to make it look pretty) 
 * for the user to download.
 * 
 * NOTES: i have the sql frame but i need to get my queries running. checklistbox has no
 * easy drag and drop for item filling (rip) so Form1Load is INCOMPLETE. there are
 * several helper functions to reduce repeated code, mostly for clearing/resetting form items.
 * most of the work to be done is SQL RELATED. i'm taking sql rn so it's really not impossibly 
 * hard imo. you can see the beginning of custom query creation in goButton_Click but it's def 
 * in its infancy. I MAY BE CRAZY BUT THIS IS GONNA BE SO COOL IF I DONT RUN OUT OF STEAM
 * 
 * ESTIMATED COMPLETION: 60%
 */

namespace oliviaEvansC_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean allSelected = false;
        Boolean filterByAmt = false;

        // FIXME !!!!!!!!!
        private void Form1_Load(object sender, EventArgs e)
        {
            // dbo.offense.offensetype -> list
            // item by item iteration w stored query????
            // populate checkboxlist items w list
        }

        // unchecks any/all checked item(s) in the offense list box
        private void uncheckAll()
        {
            for (int i = 0; i < offenseListBox.Items.Count; i++)
            {
                offenseListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // unchecks all campus checkboxes
        private void uncheckCampus() 
        {
            neCheckBox.Checked = false;
            seCheckBox.Checked = false;
            westCheckBox.Checked = false;
            metroCheckBox.Checked = false;
        }

        // rechecks all years in year groupbox
        private void recheckYears() 
        { 
            year21CheckBox.Checked = true;
            year22CheckBox.Checked = true;
            year23CheckBox.Checked = true;
        }

        // clears everything in amount groupbox
        private void clearAmt()
        {
            lessThanRadio.Checked = false;
            greaterThanRadio.Checked = false;
            equalRadio.Checked = false;
            amtTextbox.Text = string.Empty;
            filterByAmt = false;
        }

        // checks if any radio button is checked, returns bool
        private Boolean checkRadioStatus() 
        {
            if (lessThanRadio.Checked || greaterThanRadio.Checked || equalRadio.Checked)
            {
                return true;
            }
            return false;
        }

        // FIXME
        // register input and convert to query, open form2
        private void goButton_Click(object sender, EventArgs e)
        {
            string tempstr;
            
            var check = offenseListBox.CheckedItems;

            if (check.Count >= 1)
            {
                string request = "SELECT * FROM [dbo].[Offenses]";

                if (!check.Contains("All") && check.Count == 1) // if "All" is not checked
                {
                    // add each checked item to where clause
                    request += "WHERE ";
                    for (int i = 0; i < check.Count; i++)
                    {
                        tempstr = "(OffenseType = \"";
                        tempstr += check[i].ToString();
                        tempstr += "\") ";
                        if (i != check.Count - 1)
                        {
                            tempstr += " || ";
                        }
                        request += tempstr;
                    }
                }

                request += ";";

                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No offense selected.");
            }
        }

        // I AM A GENIUS FOR THIS NGL. makes "all" item exclusive
        private void offenseListBox_ItemCheck(object sender, ItemCheckEventArgs e) // e sends the object clicked
        {
            // I FORGOT HOW GREAT E IS
            if (e.Index == 0 && e.CurrentValue == CheckState.Unchecked) // if "all" is clicked AND it is NOT ALREADY CHECKED
            {
                uncheckAll();
                allSelected = true;
            }
            else if (e.Index != 0) // else if "all" is NOT being clicked on
            {
                offenseListBox.SetItemCheckState(0, CheckState.Unchecked); // double check that "all" is not checked
                // (and if checked, uncheck "all")
                allSelected = false;
            }
        }

        // click event handler sends to function
        private void clearReportButton_Click(object sender, EventArgs e)
        {
            uncheckAll();
        }

        // calls all "resetting" functions
        private void resetButton_Click(object sender, EventArgs e)
        {
            uncheckAll();
            uncheckCampus();
            recheckYears();
            if (checkRadioStatus())
                clearAmt();
        }

        // click event handler sends to function IF any radio button has been clicked
        private void clearAmtButton_Click(object sender, EventArgs e)
        {
            if (checkRadioStatus())
                clearAmt();
        }

        // set bool on check/uncheck
        private void lessThanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRadioStatus())
                filterByAmt = true;
            else 
                filterByAmt = false;
        }

        // set bool on check/uncheck
        private void greaterThanRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRadioStatus())
                filterByAmt = true;
            else
                filterByAmt = false;
        }

        // set bool on check/uncheck
        private void equalRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRadioStatus())
                filterByAmt = true;
            else
                filterByAmt = false;
        }


        // close ALL forms
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
