using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class Table
    {
        public int TableId { get; private set; }
        public int TableStatus { get; set; }

        public Table(int TableId, int TableStatus)
        {
            this.TableId = TableId;
            this.TableStatus = TableStatus;
        }
    }
}
