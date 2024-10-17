using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProjectStudentManagment
{
    internal class JsonFileStorage : IStorageServices
    {
        private readonly string _filePath;
        public JsonFileStorage()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _filePath = Path.Combine(documentsPath, "StudentManagement", "JsonData");
            Directory.CreateDirectory(_filePath);
        }
        public void Remove(string regNumber)
        {
            Directory.Delete(_filePath, true);

        }
        public Student GetByRegNumber(string regNumber)
        {
            return default;
        }
        public void Save(Student student)
        {
            var jsonText = JsonConvert.SerializeObject(student);
            var filePath = Path.Combine(_filePath, $"{student.RegNumber}.json");
            File.WriteAllText(filePath, jsonText);
        }

        public Student Search(string name)
        {
            var files = Directory.GetFiles(_filePath);
            foreach ( var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Student student = JsonConvert.DeserializeObject<Student>(fileContentJson);

                var studentName = student.Name.ToLowerInvariant(); 
                var nameToSearch = name.ToLowerInvariant();
                if (studentName.Contains(nameToSearch))
                { 
                    return student;
                }

            }
            return null;
        }

        public Student GetByRegNUmber(string regNUmber)
        {
            throw new NotImplementedException();
        }

        public void DeleteByRegNUmber(string regNUmber)
        {
            throw new NotImplementedException();
        }
    }
}
