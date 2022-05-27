using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revenue_control.Model
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryType CategoryType { get; set; }
        public int CategoryTypeId { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}
