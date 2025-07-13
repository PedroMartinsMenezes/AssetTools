namespace AssetTool
{
    [JsonAsset("MassModuleSettings")]
    public class UMassModuleSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
