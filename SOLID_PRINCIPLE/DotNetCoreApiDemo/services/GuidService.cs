namespace DotNetCoreApiDemo.services
{
    public class GuidService : IGUID
    {
        private readonly Guid _guid = Guid.NewGuid();
        public Guid GetGuid() => _guid;
    }
}
