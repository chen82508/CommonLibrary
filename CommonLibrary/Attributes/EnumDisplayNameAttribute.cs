using System;

namespace PtmbCommLibrary.Attributes
{
    /// <summary>
    /// 指定列舉欄位對應的顯示名稱。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDisplayNameAttribute : Attribute
    {
        private readonly string _displayName;
        /// <summary>
        /// 顯示名稱。
        /// </summary>
        public string DisplayName => _displayName;

        /// <summary>
        /// 初始化提供指定列舉欄位對應的顯示名稱的建構子。
        /// </summary>
        /// <param name="dispName">顯示名稱。</param>
        public EnumDisplayNameAttribute(string dispName)
        {
            this._displayName = dispName;
        }
    }
}
