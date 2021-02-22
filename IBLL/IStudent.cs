using DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
    //学生接口
    public interface IStudent
    {
        
        //查询学生
        List<Student> GetStudents();

        //反填学生
        Student GetStudent(int sid);

        //新增学生
        int AddStudent(Student s);

        //修改学生
        int UpdateStudent(Student s);

        //删除学生
        int DeleteStudent(int sid);
    }
}
