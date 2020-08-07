using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittenProject.Models;

namespace WrittenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single inheritance test
            using (var context = new SingleTestModelContext())
            {
                context.SingleTestModel.Add(new Models.SingleTestModel() { AbstractValue = 99 , NormalValue = 9});
                context.SaveChanges();
            }

            // Multi class inheritance test
            using (var context = new MultiTestModelContext())
            {
                context.MultiTestModel1.Add(new Models.MultiTestModel1() { AbstractValue = 99, NormalValue = 9 });
                context.MultiTestModel2.Add(new Models.MultiTestModel2() { AbstractValue = 99, NormalValue = 9 });
                context.SaveChanges();
            }

            // Interface implementation test
            using (var context = new SingleInterfaceContext())
            {
                context.SingleInterfaceModels.Add(new Models.SingleInterfaceModel() { InterfaceValue = 99});
                context.SaveChanges();
            }

            // Multi interface implementation test
            using (var context = new MultiInterfaceContext())
            {
                context.MultiInterfaceModels1.Add(new Models.MultiInterfaceModel1() { InterfaceValue = 99 });
                context.MultiInterfaceModels2.Add(new Models.MultiInterfaceModel2() { InterfaceValue = 99 });
                context.SaveChanges();
            }

            // Data integritet wrong
            using (var context = new PersonContext())
            {
                context.Persons.Add(new Models.Person("Jens", 2630, "Taastrup"));
                context.Persons.Add(new Models.Person("Peter", 2630, "asdasd"));
                context.Persons.Add(new Models.Person("Blah", 4040, "akjsdasd"));
                context.SaveChanges();
            }

            // Data integritet Right way
            using (var context = new PersonRightContext())
            {
                context.Persons.Add(new Models.PersonRight("Jens", new Models.CityRight(2630, "Taastrup")));
                context.Persons.Add(new Models.PersonRight("Peter", new Models.CityRight(2630, "asdasd")));
                context.Persons.Add(new Models.PersonRight("Blah", new Models.CityRight(4040, "akjsdasd")));
                context.SaveChanges();
            }

            // normalize data creation
            //using (var context = new CourseContext())
            //{
            //    Student studA = new Student() { FirstName = "Emil", LastName = "Andersen", EnrollmentDate = DateTime.Now };
            //    Student studB = new Student() { FirstName = "Lars", LastName = "Petersen", EnrollmentDate = DateTime.Now };

            //    Instructor instA = new Instructor() { FirstName = "asdad", LastName = "asdasd", HireDate = DateTime.Now };

            //    Course cA = new Course() { Instructor = instA, Name = "Programmering", StartDate = DateTime.Now };
            //    cA.Students = new List<Student>();
            //    cA.Students.Add(studA);
            //    cA.Students.Add(studB);

            //    Course cB = new Course() { Instructor = instA, Name = "FriTime", StartDate = DateTime.Now };
            //    cB.Students = new List<Student>();
            //    cB.Students.Add(studA);

            //    context.Students.Add(studA);
            //    context.Students.Add(studB);

            //    context.Instructors.Add(instA);

            //    context.Courses.Add(cA);
            //    context.Courses.Add(cB);

            //    context.SaveChanges();
            //}

            // Normalizing optimization fluent api
            using (var db = new ContractContext())
            {
                CreditContract creditContract = new CreditContract();
                creditContract.StartDate = new DateTime(2015, 1, 1);
                creditContract.EndDate = new DateTime(2015, 12, 31);
                creditContract.CreditLimit = 100000;
                creditContract.CreditLimitCurrency = "USD";
                db.Contracts.Add(creditContract);

                PrepaymentContract prepaymentContract = new PrepaymentContract();
                prepaymentContract.StartDate = new DateTime(2015, 1, 1);
                prepaymentContract.EndDate = new DateTime(2015, 12, 31);
                prepaymentContract.PrepaymentAmount = 10000;
                prepaymentContract.PrepaymentPeriod = "M";
                db.Contracts.Add(prepaymentContract);

                db.SaveChanges();
            }

            // Normalizing optimization data annotations
            using (var db = new ContractContextDataAnnotation())
            {
                CreditContract2 creditContract = new CreditContract2();
                creditContract.StartDate = new DateTime(2015, 1, 1);
                creditContract.EndDate = new DateTime(2015, 12, 31);
                creditContract.CreditLimit = 100000;
                creditContract.CreditLimitCurrency = "USD";
                db.Contracts.Add(creditContract);

                PrepaymentContract2 prepaymentContract = new PrepaymentContract2();
                prepaymentContract.StartDate = new DateTime(2015, 1, 1);
                prepaymentContract.EndDate = new DateTime(2015, 12, 31);
                prepaymentContract.PrepaymentAmount = 10000;
                prepaymentContract.PrepaymentPeriod = "M";
                db.Contracts.Add(prepaymentContract);

                db.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
