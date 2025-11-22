using Assignment01.Models;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using ITIDbContext context = new ITIDbContext();

            #region CRUD Opertations
            #region Creat Operation
            //Student student01 = new Student()
            //{
            //    FName = "Ahmed",
            //    LName = "Ali",
            //    Address = "Cairo",
            //    Age = 20,
            //    Dept_Id = 1
            //};

            //Student student02 = new Student()
            //{
            //    FName = "Sara",
            //    LName = "Mohamed",
            //    Address = "Alex",
            //    Age = 22,
            //    Dept_Id = 2
            //};
            //Student student03 = new Student()
            //{
            //    FName = "Omar",
            //    LName = "Hassan",
            //    Address = "Giza",
            //    Age = 21,
            //    Dept_Id = 1
            //};
            //context.Add(student01);
            //context.Add(student02);
            //context.Add(student03);
            //Department dept01 = new Department()
            //{
            //    Name = "Information Technology",
            //    HiringDate = new DateOnly(2020, 1, 15)
            //};
            //Department dept02 = new Department()
            //{
            //    Name = "Software Ingneering",
            //    HiringDate = new DateOnly(2025, 1, 23)
            //};
            //context.Departments.Add(dept01);
            //context.Departments.Add(dept02);
            //context.SaveChanges(); 
            #endregion

            #region Read Operation
            //var Result = from s in context.Students
            //             where s.Age > 20
            //             orderby s.FName descending
            //             select s;
            //foreach (var student in Result)
            //{
            //    Console.WriteLine($"ID: {student.Id}, Name: {student.FName} {student.LName}," +
            //        $" Age: {student.Age}, Address: {student.Address}, Dept_Id: {student.Dept_Id}");
            //}

            #endregion

            #region Update Operation
            //var Result = (from s in context.Students
            //             where s.Age == 25
            //             select s).FirstOrDefault();
            //if (Result != null)
            //Result.Age = 24;
            //context.SaveChanges();
            //    Console.WriteLine($"ID: {Result.Id}, Name: {Result.FName} {Result.LName}," +
            //        $" Age: {Result.Age}, Address: {Result.Address}, Dept_Id: {Result.Dept_Id}");

            #endregion

            #region Delete Opertation
            //var Result = (from D in context.Departments
            //              where D.Id == 2
            //              select D).FirstOrDefault();
            //if (Result != null)
            //    context.Departments.Remove(Result); 
            //context.SaveChanges(); 
            #endregion

            #endregion



        }
    }
}
