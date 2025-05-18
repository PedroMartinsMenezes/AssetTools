namespace AssetTool
{
    [JsonAsset("TransformProxy")]
    public class UTransformProxy : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}