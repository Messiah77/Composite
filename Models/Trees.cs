using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Composite.Models
{

    [Table("tree")]
    public class Trees
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250)]
        public string NameComposite { get; set; }

        [MaxLength(250)]
        public string NameLeaf { get; set; }

        [AutoIncrement]
        public string Leaf { get; set; }


    }
}
