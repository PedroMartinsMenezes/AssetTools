namespace AssetTool
{
    [JsonAsset("AISystemBase")]
    public class UAISystemBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}