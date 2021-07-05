using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;

        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите eMail пользователя, которого хотите добавить себе в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Пользователь успешно добавлен в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным eMail - не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("При добавлении пользователя в друзья произоша ошибка!");
            }

        }
    }
}
