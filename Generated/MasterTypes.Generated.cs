using System;
using System.Collections.Generic;
namespace D4DJ_Tools.Masters
{
	public static partial class MasterTypes
	{
		private static Dictionary<string, Type> specialTypes = new Dictionary<string, Type>
		{
			{ "ClubItemDetailMaster", typeof(Dictionary<ValueTuple<int, int>, ClubItemDetailMaster>) },
			{ "EpisodeMaster", typeof(Dictionary<ValueTuple<EpisodeCategory, int>, EpisodeMaster>) },
			{ "CampaignMaster", typeof(Dictionary<CampaignCategory, CampaignMaster>) },
			{ "MapSpotMaster", typeof(Dictionary<ValueTuple<int, int>, MapSpotMaster>) },
			{ "MileageMaster", typeof(Dictionary<MileageRank, MileageMaster>) },
			{ "MusicMixMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, MusicMixMaster>) },
			{ "SkillExpMaster", typeof(Dictionary<ValueTuple<int, int>, SkillExpMaster>) },
			{ "CommonTextMaster", typeof(Dictionary<CommonTextType, CommonTextMaster>) },
			{ "CommonValueMaster", typeof(Dictionary<CommonValueType, CommonValueMaster>) },
			{ "PokerCoinMultiplierMaster", typeof(Dictionary<PokerHandCategory, PokerCoinMultiplierMaster>) },
			{ "ChartAchieveMaster", typeof(Dictionary<ValueTuple<int, ChartAchieveType, int>, ChartAchieveMaster>) },
			{ "LoginBonusItemMaster", typeof(Dictionary<ValueTuple<int, int>, LoginBonusItemMaster>) },
			{ "ChartLessonMaster", typeof(Dictionary<ValueTuple<int, int>, ChartLessonMaster>) },
			{ "ChartNoteCountMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, ChartNoteCountMaster>) },
			{ "TrumpMaster", typeof(Dictionary<ValueTuple<TrumpSuit, int>, TrumpMaster>) },
		};
	}
}
