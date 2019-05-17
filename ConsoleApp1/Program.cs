using Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                // *** User ***
                var existingUser = unitOfWork.Users.SingleOrDefault(p => p.SystemId == "retroglider");
                if (existingUser == null)
                {
                    var newUser = new User() { FirstName = "Rhyss", LastName = "Leary", SystemId = "retroglider", Password = "password", Email = "rhyss@link2.com" };

                    unitOfWork.Users.Add(newUser);
                    unitOfWork.Complete();
                    existingUser = newUser;
                }
                // *** Address Book ***
                var existingAddressBook = unitOfWork.AddressBooks.SingleOrDefault(a => a.Name == "Main AddressBook");
                if (existingAddressBook == null)
                {
                    var newAddressBook = new AddressBook() { Name = "Main AddressBook", UserId = existingUser.Id };
                    unitOfWork.AddressBooks.Add(newAddressBook);
                    unitOfWork.Complete();
                    existingAddressBook = newAddressBook;
                }
                // *** Contacts ***
                var contact1 = new Contact() { FirstName = "Matt", LastName = "Kaupi", Email = "mkaupii@teksystems.com", Phone = "480-665-3506", AddressBookId = existingAddressBook.Id };
                var contact2 = new Contact() { FirstName = "Whitney", LastName = "Fairley", Email = "w.fairley@willistowerswatson.com", Phone = "214-983-0874", AddressBookId = existingAddressBook.Id };

                unitOfWork.Contacts.AddRange(new List<Contact>() { contact1, contact2 });
                unitOfWork.Complete();

                //unitOfWork.Contacts.RemoveRange(new List<Contact>() { contact1, contact2 });
                //unitOfWork.Contacts.Remove(contact1);
                //unitOfWork.Contacts.Remove(contact2);
                //unitOfWork.Complete();
            }
        }
    }
}
