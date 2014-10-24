using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics
{
    class CodeAnalyzer
    {
        public string Code { get; set; }   //Изначальный код
        public string[] SepCode { get; set; }   //Разделенный массив кода
        public List<string> ValueN1 { get; set; }
        public List<string> Operators { get; set; }
        public int n1 { get; set; }

        public static CodeAnalyzer CreateAnalyzerFromText(string text)
        {
            var analyzer = new CodeAnalyzer {Code = text};
            return analyzer;
        }

        public CodeAnalyzer()
        {
            Operators = File.ReadAllLines("Operators.txt").ToList();
        }

        public CodeAnalyzer(string fileName) : this()
        {
            Code = File.ReadAllText(fileName);
        }

        public void SeparateCode()
        {
            SepCode = Code.Split(new[] { " ", ",", ";", "(", ")","\t", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Search_n1()
        {
            ValueN1 = new List<string>();
            for (int i = 0; i < SepCode.Length; i++)
            {
                if (SepCode[i] == "void")   //Поиск имен процедур
                {
                    ValueN1.Add(SepCode[i+1]);
                }
                if (Operators.Contains(SepCode[i])) // Поиск операторов из файла
                {
                    ValueN1.Add(SepCode[i]);
                }
            }
            n1 = ValueN1.Count;
        }

    }
}
