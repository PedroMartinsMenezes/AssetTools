namespace AssetTool
{
    [JsonAsset("MassEntityConfigAsset")]
    public class UMassEntityConfigAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}