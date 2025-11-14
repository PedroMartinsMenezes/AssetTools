namespace AssetTool
{
    [JsonAsset("AIController")]
    public class AAIController : AController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}