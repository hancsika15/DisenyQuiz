using System.Windows.Forms;

namespace DisenyQuiz
{
    public partial class DisneyQuiz : Form
    {
        private List<string> disneyCharacters; // Lista a karakterek tárolására
        private Random random; // Random generátor
        private Dictionary<string, Image> imageDictionary; // Képek szótára
        private string correctAnswer; // Helyes válasz tárolása


        public DisneyQuiz()
        {
            InitializeComponent();
            InitializeDisneyCharacters();
            InitializeImageDictionary();

            random = new Random(); // Random generátor inicializálása
            btnRandomCharacter.Click += new EventHandler(btnPickRandom_Click);

            // Gombok eseménykezelõinek beállítása
            character01.Click += new EventHandler(CharacterButton_Click);
            character02.Click += new EventHandler(CharacterButton_Click);
            character03.Click += new EventHandler(CharacterButton_Click);
            characterCorrect.Click += new EventHandler(CharacterButton_Click);
        }

        private void InitializeImageDictionary()
        {
            imageDictionary = new Dictionary<string, Image>();

            // Képek betöltése fájlból és hozzáadása a szótárhoz
            string imagePath = "C:\\Users\\User\\Desktop\\DisenyQuiz\\images\\";

            imageDictionary.Add("Aranyhaj", Image.FromFile(imagePath + "rapunzel.png"));
            imageDictionary.Add("Csipkerózsika", Image.FromFile(imagePath + "csipkerozsika.png"));
            imageDictionary.Add("Elsa", Image.FromFile(imagePath + "elsa.png"));
            imageDictionary.Add("Hamupipõke", Image.FromFile(imagePath + "hamupipoke.png"));
            imageDictionary.Add("Hófehérke", Image.FromFile(imagePath + "hofeherke.png"));
            imageDictionary.Add("Kristoff", Image.FromFile(imagePath + "kristoff.png"));
            imageDictionary.Add("Olaf", Image.FromFile(imagePath + "olaf.png"));
        }

        private void InitializeDisneyCharacters()
        {
            // Lista feltöltése
            disneyCharacters = new List<string>
            {
                "Aranyhaj","Elsa","Anna","Olaf","Kristoff","Sven","Hófehérke","Hét törpe","Hamupipõke","Tündér keresztanya","Csipkerózsika","Flóra","Fána","Fiona","Belle","Szörnyeteg","Gaston","Dzsinn","Abu","Jafar","Szimba","Mufasa","Zordon","Timon","Pumbaa","Nala","Scar","Ariel","Sebastian","Flounder","Ursula","Eric herceg","Max kutya", "Pinokkió", "Dzsepettó", "Tündér", "Tücsök Tihamér", "Dumbo", "Timothy Egér", "Tinker Bell", "Pán Péter", "Hook kapitány", "John", "Michael", "Wendy", "Bagira", "Maugli", "Balu", "Sír Kán", "Kaa", "Jane", "Tarzan", "Clayton", "Kala", "Kerchak", "Robin Hood", "Kis John", "Lady Marian", "Sheriff", "Szultán", "Herkules", "Megara", "Phil", "Hádész", "Pegazus", "Zeusz", "Anna hercegnõ", "Rapunzel", "Flynn Rider", "Maximus", "Pascal", "Mother Gothel", "Moana", "Maui", "Heihei", "Tamatoa", "Te Fiti", "Elsõszámú Asszony", "Bolt", "Mittens", "Rhino", "Vanellope", "Ralph", "Felix", "Sgt. Calhoun", "Cukorka Király", "Mike Wazowski", "Sully", "Boo", "Roz", "Randall", "Woody", "Buzz Lightyear", "Jessie", "Mr. Potato Head", "Rex", "Hamm", "Slinky", "Bo Peep", "Remy", "Linguini", "Colette", "Skinner", "Emile", "Gusteau", "Marlin", "Némó", "Dory", "Crush", "Bruce", "Sven", "Wall-E", "Eve", "Auto", "Captain McCrea", "Merida", "Fergus király", "Elinor királynõ", "Triplets", "Bambi", "Thumper", "Virág", "Anyakutya", "Balto", "Marie", "Toulouse", "Berlioz", "O'Malley", "Donald kacsa", "Mickey egér", "Minnie egér", "Pluto", "Goofy", "Max Goof", "Pete", "Tiki Taki", "Kanga", "Tigris", "Malacka", "Füles", "Micimackó", "Eperke", "Maui", "Heihei", "Rex", "Ratatouille", "Aurora"
            };
        }

        private void btnPickRandom_Click(object sender, EventArgs e)
        {
            List<string> pickedCharacters = new List<string>();

            //Véletlenszerû karakterek a listából
            while (pickedCharacters.Count < 3)
            {
                string randomCharacter = disneyCharacters[random.Next(disneyCharacters.Count)];
                if (!pickedCharacters.Contains(randomCharacter))
                {
                    pickedCharacters.Add(randomCharacter);
                }
            }

            //Gombok frissítése a listából
            character01.Text = pickedCharacters[0];
            character02.Text = pickedCharacters[1];
            character03.Text = pickedCharacters[2];

            //Véletlenszerû helyes válasz a dictionary-ból
            var imageKeys = imageDictionary.Keys.ToList();
            correctAnswer = imageKeys[random.Next(imageKeys.Count)];

            //Helyes válasz beállítása
            characterCorrect.Text = correctAnswer;
            pictureBox1.Image = imageDictionary[correctAnswer];


        }

        private void CharacterButton_Click(object sender, EventArgs e)
        {
            // A gomb szövegének ellenõrzése
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Text == correctAnswer)
            {
                MessageBox.Show("Helyes válasz!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Helytelen válasz.", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }     
    }
}
