namespace AssetTool
{
    [JsonAsset("MetaHumanWardrobeItem")]
    public class UMetaHumanWardrobeItem : UMetaHumanCharacterPalette
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}