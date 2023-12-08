using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //unknown
        private void label1_Click(object sender, EventArgs e)
        {
            //unknown
        }

        // asset

        List<Student_data> List_Student = new List<Student_data>();
        Student_data student;

        string id_student ;
        string name_student ;
        double score_student;


        // arr สำหรับเก็บการคำนวณ นศ.ที่ได้ A จำนวน n * 4 + ได้ B+ จำนวน n * 3.5 ..... ไปเรื่อยๆ
        float[] all_grade = new float[8];
        double[] gpa_weigth = {4.0 , 3.5 , 3.0 , 2.5 , 2.0 ,  1.5 , 1.0 };

        // เก็บจำนวนที่ไดเกรด A  , B  , C , D ว่าได้กี่ครั้งๆ
        int[] n_of_grade = new int[8];

        //asset

       

        public void Save_button_Click(object sender, EventArgs e)
        {

            Get_value();

            //find min obj max obj
            
        }


      
        // ฟังก์ชันคำนวนเกรด A B C ... และ ค่าเฉลี่ยของนักเรียนทุกคน
        public void Calculate_function()
        {
            // ค่าปัจจุบัน 
            double current_point = List_Student[List_Student.Count - 1].score;
            // 1 = A , 2 = B+ , 3 = B , 4 = C+ , 5 = C , 6 = D+ , 7 = D , 8 = F
            int case_condition = (current_point >= 80 && current_point <= 100) ? 1 : (current_point >= 75 && current_point <= 79) ? 2 :
                (current_point >= 70 && current_point <= 74) ? 3 : ( current_point >= 65 && current_point <= 69)? 4 :(current_point >= 60 && current_point <= 64) ? 5 :
                (current_point >= 55 && current_point <= 59) ? 6 : (current_point >= 50 && current_point <= 54) ? 7 : 8;

            switch (case_condition)
            {
                case 1:
                    //A
                    n_of_grade[0]++;
                    text_A_box.Text = n_of_grade[0].ToString();
                    break;
                case 2:
                    //B+
                    n_of_grade[1]++; 
                    text_B_plus_box.Text = n_of_grade[1].ToString();
                    break;
                case 3:
                    //B
                    n_of_grade[2]++; 
                    text_B_box.Text = n_of_grade[2].ToString();
                    break;
                case 4:
                    //C+
                    n_of_grade[3]++; 
                    text_C_plus_box.Text = n_of_grade[3].ToString();
                    break;
                case 5:
                    //C
                    n_of_grade[4]++; 
                    text_C_box.Text = n_of_grade[4].ToString();
                    break;
                case 6:
                    //D+
                    n_of_grade[5]++; 
                    text_D_plus_box.Text = n_of_grade[5].ToString();
                    break;
                case 7:
                    //D
                    n_of_grade[6]++;
                    text_D_box.Text = n_of_grade[6].ToString();
                    break;
                case 8:
                    n_of_grade[7]++;
                    text_F_box.Text = n_of_grade[7].ToString();
                    break;
            }

            double GPA = 0.0;
            for (int i = 0; i < gpa_weigth.Length; i++)
            {
                GPA += n_of_grade[i] * gpa_weigth[i];
            }

            text_avg_box.Text = (GPA / (double)n_of_grade.Sum()).ToString("0.00");

        }

        public void Get_value()
        {

            id_student = text_id_student.Text;
            name_student = text_name.Text;
            bool try_parse_score = double.TryParse(text_point.Text, out score_student);
            if (!try_parse_score)
            {
                MessageBox.Show("กรุณาป้อนค่าที่เป็นตัวเลขเท่านั้น");
                text_point.Clear();
                text_point.BackColor = Color.Red;
                return;
            }
            else {
                    if (ContainsLetters(text_point.Text))
                    {
                        MessageBox.Show("กรุณาป้อนค่าที่เป็นตัวเลขเท่านั้น");
                        text_point.Clear();
                        return;
                    }

                    else
                    {
                        score_student = double.Parse(text_point.Text);
                        student = new Student_data(name_student, id_student, (score_student));
                        List_Student.Add(student);

                        text_name.Text = "";
                        text_id_student.Text = "";
                        text_point.Text = "";
                        find_max_min();


                        //average output 
                        double sum_list = (double)List_Student.Sum(s => s.score);
                        text_avg_point.Text = (sum_list / (double)List_Student.Count).ToString("0.00");


                        // ส่วน เช็คค่าและแสดงผล
                        Calculate_function();
                    }
            }

        }

        // ฟังก์ชันตรวจสอบว่ามีตัวอักษรหรือไม่
        private bool ContainsLetters(string input)
        {
            return input.Any(char.IsLetter);
        }

        // find max min by List_student
        public void find_max_min()
        {
            Student_data max_obj = new Student_data(), min_obj = new Student_data();

            //maxvalue
            double max_score = List_Student.Max(e => e.score);
            max_obj = List_Student.Where(e => e.score == max_score).FirstOrDefault();
            text_id_student_max.Text = max_obj.student_id;
            text_name_max.Text = max_obj.name;
            text_point_max.Text = max_obj.score.ToString();

            // min value
            double min_score = List_Student.Min(e => e.score);
            min_obj = List_Student.Where(e => e.score == min_score).FirstOrDefault();
            text_id_student_min.Text = min_obj.student_id;
            text_name_min.Text = min_obj.name;
            text_point_min.Text = min_obj.score.ToString();


        }











        private void text_id_student_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_point_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_avg_point_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_id_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_result_box_Enter(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // A box
        }

        private void text_id_student_max_TextChanged(object sender, EventArgs e)
        {


        }

        private void text_name_max_TextChanged(object sender, EventArgs e)
        {


        }

        private void text_point_max_TextChanged(object sender, EventArgs e)
        {

            //text_point_max.Text = $"{all_[max_idx]}";

        }

        private void text_point_TextChanged(object sender, EventArgs e)
        {
            if (text_point.Text.Length > 0)
            {
                text_point.BackColor = Color.White;
            }
        }
    }
}
