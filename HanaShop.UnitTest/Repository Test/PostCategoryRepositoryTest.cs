using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.UnitTest.Repository_Test
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count());
        }


        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory caterogry = new PostCategory();
            caterogry.Name = "Test category";
            caterogry.Alias = "test-category";
            caterogry.Description = "aa";
            caterogry.Status = true;

            var result = objRepository.Add(caterogry);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }
    }
}
