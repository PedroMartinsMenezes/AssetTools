namespace AssetTool
{
    [JsonAsset("AvaAttribute")]
    public class UAvaAttribute : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}