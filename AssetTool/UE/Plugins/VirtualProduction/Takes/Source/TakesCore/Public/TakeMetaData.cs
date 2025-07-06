namespace AssetTool
{
    [JsonAsset("TakeMetaData")]
    public class UTakeMetaData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}