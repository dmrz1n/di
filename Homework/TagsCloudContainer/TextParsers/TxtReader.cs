﻿using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TagsCloudContainer.TextParsers
{
    public class TxtReader : ITextFormatReader
    {
        public TxtReader() { }

        public IEnumerable<string> GetLines(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    yield return line;
            }
        }
    }
}