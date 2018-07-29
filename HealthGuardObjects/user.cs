namespace HealthGuardObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;

    [DataContract]

        public class user
        {
            [DataMember]
            public string theLogin { get; set; }
            [DataMember]
            public string thePassword { get; set; }
            [DataMember]
            public string thePassword2 { get; set; }
            [DataMember]
            public string theName { get; set; }

        
    }
}
