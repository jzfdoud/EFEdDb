using System;
using System.Linq;
using System.Threading.Tasks;
using EFEdDbLib;
using EFEdDbLib.Controllers;

namespace EntityFramework
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var clasCtrl = new ClassesController();
            var classes = await clasCtrl.GetAll();
            var clas = new Clas()
            {
                Id = 0,
                Code = "ARTC",
                Section = 119,
                Subject = "Ceramics"
            };

            var result = await clasCtrl.Insert(clas);

            //var majorCtrl = new MajorsController();
            //var majors = await majorCtrl.GetAll();
            //var mathMajor = await majorCtrl.GetByPk(10);
            //var major = new Major()
            //{
            //    Id = 0,
            //    Code = "MEDS",
            //    Description = "Medical",
            //    MinSat = 1200
            //};
            //var result = await majorCtrl.Insert(major);
            //mathMajor.Description = "OBGYN";
            //var result = await majorCtrl.Update(mathMajor.Id, mathMajor);

            //var result = await majorCtrl.Delete(mathMajor.Id); /* delete major defined in GetByPk() */


            //var _context = new EdDbContext();
            //var students = _context.Student;
            ////referring to the Student in the Context class

        }
    }
}
