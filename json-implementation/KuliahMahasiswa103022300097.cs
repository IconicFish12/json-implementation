using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace json_implementation1
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    class KuliahMahasiswaa103022300097
    {

        public static void ReadJSON()
        {
            try
            {

                string filePath = @"C:\Users\hp\Documents\Project KPL\MOD7\json-implementation\tp7_2_103022300097.json";

                // Baca isi file JSON
                string jsonString = File.ReadAllText(filePath);

                // Deserialize ke object
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
}
