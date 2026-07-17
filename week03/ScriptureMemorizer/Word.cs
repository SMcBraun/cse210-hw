/*===============================================================
    FILE: Word.cs
    PURPOSE: Small building block. Every word in the scripture is its own individual
    object so it can retain its own status.
    What is housed here: Variable to hold the words and a true/false status tracking
    if its should show up normally s or as underscores.
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