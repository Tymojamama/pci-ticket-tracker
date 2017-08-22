using PensionConsultants.Data.Access;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker.Business.Components
{
    public class Database
    {
        public static DataAccessComponent TicketTracker = new DataAccessComponent(DataAccessComponent.Connections.PCIISP_TicketTracker);

        public static bool Succeeded()
        {
            // Check connection and return bool
            return TicketTracker.ConnectionSucceeded();
        }
    }
}
