using CommanderDB.Model;

namespace CommanderDB.QueryData
{
    public class Subscriptions{
        
        [Subscribe]
        [Topic]
        public Commander OnCommanderAdded([EventMessage] Commander commander){
           return commander;
        }

    }
}