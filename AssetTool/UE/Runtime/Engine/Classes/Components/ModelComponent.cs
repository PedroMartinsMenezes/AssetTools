namespace AssetTool
{
    [JsonAsset("ModelComponent")]
    public class UModelComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}