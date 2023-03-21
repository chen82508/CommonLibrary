using System;

namespace CommonLibrary.Attributes
{
    /// <summary>
    /// 指定列舉欄位寬度的權重。
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumColumnWidthWeightAttribute : Attribute
    {
        private readonly int _weight;

        /// <summary>
        /// 欄位寬度的權重(單位為%)。
        /// </summary>
        public int Weight => _weight;
        /// <summary>
        /// 初始化提供指定列舉欄位寬度的權重的建構子。
        /// </summary>
        /// <param name="weight">權重的百分比數。</param>
        public EnumColumnWidthWeightAttribute(int weight)
        {
            _weight = weight;
        }
    }
}
