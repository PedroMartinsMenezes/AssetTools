namespace AssetTool
{
    [JsonAsset("OptimusSceneComponentSource")]
    public class UOptimusSceneComponentSource : UOptimusComponentSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}