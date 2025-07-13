namespace AssetTool
{
    [JsonAsset("MassEntitySettings")]
    public class UMassEntitySettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}