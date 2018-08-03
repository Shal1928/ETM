using EasyTaskManager.Models;
using System.IO;
using UseAbilities.IoC.Stores.Impl;
using UseAbilities.XML.Serialization;

namespace EasyTaskManager.Core
{
    public class SolutionStore : XmlStoreBase<Solution>
    {
        #region Singleton implementation

        private SolutionStore()
        {
            SetFileName("Solution1.xml");
        }

        private static readonly SolutionStore Instance = new SolutionStore();
        public static SolutionStore GetInstance()
        {
            return Instance;
        }

        #endregion

        public override Solution Load()
        {
            if (!File.Exists(GetFileName())) base.Save(new Solution());

            return SerializationUtility.Deserialize<Solution>(GetFileName());
        }
    }
}
