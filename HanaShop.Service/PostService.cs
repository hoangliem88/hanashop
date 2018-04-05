using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using System.Collections.Generic;

namespace HanaShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        Post GetByID(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveCHanges();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postrepository;
        private IUnitOfWork _unitofwork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postrepository = postRepository;
            this._unitofwork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postrepository.Add(post);
        }

        public void Delete(int id)
        {
            _postrepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postrepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postrepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: select all post by tag
            return _postrepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postrepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetByID(int id)
        {
            return _postrepository.GetSingleByID(id);
        }

        public void SaveCHanges()
        {
            _unitofwork.Commit();
        }

        public void Update(Post post)
        {
            _postrepository.Update(post);
        }
    }
}