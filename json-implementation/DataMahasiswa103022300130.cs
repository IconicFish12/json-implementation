﻿using System;
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


    class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    class DataMahasiswa103022300130
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    
        public static void ReadJSON()
        {
            string filePath = @"C:\Users\rakha\Desktop\KPL\KPL_MOD_07\json-implementation\json-implementation\tp7_1_103022300130.json";

            // Baca isi file JSON
            string jsonString = File.ReadAllText(filePath);
            // Deserialize ke object
            DataMahasiswa103022300130 data = JsonSerializer.Deserialize<DataMahasiswa103022300130>(jsonString);

            // Tampilkan hasil deserialisasi
            Console.WriteLine($"Nama: {data.nama.depan} {data.nama.belakang}");
            Console.WriteLine($"NIM: {data.nim}");
            Console.WriteLine($"Fakultas: {data.fakultas}");
        }
    }

