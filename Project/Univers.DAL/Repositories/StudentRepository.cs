﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univers.DAL.Entities;
using Univers.Models.Models;

namespace Univers.DAL.Repositories
{
    public class StudentRepository
    {
        /// <summary>
        /// Read the data from the Student table
        /// </summary>
        /// <returns></returns>
        public List<Student> ReadAllData()
        {
            using Context.Context context = new();

            return context.Students.ToList();
        }

        /// <summary>
        /// Add student in Students table
        /// </summary>
        /// <param name="student"></param>
        public void AddData(StudentModel student)
        {
            using Context.Context context = new();

            Student additionalStudent = new Student();
            
            additionalStudent.Id = student.Id;
            additionalStudent.UserId = student.UserId;
            additionalStudent.Identity = student.Identity;
            additionalStudent.Citizenship = student.Citizenship;
            additionalStudent.CountryOfBirth = student.CountryOfBirth;
            additionalStudent.AreaOfBirth = student.AreaOfBirth;
            additionalStudent.CityOfBirth = student.CityOfBirth;
            additionalStudent.MunicipalityOfBirth = student.MunicipalityOfBirth;
            additionalStudent.DateOfBirth = student.DateOfBirth;
            additionalStudent.FormOfEducation = student.FormOfEducation;

            context.Students.Add(additionalStudent);
            context.SaveChanges();
        }

        public void AddSpecialityId(string studentId, string specialityId)
        {
            using Context.Context context = new();

            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            
            student.SpecialityId = specialityId;
            
            context.Update(student);

            context.SaveChanges();
        }
    }
}
