using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            int Number = 0;
            //btntextBox-lar

            {

                int btntextBox0 = 0;
                int btntextBox1 = 0;
                int btntextBox2 = 0;
                int btntextBox3 = 0;
                int btntextBox4 = 0;
                int btntextBox5 = 0;
                int btntextBox6 = 0;
                int btntextBox7 = 0;
                int btntextBox8 = 0;
                int btntextBox9 = 0;
                int btntextBox10 = 0;
                int btntextBox11 = 0;
                int btntextBox12 = 0;
                int btntextBox13 = 0;
                int btntextBox14 = 0;
                int btntextBox15 = 0;
                int btntextBox16 = 0;
                int btntextBox17 = 0;
                int btntextBox18 = 0;
                int btntextBox19 = 0;
                int btntextBox20 = 0;
                int btntextBox21 = 0;
                int btntextBox22 = 0;
                int btntextBox23 = 0;
                int btntextBox24 = 0;
                int btntextBox25 = 0;
                int btntextBox26 = 0;
                int btntextBox27 = 0;
                int btntextBox28 = 0;
                int btntextBox29 = 0;
                int btntextBox30 = 0;
                int btntextBox31 = 0;
                int btntextBox32 = 0;
                int btntextBox33 = 0;
                int btntextBox34 = 0;
                int btntextBox35 = 0;
                int btntextBox36 = 0;
            }

            //row-lar
            {
                int textBoxRow1 = 0;
                int textBoxRow2 = 0;
                int textBoxRow3 = 0;
            }
            InitializeComponent();
            //col-lar
            {
                int textBoxCol3 = 0;
                int textBoxCol2 = 0;
                int textBoxCol1 = 0;
            }
            //red-black
            {
                int textBoxBlack = 0;
                int textBoxRed = 0;
            }
            //even-odd
            {
                int textBoxEven = 0;
                int textBoxOdd = 0;
            }
            //(1-18)and(19-36)
            {
                int textBoxSmall = 0;
                int textBoxBig = 0;
            }
            //tier;orph;zero
            {

                int textBoxVZero = 0;
                int textBoxOrph = 0;
                int textBoxTier = 0;

            }
            //street
            {

                int textBox34_35_36 = 0;
                int textBox31_32_33 = 0;
                int textBox28_29_30 = 0;
                int textBox25_26_27 = 0;
                int textBox22_23_24 = 0;
                int textBox19_20_21 = 0;
                int textBox16_17_18 = 0;
                int textBox13_14_15 = 0;
                int textBox10_11_12 = 0;
                int textBox7_8_9 = 0;
                int textBox4_5_6 = 0;
                int textBox1_2_3 = 0;
            }
            //Street2
            {
                int textBox31_32_33_34_35_36 = 0;
                int textBox28_29_30_31_32_33 = 0;
                int textBox25_26_27_28_29_30 = 0;
                int textBox22_23_24_25_26_27 = 0;
                int textBox19_20_21_22_23_24 = 0;
                int textBox16_17_18_19_20_21 = 0;
                int textBox13_14_15_16_17_18 = 0;
                int textBox10_11_12_13_14_15 = 0;
                int textBox4_5_6_7_8_9 = 0;
                int textBox7_8_9_10_11_12 = 0;
                int textBox1_2_3_4_5_6 = 0;
            }
            //dordluler
            {
                int textBox32_33_35_36 = 0;
                int textBox31_32_34_35 = 0;
                int textBox29_30_32_33 = 0;
                int textBox28_29_31_32 = 0;
                int textBox26_27_29_30 = 0;
                int textBox25_26_28_29 = 0;
                int textBox23_24_26_27 = 0;
                int textBox22_23_25_26 = 0;
                int textBox20_21_23_24 = 0;
                int textBox19_20_22_23 = 0;
                int textBox17_18_20_21 = 0;
                int textBox16_17_19_20 = 0;
                int textBox14_15_17_18 = 0;
                int textBox13_14_16_17 = 0;
                int textBox11_12_14_15 = 0;
                int textBox10_11_13_14 = 0;
                int textBox3_2_1_0 = 0;
                int textBox5_6_8_9 = 0;
                int textBox4_5_7_8 = 0;
                int textBox8_9_11_12 = 0;
                int textBox7_8_10_11 = 0;
                int textBox2_3_5_6 = 0;
                int textBox1_2_4_5 = 0;
            }
            //ikili Col
            {

                int textBoxCol1_2 = 0;
                int textBoxCol2_3 = 0;
                int textBoxCol1_3 = 0;

            }
            //ikili Row
            {
                int textBoxRow1_3 = 0;
                int textBoxRow2_3 = 0;
                int textBoxRow1_2 = 0;
            }
            //Amid
            {
                int textBoxAmid2 = 0;
                int textBoxAmid = 0;
            }
            //tek,10luq,20lik,30luq
            {
                int textBoxtek = 0;
                int textBox10luqlar = 0;
                int textBox20lik = 0;
                int textBox30luq = 0;
            }



        }

        public void button0_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button0.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //btntextBox-lar
            {


                btntextBox0.Text = "0";





                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {
                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {
                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();



            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {

                textBox3_2_1_0.Text = "0";

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {
                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Insert(0, button1.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }


            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //btntextBox-lar
            {


                btntextBox1.Text = "0";




                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {

                    textBox1_2_3.Text = "0";

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {

                textBox3_2_1_0.Text = "0";


                textBox1_2_4_5.Text = "0";

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button2.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }


            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox2.Text = "0";



                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();

                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();


                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {

                    textBox1_2_3.Text = "0";

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {

                textBox3_2_1_0.Text = "0";


                textBox1_2_4_5.Text = "0";


                textBox2_3_5_6.Text = "0";

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button3.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox3.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();


                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {

                    textBox1_2_3.Text = "0";

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {

                textBox3_2_1_0.Text = "0";

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();


                textBox2_3_5_6.Text = "0";

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Insert(0, button4.Text);
            {

                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //btntextBox-lar
            {


                btntextBox4.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();



                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();


                    textBox4_5_6.Text = "0";

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";


                textBox4_5_6_7_8_9.Text = "0";

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();


                textBox1_2_4_5.Text = "0";

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();


                textBox4_5_7_8.Text = "0";

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button5.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox5.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();


                    textBox4_5_6.Text = "0";

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";


                textBox4_5_6_7_8_9.Text = "0";

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();


                textBox1_2_4_5.Text = "0";


                textBox2_3_5_6.Text = "0";


                textBox4_5_7_8.Text = "0";


                textBox5_6_8_9.Text = "0";

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button6.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox6.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();


                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();


                    textBox4_5_6.Text = "0";

                    int street7 = Convert.ToInt32(textBox7_8_9.Text);
                    street7 += 1;
                    textBox7_8_9.Text = street7.ToString();

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {

                textBox1_2_3_4_5_6.Text = "0";


                textBox4_5_6_7_8_9.Text = "0";

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();


                textBox2_3_5_6.Text = "0";

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();


                textBox5_6_8_9.Text = "0";

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button7.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox7.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();



                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    textBox7_8_9.Text = "0";

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();


                textBox4_5_6_7_8_9.Text = "0";


                textBox7_8_9_10_11_12.Text = "0";

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();


                textBox4_5_7_8.Text = "0";

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();


                textBox7_8_10_11.Text = "0";

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button8.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox8.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();



                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    textBox7_8_9.Text = "0";

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();


                textBox4_5_6_7_8_9.Text = "0";


                textBox7_8_9_10_11_12.Text = "0";

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();


                textBox4_5_7_8.Text = "0";


                textBox5_6_8_9.Text = "0";


                textBox7_8_10_11.Text = "0";

                textBox8_9_11_12.Text = "0";

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button9.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {

                textBoxtek.Text = "0";

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox9.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();



                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                {
                    int street1 = Convert.ToInt32(textBox1_2_3.Text);
                    street1 += 1;
                    textBox1_2_3.Text = street1.ToString();

                    int street4 = Convert.ToInt32(textBox4_5_6.Text);
                    street4 += 1;
                    textBox4_5_6.Text = street4.ToString();

                    textBox7_8_9.Text = "0";

                    int street10 = Convert.ToInt32(textBox10_11_12.Text);
                    street10 += 1;
                    textBox10_11_12.Text = street10.ToString();

                    int street13 = Convert.ToInt32(textBox13_14_15.Text);
                    street13 += 1;
                    textBox13_14_15.Text = street13.ToString();

                    int street16 = Convert.ToInt32(textBox16_17_18.Text);
                    street16 += 1;
                    textBox16_17_18.Text = street16.ToString();

                    int street19 = Convert.ToInt32(textBox19_20_21.Text);
                    street19 += 1;
                    textBox19_20_21.Text = street19.ToString();

                    int street22 = Convert.ToInt32(textBox22_23_24.Text);
                    street22 += 1;
                    textBox22_23_24.Text = street22.ToString();

                    int street25 = Convert.ToInt32(textBox25_26_27.Text);
                    street25 += 1;
                    textBox25_26_27.Text = street25.ToString();

                    int street28 = Convert.ToInt32(textBox28_29_30.Text);
                    street28 += 1;
                    textBox28_29_30.Text = street28.ToString();

                    int street31 = Convert.ToInt32(textBox31_32_33.Text);
                    street31 += 1;
                    textBox31_32_33.Text = street31.ToString();

                    int street34 = Convert.ToInt32(textBox34_35_36.Text);
                    street34 += 1;
                    textBox34_35_36.Text = street34.ToString();


                }
            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();


                textBox4_5_6_7_8_9.Text = "0";


                textBox7_8_9_10_11_12.Text = "0";

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();


                textBox5_6_8_9.Text = "0";

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();


                textBox8_9_11_12.Text = "0";

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button10.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();


                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox10.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();




                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();


                textBox10_11_12.Text = "0";

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();


                textBox7_8_9_10_11_12.Text = "0";


                textBox10_11_12_13_14_15.Text = "0";

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();


                textBox7_8_10_11.Text = "0";

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();


                textBox10_11_13_14.Text = "0";

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button11.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();


                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }

            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox11.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();




                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();


                textBox10_11_12.Text = "0";

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();


                textBox7_8_9_10_11_12.Text = "0";


                textBox10_11_12_13_14_15.Text = "0";

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();


                textBox7_8_10_11.Text = "0";


                textBox8_9_11_12.Text = "0";


                textBox10_11_13_14.Text = "0";


                textBox11_12_14_15.Text = "0";

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button12.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                textBoxRow1_3.Text = "0";

                int Row2_3 = Convert.ToInt32(textBoxRow2_3.Text);
                Row2_3 += 1;
                textBoxRow2_3.Text = Row2_3.ToString();


                textBoxRow1_2.Text = "0";


            }
            //btntextBox-lar
            {


                btntextBox12.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();




                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow1.Text = "0";

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();


                textBox10_11_12.Text = "0";

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();


                textBox7_8_9_10_11_12.Text = "0";


                textBox10_11_12_13_14_15.Text = "0";

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();


                textBox8_9_11_12.Text = "0";

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();


                textBox11_12_14_15.Text = "0";

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button13.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";





            }
            //btntextBox-lar
            {


                btntextBox13.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();



                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();


                textBox13_14_15.Text = "0";

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();


                textBox10_11_12_13_14_15.Text = "0";
                textBox13_14_15_16_17_18.Text = "0";

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();


                textBox10_11_13_14.Text = "0";

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();


                textBox13_14_16_17.Text = "0";

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button14.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";





            }
            //btntextBox-lar

            {


                btntextBox14.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();



                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();


                textBox13_14_15.Text = "0";

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();


                textBox10_11_12_13_14_15.Text = "0";
                textBox13_14_15_16_17_18.Text = "0";

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();


                textBox10_11_13_14.Text = "0";


                textBox11_12_14_15.Text = "0";


                textBox13_14_16_17.Text = "0";


                textBox14_15_17_18.Text = "0";

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button15.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox15.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();




                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();


                textBox13_14_15.Text = "0";

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();


                textBox10_11_12_13_14_15.Text = "0";
                textBox13_14_15_16_17_18.Text = "0";

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();


                textBox11_12_14_15.Text = "0";

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();


                textBox14_15_17_18.Text = "0";

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button16.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox16.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();


                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();


                textBox16_17_18.Text = "0";

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();


                textBox13_14_15_16_17_18.Text = "0";


                textBox16_17_18_19_20_21.Text = "0";

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();


                textBox13_14_16_17.Text = "0";

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();


                textBox16_17_19_20.Text = "0";

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button17.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }

            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox17.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();


                textBox16_17_18.Text = "0";

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();


                textBox13_14_15_16_17_18.Text = "0";


                textBox16_17_18_19_20_21.Text = "0";

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();


                textBox13_14_16_17.Text = "0";


                textBox14_15_17_18.Text = "0";


                textBox16_17_19_20.Text = "0";


                textBox17_18_20_21.Text = "0";

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button18.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();


                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox18.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();




                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {

                textBoxSmall.Text = "0";

                int Big = Convert.ToInt32(textBoxBig.Text);
                Big += 1;
                textBoxBig.Text = Big.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();


                textBox16_17_18.Text = "0";

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();


                textBox13_14_15_16_17_18.Text = "0";


                textBox16_17_18_19_20_21.Text = "0";

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();


                textBox14_15_17_18.Text = "0";

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();


                textBox17_18_20_21.Text = "0";

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button19.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }



            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();


                textBox10luqlar.Text = "0";

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox19.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();




                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();


                textBox19_20_21.Text = "0";

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();


                textBox16_17_18_19_20_21.Text = "0";


                textBox19_20_21_22_23_24.Text = "0";

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();


                textBox16_17_19_20.Text = "0";

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();


                textBox19_20_22_23.Text = "0";

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button20.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox20.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();



                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();


                textBox19_20_21.Text = "0";

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();


                textBox16_17_18_19_20_21.Text = "0";


                textBox19_20_21_22_23_24.Text = "0";

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();


                textBox16_17_19_20.Text = "0";


                textBox17_18_20_21.Text = "0";


                textBox19_20_22_23.Text = "0";


                textBox20_21_23_24.Text = "0";

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button21.Text);


            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox21.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();



                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();


                textBox19_20_21.Text = "0";

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();


                textBox16_17_18_19_20_21.Text = "0";


                textBox19_20_21_22_23_24.Text = "0";

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();


                textBox17_18_20_21.Text = "0";

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();


                textBox20_21_23_24.Text = "0";

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button22.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox22.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();


                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();


                textBox22_23_24.Text = "0";

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();


                textBox19_20_21_22_23_24.Text = "0";


                textBox22_23_24_25_26_27.Text = "0";

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();


                textBox19_20_22_23.Text = "0";

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();


                textBox22_23_25_26.Text = "0";

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button23.Text);



            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox23.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();



                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();


                textBox22_23_24.Text = "0";

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();


                textBox19_20_21_22_23_24.Text = "0";


                textBox22_23_24_25_26_27.Text = "0";

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();


                textBox19_20_22_23.Text = "0";


                textBox20_21_23_24.Text = "0";


                textBox22_23_25_26.Text = "0";

                textBox23_24_26_27.Text = "0";

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button24.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {

                int Row1_3 = Convert.ToInt32(textBoxRow1_3.Text);
                Row1_3 += 1;
                textBoxRow1_3.Text = Row1_3.ToString();

                textBoxRow2_3.Text = "0";


                textBoxRow1_2.Text = "0";

            }
            //btntextBox-lar
            {


                btntextBox24.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();



                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow2.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row3 = Convert.ToInt32(textBoxRow3.Text);
                Row3 += 1;
                textBoxRow3.Text = Row3.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();


                textBox22_23_24.Text = "0";

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();


                textBox19_20_21_22_23_24.Text = "0";


                textBox22_23_24_25_26_27.Text = "0";

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();


                textBox20_21_23_24.Text = "0";

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();


                textBox23_24_26_27.Text = "0";

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button25.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox25.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();



                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();


                textBox25_26_27.Text = "0";

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();


                textBox22_23_24_25_26_27.Text = "0";


                textBox25_26_27_28_29_30.Text = "0";

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();


                textBox22_23_25_26.Text = "0";

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();


                textBox25_26_28_29.Text = "0";

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button26.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox26.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();



                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();


                textBox25_26_27.Text = "0";

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();


                textBox22_23_24_25_26_27.Text = "0";


                textBox25_26_27_28_29_30.Text = "0";

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();


                textBox22_23_25_26.Text = "0";


                textBox23_24_26_27.Text = "0";


                textBox25_26_28_29.Text = "0";


                textBox26_27_29_30.Text = "0";

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button27.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox27.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();


                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();


                textBox25_26_27.Text = "0";

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();


                textBox22_23_24_25_26_27.Text = "0";


                textBox25_26_27_28_29_30.Text = "0";

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();


                textBox23_24_26_27.Text = "0";

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();


                textBox26_27_29_30.Text = "0";

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button28.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox28.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();



                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();


                textBox28_29_30.Text = "0";

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();


                textBox25_26_27_28_29_30.Text = "0";


                textBox28_29_30_31_32_33.Text = "0";

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();


                textBox25_26_28_29.Text = "0";

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();


                textBox28_29_31_32.Text = "0";

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button29.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                textBox20lik.Text = "0";

                int otuzluq = Convert.ToInt32(textBox30luq.Text);
                otuzluq += 1;
                textBox30luq.Text = otuzluq.ToString();

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox29.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();



                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();


                textBox28_29_30.Text = "0";

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();


                textBox25_26_27_28_29_30.Text = "0";


                textBox28_29_30_31_32_33.Text = "0";

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();


                textBox25_26_28_29.Text = "0";


                textBox26_27_29_30.Text = "0";


                textBox28_29_31_32.Text = "0";


                textBox29_30_32_33.Text = "0";

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button30.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {

                textBoxAmid.Text = "0";

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }

            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox30.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();



                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();


                textBox28_29_30.Text = "0";

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();


                textBox25_26_27_28_29_30.Text = "0";


                textBox28_29_30_31_32_33.Text = "0";

                int street23134 = Convert.ToInt32(textBox31_32_33_34_35_36.Text);
                street23134 += 1;
                textBox31_32_33_34_35_36.Text = street23134.ToString();



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();


                textBox26_27_29_30.Text = "0";

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();


                textBox29_30_32_33.Text = "0";

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button31.Text);
            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }

            //red/black

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox31.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();



                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();


                textBox31_32_33.Text = "0";

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();


                textBox28_29_30_31_32_33.Text = "0";

                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();


                textBox28_29_31_32.Text = "0";

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();


                textBox31_32_34_35.Text = "0";

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button32.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }
            //red/black

            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox32.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();


                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();


                textBox31_32_33.Text = "0";

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();


                textBox28_29_30_31_32_33.Text = "0";

                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();


                textBox28_29_31_32.Text = "0";


                textBox29_30_32_33.Text = "0";


                textBox31_32_34_35.Text = "0";


                textBox32_33_35_36.Text = "0";

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button33.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }


            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                int Amid2 = Convert.ToInt32(textBoxAmid2.Text);
                Amid2 += 1;
                textBoxAmid2.Text = Amid2.ToString();
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox33.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();



                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();


                textBox31_32_33.Text = "0";

                int street34 = Convert.ToInt32(textBox34_35_36.Text);
                street34 += 1;
                textBox34_35_36.Text = street34.ToString();

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();


                textBox28_29_30_31_32_33.Text = "0";

                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();


                textBox29_30_32_33.Text = "0";

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();


                textBox32_33_35_36.Text = "0";

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button34.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }


            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {
                textBoxCol1_3.Text = "0";

                int Col2_3 = Convert.ToInt32(textBoxCol2_3.Text);
                Col2_3 += 1;
                textBoxCol2_3.Text = Col2_3.ToString();

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }
            //btntextBox-lar
            {


                btntextBox34.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();



                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();

                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol1.Text = "0";

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxOrph.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();


                textBox34_35_36.Text = "0";

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();


                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();


                textBox31_32_34_35.Text = "0";

                int dordlu23 = Convert.ToInt32(textBox32_33_35_36.Text);
                dordlu23 += 1;
                textBox32_33_35_36.Text = dordlu23.ToString();

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, button35.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }


            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {

                int Col1_3 = Convert.ToInt32(textBoxCol1_3.Text);
                Col1_3 += 1;
                textBoxCol1_3.Text = Col1_3.ToString();


                textBoxCol2_3.Text = "0";


                textBoxCol1_2.Text = "0";

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }

            //btntextBox-lar
            {


                btntextBox35.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();


                int sayi36 = Convert.ToInt32(btntextBox36.Text);
                sayi36 += 1;
                btntextBox36.Text = sayi36.ToString();


            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol2.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col3 = Convert.ToInt32(textBoxCol3.Text);
                Col3 += 1;
                textBoxCol3.Text = Col3.ToString();

            }
            //red-black
            {
                int Red = Convert.ToInt32(textBoxRed.Text);
                Red += 1;
                textBoxRed.Text = Red.ToString();

                textBoxBlack.Text = "0";
            }
            //even-odd
            {


                textBoxOdd.Text = "0";

                int Even = Convert.ToInt32(textBoxEven.Text);
                Even += 1;
                textBoxEven.Text = Even.ToString();
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxVZero.Text = "0";

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();

                int Tier = Convert.ToInt32(textBoxTier.Text);
                Tier += 1;
                textBoxTier.Text = Tier.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();


                textBox34_35_36.Text = "0";

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();


                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();


                textBox31_32_34_35.Text = "0";


                textBox32_33_35_36.Text = "0";

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {

            listBox1.Items.Insert(0, button36.Text);

            {
                int Number1 = Convert.ToInt32(Number.Text);
                Number1 += 1;
                Number.Text = Number1.ToString();
            }


            //tek,10luq,20lik,30luq
            {
                int tek = Convert.ToInt32(textBoxtek.Text);
                tek += 1;
                textBoxtek.Text = tek.ToString();

                int onluq = Convert.ToInt32(textBox10luqlar.Text);
                onluq += 1;
                textBox10luqlar.Text = onluq.ToString();

                int iyirmilik = Convert.ToInt32(textBox20lik.Text);
                iyirmilik += 1;
                textBox20lik.Text = iyirmilik.ToString();


                textBox30luq.Text = "0";

            }
            //Amid
            {
                int Amid = Convert.ToInt32(textBoxAmid.Text);
                Amid += 1;
                textBoxAmid.Text = Amid.ToString();

                textBoxAmid2.Text = "0";
            }
            //ikili Col
            {


                textBoxCol1_3.Text = "0";

                textBoxCol2_3.Text = "0";

                int Col1_2 = Convert.ToInt32(textBoxCol1_2.Text);
                Col1_2 += 1;
                textBoxCol1_2.Text = Col1_2.ToString();

            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                int Row1_2 = Convert.ToInt32(textBoxRow1_2.Text);
                Row1_2 += 1;
                textBoxRow1_2.Text = Row1_2.ToString();

            }

            //btntextBox-lar
            {


                btntextBox36.Text = "0";


                int sayi0 = Convert.ToInt32(btntextBox0.Text);
                sayi0 += 1;
                btntextBox0.Text = sayi0.ToString();


                int sayi1 = Convert.ToInt32(btntextBox1.Text);
                sayi1 += 1;
                btntextBox1.Text = sayi1.ToString();

                int sayi02 = Convert.ToInt32(btntextBox2.Text);
                sayi02 += 1;
                btntextBox2.Text = sayi02.ToString();

                int sayi3 = Convert.ToInt32(btntextBox3.Text);
                sayi3 += 1;
                btntextBox3.Text = sayi3.ToString();

                int sayi4 = Convert.ToInt32(btntextBox4.Text);
                sayi4 += 1;
                btntextBox4.Text = sayi4.ToString();


                int sayi5 = Convert.ToInt32(btntextBox5.Text);
                sayi5 += 1;
                btntextBox5.Text = sayi5.ToString();

                int sayi6 = Convert.ToInt32(btntextBox6.Text);
                sayi6 += 1;
                btntextBox6.Text = sayi6.ToString();

                int sayi7 = Convert.ToInt32(btntextBox7.Text);
                sayi7 += 1;
                btntextBox7.Text = sayi7.ToString();

                int sayi8 = Convert.ToInt32(btntextBox8.Text);
                sayi8 += 1;
                btntextBox8.Text = sayi8.ToString();


                int sayi9 = Convert.ToInt32(btntextBox9.Text);
                sayi9 += 1;
                btntextBox9.Text = sayi9.ToString();

                int sayi10 = Convert.ToInt32(btntextBox10.Text);
                sayi10 += 1;
                btntextBox10.Text = sayi10.ToString();


                int sayi11 = Convert.ToInt32(btntextBox11.Text);
                sayi11 += 1;
                btntextBox11.Text = sayi11.ToString();


                int sayi12 = Convert.ToInt32(btntextBox12.Text);
                sayi12 += 1;
                btntextBox12.Text = sayi12.ToString();

                int sayi13 = Convert.ToInt32(btntextBox13.Text);
                sayi13 += 1;
                btntextBox13.Text = sayi13.ToString();

                int sayi14 = Convert.ToInt32(btntextBox14.Text);
                sayi14 += 1;
                btntextBox14.Text = sayi14.ToString();


                int sayi15 = Convert.ToInt32(btntextBox15.Text);
                sayi15 += 1;
                btntextBox15.Text = sayi15.ToString();

                int sayi16 = Convert.ToInt32(btntextBox16.Text);
                sayi16 += 1;
                btntextBox16.Text = sayi16.ToString();

                int sayi17 = Convert.ToInt32(btntextBox17.Text);
                sayi17 += 1;
                btntextBox17.Text = sayi17.ToString();

                int sayi18 = Convert.ToInt32(btntextBox18.Text);
                sayi18 += 1;
                btntextBox18.Text = sayi18.ToString();


                int sayi19 = Convert.ToInt32(btntextBox19.Text);
                sayi19 += 1;
                btntextBox19.Text = sayi19.ToString();

                int sayi20 = Convert.ToInt32(btntextBox20.Text);
                sayi20 += 1;
                btntextBox20.Text = sayi20.ToString();

                int sayi21 = Convert.ToInt32(btntextBox21.Text);
                sayi21 += 1;
                btntextBox21.Text = sayi21.ToString();

                int sayi22 = Convert.ToInt32(btntextBox22.Text);
                sayi22 += 1;
                btntextBox22.Text = sayi22.ToString();

                int sayi23 = Convert.ToInt32(btntextBox23.Text);
                sayi23 += 1;
                btntextBox23.Text = sayi23.ToString();

                int sayi24 = Convert.ToInt32(btntextBox24.Text);
                sayi24 += 1;
                btntextBox24.Text = sayi24.ToString();

                int sayi25 = Convert.ToInt32(btntextBox25.Text);
                sayi25 += 1;
                btntextBox25.Text = sayi25.ToString();

                int sayi26 = Convert.ToInt32(btntextBox26.Text);
                sayi26 += 1;
                btntextBox26.Text = sayi26.ToString();

                int sayi27 = Convert.ToInt32(btntextBox27.Text);
                sayi27 += 1;
                btntextBox27.Text = sayi27.ToString();

                int sayi28 = Convert.ToInt32(btntextBox28.Text);
                sayi28 += 1;
                btntextBox28.Text = sayi28.ToString();

                int sayi29 = Convert.ToInt32(btntextBox29.Text);
                sayi29 += 1;
                btntextBox29.Text = sayi29.ToString();

                int sayi30 = Convert.ToInt32(btntextBox30.Text);
                sayi30 += 1;
                btntextBox30.Text = sayi30.ToString();

                int sayi31 = Convert.ToInt32(btntextBox31.Text);
                sayi31 += 1;
                btntextBox31.Text = sayi31.ToString();

                int sayi32 = Convert.ToInt32(btntextBox32.Text);
                sayi32 += 1;
                btntextBox32.Text = sayi32.ToString();

                int sayi33 = Convert.ToInt32(btntextBox33.Text);
                sayi33 += 1;
                btntextBox33.Text = sayi33.ToString();

                int sayi34 = Convert.ToInt32(btntextBox34.Text);
                sayi34 += 1;
                btntextBox34.Text = sayi34.ToString();

                int sayi35 = Convert.ToInt32(btntextBox35.Text);
                sayi35 += 1;
                btntextBox35.Text = sayi35.ToString();




            }
            //row-lar
            {

                textBoxRow3.Text = "0";

                int Row1 = Convert.ToInt32(textBoxRow1.Text);
                Row1 += 1;
                textBoxRow1.Text = Row1.ToString();

                int Row2 = Convert.ToInt32(textBoxRow2.Text);
                Row2 += 1;
                textBoxRow2.Text = Row2.ToString();
            }
            //col-lar
            {

                textBoxCol3.Text = "0";

                int Col1 = Convert.ToInt32(textBoxCol1.Text);
                Col1 += 1;
                textBoxCol1.Text = Col1.ToString();

                int Col2 = Convert.ToInt32(textBoxCol2.Text);
                Col2 += 1;
                textBoxCol2.Text = Col2.ToString();

            }
            //red-black
            {

                textBoxRed.Text = "0";

                int Black = Convert.ToInt32(textBoxBlack.Text);
                Black += 1;
                textBoxBlack.Text = Black.ToString();

            }
            //even-odd
            {

                int Odd = Convert.ToInt32(textBoxOdd.Text);
                Odd += 1;
                textBoxOdd.Text = Odd.ToString();


                textBoxEven.Text = "0";
            }
            //(1-18)and(19-36)
            {
                int Small = Convert.ToInt32(textBoxSmall.Text);
                Small += 1;
                textBoxSmall.Text = Small.ToString();


                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {


                textBoxTier.Text = "0";

                int VZero = Convert.ToInt32(textBoxVZero.Text);
                VZero += 1;
                textBoxVZero.Text = VZero.ToString();

                int Orph = Convert.ToInt32(textBoxOrph.Text);
                Orph += 1;
                textBoxOrph.Text = Orph.ToString();


            }
            //street
            {
                int street1 = Convert.ToInt32(textBox1_2_3.Text);
                street1 += 1;
                textBox1_2_3.Text = street1.ToString();

                int street4 = Convert.ToInt32(textBox4_5_6.Text);
                street4 += 1;
                textBox4_5_6.Text = street4.ToString();

                int street7 = Convert.ToInt32(textBox7_8_9.Text);
                street7 += 1;
                textBox7_8_9.Text = street7.ToString();

                int street10 = Convert.ToInt32(textBox10_11_12.Text);
                street10 += 1;
                textBox10_11_12.Text = street10.ToString();

                int street13 = Convert.ToInt32(textBox13_14_15.Text);
                street13 += 1;
                textBox13_14_15.Text = street13.ToString();

                int street16 = Convert.ToInt32(textBox16_17_18.Text);
                street16 += 1;
                textBox16_17_18.Text = street16.ToString();

                int street19 = Convert.ToInt32(textBox19_20_21.Text);
                street19 += 1;
                textBox19_20_21.Text = street19.ToString();

                int street22 = Convert.ToInt32(textBox22_23_24.Text);
                street22 += 1;
                textBox22_23_24.Text = street22.ToString();

                int street25 = Convert.ToInt32(textBox25_26_27.Text);
                street25 += 1;
                textBox25_26_27.Text = street25.ToString();

                int street28 = Convert.ToInt32(textBox28_29_30.Text);
                street28 += 1;
                textBox28_29_30.Text = street28.ToString();

                int street31 = Convert.ToInt32(textBox31_32_33.Text);
                street31 += 1;
                textBox31_32_33.Text = street31.ToString();


                textBox34_35_36.Text = "0";

            }
            //street2
            {
                int street214 = Convert.ToInt32(textBox1_2_3_4_5_6.Text);
                street214 += 1;
                textBox1_2_3_4_5_6.Text = street214.ToString();

                int street247 = Convert.ToInt32(textBox4_5_6_7_8_9.Text);
                street247 += 1;
                textBox4_5_6_7_8_9.Text = street247.ToString();

                int street2710 = Convert.ToInt32(textBox7_8_9_10_11_12.Text);
                street2710 += 1;
                textBox7_8_9_10_11_12.Text = street2710.ToString();

                int street21013 = Convert.ToInt32(textBox10_11_12_13_14_15.Text);
                street21013 += 1;
                textBox10_11_12_13_14_15.Text = street21013.ToString();

                int street21316 = Convert.ToInt32(textBox13_14_15_16_17_18.Text);
                street21316 += 1;
                textBox13_14_15_16_17_18.Text = street21316.ToString();

                int street21619 = Convert.ToInt32(textBox16_17_18_19_20_21.Text);
                street21619 += 1;
                textBox16_17_18_19_20_21.Text = street21619.ToString();

                int street21922 = Convert.ToInt32(textBox19_20_21_22_23_24.Text);
                street21922 += 1;
                textBox19_20_21_22_23_24.Text = street21922.ToString();

                int street22225 = Convert.ToInt32(textBox22_23_24_25_26_27.Text);
                street22225 += 1;
                textBox22_23_24_25_26_27.Text = street22225.ToString();

                int street22528 = Convert.ToInt32(textBox25_26_27_28_29_30.Text);
                street22528 += 1;
                textBox25_26_27_28_29_30.Text = street22528.ToString();

                int street22831 = Convert.ToInt32(textBox28_29_30_31_32_33.Text);
                street22831 += 1;
                textBox28_29_30_31_32_33.Text = street22831.ToString();


                textBox31_32_33_34_35_36.Text = "0";



            }
            //dordluler
            {
                int dordlu1 = Convert.ToInt32(textBox3_2_1_0.Text);
                dordlu1 += 1;
                textBox3_2_1_0.Text = dordlu1.ToString();

                int dordlu2 = Convert.ToInt32(textBox1_2_4_5.Text);
                dordlu2 += 1;
                textBox1_2_4_5.Text = dordlu2.ToString();

                int dordlu3 = Convert.ToInt32(textBox2_3_5_6.Text);
                dordlu3 += 1;
                textBox2_3_5_6.Text = dordlu3.ToString();

                int dordlu4 = Convert.ToInt32(textBox4_5_7_8.Text);
                dordlu4 += 1;
                textBox4_5_7_8.Text = dordlu4.ToString();

                int dordlu5 = Convert.ToInt32(textBox5_6_8_9.Text);
                dordlu5 += 1;
                textBox5_6_8_9.Text = dordlu5.ToString();

                int dordlu6 = Convert.ToInt32(textBox7_8_10_11.Text);
                dordlu6 += 1;
                textBox7_8_10_11.Text = dordlu6.ToString();

                int dordlu7 = Convert.ToInt32(textBox8_9_11_12.Text);
                dordlu7 += 1;
                textBox8_9_11_12.Text = dordlu7.ToString();

                int dordlu8 = Convert.ToInt32(textBox10_11_13_14.Text);
                dordlu8 += 1;
                textBox10_11_13_14.Text = dordlu8.ToString();

                int dordlu9 = Convert.ToInt32(textBox11_12_14_15.Text);
                dordlu9 += 1;
                textBox11_12_14_15.Text = dordlu9.ToString();

                int dordlu10 = Convert.ToInt32(textBox13_14_16_17.Text);
                dordlu10 += 1;
                textBox13_14_16_17.Text = dordlu10.ToString();

                int dordlu11 = Convert.ToInt32(textBox14_15_17_18.Text);
                dordlu11 += 1;
                textBox14_15_17_18.Text = dordlu11.ToString();

                int dordlu12 = Convert.ToInt32(textBox16_17_19_20.Text);
                dordlu12 += 1;
                textBox16_17_19_20.Text = dordlu12.ToString();

                int dordlu13 = Convert.ToInt32(textBox17_18_20_21.Text);
                dordlu13 += 1;
                textBox17_18_20_21.Text = dordlu13.ToString();

                int dordlu14 = Convert.ToInt32(textBox19_20_22_23.Text);
                dordlu14 += 1;
                textBox19_20_22_23.Text = dordlu14.ToString();

                int dordlu15 = Convert.ToInt32(textBox20_21_23_24.Text);
                dordlu15 += 1;
                textBox20_21_23_24.Text = dordlu15.ToString();

                int dordlu16 = Convert.ToInt32(textBox22_23_25_26.Text);
                dordlu16 += 1;
                textBox22_23_25_26.Text = dordlu16.ToString();

                int dordlu17 = Convert.ToInt32(textBox23_24_26_27.Text);
                dordlu17 += 1;
                textBox23_24_26_27.Text = dordlu17.ToString();

                int dordlu18 = Convert.ToInt32(textBox25_26_28_29.Text);
                dordlu18 += 1;
                textBox25_26_28_29.Text = dordlu18.ToString();

                int dordlu19 = Convert.ToInt32(textBox26_27_29_30.Text);
                dordlu19 += 1;
                textBox26_27_29_30.Text = dordlu19.ToString();

                int dordlu20 = Convert.ToInt32(textBox28_29_31_32.Text);
                dordlu20 += 1;
                textBox28_29_31_32.Text = dordlu20.ToString();

                int dordlu21 = Convert.ToInt32(textBox29_30_32_33.Text);
                dordlu21 += 1;
                textBox29_30_32_33.Text = dordlu21.ToString();

                int dordlu22 = Convert.ToInt32(textBox31_32_34_35.Text);
                dordlu22 += 1;
                textBox31_32_34_35.Text = dordlu22.ToString();


                textBox32_33_35_36.Text = "0";

            }
        }

        private void buttonResets_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            {

                Number.Text = "0";
            }

            //tek,10luq,20lik,30luq
            {
                textBoxtek.Text = "0";
                textBox10luqlar.Text = "0";
                textBox20lik.Text = "0";
                textBox30luq.Text = "0";
            }
            //Amid
            {

                textBoxAmid.Text = "0";


                textBoxAmid2.Text = "0";
            }

            //ikili Col
            {
                textBoxCol1_3.Text = "0";


                textBoxCol2_3.Text = "0";

                textBoxCol1_2.Text = "0";
            }
            //ikili Row
            {
                textBoxRow1_3.Text = "0";
                textBoxRow2_3.Text = "0";

                textBoxRow1_2.Text = "0";

            }
            {

                btntextBox0.Text = "0";
                btntextBox1.Text = "0";
                btntextBox2.Text = "0";
                btntextBox3.Text = "0";
                btntextBox4.Text = "0";
                btntextBox5.Text = "0";
                btntextBox6.Text = "0";
                btntextBox7.Text = "0";
                btntextBox8.Text = "0";
                btntextBox9.Text = "0";
                btntextBox10.Text = "0";
                btntextBox11.Text = "0";
                btntextBox12.Text = "0";
                btntextBox13.Text = "0";
                btntextBox14.Text = "0";
                btntextBox15.Text = "0";
                btntextBox16.Text = "0";
                btntextBox17.Text = "0";
                btntextBox18.Text = "0";
                btntextBox19.Text = "0";
                btntextBox20.Text = "0";
                btntextBox21.Text = "0";
                btntextBox22.Text = "0";
                btntextBox23.Text = "0";
                btntextBox24.Text = "0";
                btntextBox25.Text = "0";
                btntextBox26.Text = "0";
                btntextBox27.Text = "0";
                btntextBox28.Text = "0";
                btntextBox29.Text = "0";
                btntextBox30.Text = "0";
                btntextBox31.Text = "0";
                btntextBox32.Text = "0";
                btntextBox33.Text = "0";
                btntextBox34.Text = "0";
                btntextBox35.Text = "0";
                btntextBox36.Text = "0";
            }

            //row-lar
            {
                textBoxRow1.Text = "0";
                textBoxRow2.Text = "0";
                textBoxRow3.Text = "0";
            }

            //col-lar
            {
                textBoxCol3.Text = "0";
                textBoxCol2.Text = "0";
                textBoxCol1.Text = "0";
            }

            //red-black
            {
                textBoxBlack.Text = "0";
                textBoxRed.Text = "0";
            }
            //even-odd
            {
                textBoxEven.Text = "0";
                textBoxOdd.Text = "0";
            }
            //(1-18)and(19-36)
            {
                textBoxSmall.Text = "0";
                textBoxBig.Text = "0";
            }
            //tier;orph;zero
            {

                textBoxVZero.Text = "0";
                textBoxOrph.Text = "0";
                textBoxTier.Text = "0";
                ;

            }
            //street
            {

                textBox34_35_36.Text = "0";

                textBox31_32_33.Text = "0";

                textBox28_29_30.Text = "0";
                textBox25_26_27.Text = "0";
                textBox22_23_24.Text = "0";
                textBox19_20_21.Text = "0";
                textBox16_17_18.Text = "0";
                textBox13_14_15.Text = "0";
                textBox10_11_12.Text = "0";
                textBox7_8_9.Text = "0";
                textBox4_5_6.Text = "0";
                textBox1_2_3.Text = "0";
            }
            //Street2
            {
                textBox31_32_33_34_35_36.Text = "0";
                textBox28_29_30_31_32_33.Text = "0";
                textBox25_26_27_28_29_30.Text = "0";
                textBox22_23_24_25_26_27.Text = "0";
                textBox19_20_21_22_23_24.Text = "0";
                textBox16_17_18_19_20_21.Text = "0";
                textBox13_14_15_16_17_18.Text = "0";
                textBox10_11_12_13_14_15.Text = "0";
                textBox4_5_6_7_8_9.Text = "0";
                textBox7_8_9_10_11_12.Text = "0";
                textBox1_2_3_4_5_6.Text = "0";
            }
            //dordluler
            {
                textBox32_33_35_36.Text = "0";
                textBox31_32_34_35.Text = "0";
                textBox29_30_32_33.Text = "0";
                textBox28_29_31_32.Text = "0";
                textBox26_27_29_30.Text = "0";
                textBox25_26_28_29.Text = "0";
                textBox23_24_26_27.Text = "0";
                textBox22_23_25_26.Text = "0";
                textBox20_21_23_24.Text = "0";
                textBox19_20_22_23.Text = "0";
                textBox17_18_20_21.Text = "0";
                textBox16_17_19_20.Text = "0";
                textBox14_15_17_18.Text = "0";
                textBox13_14_16_17.Text = "0";
                textBox11_12_14_15.Text = "0";
                textBox10_11_13_14.Text = "0";
                textBox3_2_1_0.Text = "0";
                textBox5_6_8_9.Text = "0";
                textBox4_5_7_8.Text = "0";
                textBox8_9_11_12.Text = "0";
                textBox7_8_10_11.Text = "0";
                textBox2_3_5_6.Text = "0";
                textBox1_2_4_5.Text = "0";
            }

        }

  
    }
}
