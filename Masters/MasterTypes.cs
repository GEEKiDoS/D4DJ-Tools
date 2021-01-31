using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
    public static class MasterTypes
    {
        private static Dictionary<string, Type> specialTypes = new Dictionary<string, Type>
        {
            { "ChartAchieveMaster", typeof(Dictionary<(int, ChartAchieveType, int), ChartAchieveMaster>) },
            { "ChartLessonMaster", typeof(Dictionary<(int, int), ChartLessonMaster>) },
            { "ChartNoteCountMaster", typeof(Dictionary<(int, ChartSectionType), ChartNoteCountMaster>) },
            { "ClubItemDetailMaster", typeof(Dictionary<(int, int), ClubItemDetailMaster>) },
            { "CommonTextMaster", typeof(Dictionary<CommonTextType, CommonTextMaster>) },
            { "CommonValueMaster", typeof(Dictionary<CommonValueType, CommonValueMaster>) },

        };

        public static Type GetDeserializeType(string name)
        {
            if (specialTypes.ContainsKey(name))
                return specialTypes[name];

            // Default to Dictionary<int, name>
            return Type.GetType($"System.Collections.Generic.Dictionary`2[System.Int32, D4DJ_Tools.Masters.{name}]");
        }
    }
}
