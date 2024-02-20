using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp__ArraysListasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersCopy = new int[10];

            // 0-based

            for (var i = 0; i < numbersCopy.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);

            #endregion 

            #region Listas

            var list = new List<int> { 0, 1, 2, 3, 4 };
            var listFromArray = new List<int>(numbers);

            list.Add(5);
            list.AddRange(new List<int> { 6, 7 });
            list.AddRange(new int[] { 8, 9 });

            var count = list.Count;
            var countains14 = list.Contains(14);
            var contains2 = list.Contains(2);

            list.Reverse();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista ordenada");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista final");
            list.Remove(4);
            list.RemoveAll(l => l > 5);
            list.ForEach(l => Console.WriteLine(l));

            list.Clear();

            #endregion

            #region LINQ

            var students = new List<Student>
            {
                new Student(1, "Luís", "12345678910", 100),
                new Student(2, "Roberto", "98765432110", 35),
                new Student(3, "Bianca", "32165498701", 85),
                new Student(4, "Helena", "78945612391", 70),
                new Student(5, "Luís", "43265487699", 75)
            };

            var any = students.Any(); //Tem algum item nesta lista?
            var any100 = students.Any(s => s.Grade == 100); //Existe algum aluno com nota igual a 100?

            var single = students.Single(s => s.Id == 1); //Existe algum estudante com Id igual a 1? Dai ele busca e retorna
            var singleOrDefault = students.SingleOrDefault(s => s.Document == "12345678910"); //Este metodo é melhor que o de cima, se o metodo buscar e não achar nada ele retorna valor NULO

            var first = students.First(s => s.FullName == "Luís"); //Metodo que faz uma procura e retorna a primeira string que encontrar.
            var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            var orderedByGrade = students.OrderBy(s => s.Grade); // Ordena os alunos por nota crescente!
            var orderedByGradeDescending = students.OrderByDescending(s => s.Grade); // Ordena os alunos por nota descedente!

            var approvedStudents = students.Where(s => s.Grade >= 70); //Retorna as notas igual ou maior que 70

            var grade = students.Select(s => s.Grade); //Seleciona somente as notas dos estudantes
            var phoneNumbers = students.SelectMany(s => s.PhoneNumbers); // Seleciona todos os números de telefones dos alunos e manda email em toda base de alunos, conforme a biblioteca desejada

            var sum = students.Sum(s => s.Grade); // Soma todas as notas dos alunos
            var min = students.Min(s => s.Grade); // A menor nota da turma
            var max = students.Max(s => s.Grade); // Valor maximo da nota da turma
            var count1 = students.Count; // O tamanho da lista de alunos


            #endregion

            Console.ReadKey();
        }
    }


    public class Student
    {
        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;

            PhoneNumbers = new List<string> { "123323232", "23412412312", "2809138231" };
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Document { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }
}

