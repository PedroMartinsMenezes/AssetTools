namespace AssetTool
{
    [JsonAsset("TakeMetaData")]
    public class UTakeMetaData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}