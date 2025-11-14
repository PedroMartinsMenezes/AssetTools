namespace AssetTool
{
    [JsonAsset("PhysicsControlAsset")]
    public class UPhysicsControlAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}