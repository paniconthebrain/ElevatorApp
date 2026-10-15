namespace ElevatorApp
{
    public partial class Form1 : Form
    {
        int currentFloor = 0;
        int targetFloor = 0;
        int targetTop = 307;
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
            targetFloor = Floor;

            if(Floor==1)
            {
                targetTop = 0;
            }
            else
            {
                targetTop = 310;
            }
            tmrMove.Start();

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

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            const int step = 5;
            int distance = targetTop - pnlCar.Top;

            if (Math.Abs(distance) <= step)
            {
                pnlCar.Top = targetTop;
                tmrMove.Stop();
                currentFloor = targetFloor;
                UpdateDisplay();
            }
            else if (distance < 0)
            {
                pnlCar.Top -= step;
            }
            else
            {
                pnlCar.Top += step;
            }
            
        }
    }
}
