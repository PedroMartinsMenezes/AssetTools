namespace AssetTool
{
    [JsonAsset("MaterialBillboardComponent")]
    public class UMaterialBillboardComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}