using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSwaggerRestAPI_1._1
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(255), NotNull]
        public string Name { get; set; }

        [MaxLength(255), NotNull]
        public string Surname { get; set; }
    }
}
