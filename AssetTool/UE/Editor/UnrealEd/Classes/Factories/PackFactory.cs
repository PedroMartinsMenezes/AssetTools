namespace AssetTool
{
    [JsonAsset("PackFactory")]
    public class UPackFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}