namespace AssetTool
{
    [JsonAsset("TransformProxy")]
    public class UTransformProxy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}