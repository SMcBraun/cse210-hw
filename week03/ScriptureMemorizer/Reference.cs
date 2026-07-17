/*===============================================================
    FILE: Reference.cs
    PURPOSE: Manages the location details of your scripture(Book, Chapter, Verses).
        It keeps that information grouped together so you dont have to track numbers.
    What is housed here: Data fields for bookname, chapter number, single verses, and verse
        range, rules on how to write them out.
=================================================================*/

using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = verse;
        }


        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            if (_verse == _endVerse)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}--{_endVerse}";
            }
        }
    }

}