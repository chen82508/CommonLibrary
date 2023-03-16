using System;

namespace PtmbCommLibrary.Attributes
{
    /// <summary>
    /// 指定列舉欄位使用的資料表類型。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumUsingDbTableAttribute : Attribute
    {
        private readonly Type _tableType;

        /// <summary>
        /// 資料表類型。
        /// </summary>
        public Type TableType => _tableType;

        /// <summary>
        /// 初始化提供指定列舉欄位使用的資料表類型的建構子。
        /// </summary>
        /// <param name="tableType">資料表類型。</param>
        public EnumUsingDbTableAttribute(Type tableType)
        {
            _tableType = tableType;
        }
    }
}
