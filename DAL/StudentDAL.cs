using DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class StudentDAL
    {
        public int AddStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(int sid)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int sid)
        {
            throw new NotImplementedException();
        }
        //查询
        public List<Student> GetStudents()
        {
            //假数据
            var list = new List<Student>() {
                 new Student{
                     SId = 1,
                     SAge = 18,
                     SName ="张三"
                 },
                 new Student{
                     SId = 2,
                     SAge = 19,
                     SName ="李四"
                 },
                new Student{
                     SId = 3,
                     SAge = 20,
                     SName ="王五"
                 }
            };

            return list;
        }

        public int UpdateStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
