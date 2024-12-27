using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ymtProje.Business.Abstract;
using ymtPorje.DataAccess.Abstract;

namespace ymtProje.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        // Tüm listeyi getir
        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        // Filtreye göre ilk eşleşen öğeyi getir
        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        // ID'ye göre öğeyi getir
        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        // Yeni bir öğe ekle
        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        // Var olan bir öğeyi güncelle
        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }

        // ID'ye göre öğeyi sil
        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        // Belirli bir filtreye göre toplam eşleşen öğe sayısını döndür
        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
            return _repository.FilteredCount(predicate);
        }

        // Belirli bir filtreye göre listeyi döndür
        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }
    }
}
