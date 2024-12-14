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
    private int timeRemaining = 10;

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

    private void InitializeImageDictionary()
    {
        imageDictionary = new Dictionary<string, Image>();

        string imagePath = "C:\\Users\\User\\Source\\Repos\\DisenyQuiz\\images\\";

        imageDictionary.Add("Abu", Image.FromFile(imagePath + "abu.jpg"));
        imageDictionary.Add("Anna", Image.FromFile(imagePath + "anna.jpg"));
        imageDictionary.Add("Aranyhaj", Image.FromFile(imagePath + "aranyhaj.jpg"));
        imageDictionary.Add("Ariel", Image.FromFile(imagePath + "ariel.jpg"));
        imageDictionary.Add("Bambi", Image.FromFile(imagePath + "bambi.jpg"));
        imageDictionary.Add("Belle", Image.FromFile(imagePath + "belle.jpg"));
        imageDictionary.Add("Bolt", Image.FromFile(imagePath + "bolt.jpg"));
        imageDictionary.Add("Buzz Lightyear", Image.FromFile(imagePath + "buzzLightyear.jpg"));
        imageDictionary.Add("Daisy", Image.FromFile(imagePath + "daisy.jpg"));
        imageDictionary.Add("Elsa", Image.FromFile(imagePath + "elsa.jpg"));
        imageDictionary.Add("Eperke", Image.FromFile(imagePath + "eperke.jpg"));
        imageDictionary.Add("Fiona", Image.FromFile(imagePath + "fiona.jpg"));
        imageDictionary.Add("Flynn Rider", Image.FromFile(imagePath + "flynnrider.jpg"));
        imageDictionary.Add("Füles", Image.FromFile(imagePath + "fules.jpg"));
        imageDictionary.Add("Gaston", Image.FromFile(imagePath + "gaston.jpg"));
        imageDictionary.Add("Goofy", Image.FromFile(imagePath + "goofy.jpg"));
        imageDictionary.Add("Hádész", Image.FromFile(imagePath + "hadesz.jpg"));
        imageDictionary.Add("Hófehérke", Image.FromFile(imagePath + "hofeherke.jpg"));
        imageDictionary.Add("Jafar", Image.FromFile(imagePath + "jafar.jpg"));
        imageDictionary.Add("Jessie", Image.FromFile(imagePath + "jessie.jpg"));
        imageDictionary.Add("Judy Hoops", Image.FromFile(imagePath + "judyhoops.jpg"));
        imageDictionary.Add("Malacka", Image.FromFile(imagePath + "malacka.jpg"));
        imageDictionary.Add("Maximus", Image.FromFile(imagePath + "maximus.jpg"));
        imageDictionary.Add("Mézi", Image.FromFile(imagePath + "mezi.jpg"));
        imageDictionary.Add("Mickey Mouse", Image.FromFile(imagePath + "mickeyMouse.jpg"));
        imageDictionary.Add("Mike Wazowski", Image.FromFile(imagePath + "mikeWazowski.jpg"));
        imageDictionary.Add("Moana", Image.FromFile(imagePath + "moana.jpg"));
        imageDictionary.Add("Nick Wilde", Image.FromFile(imagePath + "nickwilde.jpg"));
        imageDictionary.Add("Olaf", Image.FromFile(imagePath + "olaf.jpg"));
        imageDictionary.Add("Pascal", Image.FromFile(imagePath + "pascal.jpg"));
        imageDictionary.Add("Pluto", Image.FromFile(imagePath + "pluto.jpg"));
        imageDictionary.Add("Pumbaa", Image.FromFile(imagePath + "pumbaa.jpg"));
        imageDictionary.Add("Randall", Image.FromFile(imagePath + "randall.jpg"));
        imageDictionary.Add("Remy", Image.FromFile(imagePath + "remy.jpg"));
        imageDictionary.Add("Rex", Image.FromFile(imagePath + "rex.jpg"));
        imageDictionary.Add("Rugó", Image.FromFile(imagePath + "rugo.jpg"));
        imageDictionary.Add("Sebastian", Image.FromFile(imagePath + "sebastian.jpg"));
        imageDictionary.Add("Shrek", Image.FromFile(imagePath + "shrek.jpg"));
        imageDictionary.Add("Sully", Image.FromFile(imagePath + "sulley.jpg"));
        imageDictionary.Add("Sven", Image.FromFile(imagePath + "sven.jpg"));
        imageDictionary.Add("Szamár", Image.FromFile(imagePath + "szamar.jpg"));
        imageDictionary.Add("Szörnyeteg", Image.FromFile(imagePath + "szornyeteg.jpg"));
        imageDictionary.Add("Tigris", Image.FromFile(imagePath + "tigris.jpg"));
        imageDictionary.Add("Timon", Image.FromFile(imagePath + "timon.jpg"));
        imageDictionary.Add("Ursula", Image.FromFile(imagePath + "ursula.jpg"));
        imageDictionary.Add("Woody", Image.FromFile(imagePath + "woody.jpg"));
    }
    private void InitializeDisneyCharacters()
    {
        // Lista feltöltése
        disneyCharacters = new List<string>
        {
                "Hét törpe","Tündérkeresztanya","Flóra","Fána","Dzsinn","Szimba","Mufasa","Zordon","Nala","Scar","Flounder","Eric herceg","Max kutya","Pinokkió","Dzsepettó","Tündér","Tücsök Tihamér","Dumbo","Timothy Egér","Tinker Bell","Pán Péter","Hook kapitány","John","Michael","Wendy","Bagira","Maugli","Balu","Sír Kán","Kaa","Jane","Tarzan","Clayton","Kala","Kerchak","Robin Hood","Kis John","Lady Marian","Sheriff","Szultán","Herkules","Megara","Phil","Pegazus","Zeusz","Anna hercegnő","Mother Gothel","Maui","Heihei","Tamatoa","Te Fiti","Elsőszámú Asszony","Mittens","Rhino","Vanellope","Ralph","Felix","Sgt. Calhoun","Cukorka Király","Boo","Roz","Mr. Potato Head","Hamm","Slinky","Bo Peep","Linguini","Colette","Skinner","Emile","Gusteau","Marlin","Némó","Dory","Crush","Bruce","Sven","Wall-E","Eve","Auto","Captain McCrea","Merida","Fergus király","Elinor királynő","Triplets","Thumper","Virág","Anyakutya","Balto","Marie","Toulouse","Berlioz","O'Malley","Donald kacsa","Minnie egér","Max Goof","Pete","Tiki Taki","Kanga","Micimackó","Ratatouille","Aurora","Kuzco","Kronk","Yzma","Pacha","Esmeralda","Quasimodo","Phoebus","Frollo","Clopin","Pocahontas","John Smith","Meeko","Ratcliffe","Thomas","Nakoma","Percy","Vanessa","Gideon","Honest John","Roo","Winnifred Banks","George Banks","Bert","Mary Poppins","Madame Medúza","Bianca","Bernard","Madame Mim","Arthur","Merlin","Archimedes","Madame Bonfamille","Edgar","Frou-Frou","Napoleon","Lafayette","Tiana","Naveen","Dr. Facilier","Charlotte","Mama Odie","Louis","Ray","Eudora","Big Daddy La Bouff","Scat Cat","Colonel Hathi","Winifred","King Louie","Akela","Raksha","Colonel","Seargent Tibbs","Lucy","Lord Henry Mystic","Albert","Rafiki","Sarabi","Kiara","Kovu","Vitani","Nuka","Ranjan","Zira","Tantor","Professor Ratigan","Basil","Dawson","Olivia Flaversham","Fidget"
        };
    }
    private void QuestionTimer_Tick(object sender, EventArgs e)
    {
        timeRemaining--;

        if (timeRemaining > 0)
        {
            lblTimer.Text = timeRemaining + " másodperc";
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
        timeRemaining = 10;
        lblTimer.Text = timeRemaining + " másodperc";
        questionTimer.Start();

        if (score < 0)
        {
            questionTimer.Stop();
            MessageBox.Show("Vesztettél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            DisneyQuiz frm = new DisneyQuiz();
            frm.Show();
        }

        GenerateNewQuestion();
    }
    private void ResetButtonColors()
    {
        character01.BackColor = SystemColors.Control;
        character02.BackColor = SystemColors.Control;
        character03.BackColor = SystemColors.Control;
        characterCorrect.BackColor = SystemColors.Control;
    }
    private void CharacterButton_Click(object sender, EventArgs e)
    {
        ResetButtonColors();
        Button clickedButton = sender as Button;

        if (clickedButton != null && clickedButton.Text == correctAnswer)
        {
            score++;
        }
        else
        {
            score--;
        }

        // Frissítsd a pontszámot a felületen
        lblscore.Text = "Az eddig elért pontjaid: " + score.ToString();

        if (score < 0)
        {
            questionTimer.Stop();
            MessageBox.Show("Vesztettél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            DisneyQuiz frm = new DisneyQuiz();
            frm.Show();
        }
        else if (score == 15)
        {
            questionTimer.Stop();
            MessageBox.Show("Nyertél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            DisneyQuiz frm = new DisneyQuiz();
            frm.Show();
        }
        else
        {
            StartNewQuestion(); // Új kérdés indítása helyes vagy helytelen válasz után
        }
    }
    private void btnexit_Click(object sender, EventArgs e)
    {
        questionTimer.Stop(); 
        MessageBox.Show("Kiléptél a játékból!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        this.Hide();
        DisneyQuiz frm = new DisneyQuiz();
        frm.Show();
    }
}