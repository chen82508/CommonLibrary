using PtmbCommLibrary.Attributes;
using System;
using System.ComponentModel;
using System.Reflection;

namespace PtmbCommLibrary.Extensions
{
    /// <summary>
    /// 列舉類別的擴充方法。
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// 取得列舉欄位設定的分類名稱。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="CategoryAttribute"/> 內容。</returns>
        public static string GetEnumCategoryAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, CategoryAttribute>(@enum) is CategoryAttribute attr)
                return attr.Category;
            return "CategoryAttribute的內容未設定";
        }

        /// <summary>
        /// 取得列舉欄位設定的描述。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="DescriptionAttribute"/> 內容。</returns>
        public static string GetEnumDescAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, DescriptionAttribute>(@enum) is DescriptionAttribute attr)
                return attr.Description;
            return "DescriptionAttribute的內容未設定";
        }

        /// <summary>
        /// 取得列舉欄位設定的顯示名稱。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="DisplayNameAttribute"/> 內容。</returns>
        public static string GetEnumDispNameAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, EnumDisplayNameAttribute>(@enum) is EnumDisplayNameAttribute attr)
                return attr.DisplayName;
            return "EnumDisplayNameAttribute的內容未設定";
        }

        /// <summary>
        /// 取得列舉欄位設定的映射資料表欄位名稱。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="EnumMapDbColumnAttribute"/> 內容。</returns>
        public static string GetEnumMapDbColumnAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, EnumMapDbColumnAttribute>(@enum) is EnumMapDbColumnAttribute attr)
                return attr.ColumnName;
            return "EnumMapDbColumnAttribute的內容未設定";
        }

        /// <summary>
        /// 取得列舉欄位設定的標題內容。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="TitleAttribute"/> 內容。</returns>
        public static string GetEnumTitleAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, TitleAttribute>(@enum) is TitleAttribute attr)
                return attr.Title;
            return "TitleAttribute的內容未設定";
        }

        /// <summary>
        /// 取得列舉欄位指定的資料表類型。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="EnumUsingDbTableAttribute"/> 內容。</returns>
        public static Type GetEnumUsingDbTableAttrValue<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, EnumUsingDbTableAttribute>(@enum) is EnumUsingDbTableAttribute attr)
                return attr.TableType;
            return null;
        }

        /// <summary>
        /// 取得列舉欄位指定的上層列舉內容。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="ParentEnumAttribute"/> 內容。</returns>
        public static Enum GetParentEnum<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, ParentEnumAttribute>(@enum) is ParentEnumAttribute attr)
                return attr.ParentEnum;
            return null;
        }

        /// <summary>
        /// 檢核列舉欄位是否為排序性質。
        /// </summary>
        /// <typeparam name="T">列舉欄位的類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns>列舉欄位所指定的 <see cref="IsSequenceFieldAttribute"/> 內容。</returns>
        public static bool IsSequenceColumn<T>(this T @enum) where T : Enum
        {
            if (GetAttributeSettingVal<T, IsSequenceFieldAttribute>(@enum) is IsSequenceFieldAttribute attr)
                return attr.IsSequence;
            return false;
        }

        /// <summary>
        /// 取得列舉欄位的屬性設定值
        /// </summary>
        /// <typeparam name="TEnum">列舉欄位的類別</typeparam>
        /// <typeparam name="TAttr">要取得設定值的屬性類別</typeparam>
        /// <param name="enum">列舉欄位</param>
        /// <returns></returns>
        private static TAttr GetAttributeSettingVal<TEnum, TAttr>(TEnum @enum)
            where TEnum : Enum
            where TAttr : Attribute
        {
            FieldInfo fi = @enum.GetType().GetField($"{@enum}");
            if (Attribute.GetCustomAttribute(fi, typeof(TAttr)) is TAttr attr)
            {
                return attr;
            }
            return null;
        }
    }
}
