namespace AssetTool
{
    [JsonAsset("LakeCollisionComponent")]
    public class ULakeCollisionComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}