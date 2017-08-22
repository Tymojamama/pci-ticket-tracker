using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker.Business.Entities
{
    internal interface IBusinessEntity
    {
        void DeleteDatabaseRecord();
        void SaveRecordToDatabase(Guid modifiedBy);
    }
}
