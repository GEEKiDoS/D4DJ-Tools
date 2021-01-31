using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
    public enum EventType
    {
        None,
        Bingo,
        Medley,
        Poker,
        Raid
    }

    public enum AchievementNotifyType
    {
        Default,
        PokerHand,
        BingoCard
    }

    public enum MusicCategory
    {
        None,
        Original,
        Cover,
        Game,
        Instrumental,
        Collabo
    }

    public enum ChartSectionType
    {
        Full,
        Begin,
        Middle,
        End
    }

    public enum BingoRewardCategory
    {
        Bingo,
        Hit,
        Complete
    }

    public enum RewardCategory
    {
        Stock = 1,
        Card,
        ClubItem,
        Music,
        Stamp,
        Honor,
        Episode,
        Movie
    }

    public enum BingoStatusCategory
    {
        Bingo,
        Reach,
        NoReach
    }

    public enum CampaignCategory
    {
        Mileage = 1
    }

    public enum ChartAchieveType
    {
        Score = 1,
        Combo,
        ClearCount
    }

    public enum ChartDifficulty
    {
        None,
        Easy,
        Normal,
        Hard,
        Expert
    }

    public enum ClubItemTargetType
    {
        None,
        Unit,
        Attribute,
        Parameter,
        Character,
        All
    }

    public enum ClubItemSpotCategory
    {
        Club = 1,
        DJ,
        Stage,
        Ceiling
    }

    public enum CommonTextType
    {
        OptionPresetDescription = 101,
        OptionLaneViewRateDescription,
        OptionPreBackColorDescription,
        OptionLatencyDescription,
        OptionTapTimingDescription,
        OptionEvaluationModeDescription,
        OptionMirrorDescription,
        OptionSliderEffectDescription,
        OptionEffectDescription,
        OptionAutoColorDescription,
        RatingDescription = 201,
        SetlistLiveResultScoreLogDefaultComment = 301,
        ShareLiveResult = 401,
        ShareSetlist,
        ShareProfile,
        SharePrivateRoom
    }

    public enum CommonValueType
    {
        LiveSECount = 101,
        LiveNoteDesignCount,
        LiveTapEffectCount,
        LiveSliderLineCount,
        LiveSliderArrowCount,
        LiveContinueDiamondAmount,
        LiveBoostMultiplier,
        LikeEachTakeCount = 301,
        DJBoothGuestBookLatestListCount,
        FriendRequestMaxCount,
        PresentReceivedDayCount,
        FavoriteStampMaxCount,
        HonorMaxCount,
        DJBoothSetlistMaxCount,
        DJBoothGuestBookSetlistCount,
        DJBoothGuestBookHighScoreListCount,
        NicknameMaxLength = 401,
        CommentMaxLength,
        CardDeckNameMaxLength,
        ClubDeckNameMaxLength,
        DJBoothSetlistTitleMaxLength,
        MusicFavoriteDeckNameMaxLength,
        DJBoothCommentMaxLength,
        VoltageMaxAllowCount = 501,
        FirstTimeMusicId = 601
    }

    public enum ConditionCategory
    {
        None,
        UserLevel,
        UnitLevel,
        ClubItem,
        Story,
        EventPoint
    }

}
