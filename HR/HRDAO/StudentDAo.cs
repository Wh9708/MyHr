using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
namespace HRDAO
{
    public class StudentDAO : DaoBase<EStudent>,IStudentDAO
    {
        public  Task<int> StudentAdd(Student st)
        {
            EStudent ss = new EStudent() {
                 Id=st.Id,
                  Age=st.Age,
                   Name=st.Name
            };
            return  Add(ss);
        }

        public Task<int> StudentDel(Student st)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> StudentSelect()
        {
           List<EStudent> list= await GetAll();
            List<Student> list2 = new List<Student>();
            foreach (EStudent item in list)
            {
                Student st = new Student() {
                     Id=item.Id,
                      Name=item.Name,
                       Age=item.Age
                };
                list2.Add(st);
            }
            return list2;
        }

        public Task<int> StudentUpdate(Student st, params string[] ps)
        {
            throw new NotImplementedException();
        }
    }
}
