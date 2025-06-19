namespace AssetTool
{
    [JsonAsset("ModelFactory")]
    public class UModelFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}