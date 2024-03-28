using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConsoleApp2_9
{
    
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double CalculateMethod1(double x, double y);

        [OperationContract]
        double CalculateMethod2(double x, double y);
        void DoWork();
    }
}

