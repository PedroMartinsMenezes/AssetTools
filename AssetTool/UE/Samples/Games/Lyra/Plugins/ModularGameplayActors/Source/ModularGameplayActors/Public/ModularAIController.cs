namespace AssetTool
{
    [JsonAsset("ModularAIController")]
    public class AModularAIController : AAIController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}