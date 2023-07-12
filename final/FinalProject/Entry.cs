using System;
namespace FinalProject
{
    public class Entry
    {
        private string _name;
        private string _artist;

        public string ConvertToFile()
        {
            return $"{_name},{_artist}";
        } 
         public string ConvertToString()
        {
            return $"{_name} - {_artist}";
    
        }
        public void Hold(string name, string artist)
        {
            _name = name;
            _artist = artist;
        }

    }
}