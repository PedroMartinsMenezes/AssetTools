namespace AssetTool
{
    [JsonAsset("GroomPluginSettings")]
    public class UGroomPluginSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}