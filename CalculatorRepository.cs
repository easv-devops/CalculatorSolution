using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace ConsoleCalculator
{
    public class CalculatorRepository
    {
        private readonly NpgsqlDataSource _dataSource;

        public CalculatorRepository(NpgsqlDataSource dataSource)
        {
            _dataSource = dataSource;
        }   

        public void InsertIntoDatabase(double n1, double n2, double result, string type)
        {
            var parameters = new {n1, n2, type, result};
            using(var conn = _dataSource.OpenConnection())
            {
                conn.Execute($@"insert into calculator.calculations (Number1, Number2, Operator, Result) values
                (@n1, @n2, @type, @result);
                ", parameters);
            }
        }
    }
}