namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboboxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeComboboxes()
        {
            // Names to populate the first combobox
            List<string> names = new List<string> { "Gökberk", "Mahmut", "Şimal", "Emine", "Eren", "Yiğit", "Veli" };
            comboBoxNames.DataSource = names;

            // Hair color list (all are black)
            List<string> hairColors = new List<string> { "Black" };
            comboBoxHairColor.DataSource = hairColors;

            // Eye color list
            List<string> eyeColors = new List<string> { "Green", "Brown", "Black", "Blue", "Purple" };
            comboBoxEyeColor.DataSource = eyeColors;

            // Place of living list
            List<string> places = new List<string> { "Çanakkale", "İstanbul", "Antalya", "İzmir", "Ankara" };
            comboBoxPlace.DataSource = places;

            // Add event handler to the name combobox to update the other comboboxes when the name changes
            comboBoxNames.SelectedIndexChanged += ComboBoxNames_SelectedIndexChanged;
        }

        // When the selected name changes, randomly shuffle the values in the other comboboxes
        private void ComboBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Randomize hair color (since all are black in this case, we keep it black)
            comboBoxHairColor.SelectedIndex = 0;  // Always black

            // Randomize eye color (from the list of colors)
            List<string> eyeColors = new List<string> { "Green", "Brown", "Black", "Blue", "Purple" };
            comboBoxEyeColor.SelectedIndex = rand.Next(eyeColors.Count);

            // Randomize place of living (from the list of places)
            List<string> places = new List<string> { "Çanakkale", "İstanbul", "Antalya", "İzmir", "Ankara" };
            comboBoxPlace.SelectedIndex = rand.Next(places.Count);
        }




        private void eyeColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
