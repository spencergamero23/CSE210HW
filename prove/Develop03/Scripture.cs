namespace Develop03
{
    public class Scripture
    {
       private List <Word> words = new List<Word>{};
       private Reference _reference;
       private string _text;
       private int hiddenCounter = 0;

        public Scripture(Reference reference, string text)
        {   //scripture holds a reference and a text
            _reference = reference;
            _text = text;
            foreach(string str in text.Split(' '))
            {
                Word word = new Word(str);
                words.Add(word);
            }
        }
        public void HideWords()
        {   
            int number = words.Count;
            int counter = 0;
            while(counter < 3 && !IsCompletelyHidden())
            {
                Random rndm = new Random();
                int index = rndm.Next(number);

                if (words.ElementAt(index).IsHidden() == false)
                {
                    words.ElementAt(index).Hide();
                    counter++;
                    hiddenCounter++;
                }
            }
        }

        public bool IsCompletelyHidden()
        {
            return hiddenCounter == words.Count;
        }

        public string GetRenderedText()
        {
            string neWord = _reference.ReferenceReturn() + " ";

            foreach(Word word in words)
            {
                neWord += word.GetRenderedText();
                neWord += " ";
            }
            return neWord;
        }

    }
}