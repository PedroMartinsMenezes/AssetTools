namespace AssetTool
{
    [JsonAsset("ModelComponent")]
    public class UModelComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}