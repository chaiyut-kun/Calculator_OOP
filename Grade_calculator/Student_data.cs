using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_calculator
{
    //Class นี้คือ Class ที่เอาไว้สำหรับทำงานกับข้อมูลนักเรียน
    class Student_data
    {

        private string Name;
        private string Student_id;
        private double Score;

        public string name { get => Name; set => Name = value; }
        public string student_id { get => Student_id; set => Student_id = value; }
        public double score { get => Score; set => Score = value; }

        public Student_data(string name , string student_id , double score) 
        {
            this.name = name;
            this.student_id = student_id;
            this.score = score;
        }

        public Student_data()
        {

        }
    }
}
