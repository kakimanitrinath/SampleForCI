using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    public class DataPatternRenderer: IDataPatternRenderer
    {
        private DataRenderer _dataRenderer;
        public string ListPatterns(IEnumerable<Patterns> patterns)
        {
            var adapter = new PatternCollectionDbAdapter(patterns);
            _dataRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            _dataRenderer.Render(writer);

            return writer.ToString();
        }

        internal class PatternCollectionDbAdapter : IDbDataAdapter
        {
            private readonly IEnumerable<Patterns> _patterns;

            public PatternCollectionDbAdapter(IEnumerable<Patterns> patterns )
            {
                _patterns = patterns;
            }

            public int Fill(DataSet dataSet)
            {
                var myDataTable = new DataTable();
                myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                foreach (var patterns in _patterns)
                {
                    var myRow = myDataTable.NewRow();
                    myRow[0] = patterns.Id;
                    myRow[1] = patterns.Name;
                    myRow[2] = patterns.Description;
                    myDataTable.Rows.Add(myRow);
                }
                
                dataSet.Tables.Add(myDataTable);
                dataSet.AcceptChanges();

                return myDataTable.Rows.Count;
            }

            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new NotImplementedException();
            }
        }
    }
}
