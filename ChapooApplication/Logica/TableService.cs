using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class TableService
    {
        private ITableDAL tableDAL = new TableDAL();
 
        public List<Table> GetAllTables()
        {
            List<Table> TableList = tableDAL.GetAllTables();

            return TableList;
        }

        public TableStatus GetTableStatus(Table table)
        {
            int status = table.TableStatus;
            TableStatus tableStatus = (TableStatus)status;

            return tableStatus;
        }

        public int ChangeTableStatus(Table table)
        {
            int status;

            if (table.TableStatus == 3)
            {
                status = 1;
            }
            else
            {
                status = table.TableStatus + 1;
            }

            return status;
        }
    }
}
