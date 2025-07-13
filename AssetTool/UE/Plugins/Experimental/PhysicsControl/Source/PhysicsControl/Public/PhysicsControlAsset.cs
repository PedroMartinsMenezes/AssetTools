namespace AssetTool
{
    [JsonAsset("PhysicsControlAsset")]
    public class UPhysicsControlAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}