using System;
namespace DependencyInjection
{
    public class OperationService : ISingletonService, ITransientService, IScopedService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
