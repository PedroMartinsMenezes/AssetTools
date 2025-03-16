namespace AssetTool
{
    [JsonAsset("AISystemBase")]
    public class UAISystemBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}