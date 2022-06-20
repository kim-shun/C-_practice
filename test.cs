using System;
using System.Globalization;
public class Hello{
    public static void Main(){
        string date1 = "2022/06/20 09:45:00"; //True
        string date2 = "2022/06/1 10:00:00"; //False
        string date3 = "2022/6/10 10:15:00"; //False
        string date4 = "2022/6/2 10:05:00"; //False
        string date5 = "22/06/19 09:50:00"; //True
        string date6 = "22/06/1 09:45:00"; //False
        string date7 = "22/6/10 09:55:00"; //False
        string date8 = "22/6/3 10:10:00"; //False
        change(date1);
        change(date2);
        change(date3);
        change(date4);
        change(date5);
        change(date6);
        change(date7);
        change(date8);
    }
    
    public static void change(string date)
    {
        string time = "";
        for(int i=6; i<=10; ++i)
        {
          if(" ".Equals(date.Substring(i,1)))
          {
            time = date.Substring(i + 1,8);
             Console.WriteLine(time);
          }
        }
        string format = "";
        string year = "";
        string month = "";
        string day = "";
        string t = "";
        if (date.Length <= 19)
        {
           if ("/".Equals(date.Substring(2,1)))
           {
               format = "yy/MM/dd HH:mm:ss";
               year = date.Substring(0,2);
               t = date.Substring(3,5);
           }
           else
           {
               format = "yyyy/MM/dd HH:mm:ss";
               year = date.Substring(0,4);
               t = date.Substring(5,5);
           } 
        }
        else if (date.Length <= 26)
        {
            format = "yyyy/MM/dd HH:mm:ss.ffffff";
             year = date.Substring(0,4);
            t = date.Substring(5,5);
        }
        Console.WriteLine(year);
        Console.WriteLine(t);
        if ("/".Equals(t.Substring(1,1)))
        {
          month = (t.Substring(0,1)).PadLeft(2, '0');
          if (" ".Equals(t.Substring(3,1)))
          {
            day = (t.Substring(2,1)).PadLeft(2, '0');
          }
          else
          {
            day = t.Substring(2,2);
          }
        }
        else
        {
          month = t.Substring(0,2);
           if (" ".Equals(t.Substring(4,1)))
          {
            day = (t.Substring(3,1)).PadLeft(2, '0');
          }
          else
          {
            day = t.Substring(3,2);
          }
        }
        Console.WriteLine(format);
        Console.WriteLine(month);
        Console.WriteLine(day);
        string d = String.Format("{0}/{1}/{2} {3}", year, month, day, time);
        Console.WriteLine(d);
        DateTime dt;
        bool e = DateTime.TryParseExact(d,format,null,DateTimeStyles.None, out dt);
        Console.WriteLine(e);
        if (!e)
        {
            Console.WriteLine("変換エラー");
        }
        date = dt.ToString("yyyyMMddHHmmssffffff",CultureInfo.CurrentCulture);
        
        Console.WriteLine(date);
        Console.WriteLine();
    }
}
