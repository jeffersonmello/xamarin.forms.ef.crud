using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteXF.Model.Contract
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
