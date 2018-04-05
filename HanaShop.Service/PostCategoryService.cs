using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using System.Collections.Generic;

namespace HanaShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(PostCategory postCategory);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentId);

        PostCategory GetByID(int id);

        void SaveCHanges();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryrepository;
        private IUnitOfWork _unitofwork;

        public PostCategoryService(IPostCategoryRepository postCategoryrepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryrepository = postCategoryrepository;
            this._unitofwork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryrepository.Add(postCategory);
        }

        public void Delete(PostCategory postCategory)
        {
            _postCategoryrepository.Delete(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryrepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryrepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentId)
        {
            return _postCategoryrepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetByID(int id)
        {
            return _postCategoryrepository.GetSingleByID(id);
        }

        public void SaveCHanges()
        {
            _unitofwork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryrepository.Update(postCategory);
        }
    }
}