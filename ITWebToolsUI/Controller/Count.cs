using System;
using Microsoft.AspNetCore.Components;
using ITWebToolsUI.Moudle;
namespace ITWebToolsUI.Controller
{
    public static class Count
    {
        public static List<StaffInfo> staffs = new();
        public static List<object> list = new();
        public static void test()
        {
            int i = 0;
            while (i < 10)
            {
                if (staffs.Count > 0)
                {
                    foreach (var item in staffs)
                    {
                        item.id++;
                        Console.WriteLine(item.UUID);
                        Console.WriteLine(item.id);
                    }
                }
                i++;
            }
        }
    }
}

