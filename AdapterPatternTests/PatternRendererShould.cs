using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterPatternTests
{
    [TestClass]
    public class PatternRendererShould
    {
        [TestMethod]
        public void RenderOnePatern()
        {
            var myRenderer = new PatternRenderer();
            var myList = new List<Patterns>
            {
                new Patterns {Id = 1, Name = "Sutirtha Sahu", Description = "Working"},
                new Patterns {Id = 2, Name = "Sumit Sahu", Description = "Brother"}
            };

            string result = myRenderer.ListPatterns(myList);

            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count + 2, lineCount);
        }
    }
}
