using System;
using System.Collections.Generic;
using System.Linq;

namespace TextJustification
{
    public class JustifyText
    {
        public static IList<string> Justify(string[] words, int maxWidth)
        {
            var currentLine = "";
            var result_string = new List<string>();
            var currentCount = 0;
            var currentgroup = new List<string>();
            var currentWordIndex = 0;
            foreach (var word in words)
            {
                if (currentCount + word.Length + 1 <= maxWidth)
                {
                    currentgroup.Add(word);
                    if (currentCount > 0)
                        currentCount++;
                    currentCount += word.Length;
                    if (currentWordIndex == words.Length - 1)
                    {
                        currentLine = string.Join(" ", currentgroup);
                        while (currentLine.Length < maxWidth)
                            currentLine += " ";

                        result_string.Add(currentLine);
                    }
                }
                else
                {
                    var currentLineSize = currentgroup.Select(w => w.Length).Sum();
                    var i = 0;
                    while (currentLineSize < maxWidth)
                    {
                        currentgroup[i] += " ";
                        currentLineSize = currentgroup.Select(w => w.Length).Sum();
                        i++;
                        if (i >= currentgroup.Count() - 1) i = 0;
                    }
                    currentLine = String.Join("", currentgroup);
                    result_string.Add(currentLine);
                    currentgroup = new List<string>();
                    currentCount = 0;

                    currentgroup.Add(word);
                    if (currentCount > 0) currentCount++;
                    currentCount += word.Length;

                    if (currentWordIndex == words.Length - 1)
                    {
                        currentLine = String.Join(" ", currentgroup);
                        while (currentLine.Length < maxWidth)
                            currentLine += " ";

                        result_string.Add(currentLine);
                    }
                }

                currentWordIndex++;
            }
            return result_string;
        }
    }
}