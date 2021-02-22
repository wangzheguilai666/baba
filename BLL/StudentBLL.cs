using DAL;
using DataModel;
using IBLL;
using System;
using System.Collections.Generic;

namespace BLL
{
    //继承学生接口
    public class StudentBLL : IStudent
    {
        StudentDAL dal = new StudentDAL();
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
        //显示
        public List<Student> GetStudents()
        {
            return dal.GetStudents();
        }

        public int UpdateStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
