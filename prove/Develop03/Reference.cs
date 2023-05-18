namespace Develop03
{
    public class Reference
    {
        string _book;
        int _chapter;
        int _verseFrom;
        int _verseTo;

        public Reference(string book, int chapter, int verseFrom)
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
            _verseFrom = verseTo;
        }
    }
}