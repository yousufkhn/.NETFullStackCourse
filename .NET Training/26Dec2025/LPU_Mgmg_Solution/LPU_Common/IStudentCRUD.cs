using System;
using LPU_Entity;
using System.Collections.Generic;

namespace LPU_Common
{
    public interface IStudentCRUD // in interface every method is abstract
     {
        Student SearchStudentByID(int rollNo);
        List<Student> SearchStudentByName(string name);
        bool EnrollStudent(Student sObj);
        bool UpdateStudentDetails(int id,Student newObj);
        bool DropStudentDetails(int id);



    }
}
