
namespace DotNetCoreApiDemo.services
{
    public class Operation : IOperation
    {
        private Guid _id = Guid.NewGuid();
        public Guid GetOperationGuid()
        {
            return _id;
        }
    }
}
