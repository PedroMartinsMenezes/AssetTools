namespace AssetTool
{
    [JsonAsset("NamedInterfaces")]
    public class UNamedInterfaces : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}