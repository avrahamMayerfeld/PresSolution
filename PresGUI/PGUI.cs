using PresLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        

        private void Submit_Click(object sender, EventArgs e)
        {

            PresFactors person = new PresFactors();
            if (citizen.Checked)
                person.NaturalBornCitizen = true;
            else
                person.NaturalBornCitizen = false;
            //get contents of fields and convert to int for all the following

            person.Age = int.Parse(age.Text);
            person.USResidenceYears = int.Parse(yearsResident.Text);
            person.TimesElected = int.Parse(timesElected.Text);
            //Display result based on input

            presResult.Text = person.ReturnEligibility();

        }
    }
    } 