
using Eureka.Application.DTO;
using System;
using System.Collections.Generic;

namespace Eureka.Application.Interface
{
    public interface ICrudService
    {
        IEnumerable<CrudDto> GetAll();
        CrudDto GetById(Guid Id);
        CrudDto Insert(CrudDto entity);
        CrudDto Update(Guid id, CrudDto entity);
        void Delete(Guid id);
    }
}
