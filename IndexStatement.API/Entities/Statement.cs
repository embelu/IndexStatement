using System;
using System.Collections.Generic;

#nullable disable

namespace IndexStatement.API.Entities
{
    public partial class Statement
    {
        public int Id { get; set; }
        public int EnergyTypeId { get; set; }
        public int StatementValueId { get; set; }
        public DateTime Date { get; set; }

        public virtual EnergyType EnergyType { get; set; }
        public virtual StatementValue StatementValue { get; set; }
    }
}
