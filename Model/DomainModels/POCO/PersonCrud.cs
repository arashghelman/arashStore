using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.POCO
{
    public class PersonCrud
    {
        public PersonCrud()
        {
            Ref_Person = new DTO.EF.Person();
        }
        public DTO.EF.Person Ref_Person { get; set; }

        public int CalculateAge(int birthYear)
        {
            int currentYear = 2019;
            int age = currentYear - birthYear;
            return age;
        }

        public void Insert(string firstName, string lastName, int birthYear, string sex, int phoneNumber, string emailAddress)
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
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (context!=null)
                    {
                        context.Dispose();
                    }
                }
            }           
        }
    }
}
