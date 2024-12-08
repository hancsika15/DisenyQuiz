using System.Windows.Forms;

namespace DisenyQuiz
{
    public partial class DisneyQuiz : Form
    {
        private List<string> disneyCharacters; // Lista a karakterek t�rol�s�ra
        private Random random; // Random gener�tor
        private Dictionary<string, Image> imageDictionary; // K�pek sz�t�ra
        private string correctAnswer; // Helyes v�lasz t�rol�sa


        public DisneyQuiz()
        {
            InitializeComponent();
            InitializeDisneyCharacters();
            InitializeImageDictionary();

            random = new Random(); // Random gener�tor inicializ�l�sa
            btnRandomCharacter.Click += new EventHandler(btnPickRandom_Click);

            // Gombok esem�nykezel�inek be�ll�t�sa
            character01.Click += new EventHandler(CharacterButton_Click);
            character02.Click += new EventHandler(CharacterButton_Click);
            character03.Click += new EventHandler(CharacterButton_Click);
            characterCorrect.Click += new EventHandler(CharacterButton_Click);
        }

        private void InitializeImageDictionary()
        {
            imageDictionary = new Dictionary<string, Image>();

            // K�pek bet�lt�se f�jlb�l �s hozz�ad�sa a sz�t�rhoz
            string imagePath = "C:\\Users\\User\\Desktop\\DisenyQuiz\\images\\";

            imageDictionary.Add("Aranyhaj", Image.FromFile(imagePath + "rapunzel.png"));
            imageDictionary.Add("Csipker�zsika", Image.FromFile(imagePath + "csipkerozsika.png"));
            imageDictionary.Add("Elsa", Image.FromFile(imagePath + "elsa.png"));
            imageDictionary.Add("Hamupip�ke", Image.FromFile(imagePath + "hamupipoke.png"));
            imageDictionary.Add("H�feh�rke", Image.FromFile(imagePath + "hofeherke.png"));
            imageDictionary.Add("Kristoff", Image.FromFile(imagePath + "kristoff.png"));
            imageDictionary.Add("Olaf", Image.FromFile(imagePath + "olaf.png"));
        }

        private void InitializeDisneyCharacters()
        {
            // Lista felt�lt�se
            disneyCharacters = new List<string>
            {
                "Aranyhaj","Elsa","Anna","Olaf","Kristoff","Sven","H�feh�rke","H�t t�rpe","Hamupip�ke","T�nd�r keresztanya","Csipker�zsika","Fl�ra","F�na","Fiona","Belle","Sz�rnyeteg","Gaston","Dzsinn","Abu","Jafar","Szimba","Mufasa","Zordon","Timon","Pumbaa","Nala","Scar","Ariel","Sebastian","Flounder","Ursula","Eric herceg","Max kutya", "Pinokki�", "Dzsepett�", "T�nd�r", "T�cs�k Tiham�r", "Dumbo", "Timothy Eg�r", "Tinker Bell", "P�n P�ter", "Hook kapit�ny", "John", "Michael", "Wendy", "Bagira", "Maugli", "Balu", "S�r K�n", "Kaa", "Jane", "Tarzan", "Clayton", "Kala", "Kerchak", "Robin Hood", "Kis John", "Lady Marian", "Sheriff", "Szult�n", "Herkules", "Megara", "Phil", "H�d�sz", "Pegazus", "Zeusz", "Anna hercegn�", "Rapunzel", "Flynn Rider", "Maximus", "Pascal", "Mother Gothel", "Moana", "Maui", "Heihei", "Tamatoa", "Te Fiti", "Els�sz�m� Asszony", "Bolt", "Mittens", "Rhino", "Vanellope", "Ralph", "Felix", "Sgt. Calhoun", "Cukorka Kir�ly", "Mike Wazowski", "Sully", "Boo", "Roz", "Randall", "Woody", "Buzz Lightyear", "Jessie", "Mr. Potato Head", "Rex", "Hamm", "Slinky", "Bo Peep", "Remy", "Linguini", "Colette", "Skinner", "Emile", "Gusteau", "Marlin", "N�m�", "Dory", "Crush", "Bruce", "Sven", "Wall-E", "Eve", "Auto", "Captain McCrea", "Merida", "Fergus kir�ly", "Elinor kir�lyn�", "Triplets", "Bambi", "Thumper", "Vir�g", "Anyakutya", "Balto", "Marie", "Toulouse", "Berlioz", "O'Malley", "Donald kacsa", "Mickey eg�r", "Minnie eg�r", "Pluto", "Goofy", "Max Goof", "Pete", "Tiki Taki", "Kanga", "Tigris", "Malacka", "F�les", "Micimack�", "Eperke", "Maui", "Heihei", "Rex", "Ratatouille", "Aurora"
            };
        }

        private void btnPickRandom_Click(object sender, EventArgs e)
        {
            List<string> pickedCharacters = new List<string>();

            //V�letlenszer� karakterek a list�b�l
            while (pickedCharacters.Count < 3)
            {
                string randomCharacter = disneyCharacters[random.Next(disneyCharacters.Count)];
                if (!pickedCharacters.Contains(randomCharacter))
                {
                    pickedCharacters.Add(randomCharacter);
                }
            }

            //Gombok friss�t�se a list�b�l
            character01.Text = pickedCharacters[0];
            character02.Text = pickedCharacters[1];
            character03.Text = pickedCharacters[2];

            //V�letlenszer� helyes v�lasz a dictionary-b�l
            var imageKeys = imageDictionary.Keys.ToList();
            correctAnswer = imageKeys[random.Next(imageKeys.Count)];

            //Helyes v�lasz be�ll�t�sa
            characterCorrect.Text = correctAnswer;
            pictureBox1.Image = imageDictionary[correctAnswer];


        }

        private void CharacterButton_Click(object sender, EventArgs e)
        {
            // A gomb sz�veg�nek ellen�rz�se
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Text == correctAnswer)
            {
                MessageBox.Show("Helyes v�lasz!", "Eredm�ny", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Helytelen v�lasz.", "Eredm�ny", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }     
    }
}
