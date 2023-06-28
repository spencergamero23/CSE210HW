namespace Develop03
{
    public class Scripture
    {
        List <string> words = new List<string>{};
        string _reference;
        string _text;
        int indexCounter = 0;
        int hiddenCounter = 0;
        public Scripture(string reference, string text)
        {   //scripture holds a reference and a text
            _reference = reference;
            _text = text;
        }
        public void HideWords()
        {
            for(int i = 0; i < 3; i++ )
            {
                words[indexCounter] = Hide();
                indexCounter =+1;
            }
        }

        private void IsCompletelyHidden()
        {
            foreach(string word in words)
            {
                if(word == "_ _ _")
                {
                    hiddenCounter =+1;
                }
                else
                {
                    hiddenCounter =+0;
                }

                if(hiddenCounter == 46)
                {
                    Console.Clear();
                }
            }
        }

    }
}