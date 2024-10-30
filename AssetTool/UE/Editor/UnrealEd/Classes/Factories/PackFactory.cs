namespace AssetTool
{
    [JsonAsset("PackFactory")]
    public class UPackFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}