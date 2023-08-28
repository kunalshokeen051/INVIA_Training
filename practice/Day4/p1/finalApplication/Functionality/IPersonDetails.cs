using System;
using System.Collections.Generic;
using Models;

namespace Functionality
{
   
    public interface IPersonDetails
    {
        void Display();
        void Add();
        void Delete();
        void Modify();
        void Search();
    }
}