using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIBLL;
using HRModel;
using HRIDAO;
namespace HRBLL
{
    public class StudentBLL : IStudentBLL
    {
        //属性注入
        public IStudentDAO IStudentDAO { get; set; }
        public Task<int> StudentAdd(Student st)
        {
            throw new NotImplementedException();
        }

        public Task<int> StudentDel(Student st)
        {
            throw new NotImplementedException();
        }

        public  Task<List<Student>> StudentSelect()
        {
            return IStudentDAO.StudentSelect();
        }

        public Task<int> StudentUpdate(Student st, params string[] ps)
        {
            throw new NotImplementedException();
        }
    }
}
