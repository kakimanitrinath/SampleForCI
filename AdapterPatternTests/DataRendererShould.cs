using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterPatternTests
{
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void ReturnOneRowFromStubbedAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3,lineCount);
        }

        [TestMethod]
        public void ReturnTwoRowFromOleDatabase()
        {
            var adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("Select * from Pattern");
            adapter.SelectCommand.Connection = new OleDbConnection(@"");
            //var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            //myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(4, lineCount);

        }
    }
}
