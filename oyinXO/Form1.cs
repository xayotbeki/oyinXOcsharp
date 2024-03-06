namespace oyinXO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //----------------------------
        List<int> array = new List<int>();
        string birinchi = "";
        string ikkinchi = "";
        string uchinchi = "";
        string tortinchi = "";
        string beshinchi = "";
        string oltinchi = "";
        string yettinchi = "";
        string sakkizinchi = "";
        string toqqizinchi = "";

        public void Yutuq(string a)
        {
            if (a == "X")
            {
                Yutti.Text = "X-yutti";
            }
            else
            {
                Yutti.Text = "O-yutti";
            }
        }
        public void Durrang()
        {
            if (array.Count == 9)
            {
                if (Yutti.Text == "")
                {
                    Yutti.Text = "Durrang";
                }
            }
        }
        public void xoUchun()
        {
            if (array.Count == 0 || array.Count == 2 ||
                array.Count == 4 || array.Count == 6 ||
                array.Count == 8)
            {
                if (Yutti.Text == "X-yutti" || Yutti.Text == "O-yutti" || Yutti.Text == "Durrang")
                {
                    xUchun.Text = "X";
                    oUchun.Text = "O";
                }
                else
                {
                    xUchun.Text = "=>X";
                    oUchun.Text = "O";
                }

            }
            else
            {
                if (Yutti.Text == "X-yutti" || Yutti.Text == "O-yutti" || Yutti.Text == "Durrang")
                {
                    xUchun.Text = "X";
                    oUchun.Text = "O";
                }
                else
                {
                    oUchun.Text = "=>O";
                    xUchun.Text = "X";
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button1.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button1.Text = "O";
                    array.Add(1);
                }

                birinchi = button1.Text;

                if (birinchi == ikkinchi && birinchi == uchinchi)
                {
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(birinchi);

                }
                else if (birinchi == tortinchi && birinchi == yettinchi)
                {
                    button2.Text = "*";
                    button3.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(birinchi);
                }
                else if (birinchi == beshinchi && birinchi == toqqizinchi)
                {
                    button2.Text = "*";
                    button3.Text = "*";
                    button4.Text = "*";
                    button6.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";


                    Yutuq(birinchi);
                }
                Durrang();
                xoUchun();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button2.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button2.Text = "O";
                    array.Add(1);
                }
                ikkinchi = button2.Text;

                if (ikkinchi == birinchi && ikkinchi == uchinchi)
                {
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(ikkinchi);
                }
                else if (ikkinchi == beshinchi && ikkinchi == sakkizinchi)
                {
                    button4.Text = "*";
                    button1.Text = "*";
                    button6.Text = "*";
                    button7.Text = "*";
                    button3.Text = "*";
                    button9.Text = "*";

                    Yutuq(ikkinchi);
                }
                Durrang();
                xoUchun();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button3.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button3.Text = "O";
                    array.Add(1);
                }
                uchinchi = button3.Text;

                if (uchinchi == birinchi && uchinchi == ikkinchi)
                {
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(uchinchi);
                }
                else if (uchinchi == oltinchi && uchinchi == toqqizinchi)
                {
                    button4.Text = "*";
                    button5.Text = "*";
                    button1.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";
                    button2.Text = "*";

                    Yutuq(uchinchi);
                }
                else if (uchinchi == beshinchi && uchinchi == yettinchi)
                {
                    button4.Text = "*";
                    button6.Text = "*";
                    button1.Text = "*";
                    button9.Text = "*";
                    button8.Text = "*";
                    button2.Text = "*";

                    Yutuq(uchinchi);
                }
                Durrang();
                xoUchun();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button4.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button4.Text = "O";
                    array.Add(1);
                }
                tortinchi = button4.Text;

                if (tortinchi == birinchi && tortinchi == yettinchi)
                {
                    button3.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(tortinchi);
                }
                else if (tortinchi == beshinchi && tortinchi == oltinchi)
                {
                    button3.Text = "*";
                    button7.Text = "*";
                    button1.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(tortinchi);
                }
                Durrang();
                xoUchun();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button5.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button5.Text = "O";
                    array.Add(1);
                }
                beshinchi = button5.Text;

                if (beshinchi == birinchi && beshinchi == toqqizinchi)
                {
                    button3.Text = "*";
                    button4.Text = "*";
                    button6.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button7.Text = "*";

                    Yutuq(beshinchi);
                }
                else if (beshinchi == uchinchi && beshinchi == yettinchi)
                {
                    button1.Text = "*";
                    button4.Text = "*";
                    button6.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(beshinchi);

                }
                else if (beshinchi == ikkinchi && beshinchi == sakkizinchi)
                {
                    button1.Text = "*";
                    button4.Text = "*";
                    button6.Text = "*";
                    button3.Text = "*";
                    button7.Text = "*";
                    button9.Text = "*";

                    Yutuq(beshinchi);
                }
                else if (beshinchi == tortinchi && beshinchi == oltinchi)
                {
                    button1.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button3.Text = "*";
                    button7.Text = "*";
                    button9.Text = "*";

                    Yutuq(beshinchi);
                }
                Durrang();
                xoUchun();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button6.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button6.Text = "O";
                    array.Add(1);
                }
                oltinchi = button6.Text;

                if (oltinchi == uchinchi && oltinchi == toqqizinchi)
                {
                    button1.Text = "*";
                    button4.Text = "*";
                    button5.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button7.Text = "*";

                    Yutuq(oltinchi);
                }
                else if (oltinchi == tortinchi && oltinchi == beshinchi)
                {
                    button1.Text = "*";
                    button3.Text = "*";
                    button9.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button7.Text = "*";

                    Yutuq(oltinchi);
                }
                Durrang();
                xoUchun();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button7.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button7.Text = "O";
                    array.Add(1);
                }
                yettinchi = button7.Text;

                if (yettinchi == birinchi && yettinchi == tortinchi)
                {
                    button3.Text = "*";
                    button6.Text = "*";
                    button5.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(yettinchi);
                }
                else if (yettinchi == uchinchi && yettinchi == beshinchi)
                {
                    button1.Text = "*";
                    button6.Text = "*";
                    button4.Text = "*";
                    button2.Text = "*";
                    button8.Text = "*";
                    button9.Text = "*";

                    Yutuq(yettinchi);
                }
                else if (yettinchi == sakkizinchi && yettinchi == toqqizinchi)
                {
                    button1.Text = "*";
                    button2.Text = "*";
                    button3.Text = "*";
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";

                    Yutuq(yettinchi);
                }
                Durrang();
                xoUchun();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {

                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button8.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button8.Text = "O";
                    array.Add(1);
                }
                sakkizinchi = button8.Text;

                if (sakkizinchi == ikkinchi && sakkizinchi == beshinchi)
                {
                    button3.Text = "*";
                    button6.Text = "*";
                    button4.Text = "*";
                    button1.Text = "*";
                    button7.Text = "*";
                    button9.Text = "*";

                    Yutuq(sakkizinchi);
                }
                else if (sakkizinchi == yettinchi && sakkizinchi == toqqizinchi)
                {
                    button1.Text = "*";
                    button2.Text = "*";
                    button3.Text = "*";
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";

                    Yutuq(sakkizinchi);
                }
                Durrang();
                xoUchun();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (array.Count == 0 || array.Count == 2 ||
                    array.Count == 4 || array.Count == 6 ||
                    array.Count == 8)
                {
                    button9.Text = "X";
                    array.Add(1);
                }
                else if (array.Count == 1 || array.Count == 3 ||
                        array.Count == 5 || array.Count == 7)
                {
                    button9.Text = "O";
                    array.Add(1);
                }
                toqqizinchi = button9.Text;

                if (toqqizinchi == birinchi && toqqizinchi == beshinchi)
                {
                    button3.Text = "*";
                    button6.Text = "*";
                    button4.Text = "*";
                    button2.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";

                    Yutuq(toqqizinchi);
                }
                else if (toqqizinchi == uchinchi && toqqizinchi == oltinchi)
                {
                    button1.Text = "*";
                    button5.Text = "*";
                    button4.Text = "*";
                    button2.Text = "*";
                    button7.Text = "*";
                    button8.Text = "*";

                    Yutuq(toqqizinchi);

                }
                else if (toqqizinchi == yettinchi && toqqizinchi == sakkizinchi)
                {
                    button1.Text = "*";
                    button2.Text = "*";
                    button3.Text = "*";
                    button4.Text = "*";
                    button5.Text = "*";
                    button6.Text = "*";

                    Yutuq(toqqizinchi);

                }
                Durrang();
                xoUchun();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            array = new List<int>();

            birinchi = "";
            ikkinchi = "";
            uchinchi = "";
            tortinchi = "";
            beshinchi = "";
            oltinchi = "";
            yettinchi = "";
            sakkizinchi = "";
            toqqizinchi = "";

            Yutti.Text = "";

            xUchun.Text = "=>X";
            oUchun.Text = "O";


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Yutti_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}