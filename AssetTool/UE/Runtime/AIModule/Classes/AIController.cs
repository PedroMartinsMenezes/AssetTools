namespace AssetTool
{
    [JsonAsset("AIController")]
    public class AAIController : AController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}