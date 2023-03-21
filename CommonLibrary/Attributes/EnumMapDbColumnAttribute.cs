using System;

namespace CommonLibrary.Attributes
{
    /// <summary>
    /// 指定列舉欄位映射到資料庫的欄位名稱。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumMapDbColumnAttribute : Attribute
    {
        private readonly string _columnName;
        /// <summary>
        /// 欄位名稱。
        /// </summary>
        public string ColumnName => _columnName;

        /// <summary>
        /// 初始化提供指定列舉欄位映射到資料庫的欄位名稱的建構子。
        /// </summary>
        /// <param name="columnName">欄位名稱。</param>
        public EnumMapDbColumnAttribute(string columnName)
        {
            this._columnName = columnName;
        }
    }
}
