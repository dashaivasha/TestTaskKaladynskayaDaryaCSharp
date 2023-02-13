using System;

namespace KaladynskayaDaryaCSharp.Tasks
{
    public class ChecName
    {
        public string UserName;

        public ChecName(string userName)
        {
            UserName = userName;
        }

        public string CheckIsNameVyacheslav()
        {
            var comparisonString = "Вячеслав";

            if (string.Equals(UserName, comparisonString, StringComparison.OrdinalIgnoreCase))
            {
                return "Привет, Вячеслав";
            }
            else
            {
                return "Нет такого имени";
            }
        }
    }
}
