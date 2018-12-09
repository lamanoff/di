﻿using System.Linq;
using JetBrains.Annotations;
using NHunspell;
using TagCloud.Interfaces;

namespace TagCloud
{
    public class InfinitiveCastProcessor : IWordProcessor
    {
        private readonly Hunspell hunspell;

        public InfinitiveCastProcessor(string affixFileData, string dictionaryFileData)
        {
            hunspell = new Hunspell(affixFileData, dictionaryFileData);
        }

        [CanBeNull]
        public string Process(string word)
            => hunspell.Stem(word).FirstOrDefault();
    }
}