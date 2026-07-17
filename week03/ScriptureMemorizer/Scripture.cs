/*===============================================================
    FILE: Scripture.cs
    PURPOSE: Manager file. Binds the reference locaiton and list of seperate words together
    What is housed here: The logic to split a sentence into single words, the method to pick
    random word to hide, and text the layout generator.
=================================================================*/

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            string[] splitWords = text.Split(' ');
            foreach (string wordText in splitWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();

            List<int> visibleIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                {
                    visibleIndices.Add(i);
                }
            }

            if (visibleIndices.Count == 0) return;

            int actualToHide = Math.Min(numberToHide, visibleIndices.Count);
            int hiddenCount = 0;

            while (hiddenCount < actualToHide)
            {
                int randomIndex = random.Next(visibleIndices.Count);
                int wordIndex = visibleIndices[randomIndex];

                _words[wordIndex].Hide();
                visibleIndices.RemoveAt(randomIndex);
                hiddenCount++;
            }
        }

        public string GetDisplayText()
        {
            List<string> displayWords = new List<string>();
            foreach (Word word in _words)
            {
                displayWords.Add(word.GetDisplayText());
            }

            return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";

        }
        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}