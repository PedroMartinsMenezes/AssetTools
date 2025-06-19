namespace AssetTool
{
    [JsonAsset("TransformProxy")]
    public class UTransformProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}