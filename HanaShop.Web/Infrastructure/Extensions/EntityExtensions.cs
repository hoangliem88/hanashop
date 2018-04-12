using AutoMapper;
using HanaShop.Model.Models;
using HanaShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanaShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
      
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoyVM)
        {
            postCategory.ID = postCategoyVM.ID;
            postCategory.Name = postCategoyVM.Name;
            postCategory.Alias = postCategoyVM.Alias;
            postCategory.Description = postCategoyVM.Description;
            postCategory.ParentID = postCategoyVM.ParentID;
            postCategory.DisplayOrder = postCategoyVM.DisplayOrder;
            postCategory.Image = postCategoyVM.Image;
            postCategory.CreateDate = postCategoyVM.CreateDate;
            postCategory.CreateBy = postCategoyVM.CreateBy;
            postCategory.UpdateBy = postCategoyVM.UpdateBy;
            postCategory.UpdateDate = postCategoyVM.UpdateDate;
            postCategory.MetaKeyword = postCategoyVM.MetaKeyword;
            postCategory.MetaDescription = postCategoyVM.MetaDescription;
            postCategory.Status = postCategoyVM.Status;
            postCategory.HomeFlag = postCategoyVM.HomeFlag;
            postCategory.HotFlag = postCategoyVM.HotFlag;
        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.Image = postVM.Image;
            post.Description = postVM.Description;
            post.Content = postVM.Content;
            post.CategoryID = postVM.CategoryID;
            post.ViewCount = postVM.ViewCount;
            post.CreateDate = postVM.CreateDate;
            post.CreateBy = postVM.CreateBy;
            post.UpdateBy = postVM.UpdateBy;
            post.UpdateDate = postVM.UpdateDate;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
            post.HomeFlag = postVM.HomeFlag;
            post.HotFlag = postVM.HotFlag;


        }

      
    }
}