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
			{ "MapSpotMaster", typeof(Dictionary<ValueTuple<int, int>, MapSpotMaster>) },
			{ "MileageMaster", typeof(Dictionary<MileageRank, MileageMaster>) },
			{ "MusicMixMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, MusicMixMaster>) },
			{ "CampaignMaster", typeof(Dictionary<CampaignCategory, CampaignMaster>) },
			{ "PassiveSkillExpMaster", typeof(Dictionary<ValueTuple<int, int>, PassiveSkillExpMaster>) },
			{ "SkillExpMaster", typeof(Dictionary<ValueTuple<int, int>, SkillExpMaster>) },
			{ "CommonValueMaster", typeof(Dictionary<CommonValueType, CommonValueMaster>) },
			{ "PokerCoinMultiplierMaster", typeof(Dictionary<PokerHandCategory, PokerCoinMultiplierMaster>) },
			{ "GachaBonusMaster", typeof(Dictionary<ValueTuple<int, bool>, GachaBonusMaster>) },
			{ "ChartAchieveMaster", typeof(Dictionary<ValueTuple<int, ChartAchieveType, int>, ChartAchieveMaster>) },
			{ "LoginBonusItemMaster", typeof(Dictionary<ValueTuple<int, int>, LoginBonusItemMaster>) },
			{ "ChartLessonMaster", typeof(Dictionary<ValueTuple<int, int>, ChartLessonMaster>) },
			{ "HiddenMusicMixDetailMaster", typeof(Dictionary<ValueTuple<int, int>, HiddenMusicMixDetailMaster>) },
			{ "ChartNoteCountMaster", typeof(Dictionary<ValueTuple<int, ChartSectionType>, ChartNoteCountMaster>) },
			{ "HiddenMusicMixNoteCountMaster", typeof(Dictionary<ValueTuple<int, int, ChartDifficulty>, HiddenMusicMixNoteCountMaster>) },
			{ "QuestClubDeckMaster", typeof(Dictionary<ValueTuple<int, int>, QuestClubDeckMaster>) },
			{ "QuestDeckMaster", typeof(Dictionary<ValueTuple<int, int>, QuestDeckMaster>) },
			{ "TrumpMaster", typeof(Dictionary<ValueTuple<TrumpSuit, int>, TrumpMaster>) },
		};
	}
}
