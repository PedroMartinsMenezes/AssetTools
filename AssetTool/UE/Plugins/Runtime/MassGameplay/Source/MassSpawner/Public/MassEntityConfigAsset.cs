namespace AssetTool
{
    [JsonAsset("MassEntityConfigAsset")]
    public class UMassEntityConfigAsset : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}