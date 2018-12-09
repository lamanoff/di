﻿using System.Linq;
using TagCloud.Interfaces;

namespace TagCloud
{
    public class WordFilterByFile : IWordFilter
    {
        private readonly string[] stopWords;

        public WordFilterByFile(IFileReader fileReader, string path)
        {
            stopWords = fileReader.Read(path).ToArray();
        }

        public bool ToExclude(string word)
        {
            return stopWords.Contains(word);
        }
    }
}