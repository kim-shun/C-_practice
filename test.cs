using System;
using System.Globalization;
public class Hello{
    public static void Main(){
        string inputDate1 = "2022/06/20 09:45:00";
        string inputDate2 = "2022/06/1 10:00:00";
        string inputDate3 = "2022/6/10 10:15:00";
        string inputDate4 = "2022/6/2 10:05:00";
        string inputDate5 = "22/06/19 09:50:00";
        string inputDate6 = "22/06/1 09:45:00";
        string inputDate7 = "22/6/10 09:55:00";
        string inputDate8 = "22/6/3 10:10:00";
        string inputDate9 = "2022/07/07 20:45:00.000000";
        change(inputDate1);
        change(inputDate2);
        change(inputDate3);
        change(inputDate4);
        change(inputDate5);
        change(inputDate6);
        change(inputDate7);
        change(inputDate8);
        change(inputDate9);
    }

    
    public static void change(string inputDate)
    {
        string time = "";
        for(int i=6; i<=10; ++i)
        {
          if(" ".Equals(inputDate.Substring(i,1)))
          {
            time = inputDate.Substring(inputDate.Length - (inputDate.Length - (i + 1)));
          }
        }
        string format = "";
        string year = "";
        string month = "";
        string day = "";
        string date = "";
        if (inputDate.Length <= 19)
        {
           if ("/".Equals(inputDate.Substring(2,1)))
           {
               format = "yy/MM/dd HH:mm:ss";
               year = inputDate.Substring(0,2);
               date = inputDate.Substring(3,5);
           }
           else
           {
               format = "yyyy/MM/dd HH:mm:ss";
               year = inputDate.Substring(0,4);
               date = inputDate.Substring(5,5);
           } 
        }
        else if (inputDate.Length <= 26)
        {
            format = "yyyy/MM/dd HH:mm:ss.ffffff";
            year = inputDate.Substring(0,4);
            date = inputDate.Substring(5,5);
        }
       
        if ("/".Equals(date.Substring(1,1)))
        {
          month = (date.Substring(0,1)).PadLeft(2, '0');
          if (" ".Equals(date.Substring(3,1)))
          {
            day = (date.Substring(2,1)).PadLeft(2, '0');
          }
          else
          {
            day = date.Substring(2,2);
          }
        }
        else
        {
          month = date.Substring(0,2);
           if (" ".Equals(date.Substring(4,1)))
          {
            day = (date.Substring(3,1)).PadLeft(2, '0');
          }
          else
          {
            day = date.Substring(3,2);
          }
        }
        
        inputDate = String.Format("{0}/{1}/{2} {3}", year, month, day, time);
        
        DateTime dt;
        bool result = DateTime.TryParseExact(inputDate,format,null,DateTimeStyles.None, out dt);
        Console.WriteLine(result);
        if (!result)
        {
            Console.WriteLine("変換エラー");
        }
        inputDate = dt.ToString("yyyyMMddHHmmssffffff",CultureInfo.CurrentCulture);
        
        Console.WriteLine(inputDate);
        Console.WriteLine();
    }
}
