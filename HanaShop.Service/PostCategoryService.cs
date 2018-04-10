using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using System.Collections.Generic;

namespace HanaShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        PostCategory Delete(PostCategory postCategory);

        PostCategory Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentId);

        PostCategory GetByID(int id);

        void SaveChanges();
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

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryrepository.Add(postCategory);
        }

        public PostCategory Delete(PostCategory postCategory)
        {
            return _postCategoryrepository.Delete(postCategory);
        }

        public PostCategory Delete(int id)
        {
            return _postCategoryrepository.Delete(id);
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

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryrepository.Update(postCategory);
        }
    }
}