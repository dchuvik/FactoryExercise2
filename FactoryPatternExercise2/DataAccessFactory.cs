using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string dataBaseType)
        {
            switch (dataBaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQL_DataAccess();
                case "mongodb":
                case "mongo":
                    return new Mongo_DataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
