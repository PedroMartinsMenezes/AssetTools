namespace AssetTool
{
    [JsonAsset("CodeProjectFactory")]
    public class UCodeProjectFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}