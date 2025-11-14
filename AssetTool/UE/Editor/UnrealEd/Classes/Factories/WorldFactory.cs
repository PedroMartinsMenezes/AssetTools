namespace AssetTool
{
    [JsonAsset("WorldFactory")]
    public class UWorldFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}