using System;
using OO.ContentContext;
using OrientacaoObjetos.SubscriptionContext;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>
            {
                new(".Net Fundamentos", "Aprofunde-se nos fundamentos .Net"),
                new("C# Fundamentos", "Aprofunde-se nos fundamentos C#"),
                new("Docker", "Aprofunde-se nos em Docker"),
                new("Git", "Conheça o Git")
            };
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var course = new Course("Fundamentos OOP", "Orientação a Objetos");
            var courseCsharp = new Course("C#", "Fundamentos");
            var courseAspNet = new Course("AspNet", "Fundamentos AspNet");
            courses.Add(course);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .Net", "especialista");
            var careerItem3 = new CareerItem(3, "Terceiro Passo", "avançando a carreira", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "iniciando a carreira", courseAspNet);
            var careerItem2 = new CareerItem(2, "Segundo Passo", "avançando a carreira", course);
            careerDotnet.CareerItems.Add(careerItem3);
            careerDotnet.CareerItems.Add(careerItem);
            careerDotnet.CareerItems.Add(careerItem2);
            careers.Add(careerDotnet);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.CareerItems.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }
        }
    }
}