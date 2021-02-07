using MessagePack;
using System;

namespace D4DJ_Tools
{
    public enum NoteType
    {
        Tap1,
        Tap2,
        ScratchLeft,
        ScratchRight,
        StopStart,
        StopEnd,
        LongStart,
        LongMiddle,
        LongEnd,
        Slide
    }

    [MessagePackObject]
    public class NoteData
    {
        [Key(0)]
        public int LaneId { get; set; }
        [Key(1)]
        public NoteType Type { get; set; }
        [Key(2)]
        public float Time { get; set; }
        [Key(3)]
        public int NextId { get; set; }
        [Key(4)]
        public int Direction { get; set; }
        [Key(5)]
        public int EffectType { get; set; }
        [Key(6)]
        public float EffectParameter { get; set; }
    }

    [MessagePackObject]
    public class SoflanData
    {
        [Key(0)]
        public float Time { get; set; }
        [Key(1)]
        public float TimeScale { get; set; }
        [Key(2)]
        public int LeftRight { get; set; }
    }

    [MessagePackObject]
    public class ChartData
    {
        [Key(0)]
        public string MusicName { get; set; }
        [Key(1)]
        //public (float, float, int)[] SoflanDataList { get; set; }
        public SoflanData[] SoflanDataList { get; set; }
        [Key(2)]
        public float[] BarLineList { get; set; }
        [Key(3)]
        public NoteData[] NoteDataList { get; set; }
    }

    [MessagePackObject]
    public class ChartCommonData
    {
        [Key(0)]
        public float[] SDRhythmTimes { get; set; }
        [Key(1)]
        public float[] SkillTimes { get; set; }
        [Key(2)]
        public (float, int)[] AudienceData { get; set; }
        [Key(3)]
        public float FeverPrepareTime { get; set; }
        [Key(4)]
        public float FeverTime { get; set; }
        [Key(5)]
        public float[] ClubItemTriggers { get; set; }
    }
}