using System;

namespace CommonLibrary.Attributes
{
    /// <summary>
    /// 指定欄位或屬性對應的標題內容。
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class TitleAttribute : Attribute
    {
        private readonly string _title;
        /// <summary>
        /// 指定的標題內容。
        /// </summary>
        public string Title => _title;

        /// <summary>
        /// 初始化提供指定標題內容屬性實體的建構子。
        /// </summary>
        /// <param name="title">欲指定的標題內容。</param>
        public TitleAttribute(string title)
        {
            _title = title;
        }
    }
}
