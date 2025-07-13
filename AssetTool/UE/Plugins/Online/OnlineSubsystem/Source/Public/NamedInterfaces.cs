namespace AssetTool
{
    [JsonAsset("NamedInterfaces")]
    public class UNamedInterfaces : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}