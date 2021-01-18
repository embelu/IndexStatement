using System;
using System.Collections.Generic;

#nullable disable

namespace IndexStatement.API.Entities
{
    public partial class StatementValue
    {
        public StatementValue()
        {
            Statements = new HashSet<Statement>();
        }

        public int Id { get; set; }
        public int UnityId { get; set; }
        public string Value { get; set; }

        public virtual Unity Unity { get; set; }
        public virtual ICollection<Statement> Statements { get; set; }
    }
}
