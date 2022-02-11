using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectMainTestapi.Models;
using ProjectMainTestapi.Repositories;

namespace ProjectMainTestapi.Services
{
    public class CustomerBL
    {
        private IEntityRepository<Customer> _customerRepository { get; set; }
        public CustomerBL(IEntityRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //Get All Customer
        public List<Customer> GetAllActiveCustomer()
        {
            var result = _customerRepository.GetAllQueryable()
                .Where(c => c.isDeleted == false).ToList();
            return result;
        }
    }
}
