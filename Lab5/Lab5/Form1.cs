using Lab5.PokemonList;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public List<Pokemon> Pokemons = new List<Pokemon>();
        Pokemon selectPokemon;
        Pokemon selectBoss;
        int selected;
        int heart = 4;
        int emheart = 1;
        public Form1()
        {
            InitializeComponent();
            Pokemons.Add(new Venusaur());
            Pokemons.Add(new Raichu());
            Pokemons.Add(new Blastoise());
            Pokemons.Add(new Butterfree());
            selectBoss = new Nidoking();

            this.pictureBox2.Image = selectBoss.getImage();
            this.label10.Text = "Nidoking";
            this.label12.Text = selectBoss.getAttack().ToString();
            this.label11.Text = selectBoss.getHp().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[0];
            this.pictureBox1.Image = selectPokemon.getImage();
            this.label7.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label9.Text = selectPokemon.getAttack().ToString();
            this.selected = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[1];
            this.pictureBox1.Image = selectPokemon.getImage();
            this.label7.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label9.Text = selectPokemon.getAttack().ToString();
            this.selected = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[2];
            this.pictureBox1.Image = selectPokemon.getImage();
            this.label7.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label9.Text = selectPokemon.getAttack().ToString();
            this.selected = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[3];
            this.pictureBox1.Image = selectPokemon.getImage();
            this.label7.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label9.Text = selectPokemon.getAttack().ToString();
            this.selected = 4;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            selectBoss.takeDamage(selectPokemon.getAttack());
            this.label11.Text = selectBoss.getHp().ToString();
            
            await Task.Delay(1000);
            selectPokemon.takeDamage(selectBoss.getAttack());
            if (selectPokemon.getHp() <= 0)
            {
                if (selected == 1)
                {
                    this.button1.Hide();
                }
                if (selected == 2)
                {
                    this.button2.Hide();
                }
                if (selected == 3)
                {
                    this.button3.Hide();
                }
                if (selected == 4)
                {
                    this.button4.Hide();
                }
                this.pictureBox1.Image = null;
                this.label7.Text = null;
                this.label8.Text = null;
                this.label9.Text = null;
                this.heart -= 1;
                if (heart == 0)
                {
                    MessageBox.Show("You Lose!\nGame Over");
                }
                return;
            }
            if (selectBoss.getHp() <= 0)
            {
                this.pictureBox2.Image = null;
                this.label10.Text = null;
                this.label11.Text = null;
                this.label12.Text = null;
                this.emheart -= 1;
                if (emheart == 0)
                {
                    MessageBox.Show("You Win!");
                }
            }
            this.label8.Text = selectPokemon.getHp().ToString();
        }
    }
}