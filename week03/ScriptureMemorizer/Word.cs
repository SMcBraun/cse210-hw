/*===============================================================
    FILE: Word.cs
    PURPOSE: Rrepresents one individual word in the scripture.
    What is housed here: The word's text, it hidden or visible status, 
    and behaviors for hiding, showing and displaying it.
=================================================================*/

using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return new string('_', _text.Length);
            }
            return _text;
        }


    }
}