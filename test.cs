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
}
