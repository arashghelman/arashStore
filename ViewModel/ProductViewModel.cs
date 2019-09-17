using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new Model.DomainModels.POCO.ProductCrud();
        }
        #endregion

        #region [- props -]
        public Model.DomainModels.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #endregion

        #region [- Add(string name, int quantity, decimal unitPrice, decimal discount, byte[] image) -]
        public void Add(string name, int quantity, decimal unitPrice, decimal discount, byte[] image)
        {
            Ref_ProductCrud.Insert(name, quantity, unitPrice, discount, image);
        }
        #endregion

        #region [- Remove() -]
        public void Remove()
        {
            Ref_ProductCrud.Delete();
        }
        #endregion

        #region [- Edit(int code, string name, int quantity, decimal discount, decimal unitPrice, byte[] image) -]
        public void Edit(int code, string name, int quantity, decimal discount, decimal unitPrice, byte[] image)
        {
            Ref_ProductCrud.Update(code, name, quantity, discount, unitPrice, image);
        } 
        #endregion

        #region [- Refresh() -]
        public dynamic Refresh()
        {
            return Ref_ProductCrud.Select();
        } 
        #endregion
    }
}
