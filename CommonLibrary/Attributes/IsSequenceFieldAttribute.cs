using System;

namespace CommonLibrary.Attributes
{
    /// <summary>
    /// 指示列舉欄位是否為排序欄位的屬性。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class IsSequenceFieldAttribute : Attribute
    {
        private readonly bool _isSequence;
        /// <summary>
        /// 是否為排序欄位。
        /// </summary>
        public bool IsSequence => _isSequence;

        /// <summary>
        /// 初始化提供指示列舉欄位是否為排序欄位的建構子。
        /// </summary>
        /// <param name="isSequence">是否將列舉欄位指定為排序。</param>
        public IsSequenceFieldAttribute(bool isSequence = true)
        {
            _isSequence = isSequence;
        }
    }
}
