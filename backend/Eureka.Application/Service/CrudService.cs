using AutoMapper;
using Eureka.Application.DTO;
using Eureka.Application.Interface;
using Eureka.Domain.Model;
using Eureka.Domain.Repository;
using System;
using System.Collections.Generic;

namespace Eureka.Application.Service
{
    public class CrudService : ICrudService
    {
        private readonly IMapper _mapper;
        private readonly ICrudRepository _crudRepository;

        public CrudService(IMapper mapper, ICrudRepository crudRepository)
        {
            _mapper = mapper;
            _crudRepository = crudRepository;

        }

        public IEnumerable<CrudDto> GetAll()
        {
            return _mapper.Map<IEnumerable<CrudDto>>(_crudRepository.GetAll());
        }

        public CrudDto GetById(Guid Id)
        {
            return _mapper.Map<CrudDto>(_crudRepository.GetById(Id));
        }

        public CrudDto Insert(CrudDto entity)
        {
            _crudRepository.Insert(_mapper.Map<Crud>(entity));
            _crudRepository.Save();
            return entity;
        }

        public CrudDto Update(Guid id, CrudDto entity)
        {
            var data = _crudRepository.GetById(id);

            if (data == null) throw new Exception("Entidade não encontrada.");

            data.Email = entity.Email;
            data.Value = entity.Value;

            _crudRepository.Update(_mapper.Map<Crud>(data));
            _crudRepository.Save();

            return _mapper.Map<CrudDto>(data);
        }

        public void Delete(Guid id)
        {
            _crudRepository.Delete(id);
            _crudRepository.Save();
        }
    }
}
