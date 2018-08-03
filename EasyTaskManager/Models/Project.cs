using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskManager.Models
{
    [DataContract]
    public class Project
    {
        public Project()
        {
            //
        }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}
