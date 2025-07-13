namespace AssetTool
{
    [JsonAsset("GroomFactory")]
    public class UGroomFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}