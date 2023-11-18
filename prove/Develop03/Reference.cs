using System;

namespace scripture_generator
{
    class Reference
    {
        public string _book;
        public int _chapter; 
        public int _verse;
        public int _endVerse;

        public Reference(string book, int chapter, int verse)
        {

        }
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {

        }
        public string GetDisplayText()
        {
            string text = $"text...";
            return text;
        }
    }
}