namespace D4DJ_Tools.Masters
{
	public enum CampaignButtonDisplayLocation
	{
		Home = 1,
		Club = 2,
		Story = 4,
	}

	public enum CampaignCategory
	{
		Mileage = 1,
		RaidUserExp = 2,
		RaidUnitExp = 3,
	}

	public enum CardIllustType
	{
		Normal = 0,
		LimitBreak = 1,
		MaxLimitBreak = 2,
	}

	public enum PassiveSkillType
	{
		None = 0,
		FeverBonus = 1,
		FeverSupport = 2,
		ScoreUpWithDamage = 3,
		AutoScoreUp = 4,
		SupportableScoreUp = 11,
		SupportableSkillLonger = 12,
	}

	public enum ClubItemSpotCategory
	{
		Club = 1,
		DJ = 2,
		Stage = 3,
		Ceiling = 4,
	}

	public enum ClubItemTargetType
	{
		None = 0,
		Unit = 1,
		Attribute = 2,
		Parameter = 3,
		Character = 4,
		All = 5,
	}

	public enum CommonValueType
	{
		LiveSECount = 101,
		LiveNoteDesignCount = 102,
		LiveTapEffectCount = 103,
		LiveSliderLineCount = 104,
		LiveSliderArrowCount = 105,
		LiveContinueDiamondAmount = 106,
		LiveBoostMultiplier = 107,
		GameLogicHours = 201,
		LikeEachTakeCount = 301,
		DJBoothGuestBookLatestListCount = 302,
		FriendRequestMaxCount = 303,
		PresentReceivedDayCount = 304,
		FavoriteStampMaxCount = 305,
		HonorMaxCount = 306,
		DJBoothSetlistMaxCount = 307,
		DJBoothGuestBookSetlistCount = 308,
		DJBoothGuestBookHighScoreListCount = 309,
		DJBoothSetlistLivePassMaxCount = 310,
		DJBoothSetlistActiveLivePassMaxCount = 311,
		NicknameMaxLength = 401,
		CommentMaxLength = 402,
		CardDeckNameMaxLength = 403,
		ClubDeckNameMaxLength = 404,
		DJBoothSetlistTitleMaxLength = 405,
		MusicFavoriteDeckNameMaxLength = 406,
		DJBoothCommentMaxLength = 407,
		LiveSEPresetNameMaxLength = 408,
		VoltageMaxAllowCount = 501,
		ConvertedRewardHelpId = 601,
		PrivateRoomCommentMaxLength = 701,
		RaidEventHpMode = 801,
		RaidEventSpecialBossHpMode = 802,
		ClubOrderCharaShadow = 901,
		ClubOrderDJChara = 902,
		ClubOrderDJBooth = 903,
		ClubOrderOtherChara = 904,
		ClubOrderFrontChara = 905,
		MusicTagMaxCount = 1001,
		MusicTagNameMaxLenght = 1002,
		MusicTagNeedLevel = 1003,
		MusicRecommendCount = 1004,
		EventSlotExtendableBonusTimeSeconds = 1100,
	}

	public enum ConditionCategory
	{
		None = 0,
		UserLevel = 1,
		UnitLevel = 2,
		ClubItem = 3,
		Story = 4,
		EventPoint = 5,
		CharacterRank = 6,
		Unreleased = 99,
	}

	public enum EpisodeCategory
	{
		Unit = 1,
		Event = 2,
		Card = 3,
		LiveResult = 4,
		Map = 5,
		Character = 6,
		Tutorial = 9,
	}

	public enum BingoCardType
	{
		Normal = 0,
		Special = 1,
	}

	public enum BingoRewardCategory
	{
		Bingo = 0,
		Hit = 1,
		Complete = 2,
	}

	public enum EffectTargetType
	{
		None = 0,
		Pick = 1,
		All = 2,
		Random = 3,
	}

	public enum EffectTypeOperator
	{
		None = 0,
		Rate = 1,
		Step = 2,
	}

	public enum GrowthBlockCategory
	{
		None = 0,
		Red = 1,
		Green = 2,
		White = 3,
		Condition = 4,
		Character = 5,
		Reward = 6,
		VS = 7,
	}

	public enum GrowthBlockEffectType
	{
		None = 0,
		TrainingExp = 1,
		HeartExp = 2,
		TechniqueExp = 3,
		PhysicalExp = 4,
		AllExp = 8,
		DoubleEffect = 9,
		LevelChange = 10,
		TileChange = 11,
		CharacterEffect = 12,
		SendStock = 13,
		LiveBattle = 14,
	}

	public enum EventAggregationType
	{
		MainAddPoint = 0,
		Highscore = 1,
		EngineSpecific = 2,
		DailyAddPoint = 3,
		CommonAddPoint = 4,
		None = 99,
	}

	public enum EventEpisodeType
	{
		Normal = 0,
		D4Fes1 = 1,
		D4Fes2 = 2,
	}

	public enum EventType
	{
		None = 0,
		Bingo = 1,
		Medley = 2,
		Poker = 3,
		Raid = 4,
		Slot = 5,
		Growth = 6,
	}

	public enum PokerHandCategory
	{
		RoyalStraightFlush = 0,
		StraightFlush = 1,
		FourOfAKind = 2,
		FullHouse = 3,
		Flush = 4,
		Straight = 5,
		ThreeOfAKind = 6,
		TwoPair = 7,
		OnePair = 8,
		HighCard = 9,
	}

	public enum BossLoopType
	{
		Loop = 0,
		FinalLoop = 1,
	}

	public enum SlotEffectPhase
	{
		None = 0,
		SD = 1,
		Reach = 2,
		Stamp = 4,
		UnitLogo = 8,
		FlavorText = 16,
		Shutdown = 32,
		Card = 64,
	}

	public enum DateSelectCategory
	{
		None = 0,
		Daily = 1,
		Weekly = 2,
		Monthly = 3,
	}

	public enum GachaCategory
	{
		Normal = 1,
		Tutorial = 2,
		Event = 3,
		Birthday = 4,
		StartDash = 5,
		Revival = 6,
		Special = 7,
	}

	public enum GachaRouletteType
	{
		PickUpUp = 1,
		RarityUp = 2,
		StockPresent = 3,
	}

	public enum GachaType
	{
		Normal = 0,
		StepUp = 1,
		Audition = 2,
	}

	public enum HonorType
	{
		Common = 0,
		Mission = 1,
		Character = 2,
		Event = 3,
		D4Pass = 4,
	}

	public enum Live2DUIChatCategory
	{
		MenuCommon = 0,
		LoginBonus = 1,
		Mission = 2,
		BoxGacha = 3,
		BoxGachaDraw = 4,
		BoxGachaJackpot = 5,
		Training = 6,
		BoxGachaReset = 7,
	}

	public enum ChartAchieveType
	{
		Score = 1,
		Combo = 2,
		ClearCount = 3,
	}

	public enum LiveType
	{
		Single = 0,
		Medley = 1,
		SingleBattle = 2,
	}

	public enum MultiRoomType
	{
		Free = 1,
		Beginner = 2,
		Veteran = 3,
		Master = 4,
	}

	public enum LiveSECategory
	{
		None = 0,
		Tap1 = 1,
		Tap2 = 2,
		SliderFlick = 3,
		Scratch = 4,
		TapEmpty = 5,
		ScratchEmpty = 6,
		LongLoop = 7,
	}

	public enum LiveSEPackCategory
	{
		SoundEffect = 1,
		CharacterVoice = 2,
		Collabo = 3,
	}

	public enum LoginBonusType
	{
		Common = 0,
		Campaign = 1,
		Subscription = 2,
		VipBronze = 3,
		VipSilver = 4,
		VipGold = 5,
		VipPlatinum = 6,
		EventBingo = 101,
		EventMedley = 102,
		EventPoker = 103,
		EventRaid = 104,
		EventSlot = 105,
	}

	public enum MapEventType
	{
		Normal = 0,
		Special = 1,
		Birthday = 2,
	}

	public enum MapObjectType
	{
		Prefab = 0,
		Image = 1,
		Movie = 2,
	}

	public enum MobMovingPattern
	{
		Fixed = 0,
		OneWay = 1,
		Loop = 2,
	}

	public enum AchievementNotifyType
	{
		Default = 0,
		PokerHand = 1,
		BingoCard = 2,
		Slot = 3,
	}

	public enum MissionCategory
	{
		Achievement = 0,
		Tutorial = 1,
		Chart = 2,
		TimeLimited = 3,
		Daily = 4,
		Weekly = 5,
		Event = 6,
	}

	public enum ChartDifficulty
	{
		None = 0,
		Easy = 1,
		Normal = 2,
		Hard = 3,
		Expert = 4,
	}

	public enum ChartSectionType
	{
		Full = 0,
		Begin = 1,
		Middle = 2,
		End = 3,
		DJSimulator = 4,
	}

	public enum MusicCategory
	{
		None = 0,
		Original = 1,
		Cover = 2,
		Game = 3,
		Instrumental = 4,
		Collabo = 5,
	}

	public enum MileageRank
	{
		Normal = 0,
		Bronze = 1,
		Silver = 2,
		Gold = 3,
		Platinum = 4,
	}

	public enum QuestConditionType
	{
		Hp = 1,
		MaxCombo = 2,
		GreatCount = 3,
		GoodCount = 4,
		BadCount = 5,
		MissCount = 6,
		Score = 7,
	}

	public enum StampCategory
	{
		Common = 0,
		Rare = 1,
		Collabo = 2,
	}

	public enum RewardCategory
	{
		Stock = 1,
		Card = 2,
		ClubItem = 3,
		Music = 4,
		Stamp = 5,
		Honor = 6,
		Episode = 7,
		Movie = 8,
		DuplicateCard = 9,
		EventPoint = 10,
		LiveSEPack = 11,
		Cloth = 12,
	}

	public enum StockCategory
	{
		Diamond = 0,
		Fragment = 1,
		Exp = 2,
		SkillExp = 3,
		LimitBreak = 4,
		VoltageRecovery = 5,
		Boost = 6,
		MusicShop = 7,
		Event = 8,
		GachaTicket = 9,
		Random = 10,
		ParameterLevelUp = 11,
		CardStack = 12,
		Other = 99,
	}

	public enum TrumpSuit
	{
		Club = 0,
		Diamond = 1,
		Heart = 2,
		Spade = 3,
	}

}
