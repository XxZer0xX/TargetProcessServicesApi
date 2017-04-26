using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    public class ImpedimentSimpleHistory : SimpleHistory
    {
        /// <summary>
        ///     What entity was changed
        /// </summary>
        /// <value></value>
        [DataMember]
        public Impediment Impediment { get; set; }
    }
}