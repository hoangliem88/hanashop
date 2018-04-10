using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using HanaShop.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.UnitTest.Service_Test
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categorySerivce;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categorySerivce = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory(){ ID = 1, Name = "DM1", Description="a", Status =true},
                 new PostCategory(){ ID = 2, Name = "DM1", Description="a", Status =true},
                  new PostCategory(){ ID = 3, Name = "DM1", Description="a", Status =true},
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //all action
            var result =_categorySerivce.GetAll() as List<PostCategory>;

            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "abc";
            category.Description = "asdasd";
            category.Status = true;

            _mockRepository.Setup(m=>m.Add(category)).Returns((PostCategory p)=>
            {
                p.ID = 1;
                return p;
            });
            var result = _categorySerivce.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
