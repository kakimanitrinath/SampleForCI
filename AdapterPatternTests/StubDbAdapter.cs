using System.Data;
using IDbDataAdapter = AdapterPattern.IDbDataAdapter;

namespace AdapterPatternTests
{
    public class StubDbAdapter : IDbDataAdapter
    {
        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new System.NotImplementedException();
        }

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof (int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof (string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof (string)));

            var myRow = myDataTable.NewRow();
            myRow[0] = 1;
            myRow[1] = "Sutirtha";
            myRow[2] = "Working in TESCO";
            myDataTable.Rows.Add(myRow);
            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return 1;
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new System.NotImplementedException();
        }
    }
}