using System;

namespace Console_calc
{
    internal class CheckData
    {
        public static double CheckDataToDouble(string num, out string message)
        {
            try
            {
                message = "";
                return double.Parse(num);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return 0;
            }
        }

        public static bool CheckDivision(double b, out string message)
        {
            if (b == 0)
            {
                message = "Ошибка: деление на ноль невозможно!";
                return false;
            }
            message = "";
            return true;
        }
    }
}

