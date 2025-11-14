namespace AssetTool
{
    [JsonAsset("PathedPhysicsMoverComponent")]
    public class UPathedPhysicsMoverComponent : UMoverComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}