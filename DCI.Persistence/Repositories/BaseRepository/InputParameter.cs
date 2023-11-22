using Dapper;
using System.Reflection;

namespace DCI.Persistence.Repositories.BaseRepository
{
    public static class InputParameter
    {
        public static DynamicParameters GetParameters<T>(T values)
        {
            DynamicParameters input_parameters = new();

            Type type = values.GetType();
            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType.Namespace != "System.Collections.Generic")
                {
                    string name = "@" + prop.Name;
                    object? value = prop.GetValue(values);
                    input_parameters.Add(name, value);
                }
            }
            return input_parameters;
        }


        public static DynamicParameters BindParametersList<T>(T values)
        {
            DynamicParameters input_parameters = new();

            Type type = values.GetType();
            PropertyInfo[] props = type.GetProperties();
            

            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType.Namespace != "System.Collections.Generic")
                {
                    string name = "@" + prop.Name;
                    object? value = prop.GetValue(values);
                    input_parameters.Add(name, value);
                }

                if (prop.PropertyType.Namespace == "System.Collections.Generic")
                {
                    string name = "@" + prop.Name;
                    var v = (prop.GetValue(values));

                    object? value = prop.GetValue(values);                   

                    input_parameters.Add(name, value);
                }
            }
            return input_parameters;
        }
        public static string GetQueryWithParameters<T>(string funcname, T parameters)
        {
            string func_input_parameters = string.Empty;
            Type type = parameters.GetType();
            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                if (prop.PropertyType.Namespace != "System.Collections.Generic")
                {
                    string name = "@" + prop.Name;
                    func_input_parameters += name + ",";
                }
            }
            func_input_parameters = func_input_parameters.Trim(new char[] { ',' });
            string func_input_query = "Select * from " + funcname + "(" + func_input_parameters + ")";

            return func_input_query;
        }
        public static string GetQueryByID<T>(string funcname, T parameters)
        {

            string func_input_query = "Select * from " + funcname + "(" + parameters + ")";
            return func_input_query;
        }
        public static string GetQuery(string funcname)
        {
            string inputquery = "Select * from " + funcname + "()";
            return inputquery;
        }
    }
}
