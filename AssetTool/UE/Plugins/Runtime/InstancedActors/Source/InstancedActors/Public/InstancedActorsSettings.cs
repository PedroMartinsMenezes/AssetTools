namespace AssetTool
{
    [JsonAsset("InstancedActorsProjectSettings")]
    public class UInstancedActorsProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}