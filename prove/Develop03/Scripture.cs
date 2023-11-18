using System;
using System.Security.Cryptography.X509Certificates;

namespace scripture_generator
{
    class Scripture
    {
        public string _reference;
        public List<Word> _words = new List<Word>();

        public Scripture(Reference Reference, string text)
        {

        }
        public void HideRandomWords(int numberToHide)
        {  

        }
        public string GetDisplayText()
        {
            string text = $"text...";
            return text;
        } 
        public bool IsCompletelyHidden()
        {
            bool text = true;
            return text;
        }
    } 
}

