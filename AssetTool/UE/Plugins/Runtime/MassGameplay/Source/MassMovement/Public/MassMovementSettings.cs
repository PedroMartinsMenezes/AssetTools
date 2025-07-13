namespace AssetTool
{
    [JsonAsset("MassMovementSettings")]
    public class UMassMovementSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}