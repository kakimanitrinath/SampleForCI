using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    public class PatternRenderer
    {
        private readonly IDataPatternRenderer _dataPatternRenderer;

        public PatternRenderer(IDataPatternRenderer dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public PatternRenderer() : this (new DataPatternRenderer())
        {
            
        }

        public string ListPatterns(IEnumerable<Patterns> patterns)
        {
            return _dataPatternRenderer.ListPatterns(patterns);
        }
    }
}
