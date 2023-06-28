namespace Develop03
{
    public class Word
    {
        public string _word;

        public bool _isVisible;

        public Word(string word)
        {
            _word = word;
            _isVisible = true;
        }

        public void Hide()
        {
            _word = "_ _ _";
        }
        private void Show()
        {
        }
        private void IsHidden()
        {
            if (_isVisible != true)
            {
                Hide();
            }
            else{
                Show();
            }
        }
        //  ///private string GetRenderedText()
        // {
        //     return 
        // }


    }
}