using System.ComponentModel;
using System.Reflection;

namespace KaladynskayaDaryaCSharp.Constants
{
    public static class MenuKeys
    {
        public enum MenuItems
        {
            [Description("Task1 - CheckNumber")]
            Task1CheckNumber = 1,
            [Description("Task2 - NameCheck")]
            Task2NameCheck,
            [Description("Task3 - ArrayTask")]
            ArrayTask,
            [Description("Exit")]
            Exit
        }

        public static string GetEnumDescription(this Enum genericEnum)
        {
            var genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Count() > 0)
                {
                    return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
                }
            }

            return genericEnum.ToString();
        }
    }
}
