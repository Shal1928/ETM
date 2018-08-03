using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskManager.Models
{
    [DataContract]
    public class Solution
    {
        public Solution()
        {
            //
        }

        [DataMember]
        public Collection<Project> Projects { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}
