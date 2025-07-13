namespace AssetTool
{
    [JsonAsset("GameFrameworkComponentManager")]
    public class UGameFrameworkComponentManager : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}