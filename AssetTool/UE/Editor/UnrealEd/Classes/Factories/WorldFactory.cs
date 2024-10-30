namespace AssetTool
{
    [JsonAsset("WorldFactory")]
    public class UWorldFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}