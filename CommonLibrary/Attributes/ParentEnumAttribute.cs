using System;

namespace CommonLibrary.Attributes
{
    /// <summary>
    /// 指定列舉欄位對應的上層列舉欄位。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ParentEnumAttribute : Attribute
    {
        private readonly Enum _parentEnum;
        /// <summary>
        /// 對應的上層列舉欄位。
        /// </summary>
        public Enum ParentEnum => _parentEnum;

        /// <summary>
        /// 初始化提供紀錄上層列舉類別實體的建構子。
        /// </summary>
        /// <param name="enumType">上層列舉類型。</param>
        /// <param name="enumInt">上層列舉欄位對應的整數值。</param>
        public ParentEnumAttribute(Type enumType, int enumInt)
        {
            this._parentEnum = (Enum)Enum.ToObject(enumType, enumInt);
        }
    }
}
