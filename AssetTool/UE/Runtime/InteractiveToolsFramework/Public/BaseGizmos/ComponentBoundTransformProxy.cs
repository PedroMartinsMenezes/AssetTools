namespace AssetTool
{
    [JsonAsset("ComponentBoundTransformProxy")]
    public class UComponentBoundTransformProxy : UTransformProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}