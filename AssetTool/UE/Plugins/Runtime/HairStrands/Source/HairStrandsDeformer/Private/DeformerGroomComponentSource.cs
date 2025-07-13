namespace AssetTool
{
    [JsonAsset("OptimusGroomComponentSource")]
    public class UOptimusGroomComponentSource : UOptimusComponentSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}