using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 1. 0.250” Size Character Set Macros-  character space 0.05”
2. 0.190” Size Character Set Macros-  Character space 0.04”
3. 0.125” Size Character Set Macros-  Character space 0.03”
4. 0.090” Size Character Set Macros-  Character space 0.02”
 * 
 */
namespace OCSMarkingDLL.cr
{
    public class MainCR0P25
    {

        //============ start ===============
        //19th July 2022


        public static String getCR0()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(0)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0179");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0774");
            sb.AppendLine("G01 X[#5-0.0714] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.1667] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0774");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0179");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(1)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.0774  F[#178]");
            sb.AppendLine("G01 Z[#26+0.2]");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.131] Y-0.125");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.18 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR2()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(2)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.1012");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1012");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0536");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1548] Y0.006");
            sb.AppendLine("G01 X[#5-0.0357] Y0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR3()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(3)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.125");
            sb.AppendLine("G01 X[#5-0.119] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.006");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0893");
            sb.AppendLine("G01 X[#5-0.1667] Y0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0774");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR4()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(4)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0417");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.265 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR5()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(5)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.131] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.006");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0893");
            sb.AppendLine("G01 X[#5-0.1667] Y0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0774");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR6()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(6)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0893");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 X[#5-0.119] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0417");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.119] Y0.125");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.1667] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0417");
            sb.AppendLine("G01 X[#5-0.1905] Y0.006");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.131] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.119] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.0595] Y0.006");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR7()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(7)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0833] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR8()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(8)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.131] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0179");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0417");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0774");
            sb.AppendLine("G01 X[#5-0.1905] Y0.1012");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1429] Y0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0774");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0417");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0179");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.265 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCR9()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(9)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0417");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1548] Y0.0179");
            sb.AppendLine("G01 X[#5-0.119] Y0.0298");
            sb.AppendLine("G01 X[#5-0.1071] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0714] Y0.0179");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0536");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 X[#5-0.119] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0179");
            sb.AppendLine("G01 X[#5-0.1786] Y0.0774");
            sb.AppendLine("G01 X[#5-0.1548] Y0.1131");
            sb.AppendLine("G01 X[#5-0.119] Y0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0893");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(A)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0119] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0417");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1667] Y0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRAMP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(&)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2738] Y-0.0179");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2738] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.2619] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.25] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.2381] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.2262] Y-0.006");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G01 X[#5-0.1786] Y0.0893");
            sb.AppendLine("G01 X[#5-0.1548] Y0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.0833] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0774");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0536");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0179");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.131] Y0.006");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2381] Y0.125");
            sb.AppendLine("G01 X[#5-0.2619] Y0.125");
            sb.AppendLine("G01 X[#5-0.2738] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2738] Y0.1012");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.32 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRB()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(B)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.1012");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0536");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1905] Y0.006");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0179");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0417");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0774");
            sb.AppendLine("G01 X[#5-0.2024] Y0.1012");
            sb.AppendLine("G01 X[#5-0.1905] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("(NEXT LINE)");
            sb.AppendLine("#6 = #3 * #177");
            sb.AppendLine("C[#6]");
            sb.AppendLine("#3 = #3 + 1");
            sb.AppendLine("#5 = #24 (MARKING X VALUE CALCULATOR)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRC()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(C)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0655");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0655");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0655");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCOLON()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(:)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0417");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.0714] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1012");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y0.125");
            sb.AppendLine("G01 X[#5-0.0714] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1012");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.12 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRCOMMA()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(,)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1131");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0357] Y0.125");
            sb.AppendLine("G01 X[#5-0.0238] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0357] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1369");
            sb.AppendLine("G01 X[#5-0.0357] Y0.1607");
            sb.AppendLine("G01 X[#5-0.0238] Y0.1726");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.095 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRD()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(D)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.131] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1667] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0655");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0893");
            sb.AppendLine("G01 X[#5-0.1667] Y0.1131");
            sb.AppendLine("G01 X[#5-0.131] Y0.125");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }


        public static String getCRDOT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(.)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1012");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y0.125");
            sb.AppendLine("G01 X[#5-0.0714] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1012");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.14 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(E)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRF()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(F)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRFOOTER()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(END)");
            sb.AppendLine("M05");
            sb.AppendLine("G69");
            sb.AppendLine("G49");
            sb.AppendLine("G00 G91 G28 G01 X0 Y0");
            sb.AppendLine("G91 G30 P3 Z0");
            sb.AppendLine("M99");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRG()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(G)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0655");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0655");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0655");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0298");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1548] Y0.0298");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0298");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(H)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRHASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(#)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.131] Y-0.1726");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.2083");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.1726");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.119] Y0.2083");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0179");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0179");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0536");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRHEADER(string pstr)
        {
            return CMON.getHEADER(pstr, Consts.P250);
        }

        public static String getCRHYPHEN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(-)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0179");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2619] Y0.0179");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.31 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(I)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.1 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRJ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(J)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1429] Y0.0655");
            sb.AppendLine("G01 X[#5-0.131] Y0.1012");
            sb.AppendLine("G01 X[#5-0.119] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0714] Y0.125");
            sb.AppendLine("G01 X[#5-0.0476] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0357] Y0.1012");
            sb.AppendLine("G01 X[#5-0.0238] Y0.0655");
            sb.AppendLine("G01 X[#5-0.0238] Y0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.2 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRK()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(K)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0417");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.0179");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRL()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(L)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 X[#5-0.1905] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRM()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(M)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125 F[#178]");
            sb.AppendLine("G01 Z[#26+0.2]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1429] Y0.125");
            sb.AppendLine("G01 X[#5-0.2381] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2381] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRN()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(N)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2143] Y0.125");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRO()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(O)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0655");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0655");
            sb.AppendLine("G01 X[#5-0.2262] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2262] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRP()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(P)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125 F[#178]");
            sb.AppendLine("G01 Z[#26+0.2]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.1012");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1548] Y0.006");
            sb.AppendLine("G01 X[#5-0.0476] Y0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRQ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Q)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0298");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0655");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y0.125");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0655");
            sb.AppendLine("G01 X[#5-0.2262] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2262] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.1429] Y0.0774");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y0.1488");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRR()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(R)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.125");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.1012");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0774");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.0536");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.1905] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1548] Y-0.006");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.131] Y-0.006");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2143] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRS()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(S)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.0893");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.1131");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0893");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.0655");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.0417");
            sb.AppendLine("G01 X[#5-0.0595] Y-0.0298");
            sb.AppendLine("G01 X[#5-0.0833] Y-0.0179");
            sb.AppendLine("G01 X[#5-0.1548] Y0.006");
            sb.AppendLine("G01 X[#5-0.1786] Y0.0179");
            sb.AppendLine("G01 X[#5-0.1905] Y0.0298");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0536");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.1429] Y0.125");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G01 X[#5-0.0595] Y0.1131");
            sb.AppendLine("G01 X[#5-0.0357] Y0.0893");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRSLASH()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(/)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0357] Y0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRSPACE()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(SPACE)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.15 (NEXT CHARACTER)");
            sb.AppendLine("");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRT()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(T)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0952] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0952] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0119] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1786] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.235 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRU()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(U)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0476] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0476] Y0.0536");
            sb.AppendLine("G01 X[#5-0.0595] Y0.0893");
            sb.AppendLine("G01 X[#5-0.0833] Y0.1131");
            sb.AppendLine("G01 X[#5-0.119] Y0.125");
            sb.AppendLine("G01 X[#5-0.1429] Y0.125");
            sb.AppendLine("G01 X[#5-0.1786] Y0.1131");
            sb.AppendLine("G01 X[#5-0.2024] Y0.0893");
            sb.AppendLine("G01 X[#5-0.2143] Y0.0536");
            sb.AppendLine("G01 X[#5-0.2143] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(V)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0119] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRW()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(W)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0238] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0833] Y0.125");
            sb.AppendLine("G01 X[#5-0.1429] Y-0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G01 X[#5-0.2619] Y-0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRX()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(X)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.0357] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRY()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Y)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0119] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.006");
            sb.AppendLine("G01 X[#5-0.1071] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.1071] Y-0.006");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }

        public static String getCRZ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("(Z)");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("G01 X[#5-0.0357] Y-0.125");
            sb.AppendLine("G01 Z[#26+0.2] F[#178]");
            sb.AppendLine("G01 X[#5-0.2024] Y-0.125");
            sb.AppendLine("G01 X[#5-0.0357] Y0.125");
            sb.AppendLine("G01 X[#5-0.2024] Y0.125");
            sb.AppendLine("G00 Z[#26+0.25]");
            sb.AppendLine("#5 = #5 - 0.255 (NEXT CHARACTER)");
            sb.AppendLine("");
            return sb.ToString();
        }


        //========= END ======================
    }//CLASS
}
