namespace decoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] words = File.ReadAllLines("data.txt");
            for (int i = 0; i < words.Length; i++)
            {

                to_be_deciphered.Items.Add(words[i]);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = 0,p=0,v=0;
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k','l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u','v','w', 'x', 'y', 'z' };
            string translated,translation="";
            v = to_be_deciphered.Items.Count;
            for (int i = 0; i < v; i++) 
            {
                if (i % 2 != 0)
                {

                }
                else                     
                {

                    translation = Convert.ToString(to_be_deciphered.Items[i]);
                    char[] split_translation = translation.ToCharArray();
                    for (int s = 0; s < translation.Length; s++)
                    {
                        for (int c = 0; c < alphabet.Length; c++)
                        {
                            if (alphabet[c] == translation[s])
                            {
                                position = c;

                            }
                        }
                        if (position < 3)
                        {
                            p = 25 - position;
                            split_translation[s] = alphabet[p];
                        }
                        else
                        {
                            p = position - 3;
                            split_translation[s] = alphabet[p];
                        }
                    }
                    translated = split_translation.ToString();     
                    result.Items.Add(translated);
                   
                }
              
               
            }
        }
    }
}
