namespace ElevatorApp
{
    public partial class Form1 : Form
    {
        int currentFloor = 0;
        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            lblPanelDisplay.Text = currentFloor.ToString();

            if (currentFloor == 1)
            {
                lblFloor0Status.Text = "-";
                lblFloor1Status.Text = "Elevator Here";
            }
            else
            {
                lblFloor1Status.Text = "-";
                lblFloor0Status.Text = "Elevator Here";

            }
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            MoveTo(1);
        }

        private void btnFloor0_Click(object sender, EventArgs e)
        {
            MoveTo(0);
        }

        private void MoveTo(int Floor)
        {
            currentFloor = Floor;
            UpdateDisplay();

        }

        private void btnRequestFloor1_Click(object sender, EventArgs e)
        {
            MoveTo(1);
        }

        private void btnRequestFloor0_Click(object sender, EventArgs e)
        {
            MoveTo(0);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }
    }
}
