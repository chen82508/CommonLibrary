using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PtmbCommLibrary.Extensions
{
    /// <summary>
    /// 字串驗證的擴充方法。
    /// </summary>
    public static class StringValidationExtension
    {
        /// <summary>
        /// 驗證是否為有效的中華民國身分證字號。
        /// </summary>
        /// <param name="idNo">受驗證的中華民國身分證字號。</param>
        /// <returns>受驗證的中華民國身分證字號是否有效。</returns>
        public static bool ValidROCID(this string idNo)
        {
            if (idNo == null)
            {
                return false;
            }

            idNo = idNo.ToUpper();
            Regex regex = new Regex(@"^([A-Z])([1-2]\d{8})$");
            Match match = regex.Match(idNo);
            if (!match.Success)
            {
                return false;
            }

            // 建立字母對應表(A~Z)：
            // A=10 B=11 C=12 D=13 E=14 F=15 G=16 H=17 J=18 K=19 L=20 M=21 N=22
            // P=23 Q=24 R=25 S=26 T=27 U=28 V=29 X=30 Y=31 W=32 Z=33 I=34 O=35
            string alphabet = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
            string transferIdNo = $"{alphabet.IndexOf(match.Groups[1].Value) + 10}" +
                                  $"{match.Groups[2].Value}";

            int[] idNoArray = transferIdNo.ToCharArray().Select(c => Convert.ToInt32($"{c}")).ToArray();
            int sum = idNoArray[0];
            int[] weight = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            for (int i = 0; i < weight.Length; i++)
            {
                sum += weight[i] * idNoArray[i + 1];
            }

            return sum % 10 == 0;
        }
    }
}
