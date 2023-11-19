using System;

namespace scripture_memorizer
{
    public class Word
    {
        public string _text;
        public bool _isHidden;

        public Word(string text)
        {
            text = _text;
            _isHidden = false;
        }
        public void Hide()
        {
            _isHidden = true;
        }
        // public void Show()
        // {
        //     _isHidden = false;
        // }
        public bool IsHidden()
        {
            return _isHidden;
        }
        public string GetDisplayText()
        {
            if (_isHidden == false)
            {
                return _text;
            }
            else
            {
                return "_";
            }
        }
    }
}