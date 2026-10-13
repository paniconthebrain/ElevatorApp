namespace ElevatorApp
{
    public partial class Form1 : Form
    {
        int currentFloor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            currentFloor = 1;
            UpdateDisplay();
        }



        private void btnFloor0_Click(object sender, EventArgs e)
        {
            currentFloor = 0;
            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            lblFloor.Text = "Floor: " + currentFloor;
        }

        private void moveTo(int Floor)
        {
            currentFloor = Floor;
            UpdateDisplay();

        }
    }
}
