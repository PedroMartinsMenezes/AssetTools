namespace AssetTool
{
    [JsonAsset("MassObserverRegistry")]
    public class UMassObserverRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}