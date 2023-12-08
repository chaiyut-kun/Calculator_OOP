namespace Grade_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_id_student = new System.Windows.Forms.TextBox();
            this.student_id_label = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.text_point = new System.Windows.Forms.TextBox();
            this.point_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.text_id_student_max = new System.Windows.Forms.TextBox();
            this.text_id_student_min = new System.Windows.Forms.TextBox();
            this.text_name_max = new System.Windows.Forms.TextBox();
            this.text_name_min = new System.Windows.Forms.TextBox();
            this.text_point_max = new System.Windows.Forms.TextBox();
            this.text_point_min = new System.Windows.Forms.TextBox();
            this.text_avg_point = new System.Windows.Forms.TextBox();
            this.avg_point_label = new System.Windows.Forms.Label();
            this.max_point_label = new System.Windows.Forms.Label();
            this.min_point_label = new System.Windows.Forms.Label();
            this.student_id_label2 = new System.Windows.Forms.Label();
            this.name_label2 = new System.Windows.Forms.Label();
            this.point_label2 = new System.Windows.Forms.Label();
            this.group_enter_data_box = new System.Windows.Forms.GroupBox();
            this.group_result_box = new System.Windows.Forms.GroupBox();
            this.label_avg = new System.Windows.Forms.Label();
            this.text_avg_box = new System.Windows.Forms.TextBox();
            this.label_F = new System.Windows.Forms.Label();
            this.text_F_box = new System.Windows.Forms.TextBox();
            this.label_D_box = new System.Windows.Forms.Label();
            this.text_D_box = new System.Windows.Forms.TextBox();
            this.label_D_plus = new System.Windows.Forms.Label();
            this.text_D_plus_box = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.text_C_box = new System.Windows.Forms.TextBox();
            this.label_C_plus = new System.Windows.Forms.Label();
            this.text_C_plus_box = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.text_B_box = new System.Windows.Forms.TextBox();
            this.label_B_plus = new System.Windows.Forms.Label();
            this.text_B_plus_box = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.text_A_box = new System.Windows.Forms.TextBox();
            this.group_enter_data_box.SuspendLayout();
            this.group_result_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_id_student
            // 
            this.text_id_student.Location = new System.Drawing.Point(168, 35);
            this.text_id_student.Name = "text_id_student";
            this.text_id_student.Size = new System.Drawing.Size(100, 27);
            this.text_id_student.TabIndex = 1;
            this.text_id_student.TextChanged += new System.EventHandler(this.text_id_student_TextChanged);
            // 
            // student_id_label
            // 
            this.student_id_label.AutoSize = true;
            this.student_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label.Location = new System.Drawing.Point(68, 37);
            this.student_id_label.Name = "student_id_label";
            this.student_id_label.Size = new System.Drawing.Size(94, 20);
            this.student_id_label.TabIndex = 2;
            this.student_id_label.Text = "รหัสนักศึกษา";
            this.student_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(168, 80);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 27);
            this.text_name.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(68, 82);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(91, 20);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "ชื่อ-นามสกุล";
            // 
            // text_point
            // 
            this.text_point.Location = new System.Drawing.Point(168, 131);
            this.text_point.Name = "text_point";
            this.text_point.Size = new System.Drawing.Size(100, 27);
            this.text_point.TabIndex = 5;
            this.text_point.TextChanged += new System.EventHandler(this.text_point_TextChanged);
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label.Location = new System.Drawing.Point(68, 133);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(58, 20);
            this.point_label.TabIndex = 6;
            this.point_label.Text = "คะแนน";
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(178, 177);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(79, 32);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = " บักทึก";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // text_id_student_max
            // 
            this.text_id_student_max.Location = new System.Drawing.Point(489, 100);
            this.text_id_student_max.Name = "text_id_student_max";
            this.text_id_student_max.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_max.TabIndex = 8;
            this.text_id_student_max.TextChanged += new System.EventHandler(this.text_id_student_max_TextChanged);
            // 
            // text_id_student_min
            // 
            this.text_id_student_min.Location = new System.Drawing.Point(489, 149);
            this.text_id_student_min.Name = "text_id_student_min";
            this.text_id_student_min.Size = new System.Drawing.Size(100, 27);
            this.text_id_student_min.TabIndex = 9;
            this.text_id_student_min.TextChanged += new System.EventHandler(this.text_id_student_min_TextChanged);
            // 
            // text_name_max
            // 
            this.text_name_max.Location = new System.Drawing.Point(621, 100);
            this.text_name_max.Name = "text_name_max";
            this.text_name_max.Size = new System.Drawing.Size(100, 27);
            this.text_name_max.TabIndex = 9;
            this.text_name_max.TextChanged += new System.EventHandler(this.text_name_max_TextChanged);
            // 
            // text_name_min
            // 
            this.text_name_min.Location = new System.Drawing.Point(621, 151);
            this.text_name_min.Name = "text_name_min";
            this.text_name_min.Size = new System.Drawing.Size(100, 27);
            this.text_name_min.TabIndex = 10;
            this.text_name_min.TextChanged += new System.EventHandler(this.text_name_min_TextChanged);
            // 
            // text_point_max
            // 
            this.text_point_max.Location = new System.Drawing.Point(753, 100);
            this.text_point_max.Name = "text_point_max";
            this.text_point_max.Size = new System.Drawing.Size(100, 27);
            this.text_point_max.TabIndex = 11;
            this.text_point_max.TextChanged += new System.EventHandler(this.text_point_max_TextChanged);
            // 
            // text_point_min
            // 
            this.text_point_min.Location = new System.Drawing.Point(753, 151);
            this.text_point_min.Name = "text_point_min";
            this.text_point_min.Size = new System.Drawing.Size(100, 27);
            this.text_point_min.TabIndex = 12;
            this.text_point_min.TextChanged += new System.EventHandler(this.text_point_min_TextChanged);
            // 
            // text_avg_point
            // 
            this.text_avg_point.Location = new System.Drawing.Point(753, 205);
            this.text_avg_point.Name = "text_avg_point";
            this.text_avg_point.Size = new System.Drawing.Size(100, 27);
            this.text_avg_point.TabIndex = 13;
            this.text_avg_point.TextChanged += new System.EventHandler(this.text_avg_point_TextChanged);
            // 
            // avg_point_label
            // 
            this.avg_point_label.AutoSize = true;
            this.avg_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_point_label.Location = new System.Drawing.Point(628, 207);
            this.avg_point_label.Name = "avg_point_label";
            this.avg_point_label.Size = new System.Drawing.Size(93, 20);
            this.avg_point_label.TabIndex = 14;
            this.avg_point_label.Text = "คะแนนเฉลี่ย";
            // 
            // max_point_label
            // 
            this.max_point_label.AutoSize = true;
            this.max_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_point_label.Location = new System.Drawing.Point(371, 102);
            this.max_point_label.Name = "max_point_label";
            this.max_point_label.Size = new System.Drawing.Size(94, 20);
            this.max_point_label.TabIndex = 15;
            this.max_point_label.Text = "คะแนนสูงสุด";
            // 
            // min_point_label
            // 
            this.min_point_label.AutoSize = true;
            this.min_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_point_label.Location = new System.Drawing.Point(371, 153);
            this.min_point_label.Name = "min_point_label";
            this.min_point_label.Size = new System.Drawing.Size(95, 20);
            this.min_point_label.TabIndex = 16;
            this.min_point_label.Text = "คะแนนต่ำสุด";
            // 
            // student_id_label2
            // 
            this.student_id_label2.AutoSize = true;
            this.student_id_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label2.Location = new System.Drawing.Point(485, 53);
            this.student_id_label2.Name = "student_id_label2";
            this.student_id_label2.Size = new System.Drawing.Size(94, 20);
            this.student_id_label2.TabIndex = 17;
            this.student_id_label2.Text = "รหัสนักศึกษา";
            // 
            // name_label2
            // 
            this.name_label2.AutoSize = true;
            this.name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label2.Location = new System.Drawing.Point(628, 53);
            this.name_label2.Name = "name_label2";
            this.name_label2.Size = new System.Drawing.Size(91, 20);
            this.name_label2.TabIndex = 18;
            this.name_label2.Text = "ชื่อ-นามสกุล";
            // 
            // point_label2
            // 
            this.point_label2.AutoSize = true;
            this.point_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label2.Location = new System.Drawing.Point(759, 53);
            this.point_label2.Name = "point_label2";
            this.point_label2.Size = new System.Drawing.Size(58, 20);
            this.point_label2.TabIndex = 19;
            this.point_label2.Text = "คะแนน";
            // 
            // group_enter_data_box
            // 
            this.group_enter_data_box.Controls.Add(this.student_id_label);
            this.group_enter_data_box.Controls.Add(this.text_id_student);
            this.group_enter_data_box.Controls.Add(this.text_name);
            this.group_enter_data_box.Controls.Add(this.name_label);
            this.group_enter_data_box.Controls.Add(this.text_point);
            this.group_enter_data_box.Controls.Add(this.point_label);
            this.group_enter_data_box.Controls.Add(this.Save_button);
            this.group_enter_data_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_enter_data_box.Location = new System.Drawing.Point(58, 63);
            this.group_enter_data_box.Name = "group_enter_data_box";
            this.group_enter_data_box.Size = new System.Drawing.Size(335, 254);
            this.group_enter_data_box.TabIndex = 20;
            this.group_enter_data_box.TabStop = false;
            this.group_enter_data_box.Text = "กรอกข้อมูล";
            // 
            // group_result_box
            // 
            this.group_result_box.Controls.Add(this.label_avg);
            this.group_result_box.Controls.Add(this.text_avg_box);
            this.group_result_box.Controls.Add(this.label_F);
            this.group_result_box.Controls.Add(this.text_F_box);
            this.group_result_box.Controls.Add(this.label_D_box);
            this.group_result_box.Controls.Add(this.text_D_box);
            this.group_result_box.Controls.Add(this.label_D_plus);
            this.group_result_box.Controls.Add(this.text_D_plus_box);
            this.group_result_box.Controls.Add(this.label_C);
            this.group_result_box.Controls.Add(this.text_C_box);
            this.group_result_box.Controls.Add(this.label_C_plus);
            this.group_result_box.Controls.Add(this.text_C_plus_box);
            this.group_result_box.Controls.Add(this.label_B);
            this.group_result_box.Controls.Add(this.text_B_box);
            this.group_result_box.Controls.Add(this.label_B_plus);
            this.group_result_box.Controls.Add(this.text_B_plus_box);
            this.group_result_box.Controls.Add(this.label_A);
            this.group_result_box.Controls.Add(this.text_A_box);
            this.group_result_box.Controls.Add(this.text_name_min);
            this.group_result_box.Controls.Add(this.text_id_student_max);
            this.group_result_box.Controls.Add(this.point_label2);
            this.group_result_box.Controls.Add(this.text_id_student_min);
            this.group_result_box.Controls.Add(this.name_label2);
            this.group_result_box.Controls.Add(this.text_name_max);
            this.group_result_box.Controls.Add(this.student_id_label2);
            this.group_result_box.Controls.Add(this.text_point_max);
            this.group_result_box.Controls.Add(this.min_point_label);
            this.group_result_box.Controls.Add(this.text_point_min);
            this.group_result_box.Controls.Add(this.max_point_label);
            this.group_result_box.Controls.Add(this.text_avg_point);
            this.group_result_box.Controls.Add(this.avg_point_label);
            this.group_result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_result_box.Location = new System.Drawing.Point(472, 63);
            this.group_result_box.Name = "group_result_box";
            this.group_result_box.Size = new System.Drawing.Size(902, 586);
            this.group_result_box.TabIndex = 21;
            this.group_result_box.TabStop = false;
            this.group_result_box.Text = "ผลลัพธ์";
            this.group_result_box.Enter += new System.EventHandler(this.group_result_box_Enter);
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avg.Location = new System.Drawing.Point(10, 532);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(78, 20);
            this.label_avg.TabIndex = 37;
            this.label_avg.Text = "เกรดเฉลี่ย";
            // 
            // text_avg_box
            // 
            this.text_avg_box.Location = new System.Drawing.Point(94, 529);
            this.text_avg_box.Name = "text_avg_box";
            this.text_avg_box.Size = new System.Drawing.Size(126, 27);
            this.text_avg_box.TabIndex = 36;
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_F.Location = new System.Drawing.Point(51, 470);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(19, 20);
            this.label_F.TabIndex = 35;
            this.label_F.Text = "F";
            // 
            // text_F_box
            // 
            this.text_F_box.Location = new System.Drawing.Point(94, 467);
            this.text_F_box.Name = "text_F_box";
            this.text_F_box.Size = new System.Drawing.Size(126, 27);
            this.text_F_box.TabIndex = 34;
            // 
            // label_D_box
            // 
            this.label_D_box.AutoSize = true;
            this.label_D_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_D_box.Location = new System.Drawing.Point(51, 416);
            this.label_D_box.Name = "label_D_box";
            this.label_D_box.Size = new System.Drawing.Size(22, 20);
            this.label_D_box.TabIndex = 33;
            this.label_D_box.Text = "D";
            // 
            // text_D_box
            // 
            this.text_D_box.Location = new System.Drawing.Point(94, 413);
            this.text_D_box.Name = "text_D_box";
            this.text_D_box.Size = new System.Drawing.Size(126, 27);
            this.text_D_box.TabIndex = 32;
            // 
            // label_D_plus
            // 
            this.label_D_plus.AutoSize = true;
            this.label_D_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_D_plus.Location = new System.Drawing.Point(51, 358);
            this.label_D_plus.Name = "label_D_plus";
            this.label_D_plus.Size = new System.Drawing.Size(32, 20);
            this.label_D_plus.TabIndex = 31;
            this.label_D_plus.Text = "D+";
            // 
            // text_D_plus_box
            // 
            this.text_D_plus_box.Location = new System.Drawing.Point(94, 355);
            this.text_D_plus_box.Name = "text_D_plus_box";
            this.text_D_plus_box.Size = new System.Drawing.Size(126, 27);
            this.text_D_plus_box.TabIndex = 30;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C.Location = new System.Drawing.Point(51, 305);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(21, 20);
            this.label_C.TabIndex = 29;
            this.label_C.Text = "C";
            // 
            // text_C_box
            // 
            this.text_C_box.Location = new System.Drawing.Point(94, 302);
            this.text_C_box.Name = "text_C_box";
            this.text_C_box.Size = new System.Drawing.Size(126, 27);
            this.text_C_box.TabIndex = 28;
            // 
            // label_C_plus
            // 
            this.label_C_plus.AutoSize = true;
            this.label_C_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C_plus.Location = new System.Drawing.Point(51, 257);
            this.label_C_plus.Name = "label_C_plus";
            this.label_C_plus.Size = new System.Drawing.Size(31, 20);
            this.label_C_plus.TabIndex = 27;
            this.label_C_plus.Text = "C+";
            // 
            // text_C_plus_box
            // 
            this.text_C_plus_box.Location = new System.Drawing.Point(94, 254);
            this.text_C_plus_box.Name = "text_C_plus_box";
            this.text_C_plus_box.Size = new System.Drawing.Size(126, 27);
            this.text_C_plus_box.TabIndex = 26;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B.Location = new System.Drawing.Point(51, 203);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(21, 20);
            this.label_B.TabIndex = 25;
            this.label_B.Text = "B";
            // 
            // text_B_box
            // 
            this.text_B_box.Location = new System.Drawing.Point(94, 200);
            this.text_B_box.Name = "text_B_box";
            this.text_B_box.Size = new System.Drawing.Size(126, 27);
            this.text_B_box.TabIndex = 24;
            // 
            // label_B_plus
            // 
            this.label_B_plus.AutoSize = true;
            this.label_B_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B_plus.Location = new System.Drawing.Point(51, 156);
            this.label_B_plus.Name = "label_B_plus";
            this.label_B_plus.Size = new System.Drawing.Size(31, 20);
            this.label_B_plus.TabIndex = 23;
            this.label_B_plus.Text = "B+";
            // 
            // text_B_plus_box
            // 
            this.text_B_plus_box.Location = new System.Drawing.Point(94, 153);
            this.text_B_plus_box.Name = "text_B_plus_box";
            this.text_B_plus_box.Size = new System.Drawing.Size(126, 27);
            this.text_B_plus_box.TabIndex = 22;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A.Location = new System.Drawing.Point(51, 107);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(20, 20);
            this.label_A.TabIndex = 21;
            this.label_A.Text = "A";
            // 
            // text_A_box
            // 
            this.text_A_box.Location = new System.Drawing.Point(94, 104);
            this.text_A_box.Name = "text_A_box";
            this.text_A_box.Size = new System.Drawing.Size(126, 27);
            this.text_A_box.TabIndex = 20;
            this.text_A_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 724);
            this.Controls.Add(this.group_result_box);
            this.Controls.Add(this.group_enter_data_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_enter_data_box.ResumeLayout(false);
            this.group_enter_data_box.PerformLayout();
            this.group_result_box.ResumeLayout(false);
            this.group_result_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_id_student;
        private System.Windows.Forms.Label student_id_label;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_point;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox text_id_student_max;
        private System.Windows.Forms.TextBox text_id_student_min;
        private System.Windows.Forms.TextBox text_name_max;
        private System.Windows.Forms.TextBox text_name_min;
        private System.Windows.Forms.TextBox text_point_max;
        private System.Windows.Forms.TextBox text_point_min;
        private System.Windows.Forms.TextBox text_avg_point;
        private System.Windows.Forms.Label avg_point_label;
        private System.Windows.Forms.Label max_point_label;
        private System.Windows.Forms.Label min_point_label;
        private System.Windows.Forms.Label student_id_label2;
        private System.Windows.Forms.Label name_label2;
        private System.Windows.Forms.Label point_label2;
        private System.Windows.Forms.GroupBox group_enter_data_box;
        private System.Windows.Forms.GroupBox group_result_box;
        private System.Windows.Forms.Label label_B_plus;
        private System.Windows.Forms.TextBox text_B_plus_box;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox text_A_box;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox text_B_box;
        private System.Windows.Forms.Label label_D_plus;
        private System.Windows.Forms.TextBox text_D_plus_box;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.TextBox text_C_box;
        private System.Windows.Forms.Label label_C_plus;
        private System.Windows.Forms.TextBox text_C_plus_box;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.TextBox text_avg_box;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.TextBox text_F_box;
        private System.Windows.Forms.Label label_D_box;
        private System.Windows.Forms.TextBox text_D_box;
    }
}

