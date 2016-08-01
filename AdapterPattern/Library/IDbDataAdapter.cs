using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IDbDataAdapter
    {
        DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType);
        int Fill(DataSet dataSet);

        IDataParameter[] GetFillParameters();
    }
}
