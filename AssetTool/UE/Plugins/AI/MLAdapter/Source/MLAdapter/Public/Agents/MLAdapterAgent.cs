namespace AssetTool
{
    [JsonAsset("MLAdapterAgent")]
    public class UMLAdapterAgent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}