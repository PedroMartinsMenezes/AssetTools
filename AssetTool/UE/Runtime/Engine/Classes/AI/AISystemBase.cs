namespace AssetTool
{
    [JsonAsset("AISystemBase")]
    public class UAISystemBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}