using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Друзья:");


            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас нет друзей");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("eMail друга: {0}. Имя друга: {1}. Фамилия друга: {2}", friend.Email, friend.FirstName, friend.LastName);
            });

        }

    }
}
