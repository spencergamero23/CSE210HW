namespace Develop03
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verseFrom;
        private  int _verseTo;

        // * Construtors are the name of the class
        // * Usually contain the necessary attributes for the class as parameters
        // * Allows you to assign values to member variables
        // * Is executed upon class creation.
        public Reference (string book, int chapter, int verseFrom)
        {
            _book = book;
            _chapter = chapter;
            _verseFrom = verseFrom;
            _verseTo = verseFrom;
        }
        public Reference (string book, int chapter, int verseFrom, int verseTo)
        {
            _book = book;
            _chapter = chapter;
            _verseFrom = verseFrom;
            _verseTo = verseTo;
        }

        public string ReferenceReturn()
        {
            if (_verseFrom == _verseTo)
            {
                return $"{_book} {_chapter}:{_verseFrom}";    
            }
            
                return $"{_book} {_chapter}:{_verseFrom} - {_verseTo}";
        }

    }
}