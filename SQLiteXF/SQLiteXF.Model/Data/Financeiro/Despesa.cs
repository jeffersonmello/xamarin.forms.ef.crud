using SQLiteXF.Model.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteXF.Model.Data.Financeiro
{
    public class Despesa : Base
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Pago { get; set; }
    }
}
