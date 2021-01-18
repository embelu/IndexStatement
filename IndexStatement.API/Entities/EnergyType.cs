using System;
using System.Collections.Generic;

#nullable disable

namespace IndexStatement.API.Entities
{
    public partial class EnergyType
    {
        public EnergyType()
        {
            Statements = new HashSet<Statement>();
        }

        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<Statement> Statements { get; set; }
    }
}
