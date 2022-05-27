using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revenue_control.Model
{
    public class CategoryType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

    }
}
