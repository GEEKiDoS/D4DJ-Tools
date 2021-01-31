using MessagePack;

namespace D4DJ_Tools.Masters
{
    [MessagePackObject]
    public class AttributeMaster
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
    }
}
