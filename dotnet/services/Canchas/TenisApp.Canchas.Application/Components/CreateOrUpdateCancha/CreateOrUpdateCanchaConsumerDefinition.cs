using MassTransit;

namespace TenisApp.Canchas.Application
{
    public class CreateOrUpdateCanchaConsumerDefinition : ConsumerDefinition<CreateOrUpdateCanchaConsumer>
    {
        protected override void ConfigureConsumer(
            IReceiveEndpointConfigurator endpointConfigurator,
            IConsumerConfigurator<CreateOrUpdateCanchaConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}