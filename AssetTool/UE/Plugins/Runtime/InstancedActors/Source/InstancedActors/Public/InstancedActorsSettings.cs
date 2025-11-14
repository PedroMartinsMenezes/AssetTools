namespace AssetTool
{
    [JsonAsset("InstancedActorsProjectSettings")]
    public class UInstancedActorsProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}