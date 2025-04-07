using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace json_implementation1
{
    class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    class DataMahasiswaa103022300097
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string filePath = @"C:\Users\hp\Documents\Project KPL\MOD7\json-implementation\tp7_1_103022300097.json";

            // Baca isi file JSON
            string jsonString = File.ReadAllText(filePath);

            // Deserialize ke object
            DataMahasiswaa103022300097 data = JsonSerializer.Deserialize<DataMahasiswaa103022300097>(jsonString);

            // Tampilkan hasil deserialisasi
            Console.WriteLine($"Nama: {data.nama.depan} {data.nama.belakang}");
            Console.WriteLine($"NIM: {data.nim}");
            Console.WriteLine($"Fakultas: {data.fakultas}");
        }
    }
}
