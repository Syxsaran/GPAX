namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textBoxMaxName.Text = oGPACal.getMaxName().ToString();

            double min = oGPACal.getMin();
            textBoxMinGPA.Text = min.ToString();
            textBoxMinName.Text = oGPACal.getMinName().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty;
            textBoxAllData.Text = oGPACal.getAlldata();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxAllData.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";

        }
    }
}