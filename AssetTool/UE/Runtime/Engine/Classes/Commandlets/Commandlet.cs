namespace AssetTool
{
    [JsonAsset("Commandlet")]
    public class UCommandlet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}