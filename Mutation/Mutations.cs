using CommanderDb.Model;
using CommanderDB.Model;
using CommanderDB.QueryData;
using Data.AppCommandDbContext;
using HotChocolate.Subscriptions;

namespace CommanderDB.Mutation
{
    public class Mutations
    {
       
         
        public async Task<AddCommanderPaylod> AddCommanderAsync(AddCommanderInput input, 
        [ScopedService] AppCommandDbContext context,
        [Service] ITopicEventSender eventSender,
        CancellationToken cancellationToken
        ){
         
         var commander = new Commander{
            name = input.name
         };

         context.Commanders.Add(commander);
         await context.SaveChangesAsync(cancellationToken);
         await eventSender.SendAsync(nameof(Subscriptions.OnCommanderAdded), commander, cancellationToken);

         return new AddCommanderPaylod(commander);

        }
        
       
           
        public async Task<AddMacmiilkaPayload> AddMacmiilkaAsync(AddMacmiilkaInput input, 
        [ScopedService] AppCommandDbContext context){
            
            var macmiilka = new Macmiilka{
                Name = input.name,
                Age = input.age,
                CommanderId = input.CommanderId
            };
             context.Macmiilkas.Add(macmiilka);
             await context.SaveChangesAsync();
             return new AddMacmiilkaPayload(macmiilka);
        }

    }
}