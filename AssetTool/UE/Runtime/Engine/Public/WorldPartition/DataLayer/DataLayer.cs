namespace AssetTool
{
    [JsonAsset("DataLayer")]
    public class UDEPRECATED_DataLayer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}