using HealthGuardObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WCFHealthGuard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void userRegister(string login, string password, string password2, string name, string email);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        int getprofileID(string login);

        [OperationContract]
        user getPatientInformation(int login);


        [OperationContract]
        void InsertingtheData(string login, string password, string password2, string name);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        int loginUser(string login, string password);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }


    


        }

        //[DataContract]

        //public class userList
        //{
        //    [DataMember]
        //    public List<user> Users { get; set; }
            

        //}
    }
}
