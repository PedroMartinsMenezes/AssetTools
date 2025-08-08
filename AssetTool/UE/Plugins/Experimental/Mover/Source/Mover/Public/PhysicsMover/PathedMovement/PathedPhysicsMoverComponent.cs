namespace AssetTool
{
    [JsonAsset("PathedPhysicsMoverComponent")]
    public class UPathedPhysicsMoverComponent : UMoverComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}