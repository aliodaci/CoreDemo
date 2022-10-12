using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddCategory(Blog blog)
        {
            using (var c=new ContextDb())
            {
                c.Add(blog);
                c.SaveChanges();
            }
        }

        public void DeleteCategory(Blog blog)
        {
            using (var c = new ContextDb())
            {
                c.Remove(blog);
                c.SaveChanges();
            }
        }

        public Blog GetById(int id)
        {
            using (var c = new ContextDb())
            {
                return c.Blogs.Find(id);
            }
        }

        public List<Blog> ListAllGetCategory()
        {
            using (var c = new ContextDb())
            {
                return c.Blogs.ToList();
            }
        }

        public void UpdateCategory(Blog blog)
        {
            using (var c = new ContextDb())
            {
                c.Update(blog);
                c.SaveChanges();
            }
        }
    }
}
