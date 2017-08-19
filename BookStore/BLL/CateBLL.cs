using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CateBLL
    {
        ModelDataContext db;
        public CateBLL()
        {
            db = new ModelDataContext();
        }

        public List<Category> getToAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> getToAllAvailable()
        {
            return db.Categories.Where(cate => cate.Status == true).ToList();
        }

        public Category getByID(long id)
        {
            return db.Categories.SingleOrDefault(cate => cate.ID == id);
        }

        public bool Insert(Category _category)
        {
            try
            {
                db.Categories.InsertOnSubmit(_category);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Category _category)
        {
            try
            {
                var _record = db.Categories.SingleOrDefault(cate => cate.ID == _category.ID);
                _record.Name = _category.Name;
                _record.Description = _category.Description;
                _record.ImagePath = _category.ImagePath;
                _record.Meta_Description = _category.Meta_Description;
                _record.Meta_Keyword = _category.Meta_Keyword;
                _record.Status = _category.Status;
                _record.ShowOnHome = _category.ShowOnHome;
                _record.Detail = _category.Detail;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            try
            {
                var _record = db.Categories.SingleOrDefault(cate => cate.ID == id);
                db.Categories.DeleteOnSubmit(_record);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangedStatus(long id)
        {
            var _record = db.Categories.SingleOrDefault(cate => cate.ID == id);
            _record.Status = !_record.Status;
            db.SubmitChanges();
            return Convert.ToBoolean(_record.Status);
        } 
    }
}
