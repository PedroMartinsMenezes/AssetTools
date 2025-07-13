namespace AssetTool
{
    [JsonAsset("MyPluginObject")]
    public class UMyPluginObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}