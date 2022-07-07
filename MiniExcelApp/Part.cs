using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExcelApp
{
    public class Part
    {
        [ExcelColumnName("ID")]
        public int Id { get; set; }

        [ExcelIgnore]
        public DateTime Birth { get; set; }

        [ExcelColumnName("Part number")]
        public string? Partnumber { get; set; }

        [ExcelColumnName("Lot number")]
        public string?  Lotnumber { get; set; }
    }
}
