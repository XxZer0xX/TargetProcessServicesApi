using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    [DataContract]
    public class SimpleContext
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public bool? No { get; set; }
    }
}