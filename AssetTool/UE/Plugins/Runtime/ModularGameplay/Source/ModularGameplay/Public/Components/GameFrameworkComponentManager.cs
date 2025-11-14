namespace AssetTool
{
    [JsonAsset("GameFrameworkComponentManager")]
    public class UGameFrameworkComponentManager : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}