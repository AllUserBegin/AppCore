using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore.Model
{
    /// <summary>
    /// 
    /// </summary>
    [ProtoContract]
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        public int Age { get; set; }
    }
}
