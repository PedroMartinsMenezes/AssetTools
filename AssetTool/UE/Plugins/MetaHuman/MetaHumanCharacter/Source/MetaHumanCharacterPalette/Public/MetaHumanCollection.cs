namespace AssetTool
{
    [JsonAsset("MetaHumanCollection")]
    public class UMetaHumanCollection : UMetaHumanCharacterPalette
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}