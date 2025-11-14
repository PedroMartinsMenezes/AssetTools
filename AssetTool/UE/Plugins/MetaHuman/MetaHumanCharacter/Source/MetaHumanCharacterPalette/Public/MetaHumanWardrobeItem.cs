namespace AssetTool
{
    [JsonAsset("MetaHumanWardrobeItem")]
    public class UMetaHumanWardrobeItem : UMetaHumanCharacterPalette
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}