﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TagsCloudContainer
{
    public class WordsGetter
    {
        private readonly string path;
        private readonly HashSet<string> boringWords;
        private readonly Dictionary<string, int> wordsQuantities;

        public WordsGetter(string path, IEnumerable<string> boringWords)
        {
            this.path = path;
            this.boringWords = boringWords.ToHashSet();
            wordsQuantities = GetWordsFromFile(path);
        }

        public IReadOnlyDictionary<string, int> GetWordsQuantities()
            => wordsQuantities;

        public int GetDistinctWordsCount()
            => wordsQuantities.Count;

        private Dictionary<string, int> GetWordsFromFile(string path)
        {
            var words = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    if (boringWords.Contains(line)) continue;
                    if (!words.TryGetValue(line,  out _))
                        words.Add(line, 0);
                    words[line]++;
                }
            }

            return words;
        }
    }
}