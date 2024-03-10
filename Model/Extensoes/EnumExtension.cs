using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BlazingPizza.Model.Extensoes
{
    public static class EnumExtension
    {
        public static string ObterNome(this Enum enumValue)
        {
            return enumValue.ObterAtributo<DisplayAttribute>().Name;
        }
        public static TAttribute ObterAtributo<TAttribute>(this Enum enumValue)
                where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }
}