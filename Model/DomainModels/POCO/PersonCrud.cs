using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.POCO
{
    public class PersonCrud
    {
        #region [- ctor -]
        public PersonCrud()
        {
            Ref_Person = new DTO.EF.Person();
        }
        #endregion

        #region [- props -]
        public DTO.EF.Person Ref_Person { get; set; }
        #endregion

        #region [- public int CalculateAge(int birthYear) -]
        public int CalculateAge(int birthYear)
        {
            int currentYear = 2019;
            int age = currentYear - birthYear;
            return age;
        }
        #endregion

        #region [- Insert(string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress) -]
        public void Insert(string firstName, string lastName, int birthYear, string sex, string phoneNumber, string emailAddress)
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    Ref_Person.FirstName = firstName;
                    Ref_Person.LastName = lastName;
                    Ref_Person.BirthYear = birthYear;
                    Ref_Person.Age = CalculateAge(birthYear);
                    Ref_Person.Sex = sex;
                    Ref_Person.PhoneNumber = phoneNumber;
                    Ref_Person.EmailAddress = emailAddress;

                    context.People.Add(Ref_Person);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                    var q = context.People.FirstOrDefault();
                    context.People.Remove(q);
                    context.SaveChanges();
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
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

        #region [- Update(int id, string firstName, string lastName, int birthYear, int age, string sex, int phoneNumber, string emailAddress) -]
        public void Update(int id, string firstName, string lastName, int birthYear, int age, string sex, string phoneNumber, string emailAddress)
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    var q = context.People.FirstOrDefault(x => x.ID == id) as DTO.EF.Person;
                    if (q != null)
                    {
                        q.FirstName = firstName;
                        q.LastName = lastName;
                        q.BirthYear = birthYear;
                        q.Age = CalculateAge(birthYear);
                        q.Sex = sex;
                        q.PhoneNumber = phoneNumber;
                        q.EmailAddress = emailAddress;
                        context.Entry(q).CurrentValues.SetValues(context.People);
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
        public List<DTO.EF.Person> Select()
        {
            using (var context = new DTO.EF.StoreEntities())
            {
                try
                {
                    var q = context.People.ToList();
                    return q;
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentNullException();
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
