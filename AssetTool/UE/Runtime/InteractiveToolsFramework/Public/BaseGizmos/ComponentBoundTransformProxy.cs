namespace AssetTool
{
    [JsonAsset("ComponentBoundTransformProxy")]
    public class UComponentBoundTransformProxy : UTransformProxy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}