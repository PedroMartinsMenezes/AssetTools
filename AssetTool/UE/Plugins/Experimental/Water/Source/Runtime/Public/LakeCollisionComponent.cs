namespace AssetTool
{
    [JsonAsset("LakeCollisionComponent")]
    public class ULakeCollisionComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}