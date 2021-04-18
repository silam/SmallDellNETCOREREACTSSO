using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorWCFService
{

    [ServiceContract()]
    public interface ISimpleCalculator
    {
        [OperationContract()]
        int Add(int num1, int num2);
    }

    public class SimpleCalculator : ISimpleCalculator {
      public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
