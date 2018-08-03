using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTaskManager.Models
{
    public class Solution
    {
        public Solution()
        {
            //
        }

        public Collection<Project> Projects { get; set; }

        public string Title { get; set; }
    }
}
