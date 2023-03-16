using System;
using System.Reflection;

namespace ScoreCardBackend.Extensions
{
    /// <summary>
    /// 泛用物件的擴充方法。
    /// </summary>
    public static class ObjectExtension
    {
        /// <summary>
        /// 取得對應屬性的填入值。
        /// </summary>
        /// <param name="obj">呼叫擴充方法的物件。</param>
        /// <param name="propertyName">要取得填入值的屬性名稱。</param>
        /// <returns></returns>
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            Type type = obj.GetType();
            PropertyInfo prop = type.GetProperty(propertyName);
            object value = $"{prop.GetValue(obj)}";
            return value;
        }
    }
}
