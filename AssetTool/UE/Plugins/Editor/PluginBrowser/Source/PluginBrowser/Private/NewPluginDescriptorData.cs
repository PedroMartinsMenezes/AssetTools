namespace AssetTool
{
    [JsonAsset("NewPluginDescriptorData")]
    public class UNewPluginDescriptorData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}