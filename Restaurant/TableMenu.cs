using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;

using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TableMenu : Form
    {
        const double price_Fries = 1.99;
        const double price_Salad = 1.99;
        const double price_Onionrings = 2.99;
        const double price_Hamburger = 3.99;
        const double price_Cheesandwich = 3.99;
        const double price_Chickensandwich = 3.99;
        const double price_Chickenwings = 2.99;
        //dersert
        const double price_Hashbrowns = 2.99;
        const double price_Tostedbegel = 2.99;
        const double price_Pancake = 2.99;
        const double price_Chocolatemuffin = 2.99;
        const double price_Pineapplesticks = 2.99;
        //Drinks
        const double price_Tea = 1.99;
        const double price_Coffee = 1.99;
        const double price_Water = 0.99;
        const double price_Orangejuice = 2.99;
        //cool
        const double price_Vanillacone = 0.99;
        const double price_Vanillashake = 1.99;
        const double price_Straberryshake = 1.99;
        const double price_Chocolatemilkshake = 2.99;
        //payment
        const double taxrate = 0.99;
        double iTax, isubTotal, total;



        public TableMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOnionRings.Checked == true)
            {
                txtOnionRings.Enabled = true;
                txtOnionRings.Focus();
                txtOnionRings.Text = "";

            }
            else
            {
                txtOnionRings.Enabled = false;
                //txtFries.Focus();
                txtOnionRings.Text = "";

            }
        }

        private void TableMenu_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(" select item");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card");
            Enabletextboxest();
            comboBox1.Enabled = false;


        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChickenWings.Checked == true)
            {
                txtChickenWings.Enabled = true;
                txtChickenWings.Focus();
                txtChickenWings.Text = "";

            }
            else
            {
                txtChickenWings.Enabled = false;
                //txtFries.Focus();
                txtChickenWings.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVanillaShake_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOrange.Checked == true)
            {
                txtOrangeJuice.Enabled = true;
                txtOrangeJuice.Focus();
                txtOrangeJuice.Text = "";

            }
            else
            {
                txtOrangeJuice.Enabled = false;
                //txtFries.Focus();
                txtOrangeJuice.Text = "";

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult icancel;
            icancel = MessageBox.Show("confirm you want to cancel the order","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           
            if(icancel== DialogResult.Yes)
            {
                Application.Exit();
            }


        }
        private void resttextboxest()
        {


            Action<Control.ControlCollection> restfunction = null;

            restfunction = (controls) =>
            {
                foreach (Control conrol in controls)
                {
                    if (conrol is TextBox)
                        (conrol as TextBox).Text = "0";
                    else
                        restfunction(conrol.Controls);

                }

            };
            restfunction(Controls);
         }
        private void restCheckbox()
        {


            Action<Control.ControlCollection> restcheckboxfunction = null;

            restcheckboxfunction = (controls) =>
            {
                foreach (Control conrol in controls)
                {
                    if (conrol is CheckBox)
                        (conrol as CheckBox).Checked=false;
                    else
                        restcheckboxfunction(conrol.Controls);

                }

            };
            restcheckboxfunction(Controls);
        }
        //================================disable All Textbos===============
        private void Enabletextboxest()
        {


            Action<Control.ControlCollection> enablefunction = null;

            enablefunction = (controls) =>
            {
                foreach (Control conrol in controls)
                {
                    if (conrol is TextBox)
                        (conrol as TextBox).Enabled=false;
                    else
                        enablefunction(conrol.Controls);

                }

            };
            enablefunction(Controls);
        }
        //========================end disable textbox funtion==============
        private void btnReset_Click(object sender, EventArgs e)
        {
            resttextboxest();
            restCheckbox();
        }

        private void checkFries_CheckedChanged(object sender, EventArgs e)
        {
            if(checkFries.Checked==true)
            {
                txtFries.Enabled = true;
                txtFries.Focus();
                txtFries.Text = "";

            }
            else
            {
                txtFries.Enabled = false;
                //txtFries.Focus();
                txtFries.Text = "";

            }
        }

        private void checkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSalad.Checked == true)
            {
                txtSalad.Enabled = true;
                txtSalad.Focus();
                txtSalad.Text = "";

            }
            else
            {
                txtSalad.Enabled = false;
                //txtFries.Focus();
                txtSalad.Text = "";

            }
        }

        private void checkHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHamBurger.Checked == true)
            {
                txtHamBurger.Enabled = true;
                txtHamBurger.Focus();
                txtHamBurger.Text = "";

            }
            else
            {
                txtHamBurger.Enabled = false;
                //txtFries.Focus();
                txtHamBurger.Text = "";

            }
        }

        private void checkCheeseSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCheeseSandwich.Checked == true)
              {
                txtCheeseSandwich.Enabled = true;
                txtCheeseSandwich.Focus();
                txtCheeseSandwich.Text = "";

              }
            else
            {
                txtCheeseSandwich.Enabled = false;
                //txtFries.Focus();
                txtCheeseSandwich.Text = "";

            }
        }

        private void checkChickenSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChickenSandwich.Checked == true)
            {
                txtChickenSandwich.Enabled = true;
                txtChickenSandwich.Focus();
                txtChickenSandwich.Text = "";

            }
            else
            {
                txtChickenSandwich.Enabled = false;
                //txtFries.Focus();
                txtChickenSandwich.Text = "";

            }

        }

        private void checkHashBrowns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHashBrowns.Checked == true)
            {
                txtHashBrowns.Enabled = true;
                txtHashBrowns.Focus();
                txtHashBrowns.Text = "";

            }
            else
            {
                txtHashBrowns.Enabled = false;
                //txtFries.Focus();
                txtHashBrowns.Text = "";

            }
        }

        private void checkToastedBagel_CheckedChanged(object sender, EventArgs e)
        {

            if (checkToastedBagel.Checked == true)
            {
                txtToastedBagel.Enabled = true;
                txtToastedBagel.Focus();
                txtToastedBagel.Text = "";

            }
            else
            {
                txtToastedBagel.Enabled = false;
                //txtFries.Focus();
                txtToastedBagel.Text = "";

            }
        }

        private void checkPancake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPancake.Checked == true)
            {
                txtPancakes.Enabled = true;
                txtPancakes.Focus();
                txtPancakes.Text = "";

            }
            else
            {
                txtPancakes.Enabled = false;
                //txtFries.Focus();
                txtPancakes.Text = "";

            }
        }

        private void checkchocolatemuffin_CheckedChanged(object sender, EventArgs e)
        {

            if (checkchocolatemuffin.Checked == true)
            {
                txtchocolatemuffin.Enabled = true;
                txtchocolatemuffin.Focus();
                txtchocolatemuffin.Text = "";

            }
            else
            {
                txtchocolatemuffin.Enabled = false;
                //txtFries.Focus();
                txtchocolatemuffin.Text = "";

            }
        }

        private void checkPineappleSticks_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPineappleSticks.Checked == true)
            {
                txtPineappleSticks.Enabled = true;
                txtPineappleSticks.Focus();
                txtPineappleSticks.Text = "";

            }
            else
            {
                txtPineappleSticks.Enabled = false;
                //txtFries.Focus();
                txtPineappleSticks.Text = "";

            }
        }

        private void checkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTea.Checked == true)
            {
                txtTea.Enabled = true;
                txtTea.Focus();
                txtTea.Text = "";

            }
            else
            {
                txtTea.Enabled = false;
                //txtFries.Focus();
                txtTea.Text = "";

            }
        }

        private void checkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCoffee.Checked == true)
            {
                txtCoffee.Enabled = true;
                txtCoffee.Focus();
                txtCoffee.Text = "";

            }
            else
            {
                txtCoffee.Enabled = false;
                //txtFries.Focus();
                txtCoffee.Text = "";

            }
        }

        private void checkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWater.Checked == true)
            {
                txtWater.Enabled = true;
                txtWater.Focus();
                txtWater.Text = "";

            }
            else
            {
                txtWater.Enabled = false;
                //txtFries.Focus();
                txtWater.Text = "";

            }
        }

        private void checkVanillaCone_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVanillaCone.Checked == true)
            {
                txtVanillaCone.Enabled = true;
                txtVanillaCone.Focus();
                txtVanillaCone.Text = "";

            }
            else
            {
                txtVanillaCone.Enabled = false;
                //txtFries.Focus();
                txtVanillaCone.Text = "";

            }
        }

        private void checVanillaShake_CheckedChanged(object sender, EventArgs e)
        {
            if (checVanillaShake.Checked == true)
            {
                txtVanillaShake.Enabled = true;
                txtVanillaShake.Focus();
                txtVanillaShake.Text = "";

            }
            else
            {
                txtVanillaShake.Enabled = false;
                //txtFries.Focus();
                txtVanillaShake.Text = "";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //double cost, ichenge;


            if (comboBox1.SelectedIndex == 1)
            {
                txtpayment.Enabled = true;
                txtpayment.Focus();
                txtpayment.Text = "";
                //ichenge = Convert.ToDouble(txtpayment.Text);
                //cost = (ichenge - total);
                //txtChange.Text = string.Format("{0:C}", (Convert.ToString(cost)));
            }
            //txtpayment.Text = "";
            else
            {
                txtpayment.Enabled = false;
                txtpayment.Text = "0";
                txtChange.Text = "";

            }
            if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show("Insert card");
                 
            }

                ////payment method//

                /*if (comboBox1.SelectedIndex > 0)
                 //{
                     if (comboBox1.SelectedIndex == 1)
                     {
                         txtpayment.Focus();
                         ichenge = Convert.ToDouble(txtpayment.Text);
                         cost = (ichenge - total);
                         txtChange.Text = string.Format("{0:C", (Convert.ToString(cost)));
                     }
                     else
                     {
                         txtpayment.Enabled = false;
                         txtChange.Enabled = false;

                     }

            //     }//
             }
             else
             {
                 txtpayment.Enabled = false;
                 txtpayment.Text = "0";

             }*/

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
          
 

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //item prices//define here
        private void Payment()
        {
            double[] itemecost = new double[22];
            itemecost[0] = Convert.ToDouble(txtFries.Text) * price_Fries;
            itemecost[1] = Convert.ToDouble(txtSalad.Text) * price_Salad;
            itemecost[2] = Convert.ToDouble(txtOnionRings.Text) * price_Onionrings;
            itemecost[3] = Convert.ToDouble(txtHamBurger.Text) * price_Hamburger;
            itemecost[4] = Convert.ToDouble(txtCheeseSandwich.Text) * price_Cheesandwich;
            itemecost[5] = Convert.ToDouble(txtChickenSandwich.Text) * price_Chickensandwich;
            itemecost[6] = Convert.ToDouble(txtChickenWings.Text) * price_Chickenwings;
            //desert
            itemecost[7] = Convert.ToDouble(txtHashBrowns.Text) * price_Hashbrowns;
            itemecost[8] = Convert.ToDouble(txtToastedBagel.Text) * price_Tostedbegel;
            itemecost[9] = Convert.ToDouble(txtPancakes.Text) * price_Pancake;
            itemecost[10] = Convert.ToDouble(txtchocolatemuffin.Text) * price_Chocolatemuffin;
            itemecost[11] = Convert.ToDouble(txtPineappleSticks.Text) * price_Pineapplesticks;
            //Drink cool

            itemecost[12] = Convert.ToDouble(txtTea.Text) * price_Tea;
            itemecost[13] = Convert.ToDouble(txtCoffee.Text) * price_Coffee;
            itemecost[14] = Convert.ToDouble(txtWater.Text) * price_Water;
            itemecost[15] = Convert.ToDouble(txtOrangeJuice.Text) * price_Orangejuice;
            ///shakes//

            itemecost[16] = Convert.ToDouble(txtVanillaCone.Text) * price_Vanillacone;
            itemecost[17] = Convert.ToDouble(txtVanillaShake.Text) * price_Vanillashake;
            itemecost[18] = Convert.ToDouble(txtStraberrySh.Text) * price_Straberryshake;
            itemecost[19] = Convert.ToDouble(txtChocolateSh.Text) * price_Chocolatemilkshake;
            ////total cal///////
            for (int i = 0; i <= 19; i++)
            {
                isubTotal = isubTotal + itemecost[i];

            }
            txtSubtotal.Text = string.Format("{0:C}", Convert.ToString(isubTotal));
            iTax = (isubTotal * taxrate) / 100;
            txtTax.Text = string.Format("{0:C}", Convert.ToString(iTax));
            total = (isubTotal + iTax);
            txtTotal.Text = string.Format("{0:C}", Convert.ToString(total));
        }

        private void checkout_CheckedChanged(object sender, EventArgs e)
        {
            if(checkout.Enabled==true)
            {
                comboBox1.Enabled = true;


                Payment();

            }
        }

        private void txtpayment_MouseLeave(object sender, EventArgs e)
        {
            double cost, ichenge;

            ichenge = Convert.ToDouble(txtpayment.Text);
            cost = (ichenge - total);
            txtChange.Text = string.Format("{0:C}", (Convert.ToString(cost)));
        }

        private void checkStraberrySh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStraberrySh.Checked == true)
            {
                txtStraberrySh.Enabled = true;
                txtStraberrySh.Focus();
                txtStraberrySh.Text = "";

            }
            else
            {
                txtStraberrySh.Enabled = false;
                //txtFries.Focus();
                txtStraberrySh.Text = "";

            }
        }

        private void checkChocolateSh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChocolateSh.Checked == true)
            {
                txtChocolateSh.Enabled = true;
                txtChocolateSh.Focus();
                txtChocolateSh.Text = "";

            }
            else
            {
                txtChocolateSh.Enabled = false;
                //txtFries.Focus();
                txtChocolateSh.Text = "";

            }
        }
    }
}
