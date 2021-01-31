using System;
namespace Module8
{
    public class User<T, U>
    {
        public User(){}

        public User(T userid, U name)
        {
            UserId = userid;
            Name = name;
        }

        public T UserId { get; set; }

        public U Name { get; set; }
    }
}

