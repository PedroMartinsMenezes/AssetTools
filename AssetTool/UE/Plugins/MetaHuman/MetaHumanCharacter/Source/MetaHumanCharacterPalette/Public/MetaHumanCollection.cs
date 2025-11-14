namespace AssetTool
{
    [JsonAsset("MetaHumanCollection")]
    public class UMetaHumanCollection : UMetaHumanCharacterPalette
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}