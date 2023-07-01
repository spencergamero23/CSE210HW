namespace Develop03
{
    public class Word
    {
        private string _word;

        private bool _isVisible;

        private string _hiddenWord = "";

        public Word(string word)
        {
            _word = word;
            _isVisible = true;
            int wordLength= _word.Length;
            for (int i = 0; i < wordLength; i++)
            {
                _hiddenWord += '_';
            }
        }

        public void Hide()
        {
           _isVisible = false;
        }
        public void Show()
        {
            _isVisible = true;
        }
        public bool IsHidden()
        {
            return !_isVisible;

        }
         public string GetRenderedText()
        {
            return _isVisible ? _word : _hiddenWord; // short hand for if _isVisible is true then _word else hiddenWord
        }


    }
}