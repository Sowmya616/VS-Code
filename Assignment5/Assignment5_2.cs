using System;
using System.Collections.Generic;
using System.Collections;
using Employee_Management;

namespace Assignment5_2
{
    internal class MyProgram
    {
        static void Main(string[] args)
        {
            ArrayList empList = new ArrayList();

            empList.Add(new LitwareLib.Employee());
            empList.Add(new LitwareLib.Employee());

            ((LitwareLib.Employee)empList[0]).SetEmployeeData(05, "Isan", 5000);
            ((LitwareLib.Employee)empList[1]).SetEmployeeData(06, "Dia", 6000);


        }
    }
}
