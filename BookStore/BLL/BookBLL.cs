using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class BookBLL
    {
        ModelDataContext db;
        public BookBLL()
        {
            db = new ModelDataContext();
        }

        public List<Book> getToAll()
        {
            return db.Books.ToList();
        }

        public List<Book> getToAllAvailable()
        {
            return db.Books.Where(b => b.Status == true).ToList();
        }

        public List<Book> getByCateID(long cateID)
        {
            return db.Books.Where(b => b.CateID == cateID).ToList();
        }

        public Book getByID(long id)
        {
            return db.Books.SingleOrDefault(b => b.ID == id);
        }

        public bool Insert(Book _Book)
        {
            try
            {
                db.Books.InsertOnSubmit(_Book);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Book _Book)
        {
            try
            {
                var _record = db.Books.SingleOrDefault(b => b.ID == _Book.ID);
                _record.Name = _Book.Name;
                _record.Description = _Book.Description;
                _record.ImagePath = _Book.ImagePath;
                _record.Meta_Description = _Book.Meta_Description;
                _record.Meta_Keyword = _Book.Meta_Keyword;
                _record.Status = _Book.Status;
                _record.ShowOnHome = _Book.ShowOnHome;
                _record.Detail = _Book.Detail;
                _record.CateID = _Book.CateID;
                _record.Price = _Book.Price;
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
                var _record = db.Books.SingleOrDefault(b => b.ID == id);
                db.Books.DeleteOnSubmit(_record);
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
            var _record = db.Books.SingleOrDefault(cate => cate.ID == id);
            _record.Status = !_record.Status;
            db.SubmitChanges();
            return Convert.ToBoolean(_record.Status);
        } 
    }
}
