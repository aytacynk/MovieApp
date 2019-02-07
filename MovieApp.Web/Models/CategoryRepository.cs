using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public static class CategoryRepository
    {
        private static List<Category> categories = null;

        public static List<Category> Categories
        {
            get { return categories; }
        }

        static CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category(){ Id=1, CategoryName="Comedy"},
                new Category(){ Id=2, CategoryName="Fear & Violant"},
                new Category(){ Id=3, CategoryName="Romance"},
                new Category(){ Id=4, CategoryName="Sport"},
                new Category(){ Id=5, CategoryName="Science"}
            };
        }

        public static void AddCategory(Category cat)
        {
            categories.Add(cat);
        }


        public static Category GetById(int? id)
        {
            return Categories.FirstOrDefault(x => x.Id == id);
        }

    }
}
