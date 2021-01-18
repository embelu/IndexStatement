using System;
using System.Collections.Generic;

#nullable disable

namespace IndexStatement.API.Entities
{
    public partial class Unity
    {
        public Unity()
        {
            StatementValues = new HashSet<StatementValue>();
        }

        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<StatementValue> StatementValues { get; set; }
    }
}
