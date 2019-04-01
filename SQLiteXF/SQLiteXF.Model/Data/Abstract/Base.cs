using SQLiteXF.Model.Contract;
using System;

namespace SQLiteXF.Model.Data.Abstract
{
    public class Base : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
