﻿using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelgatesImplementationRunner delgatesRunner = new DelgatesImplementationRunner();
            delgatesRunner.RunMenuWithDelegatesImplementation();
            //RunMenuWithInterfacesImplementation();
           
        }
    }
}
