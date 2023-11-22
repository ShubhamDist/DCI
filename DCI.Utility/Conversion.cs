using System.Data;
using System.Reflection;

namespace DCI.Utility
{
    public static class Conversion
    {
        public static DateTime ConvertToDateTime(DateTime? dateTime)
        {
            return DateTime.SpecifyKind((DateTime)(dateTime == null ? Convert.ToDateTime("1900-01-01 00:00:00.000") : dateTime), DateTimeKind.Unspecified);
        }


        public static DataTable ListtoDataTableConverter<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);
                
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

    }
}
