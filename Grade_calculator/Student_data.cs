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

        // อันนี้ field 
        private string Name;
        private string Student_id;
        private double Score;

        // นีคือ Getter Setter property
        public string name { get => Name; set => Name = value; }
        public string student_id { get => Student_id; set => Student_id = value; }
        public double score { get => Score; set => Score = value; }

        // Constructor ที่รับค่า argument ได้
        public Student_data(string name , string student_id , double score) 
        {
            this.name = name;
            this.student_id = student_id;
            this.score = score;
        }

        //default Constructor
        public Student_data()
        {

        }
    }
}
