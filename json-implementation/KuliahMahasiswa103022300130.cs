using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    class KuliahMahasiswa103022300130
    {

        public static void ReadJSON()
        {
            try
            {

            string filePath = @"C:\Users\rakha\Desktop\KPL\KPL_MOD_07\json-implementation\json-implementation\tp7_2_103022300130.json";

           
            string jsonString = File.ReadAllText(filePath);

                
                var data = JsonSerializer.Deserialize<CourseList>(jsonString);

                foreach (var course in data.courses)
                {
                    Console.WriteLine($"Kode: {course.code}, Nama: {course.name}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }


