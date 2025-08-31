
namespace DotNetCoreApiDemo.services
{
    public class OperationService : ISingletonService, IScopedService, ITransientService
    {
        private readonly Guid _operationId;

        public OperationService()
        {
            _operationId = Guid.NewGuid();
        }
        public Guid GetOperationId()
        {
            return _operationId;
        }
    }
}
