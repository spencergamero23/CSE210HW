namespace Develop03
{
    public class Reference
    {
        public string _book;
        public int _chapter;
        public int _verseFrom;
        public  int _verseTo;

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
            return {_book}, {_chapter}, {_verseFrom},{_verseTo};
        }

    }
}