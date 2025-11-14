namespace AssetTool
{
    [JsonAsset("MassMovementSettings")]
    public class UMassMovementSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}