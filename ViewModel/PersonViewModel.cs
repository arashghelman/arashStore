using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PersonViewModel
    {
        #region [- ctor -]
        public PersonViewModel()
        {
            Ref_PersonCrud = new Model.DomainModels.POCO.PersonCrud();
        }
        #endregion

        #region [- props -]
        public Model.DomainModels.POCO.PersonCrud Ref_PersonCrud { get; set; }
        #endregion

        #region [- Add(string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress) -]
        public void Add(string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress)
        {
            Ref_PersonCrud.Insert(firstName, lastName, birthYear, sex, phoneNumber, emailAddress);
        }
        #endregion

        #region [- Remove() -]
        public void Remove()
        {
            Ref_PersonCrud.Delete();
        }
        #endregion

        #region [- Edit(int id, string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress) -]
        public void Edit(int id, string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress)
        {
            Ref_PersonCrud.Update(id, firstName, lastName, birthYear, sex, phoneNumber, emailAddress);
        }
        #endregion

        #region [- Refresh() -]
        public dynamic Refresh()
        {
            return Ref_PersonCrud.Select();
        } 
        #endregion
    }
}
