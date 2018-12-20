using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    public class TableService
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

        public void ChangeTableStatus(Table table)
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

            tableDAL.ChangeTableStatus(status, table);
        }

        public int GetTableId(Table table)
        {
            return tableDAL.GetTableId(table);
        }
    }
}
