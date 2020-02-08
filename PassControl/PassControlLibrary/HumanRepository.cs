using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class HumanRepository
    {
        private List<Human> employees;

        public HumanRepository()
        {
            employees = new List<Human>();
            employees.Add(new Human(1, "Martynas", "Auksine", new List<int> { 1, 2, 3 }));
            employees.Add(new Human(2, "Andrius", "Mazmena", new List<int> { 1, 3 }));
            employees.Add(new Human(3, "Giedre", "Giedraite", new List<int> { 2, 3 })); 
            employees.Add(new Human(4, "Jonas", "Jonaitis", new List<int> { 1, 2, }));
            employees.Add(new Human(5, "Eva", "Evatyte", new List<int> {3 }));
            employees.Add(new Human(6, "Leo", "Leonovic", new List<int> { }));
            employees.Add(new Human(7, "Marta", "Mockute", new List<int> { 1, 2, 3 }));
            employees.Add(new Human(8, "Miranda", "Mirandyte", new List<int> { 1, 4}));
            employees.Add(new Human(9, "Saulius", "Saulenas", new List<int> { 1, 2, 3, 4}));
            employees.Add(new Human(10, "Lina", "Linute", new List<int> { 1, 2, 3 }));
            employees.Add(new Human(11, "Rasa", "Rasaite", new List<int> { 2, 3 }));
            employees.Add(new Human(12, "Asta", "Astute", new List<int> { 1, 2, 4 }));
            employees.Add(new Human(13, "Linas", "Linaitis", new List<int> { 1, 3, 4}));

        }
        public List<Human> Retrieve()
        {
            return employees;
        }
        public Human Retrieve (int id)
        {
            foreach (var employee in employees)
            {
                if (employee.Id == id)
                    return employee;
            }
            return null;
        }
    }
}
