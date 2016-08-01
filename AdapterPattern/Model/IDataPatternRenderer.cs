using System.Collections.Generic;

namespace AdapterPattern.Model
{
    public interface IDataPatternRenderer
    {
        string ListPatterns(IEnumerable<Patterns> patterns);
    }
}