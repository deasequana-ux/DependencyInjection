using System;
namespace DependencyInjection
{
    public class OperationService : ISingletonService, ITransientService, IScopedService
    {
        Guid id;  //Guid, benzersiz değerler oluşturmak için kullanılır.
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
