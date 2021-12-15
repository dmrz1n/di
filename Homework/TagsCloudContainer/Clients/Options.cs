﻿using System.Collections.Generic;
using CommandLine;

namespace TagsCloudContainer.Clients
{
    public class Options
    {
        [Value(0, HelpText = "path to input file")]
        public string Input { get; set; }

        [Option('o', "output", Default = "tagcloud", HelpText = "path to output file")]
        public string Output { get; set; }


        [Option('w', "width", Default = 1000, HelpText = "tag cloud image width")]
        public int Width { get; set; }


        [Option('h', "height", Default = 1000, HelpText = "tag cloud image height")]
        public int Height { get; set; }


        [Option('n', "fontName", Default = "Arial", HelpText = "tags fontName")]
        public string FontName { get; set; }

        [Option('s', "fontSize", Default = 20, HelpText = "tags fontSize")]
        public int FontSize { get; set; }

        [Option('c', "color", Default = 0, HelpText = 
            "tag's color scheme (0 - Black and White, 1 - Camouflage, 2 - Cyberpunk")]
        public int Color { get; set; }

        [Option('f', "inputformat", Default = "txt", HelpText = "input file format")]
        public string InputFileFormat { get; set; }

        [Option('i', "outputformat", Default = "png", HelpText = "output file format")]
        public string OutputFileFormat { get; set; }

        [Option('e', "exclude", Default = new[] {""})]
        public IEnumerable<string> ExcludedWords { get; set; }
    }
}
