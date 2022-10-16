using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MLANE_WCF_Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    // methods go here.  Change the stuff to examples 
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string PrimeNumber(int num);

        [OperationContract]
        int SumOfDigits(int num);

        [OperationContract]
        string ReverseString(string inputString);

        [OperationContract]
        string PrintHtmlTags(string tag, string data);

        [OperationContract]
        int[] SortNumbers(string type, int[] data);

    }
}
