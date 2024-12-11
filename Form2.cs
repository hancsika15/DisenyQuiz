using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DisenyQuiz;

public partial class DisneyQuizGame : Form
{
    private List<string> disneyCharacters;
    private Dictionary<string, Image> imageDictionary;
    private Random random;
    private string correctAnswer;
    private int score = 0;

    private Timer questionTimer;
    private int timeRemaining = 20; // 20 másodperc időlimit

    public DisneyQuizGame()
    {
        InitializeComponent();
        InitializeDisneyCharacters();
        InitializeImageDictionary();

        // Timer beállítása
        questionTimer = new Timer();
        questionTimer.Interval = 1000; // 1 másodperc
        questionTimer.Tick += QuestionTimer_Tick;

        random = new Random();
        character01.Click += CharacterButton_Click;
        character02.Click += CharacterButton_Click;
        character03.Click += CharacterButton_Click;
        characterCorrect.Click += CharacterButton_Click;

        StartNewQuestion(); // Játék indítása az ablak betöltésekor

    }

    private void QuestionTimer_Tick(object sender, EventArgs e)
    {
        timeRemaining--;

        if (timeRemaining > 0)
        {
            lblTimer.Text = "Idő hátra: " + timeRemaining + " másodperc";
        }
        else
        {
            questionTimer.Stop();
            MessageBox.Show("Lejárt az idő!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            score--; // Csökkentsd a pontszámot idő túllépés esetén
            lblscore.Text = "Az eddig elért pontjaid: " + score.ToString();

            StartNewQuestion(); // Új kérdés indítása
        }
    }


    private void InitializeImageDictionary()
    {
        imageDictionary = new Dictionary<string, Image>();

        string imagePath = "C:\\Users\\ny20keresztúrih\\Source\\Repos\\DisenyQuiz\\images\\";

        imageDictionary.Add("Aranyhaj", Image.FromFile(imagePath + "rapunzel.png"));
        imageDictionary.Add("Csipkerózsika", Image.FromFile(imagePath + "csipkerozsika.png"));
        imageDictionary.Add("Elsa", Image.FromFile(imagePath + "elsa.png"));
        imageDictionary.Add("Hamupipőke", Image.FromFile(imagePath + "hamupipoke.png"));
        imageDictionary.Add("Hófehérke", Image.FromFile(imagePath + "hofeherke.png"));
        imageDictionary.Add("Kristoff", Image.FromFile(imagePath + "kristoff.png"));
        imageDictionary.Add("Olaf", Image.FromFile(imagePath + "olaf.png"));
    }

    private void InitializeDisneyCharacters()
    {
        // Lista feltöltése
        disneyCharacters = new List<string>
            {
                "Aranyhaj","Elsa","Anna","Olaf","Kristoff","Sven","Hófehérke","Hét törpe","Hamupipőke","Tündér keresztanya","Csipkerózsika","Flóra","Fána","Fiona","Belle","Szörnyeteg","Gaston","Dzsinn","Abu","Jafar","Szimba","Mufasa","Zordon","Timon","Pumbaa","Nala","Scar","Ariel","Sebastian","Flounder","Ursula","Eric herceg","Max kutya", "Pinokkió", "Dzsepettó", "Tündér", "Tücsök Tihamér", "Dumbo", "Timothy Egér", "Tinker Bell", "Pán Péter", "Hook kapitány", "John", "Michael", "Wendy", "Bagira", "Maugli", "Balu", "Sír Kán", "Kaa", "Jane", "Tarzan", "Clayton", "Kala", "Kerchak", "Robin Hood", "Kis John", "Lady Marian", "Sheriff", "Szultán", "Herkules", "Megara", "Phil", "Hádész", "Pegazus", "Zeusz", "Anna hercegnő", "Rapunzel", "Flynn Rider", "Maximus", "Pascal", "Mother Gothel", "Moana", "Maui", "Heihei", "Tamatoa", "Te Fiti", "Elsőszámú Asszony", "Bolt", "Mittens", "Rhino", "Vanellope", "Ralph", "Felix", "Sgt. Calhoun", "Cukorka Király", "Mike Wazowski", "Sully", "Boo", "Roz", "Randall", "Woody", "Buzz Lightyear", "Jessie", "Mr. Potato Head", "Rex", "Hamm", "Slinky", "Bo Peep", "Remy", "Linguini", "Colette", "Skinner", "Emile", "Gusteau", "Marlin", "Némó", "Dory", "Crush", "Bruce", "Sven", "Wall-E", "Eve", "Auto", "Captain McCrea", "Merida", "Fergus király", "Elinor királynő", "Triplets", "Bambi", "Thumper", "Virág", "Anyakutya", "Balto", "Marie", "Toulouse", "Berlioz", "O'Malley", "Donald kacsa", "Mickey egér", "Minnie egér", "Pluto", "Goofy", "Max Goof", "Pete", "Tiki Taki", "Kanga", "Tigris", "Malacka", "Füles", "Micimackó", "Eperke", "Maui", "Heihei", "Rex", "Ratatouille", "Aurora"
            };
    }


    private void ResetButtonColors()
    {
        character01.BackColor = SystemColors.Control;
        character02.BackColor = SystemColors.Control;
        character03.BackColor = SystemColors.Control;
        characterCorrect.BackColor = SystemColors.Control;
    }

    private void GenerateNewQuestion()
    {
        ResetButtonColors();

        List<string> pickedCharacters = new List<string>();

        while (pickedCharacters.Count < 3)
        {
            string randomCharacter = disneyCharacters[random.Next(disneyCharacters.Count)];
            if (!pickedCharacters.Contains(randomCharacter))
            {
                pickedCharacters.Add(randomCharacter);
            }
        }

        var imageKeys = imageDictionary.Keys.ToList();
        correctAnswer = imageKeys[random.Next(imageKeys.Count)];
        pickedCharacters.Add(correctAnswer);

        pickedCharacters = pickedCharacters.OrderBy(x => random.Next()).ToList();

        character01.Text = pickedCharacters[0];
        character02.Text = pickedCharacters[1];
        character03.Text = pickedCharacters[2];
        characterCorrect.Text = pickedCharacters[3];

        pictureBox1.Image = imageDictionary[correctAnswer];
    }

    private void StartNewQuestion()
    {
        timeRemaining = 20; // Időzítő visszaállítása
        lblTimer.Text = "Idő hátra: " + timeRemaining + " másodperc";
        questionTimer.Start();
        GenerateNewQuestion(); // Új kérdés generálása
    }

    private void CharacterButton_Click(object sender, EventArgs e)
    {
        ResetButtonColors();
        Button clickedButton = sender as Button;

        if (clickedButton != null && clickedButton.Text == correctAnswer)
        {
            score++;
            clickedButton.BackColor = Color.Green;
            lblscore.Text = "Az eddig elért pontjaid: " + score.ToString();
        }
        else
        {
            score--;
            clickedButton.BackColor = Color.Red;
            lblscore.Text = "Az eddig elért pontjaid: " + score.ToString();
        }

        if (score < 0)
        {
            questionTimer.Stop(); // Időzítő leállítása
            MessageBox.Show("Vesztettél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            DisneyQuiz frm = new DisneyQuiz();
            frm.Show();
        }
        else
        {
            StartNewQuestion(); // Új kérdés indítása helyes vagy helytelen válasz után
        }
    }
}
