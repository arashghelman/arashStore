using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.POCO
{
    public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {
            Ref_Product = new DTO.EF.Product();
        } 
        #endregion

        #region [- props -]
        public DTO.EF.Product Ref_Product { get; set; } 
        #endregion

        #region [- Insert(string name, int quantity, decimal unitPrice, decimal discount, byte[] image) -]
        public void Insert(string name, int quantity, decimal unitPrice, decimal discount, byte[] image)
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    Ref_Product.Name = name;
                    Ref_Product.Quantity = quantity;
                    Ref_Product.UnitPrice = unitPrice;
                    Ref_Product.Discount = discount;
                    Ref_Product.Image = image;
                    context.Products.Add(Ref_Product);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw new Exception();
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete()
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    var q = context.Products.FirstOrDefault();
                    context.Products.Remove(q);
                    context.SaveChanges();
                }
                catch (NullReferenceException)
                {

                    throw new NullReferenceException();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update(int code, string name, decimal discount, decimal unitPrice, byte[] image) -]
        public void Update(int code, string name, decimal discount, decimal unitPrice, byte[] image)
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    var q = context.Products.FirstOrDefault(x => x.Code == code) as DTO.EF.Product;
                    if (q != null)
                    {
                        q.Name = name;
                        q.Discount = discount;
                        q.UnitPrice = unitPrice;
                        q.Image = image;
                        context.Entry(q).CurrentValues.SetValues(context.Products);
                        context.SaveChanges();
                    }
                }
                catch (NullReferenceException)
                {
                    throw new NullReferenceException();
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        } 
        #endregion

        #region [- Select() -]
        public List<DTO.EF.Product> Select()
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    var q = context.Products.ToList();
                    return q;
                }
                catch (ArgumentNullException)
                {

                    throw new ArgumentNullException();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        } 
        #endregion
    }
}
