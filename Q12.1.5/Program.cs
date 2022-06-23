using System;
using System.Threading;

namespace Q12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
			User[] users = { new User("UserLogin1", "UserName1", true),
				             new User("UserLogin2", "UserName2", false),
				             new User("UserLogin3", "UserName3", true),
				             new User("UserLogin4", "UserName4", false)};

			foreach (User user in users) 
			{
				Console.WriteLine("Приветствую,{0}",user.Name);
				Thread.Sleep(1000);
				if (!user.IsPremium)
			    {
					ShowAds();
                }
			}

		}
		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			Thread.Sleep(1000);
			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			Thread.Sleep(2000);
			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			Thread.Sleep(3000);
		}
	}
	

}
