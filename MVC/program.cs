using System;
using System.Collections.Generic;
using System.Linq;



namespace MVC
{
    class Phone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
    interface IphoneReposotory
    {
        List<Phone> GetAllPhones();
        Phone GetPhoneById(int id);
        void AddPhone(Phone phone);
        void DeletePhone(int id);
    }
    class PhoneRepository : IphoneReposotory
    {
        private List<Phone> phones = new List<Phone>();

        public List<Phone> GetAllPhones()
        {
            return phones;
        }
        public Phone GetPhoneById(int id)
        {
            return phones.FirstOrDefault(p => p.Id == id);
        }
        public void AddPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public void DeletePhone(int id)
        {
            var phone = GetPhoneById(id);
            if (phone != null)
            {
                phones.Remove(phone);
            }
        }
    }

    class View
    {
        public void GetAllPhones(List<Phone> phones)
        {
            Console.WriteLine("---- All Phones ----");
            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine($"{phones[i].Id}: {phones[i].Brand} {phones[i].Model} - ${phones[i].Price}");
            }
        }
        public void Show(Phone phone)
        {
            if (phone != null)
            {
                Console.WriteLine($"Phone Details: {phone.Id}: {phone.Brand} {phone.Model} - ${phone.Price}");
            }
            else
            {
                Console.WriteLine("Phone not found.");
            }
        }
    }

    class Controller
    {
        private IphoneReposotory reposotory;
        private View view;

        public Controller(IphoneReposotory reposotory, View view)
        {
            this.reposotory = reposotory;
            this.view = view;
        }
        public void AddPhone(Phone phone)
        {
            reposotory.AddPhone(phone);
        }
        public void DeletePhone(int id)
        {
            reposotory.DeletePhone(id);
        }
        public void DisplayAllPhones()
        {
            var phones = reposotory.GetAllPhones();
            view.GetAllPhones(phones);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new PhoneRepository();
            var view = new View();
            var controller = new Controller(repository, view);
            controller.AddPhone(new Phone { Id = 1, Brand = "Iphone", Model = "14 Pro", Price = 1200 });
            controller.AddPhone(new Phone { Id = 2, Brand = "Huawei", Model = "P50 Pro", Price = 500 });
            controller.DisplayAllPhones();
        }
    }
}
