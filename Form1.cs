namespace mdomin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            PictureBox pb = new PictureBox();
            pb.Width = 100;
            pb.Height = 100;
            pb.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pb);
        }
    }
}
