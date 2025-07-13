namespace AssetTool
{
    [JsonAsset("EnvironmentQueryFactory")]
    public class UEnvironmentQueryFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}