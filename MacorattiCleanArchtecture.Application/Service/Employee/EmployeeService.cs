using AutoMapper;
using MacorattiCleanArchtecture.Application.DTOs;
using MacorattiCleanArchtecture.Application.Interfaces.Employee;
using MacorattiCleanArchtecture.Domain.Interfaces.Service;
using EmployeeModel = MacorattiCleanArchtecture.Domain.Entities.Employee.Employee;

namespace MacorattiCleanArchtecture.Application.Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;

        private IEmployeeRepository _repository;

        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _repository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDTO>> SelectAllAsync()
        {
            return _mapper.Map<IEnumerable<EmployeeDTO>>(await _repository.SelectAllAsync());
        }

        public async Task<EmployeeDTO> InsertAsync(EmployeeDTO employee)
        {
            return _mapper.Map<EmployeeDTO>(await _repository.InsertAsync(_mapper.Map<EmployeeModel>(employee)));
        }

        public async Task<EmployeeDTO> UpdateAsync(EmployeeDTO employee)
        {
            return _mapper.Map<EmployeeDTO>(await _repository.UpdateAsync(_mapper.Map<EmployeeModel>(employee)));
        }

        public bool DeleteAsync(Guid id)
        {
            _repository.DeleteAsync(id);

            return true;
        } 
    }
}
