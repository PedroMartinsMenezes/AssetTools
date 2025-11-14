namespace AssetTool
{
    [JsonAsset("MyPluginObject")]
    public class UMyPluginObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}