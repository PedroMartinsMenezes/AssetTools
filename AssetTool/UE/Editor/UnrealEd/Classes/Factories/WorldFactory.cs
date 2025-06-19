namespace AssetTool
{
    [JsonAsset("WorldFactory")]
    public class UWorldFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}