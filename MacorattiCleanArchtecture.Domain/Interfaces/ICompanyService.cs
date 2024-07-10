using System.Runtime.InteropServices;

namespace MacorattiCleanArchtecture.Domain.Interfaces
{
    public interface ICompanyService
    {
        public void Select();

        public void Insert();

        public void Update();

        public void Delete();
    }
}
